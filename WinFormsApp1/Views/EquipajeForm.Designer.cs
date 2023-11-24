namespace AviaApp.Views
{
    partial class EquipajeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            peso = new MaterialSkin.Controls.MaterialTextBox();
            alto = new MaterialSkin.Controls.MaterialTextBox();
            ancho = new MaterialSkin.Controls.MaterialTextBox();
            largo = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // peso
            // 
            peso.AnimateReadOnly = false;
            peso.BorderStyle = BorderStyle.None;
            peso.Depth = 0;
            peso.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            peso.Hint = "Peso";
            peso.LeadingIcon = null;
            peso.Location = new Point(373, 201);
            peso.Margin = new Padding(3, 2, 3, 2);
            peso.MaxLength = 50;
            peso.MouseState = MaterialSkin.MouseState.OUT;
            peso.Multiline = false;
            peso.Name = "peso";
            peso.Size = new Size(239, 50);
            peso.TabIndex = 17;
            peso.Text = "";
            peso.TrailingIcon = null;
            // 
            // alto
            // 
            alto.AnimateReadOnly = false;
            alto.BorderStyle = BorderStyle.None;
            alto.Depth = 0;
            alto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            alto.Hint = "Alto";
            alto.LeadingIcon = null;
            alto.Location = new Point(70, 201);
            alto.Margin = new Padding(3, 2, 3, 2);
            alto.MaxLength = 50;
            alto.MouseState = MaterialSkin.MouseState.OUT;
            alto.Multiline = false;
            alto.Name = "alto";
            alto.Size = new Size(239, 50);
            alto.TabIndex = 16;
            alto.Text = "";
            alto.TrailingIcon = null;
            // 
            // ancho
            // 
            ancho.AnimateReadOnly = false;
            ancho.BorderStyle = BorderStyle.None;
            ancho.Depth = 0;
            ancho.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ancho.Hint = "Ancho";
            ancho.LeadingIcon = null;
            ancho.Location = new Point(373, 142);
            ancho.Margin = new Padding(3, 2, 3, 2);
            ancho.MaxLength = 50;
            ancho.MouseState = MaterialSkin.MouseState.OUT;
            ancho.Multiline = false;
            ancho.Name = "ancho";
            ancho.Size = new Size(239, 50);
            ancho.TabIndex = 15;
            ancho.Text = "";
            ancho.TrailingIcon = null;
            // 
            // largo
            // 
            largo.AnimateReadOnly = false;
            largo.BorderStyle = BorderStyle.None;
            largo.Depth = 0;
            largo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            largo.Hint = "Largo";
            largo.LeadingIcon = null;
            largo.Location = new Point(70, 142);
            largo.Margin = new Padding(3, 2, 3, 2);
            largo.MaxLength = 50;
            largo.MouseState = MaterialSkin.MouseState.OUT;
            largo.Multiline = false;
            largo.Name = "largo";
            largo.Size = new Size(239, 50);
            largo.TabIndex = 14;
            largo.Text = "";
            largo.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(270, 83);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(163, 24);
            materialLabel1.TabIndex = 18;
            materialLabel1.Text = "Registrar Equipaje";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(289, 288);
            materialButton1.Margin = new Padding(4, 5, 4, 5);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(99, 36);
            materialButton1.TabIndex = 19;
            materialButton1.Text = "Registrar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 71);
            panel2.TabIndex = 90;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.avia__4_;
            pictureBox4.Location = new Point(380, 12);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Britannic Bold", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(255, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 48);
            label2.TabIndex = 0;
            label2.Text = "AVIA";
            // 
            // EquipajeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(685, 361);
            Controls.Add(panel2);
            Controls.Add(materialButton1);
            Controls.Add(materialLabel1);
            Controls.Add(peso);
            Controls.Add(alto);
            Controls.Add(ancho);
            Controls.Add(largo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EquipajeForm";
            Text = "EquipajeForm";
            Load += EquipajeForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox peso;
        private MaterialSkin.Controls.MaterialTextBox alto;
        private MaterialSkin.Controls.MaterialTextBox ancho;
        private MaterialSkin.Controls.MaterialTextBox largo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label2;
    }
}