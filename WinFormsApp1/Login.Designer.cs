namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dpi = new MaterialSkin.Controls.MaterialTextBox();
            password = new MaterialSkin.Controls.MaterialTextBox();
            loginButton = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            signUpButton = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dpi
            // 
            dpi.AnimateReadOnly = false;
            dpi.BorderStyle = BorderStyle.None;
            dpi.Depth = 0;
            dpi.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dpi.Hint = "Dpi";
            dpi.LeadingIcon = null;
            dpi.Location = new Point(44, 100);
            dpi.Margin = new Padding(3, 2, 3, 2);
            dpi.MaxLength = 50;
            dpi.MouseState = MaterialSkin.MouseState.OUT;
            dpi.Multiline = false;
            dpi.Name = "dpi";
            dpi.Size = new Size(240, 50);
            dpi.TabIndex = 0;
            dpi.Text = "";
            dpi.TrailingIcon = null;
            // 
            // password
            // 
            password.AnimateReadOnly = false;
            password.BorderStyle = BorderStyle.None;
            password.Depth = 0;
            password.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            password.Hint = "Contraseña";
            password.LeadingIcon = null;
            password.Location = new Point(44, 150);
            password.Margin = new Padding(3, 2, 3, 2);
            password.MaxLength = 50;
            password.MouseState = MaterialSkin.MouseState.OUT;
            password.Multiline = false;
            password.Name = "password";
            password.Size = new Size(240, 50);
            password.TabIndex = 1;
            password.Text = "";
            password.TrailingIcon = null;
            // 
            // loginButton
            // 
            loginButton.AutoSize = false;
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginButton.Depth = 0;
            loginButton.HighEmphasis = true;
            loginButton.Icon = null;
            loginButton.Location = new Point(44, 248);
            loginButton.Margin = new Padding(4);
            loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            loginButton.Name = "loginButton";
            loginButton.NoAccentTextColor = Color.Empty;
            loginButton.Size = new Size(240, 27);
            loginButton.TabIndex = 3;
            loginButton.Text = "Entrar";
            loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loginButton.UseAccentColor = false;
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // signUpButton
            // 
            signUpButton.AutoSize = false;
            signUpButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            signUpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            signUpButton.Depth = 0;
            signUpButton.HighEmphasis = true;
            signUpButton.Icon = null;
            signUpButton.Location = new Point(44, 203);
            signUpButton.Margin = new Padding(4);
            signUpButton.MouseState = MaterialSkin.MouseState.HOVER;
            signUpButton.Name = "signUpButton";
            signUpButton.NoAccentTextColor = Color.Empty;
            signUpButton.Size = new Size(240, 37);
            signUpButton.TabIndex = 4;
            signUpButton.Text = "¿No tienes cuenta? ¡Registrate!";
            signUpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            signUpButton.UseAccentColor = false;
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click_1;
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
            panel2.Size = new Size(329, 71);
            panel2.TabIndex = 90;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = AviaApp.Properties.Resources.avia__4_;
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(329, 338);
            Controls.Add(panel2);
            Controls.Add(signUpButton);
            Controls.Add(loginButton);
            Controls.Add(password);
            Controls.Add(dpi);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Login";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox dpi;
        private MaterialSkin.Controls.MaterialTextBox password;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton signUpButton;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label2;
    }
}