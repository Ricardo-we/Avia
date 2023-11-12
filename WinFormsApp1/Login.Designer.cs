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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            loginButton = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            signUpButton = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dpi
            // 
            dpi.AnimateReadOnly = false;
            dpi.BorderStyle = BorderStyle.None;
            dpi.Depth = 0;
            dpi.Font = new Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            dpi.Hint = "Dpi";
            dpi.LeadingIcon = null;
            dpi.Location = new Point(253, 128);
            dpi.MaxLength = 50;
            dpi.MouseState = MaterialSkin.MouseState.OUT;
            dpi.Multiline = false;
            dpi.Name = "dpi";
            dpi.Size = new Size(274, 50);
            dpi.TabIndex = 0;
            dpi.Text = "";
            dpi.TrailingIcon = null;
            // 
            // password
            // 
            password.AnimateReadOnly = false;
            password.BorderStyle = BorderStyle.None;
            password.Depth = 0;
            password.Font = new Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            password.Hint = "Contraseña";
            password.LeadingIcon = null;
            password.Location = new Point(253, 194);
            password.MaxLength = 50;
            password.MouseState = MaterialSkin.MouseState.OUT;
            password.Multiline = false;
            password.Name = "password";
            password.Size = new Size(274, 50);
            password.TabIndex = 1;
            password.Text = "";
            password.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel1.Location = new Point(349, 57);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(66, 41);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Avia";
            // 
            // loginButton
            // 
            loginButton.AutoSize = false;
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginButton.Depth = 0;
            loginButton.HighEmphasis = true;
            loginButton.Icon = null;
            loginButton.Location = new Point(253, 325);
            loginButton.Margin = new Padding(4, 6, 4, 6);
            loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            loginButton.Name = "loginButton";
            loginButton.NoAccentTextColor = Color.Empty;
            loginButton.Size = new Size(274, 36);
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
            signUpButton.Location = new Point(253, 265);
            signUpButton.Margin = new Padding(4, 6, 4, 6);
            signUpButton.MouseState = MaterialSkin.MouseState.HOVER;
            signUpButton.Name = "signUpButton";
            signUpButton.NoAccentTextColor = Color.Empty;
            signUpButton.Size = new Size(239, 36);
            signUpButton.TabIndex = 4;
            signUpButton.Text = "¿No tienes cuenta? ¡Registrate!";
            signUpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            signUpButton.UseAccentColor = false;
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = AviaApp.Properties.Resources.Avia__1_;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 86);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(signUpButton);
            Controls.Add(loginButton);
            Controls.Add(materialLabel1);
            Controls.Add(password);
            Controls.Add(dpi);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox dpi;
        private MaterialSkin.Controls.MaterialTextBox password;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton signUpButton;
        private PictureBox pictureBox1;
    }
}