namespace AviaApp.Views
{
    partial class SignUp
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
            pictureBox1 = new PictureBox();
            signUpButton = new MaterialSkin.Controls.MaterialButton();
            signUpBtn = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            password = new MaterialSkin.Controls.MaterialTextBox();
            name = new MaterialSkin.Controls.MaterialTextBox();
            dpi = new MaterialSkin.Controls.MaterialTextBox();
            age = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Avia__1_;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 86);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // signUpButton
            // 
            signUpButton.AutoSize = false;
            signUpButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            signUpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            signUpButton.Depth = 0;
            signUpButton.HighEmphasis = true;
            signUpButton.Icon = null;
            signUpButton.Location = new Point(254, 411);
            signUpButton.Margin = new Padding(4, 6, 4, 6);
            signUpButton.MouseState = MaterialSkin.MouseState.HOVER;
            signUpButton.Name = "signUpButton";
            signUpButton.NoAccentTextColor = Color.Empty;
            signUpButton.Size = new Size(274, 36);
            signUpButton.TabIndex = 10;
            signUpButton.Text = "¿Ya tienes una cuenta? ¡Inicia sesión!";
            signUpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            signUpButton.UseAccentColor = false;
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // signUpBtn
            // 
            signUpBtn.AutoSize = false;
            signUpBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            signUpBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            signUpBtn.Depth = 0;
            signUpBtn.HighEmphasis = true;
            signUpBtn.Icon = null;
            signUpBtn.Location = new Point(254, 459);
            signUpBtn.Margin = new Padding(4, 6, 4, 6);
            signUpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            signUpBtn.Name = "signUpBtn";
            signUpBtn.NoAccentTextColor = Color.Empty;
            signUpBtn.Size = new Size(274, 36);
            signUpBtn.TabIndex = 9;
            signUpBtn.Text = "Registrarse";
            signUpBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            signUpBtn.UseAccentColor = false;
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel1.Location = new Point(350, 58);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(66, 41);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "Avia";
            // 
            // password
            // 
            password.AnimateReadOnly = false;
            password.BorderStyle = BorderStyle.None;
            password.Depth = 0;
            password.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            password.Hint = "Contraseña";
            password.LeadingIcon = null;
            password.Location = new Point(254, 195);
            password.MaxLength = 50;
            password.MouseState = MaterialSkin.MouseState.OUT;
            password.Multiline = false;
            password.Name = "password";
            password.Size = new Size(274, 50);
            password.TabIndex = 7;
            password.Text = "";
            password.TrailingIcon = null;
            // 
            // name
            // 
            name.AnimateReadOnly = false;
            name.BorderStyle = BorderStyle.None;
            name.Depth = 0;
            name.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            name.Hint = "Nombre de usuario";
            name.LeadingIcon = null;
            name.Location = new Point(254, 129);
            name.MaxLength = 50;
            name.MouseState = MaterialSkin.MouseState.OUT;
            name.Multiline = false;
            name.Name = "name";
            name.Size = new Size(274, 50);
            name.TabIndex = 6;
            name.Text = "";
            name.TrailingIcon = null;
            // 
            // dpi
            // 
            dpi.AnimateReadOnly = false;
            dpi.BorderStyle = BorderStyle.None;
            dpi.Depth = 0;
            dpi.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dpi.Hint = "Dpi";
            dpi.LeadingIcon = null;
            dpi.Location = new Point(254, 262);
            dpi.MaxLength = 50;
            dpi.MouseState = MaterialSkin.MouseState.OUT;
            dpi.Multiline = false;
            dpi.Name = "dpi";
            dpi.Size = new Size(274, 50);
            dpi.TabIndex = 12;
            dpi.Text = "";
            dpi.TrailingIcon = null;
            // 
            // age
            // 
            age.AnimateReadOnly = false;
            age.BorderStyle = BorderStyle.None;
            age.Depth = 0;
            age.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            age.Hint = "Edad";
            age.LeadingIcon = null;
            age.Location = new Point(254, 328);
            age.MaxLength = 50;
            age.MouseState = MaterialSkin.MouseState.OUT;
            age.Multiline = false;
            age.Name = "age";
            age.Size = new Size(274, 50);
            age.TabIndex = 13;
            age.Text = "";
            age.TrailingIcon = null;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(822, 556);
            Controls.Add(age);
            Controls.Add(dpi);
            Controls.Add(pictureBox1);
            Controls.Add(signUpButton);
            Controls.Add(signUpBtn);
            Controls.Add(materialLabel1);
            Controls.Add(password);
            Controls.Add(name);
            Name = "SignUp";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton signUpButton;
        private MaterialSkin.Controls.MaterialButton signUpBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox password;
        private MaterialSkin.Controls.MaterialTextBox name;
        private MaterialSkin.Controls.MaterialTextBox dpi;
        private MaterialSkin.Controls.MaterialTextBox age;
    }
}