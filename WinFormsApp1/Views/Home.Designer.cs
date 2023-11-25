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
            equipajeButton = new MaterialSkin.Controls.MaterialButton();
            MisVuelosButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // equipajeButton
            // 
            equipajeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            equipajeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            equipajeButton.Depth = 0;
            equipajeButton.HighEmphasis = true;
            equipajeButton.Icon = null;
            equipajeButton.Location = new Point(530, 23);
            equipajeButton.Margin = new Padding(3, 5, 3, 5);
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
            MisVuelosButton.Location = new Point(638, 25);
            MisVuelosButton.Margin = new Padding(3, 5, 3, 5);
            MisVuelosButton.MouseState = MaterialSkin.MouseState.HOVER;
            MisVuelosButton.Name = "MisVuelosButton";
            MisVuelosButton.NoAccentTextColor = Color.Empty;
            MisVuelosButton.Size = new Size(105, 36);
            MisVuelosButton.TabIndex = 17;
            MisVuelosButton.Text = "Mis Vuelos";
            MisVuelosButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            MisVuelosButton.UseAccentColor = false;
            MisVuelosButton.UseVisualStyleBackColor = true;
            MisVuelosButton.Click += MisVuelosButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 451);
            Controls.Add(MisVuelosButton);
            Controls.Add(equipajeButton);
            Name = "Home";
            Padding = new Padding(2, 51, 2, 3);
            Text = "Vuelos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton equipajeButton;
        private MaterialSkin.Controls.MaterialButton MisVuelosButton;
    }
}