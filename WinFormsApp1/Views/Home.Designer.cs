namespace AviaApp.Views
{
    partial class Home
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
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            equipajeButton = new MaterialSkin.Controls.MaterialButton();
            MisVuelosButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(496, 22);
            materialButton1.Margin = new Padding(3, 4, 3, 4);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(91, 36);
            materialButton1.TabIndex = 15;
            materialButton1.Text = "Asientos";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // equipajeButton
            // 
            equipajeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            equipajeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            equipajeButton.Depth = 0;
            equipajeButton.HighEmphasis = true;
            equipajeButton.Icon = null;
            equipajeButton.Location = new Point(402, 22);
            equipajeButton.Margin = new Padding(3, 4, 3, 4);
            equipajeButton.MouseState = MaterialSkin.MouseState.HOVER;
            equipajeButton.Name = "equipajeButton";
            equipajeButton.NoAccentTextColor = Color.Empty;
            equipajeButton.Size = new Size(90, 36);
            equipajeButton.TabIndex = 16;
            equipajeButton.Text = "Equipaje";
            equipajeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            equipajeButton.UseAccentColor = false;
            equipajeButton.UseVisualStyleBackColor = true;
            equipajeButton.Click += equipajeButton_Click;
            // 
            // MisVuelosButton
            // 
            MisVuelosButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MisVuelosButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            MisVuelosButton.Depth = 0;
            MisVuelosButton.HighEmphasis = true;
            MisVuelosButton.Icon = null;
            MisVuelosButton.Location = new Point(593, 22);
            MisVuelosButton.Margin = new Padding(3, 4, 3, 4);
            MisVuelosButton.MouseState = MaterialSkin.MouseState.HOVER;
            MisVuelosButton.Name = "MisVuelosButton";
            MisVuelosButton.NoAccentTextColor = Color.Empty;
            MisVuelosButton.Size = new Size(91, 36);
            MisVuelosButton.TabIndex = 17;
            MisVuelosButton.Text = "Mis Vuelos";
            MisVuelosButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            MisVuelosButton.UseAccentColor = false;
            MisVuelosButton.UseVisualStyleBackColor = true;
            MisVuelosButton.Click += MisVuelosButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(700, 338);
            Controls.Add(MisVuelosButton);
            Controls.Add(equipajeButton);
            Controls.Add(materialButton1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            Padding = new Padding(2, 38, 2, 2);
            Text = "Vuelos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton equipajeButton;
        private MaterialSkin.Controls.MaterialButton MisVuelosButton;
    }
}