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
            signUpButton = new MaterialSkin.Controls.MaterialButton();
            signUpBtn = new MaterialSkin.Controls.MaterialButton();
            password = new MaterialSkin.Controls.MaterialTextBox();
            name = new MaterialSkin.Controls.MaterialTextBox();
            dpi = new MaterialSkin.Controls.MaterialTextBox();
            age = new MaterialSkin.Controls.MaterialTextBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // signUpButton
            // 
            signUpButton.AutoSize = false;
            signUpButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            signUpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            signUpButton.Depth = 0;
            signUpButton.HighEmphasis = true;
            signUpButton.Icon = null;
            signUpButton.Location = new Point(37, 298);
            signUpButton.Margin = new Padding(4, 4, 4, 4);
            signUpButton.MouseState = MaterialSkin.MouseState.HOVER;
            signUpButton.Name = "signUpButton";
            signUpButton.NoAccentTextColor = Color.Empty;
            signUpButton.Size = new Size(240, 33);
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
            signUpBtn.Location = new Point(37, 340);
            signUpBtn.Margin = new Padding(4, 4, 4, 4);
            signUpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            signUpBtn.Name = "signUpBtn";
            signUpBtn.NoAccentTextColor = Color.Empty;
            signUpBtn.Size = new Size(240, 27);
            signUpBtn.TabIndex = 9;
            signUpBtn.Text = "Registrarse";
            signUpBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            signUpBtn.UseAccentColor = false;
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // password
            // 
            password.AnimateReadOnly = false;
            password.BorderStyle = BorderStyle.None;
            password.Depth = 0;
            password.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            password.Hint = "Contraseña";
            password.LeadingIcon = null;
            password.Location = new Point(37, 142);
            password.Margin = new Padding(3, 2, 3, 2);
            password.MaxLength = 50;
            password.MouseState = MaterialSkin.MouseState.OUT;
            password.Multiline = false;
            password.Name = "password";
            password.Size = new Size(240, 50);
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
            name.Location = new Point(37, 93);
            name.Margin = new Padding(3, 2, 3, 2);
            name.MaxLength = 50;
            name.MouseState = MaterialSkin.MouseState.OUT;
            name.Multiline = false;
            name.Name = "name";
            name.Size = new Size(240, 50);
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
            dpi.Location = new Point(37, 192);
            dpi.Margin = new Padding(3, 2, 3, 2);
            dpi.MaxLength = 50;
            dpi.MouseState = MaterialSkin.MouseState.OUT;
            dpi.Multiline = false;
            dpi.Name = "dpi";
            dpi.Size = new Size(240, 50);
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
            age.Location = new Point(37, 242);
            age.Margin = new Padding(3, 2, 3, 2);
            age.MaxLength = 50;
            age.MouseState = MaterialSkin.MouseState.OUT;
            age.Multiline = false;
            age.Name = "age";
            age.Size = new Size(240, 50);
            age.TabIndex = 13;
            age.Text = "";
            age.TrailingIcon = null;
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
            panel2.Size = new Size(325, 71);
            panel2.TabIndex = 91;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.avia__4_;
            pictureBox4.Location = new Point(195, 12);
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
            label2.Location = new Point(70, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 48);
            label2.TabIndex = 0;
            label2.Text = "AVIA";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(325, 389);
            Controls.Add(panel2);
            Controls.Add(age);
            Controls.Add(dpi);
            Controls.Add(signUpButton);
            Controls.Add(signUpBtn);
            Controls.Add(password);
            Controls.Add(name);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUp";
            Text = "Registro";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton signUpButton;
        private MaterialSkin.Controls.MaterialButton signUpBtn;
        private MaterialSkin.Controls.MaterialTextBox password;
        private MaterialSkin.Controls.MaterialTextBox name;
        private MaterialSkin.Controls.MaterialTextBox dpi;
        private MaterialSkin.Controls.MaterialTextBox age;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label2;
    }
}