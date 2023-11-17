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
            peso.Location = new Point(425, 174);
            peso.MaxLength = 50;
            peso.MouseState = MaterialSkin.MouseState.OUT;
            peso.Multiline = false;
            peso.Name = "peso";
            peso.Size = new Size(274, 50);
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
            alto.Location = new Point(78, 174);
            alto.MaxLength = 50;
            alto.MouseState = MaterialSkin.MouseState.OUT;
            alto.Multiline = false;
            alto.Name = "alto";
            alto.Size = new Size(274, 50);
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
            ancho.Location = new Point(425, 96);
            ancho.MaxLength = 50;
            ancho.MouseState = MaterialSkin.MouseState.OUT;
            ancho.Multiline = false;
            ancho.Name = "ancho";
            ancho.Size = new Size(274, 50);
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
            largo.Location = new Point(78, 96);
            largo.MaxLength = 50;
            largo.MouseState = MaterialSkin.MouseState.OUT;
            largo.Multiline = false;
            largo.Name = "largo";
            largo.Size = new Size(274, 50);
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
            materialLabel1.Location = new Point(307, 18);
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
            materialButton1.Location = new Point(330, 291);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
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
            // EquipajeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(materialButton1);
            Controls.Add(materialLabel1);
            Controls.Add(peso);
            Controls.Add(alto);
            Controls.Add(ancho);
            Controls.Add(largo);
            Name = "EquipajeForm";
            Text = "EquipajeForm";
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
    }
}