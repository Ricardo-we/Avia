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
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            signUpButton = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(253, 128);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(274, 50);
            materialTextBox1.TabIndex = 0;
            materialTextBox1.Text = "Nombre de usuario";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(253, 194);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(274, 50);
            materialTextBox2.TabIndex = 1;
            materialTextBox2.Text = "Contraseña";
            materialTextBox2.TrailingIcon = null;
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
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(253, 325);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(274, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Entrar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(signUpButton);
            Controls.Add(materialButton1);
            Controls.Add(materialLabel1);
            Controls.Add(materialTextBox2);
            Controls.Add(materialTextBox1);
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton signUpButton;
        private PictureBox pictureBox1;
    }
}