using Avia.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace AviaApp.Utils
{

    public class EditForm<T> : Form where T : class
    {
        private readonly T modelInstance;
        private readonly TableLayoutPanel flowLayoutPanel;
        private readonly Button btnSave;
        private readonly Type modelType;
        private readonly DBContext dbContext;

        public EditForm(DBContext dbContext, T modelInstance)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.modelInstance = modelInstance ?? throw new ArgumentNullException(nameof(modelInstance));

            modelType = typeof(T);

            flowLayoutPanel = new TableLayoutPanel { Dock = DockStyle.Fill };
            btnSave = new MaterialButton { Text = "Guardar", Dock = DockStyle.Bottom };

            btnSave.Click += (sender, e) => SaveModel();

            InitializeControls();

            Text = $"Editar {modelType.Name}";
            Width = 500;
            Height = 300;
        }

        private void InitializeControls()
        {
            flowLayoutPanel.AutoSize = true;

            foreach (var property in modelType.GetProperties())
            {
                // Omitir campos marcados como [Key] o [DatabaseGenerated]
                if (property.GetCustomAttribute<KeyAttribute>() != null ||
                    property.GetCustomAttribute<DatabaseGeneratedAttribute>() != null)
                {
                    continue;
                }

                //var label = new Label { Text = property.Name, AutoSize = true };
                var textBox = new MaterialTextBox { Dock = DockStyle.Top, Text = GetModelPropertyValue(property), Tag = property.Name, Hint = property.Name };

                //flowLayoutPanel.Controls.Add(label);
                //flowLayoutPanel.Controls.Add(textBox);
                flowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                //flowLayoutPanel.Controls.Add(label, 0, flowLayoutPanel.RowCount - 1);
                flowLayoutPanel.Controls.Add(textBox, 0, flowLayoutPanel.RowCount - 1);
                flowLayoutPanel.RowCount++;
            }

            Controls.Add(flowLayoutPanel);
            Controls.Add(btnSave);
        }

        private void SaveModel()
        {
            try
            {
                foreach (Control control in flowLayoutPanel.Controls)
                {
                    if (control is MaterialTextBox textBox )
                    {
                        var propertyName = (string)textBox.Tag;
                        var property = modelType.GetProperty(propertyName);

                        if (property != null)
                        {
                            var value = Convert.ChangeType(textBox.Text, property.PropertyType);
                            property.SetValue(modelInstance, value);
                        }
                    }
                }

                dbContext.SaveChanges();

                MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Full exception details: {ex.ToString()}");
            }
        }

        private string GetModelPropertyValue(PropertyInfo property)
        {
            // Obtenemos el valor actual de la propiedad del modelo
            var value = property.GetValue(modelInstance);
            return value?.ToString() ?? string.Empty;
        }
    }

    public class GenericCrudForm<T> : Form where T : class
    {
        private T modelInstance;
        private TableLayoutPanel tableLayoutPanel;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Type modelType;
        private DBContext dbContext;
        private bool IsEditing;
        private DataGridView dataGridView;

        public GenericCrudForm(DBContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

            modelType = typeof(T);
            modelInstance = Activator.CreateInstance<T>();
            IsEditing = false;

            tableLayoutPanel = new TableLayoutPanel { Dock = DockStyle.Fill };

            btnSave = new MaterialButton { Text = "Guardar", Dock = DockStyle.Bottom };
            dataGridView = new DataGridView { Dock = DockStyle.Bottom, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, AllowUserToAddRows = false };
            
            dataGridView.CellDoubleClick += (sender, e) => EditModelFromDataGridView();

            btnSave.Click += (sender, e) => SaveModel();

            InitializeControls();

            Text = $"CRUD Form - {modelType.Name}";
            Width = 600;
            Height = 600;
        }

        private bool IsComplexType(Type type)
        {
            return !type.IsPrimitive && !type.IsValueType && type != typeof(string) && !type.IsArray && !type.IsEnum;
        }

        private void InitializeControls()
        {

            foreach (var property in modelType.GetProperties())
            {
                if (property.GetCustomAttribute<KeyAttribute>() != null ||
                    property.GetCustomAttribute<DatabaseGeneratedAttribute>() != null || 
                    IsComplexType(property.PropertyType))
                {
                    continue;
                }

                var textBox = new MaterialTextBox { Dock = DockStyle.Fill, Tag = property.Name, Text = GetModelPropertyValue(property), Hint= property.Name };

                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tableLayoutPanel.Controls.Add(textBox, 1, tableLayoutPanel.RowCount - 1);
                tableLayoutPanel.RowCount++;
            }

            Controls.Add(tableLayoutPanel);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView);

            // Configura el DataGridView
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dataGridView.Columns.Clear();

            foreach (var property in modelType.GetProperties())
            {
                var columnName = property.Name;
                dataGridView.Columns.Add(columnName, columnName);
            }

            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            dataGridView.Columns.Add(deleteButtonColumn);

            RefreshDataGridView(); // Añade esta línea para cargar los datos inicialmente
            dataGridView.CellEndEdit += (sender, e) => UpdateModelFromDataGridView();
            dataGridView.CellClick += DataGridView_CellClick;
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                // Se hizo clic en el botón de eliminar en la fila específica
                DeleteModelFromDataGridView(e.RowIndex);
            }
        }

        private List<object> GetPropertyValues(T item)
        {
            // Obtiene los valores de las propiedades del modelo
            var values = new List<object>();
            foreach (var property in modelType.GetProperties())
            {
                var value = property.GetValue(item);
                values.Add(value);
            }
            return values;
        }

        private void RefreshDataGridView()
        {
            // Actualiza los datos en el DataGridView después de guardar cambios
            dataGridView.DataSource = null; // Limpia el origen de datos
            dataGridView.Rows.Clear(); // Limpia las filas existentes

            var data = dbContext.Set<T>().ToList();
            foreach (var item in data)
            {
                dataGridView.Rows.Add(GetPropertyValues(item).ToArray());
            }
        }

        private void UpdateModelFromDataGridView()
        {
            if (dataGridView.CurrentRow != null)
            {
                modelInstance = dataGridView.CurrentRow.DataBoundItem as T;
            }
        }

        private string GetModelPropertyValue(PropertyInfo property)
        {
            var textBox = tableLayoutPanel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Tag.ToString() == property.Name);
            return textBox?.Text ?? string.Empty;
        }

        private void SaveModel()
        {
            try
            {
                foreach (Control control in tableLayoutPanel.Controls)
                {
                    if (control is MaterialTextBox textBox)
                    {
                        var propertyName = (string)textBox.Tag;
                        var property = modelType.GetProperty(propertyName);

                        if (property != null)
                        {
                            var value = Convert.ChangeType(textBox.Text, property.PropertyType);
                            property.SetValue(modelInstance, value);
                        }
                    }
                }

                if (IsEditing)
                {
                    dbContext.Entry(modelInstance).State = EntityState.Modified;
                }
                else
                {
                    dbContext.Set<T>().Add(modelInstance);
                }

                dbContext.SaveChanges();

                MessageBox.Show("Modelo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el modelo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditModelFromDataGridView()
        {
            if (dataGridView.CurrentRow != null)
            {
                int rowIndex = dataGridView.CurrentRow.Index;

                if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
                {
                    T selectedModel = dbContext.Set<T>().ToList()[rowIndex];

                    var editForm = new EditForm<T>(dbContext, selectedModel);
                    editForm.ShowDialog();

                    RefreshDataGridView();
                    ClearFormFields();
                }
            }
        }

        private void DeleteModelFromDataGridView(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
            {
                //modelInstance = dataGridView.Rows[rowIndex].DataBoundItem as T;
                T modelInstance = dbContext.Set<T>().ToList()[rowIndex];

                dbContext.Set<T>().Remove(modelInstance);
                dbContext.SaveChanges();

                MessageBox.Show("Modelo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
                ClearFormFields();
            }
        }

        private void ClearFormFields()
        {
            // Limpia los campos del formulario después de guardar o eliminar
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is MaterialTextBox textBox)
                {
                    textBox.Clear();
                }
            }

            IsEditing = false;
        }
    }

}
