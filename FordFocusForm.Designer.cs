namespace CSC240_06_03_CarDealer_pmm
{
    partial class FordFocusForm
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
            UxProsLabel = new Label();
            UxProsDescriptionLabel = new Label();
            UxConsLabel = new Label();
            UxConsDescriptionLabel = new Label();
            SuspendLayout();
            // 
            // UxProsLabel
            // 
            UxProsLabel.AutoSize = true;
            UxProsLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxProsLabel.Location = new Point(35, 31);
            UxProsLabel.Name = "UxProsLabel";
            UxProsLabel.Size = new Size(54, 22);
            UxProsLabel.TabIndex = 0;
            UxProsLabel.Text = "Pros";
            // 
            // UxProsDescriptionLabel
            // 
            UxProsDescriptionLabel.AutoSize = true;
            UxProsDescriptionLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UxProsDescriptionLabel.Location = new Point(39, 77);
            UxProsDescriptionLabel.Name = "UxProsDescriptionLabel";
            UxProsDescriptionLabel.Size = new Size(328, 72);
            UxProsDescriptionLabel.TabIndex = 1;
            UxProsDescriptionLabel.Text = "Balanced ride and handling.\r\nQuiet Interior.\r\nAttractive interior.\r\nAbundant list of upscale and high-tech options.";
            // 
            // UxConsLabel
            // 
            UxConsLabel.AutoSize = true;
            UxConsLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxConsLabel.Location = new Point(482, 35);
            UxConsLabel.Name = "UxConsLabel";
            UxConsLabel.Size = new Size(59, 22);
            UxConsLabel.TabIndex = 2;
            UxConsLabel.Text = "Cons";
            // 
            // UxConsDescriptionLabel
            // 
            UxConsDescriptionLabel.AutoSize = true;
            UxConsDescriptionLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UxConsDescriptionLabel.Location = new Point(486, 75);
            UxConsDescriptionLabel.Name = "UxConsDescriptionLabel";
            UxConsDescriptionLabel.Size = new Size(208, 36);
            UxConsDescriptionLabel.TabIndex = 3;
            UxConsDescriptionLabel.Text = "Tight Backseat.\r\nUnderwhelming acceleration.";
            // 
            // FordFocusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 261);
            Controls.Add(UxConsDescriptionLabel);
            Controls.Add(UxConsLabel);
            Controls.Add(UxProsDescriptionLabel);
            Controls.Add(UxProsLabel);
            Name = "FordFocusForm";
            Text = "Ford Focus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UxProsLabel;
        private Label UxProsDescriptionLabel;
        private Label UxConsLabel;
        private Label UxConsDescriptionLabel;
    }
}