namespace CSC240_06_03_CarDealer_pmm
{
    partial class ChevyTahoeForm
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
            UxConsLabel = new Label();
            UxProsDescriptionLabel = new Label();
            UxConsDescriptionLabel = new Label();
            SuspendLayout();
            // 
            // UxProsLabel
            // 
            UxProsLabel.AutoSize = true;
            UxProsLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxProsLabel.Location = new Point(87, 53);
            UxProsLabel.Name = "UxProsLabel";
            UxProsLabel.Size = new Size(54, 22);
            UxProsLabel.TabIndex = 0;
            UxProsLabel.Text = "Pros";
            // 
            // UxConsLabel
            // 
            UxConsLabel.AutoSize = true;
            UxConsLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxConsLabel.Location = new Point(409, 53);
            UxConsLabel.Name = "UxConsLabel";
            UxConsLabel.Size = new Size(59, 22);
            UxConsLabel.TabIndex = 1;
            UxConsLabel.Text = "Cons";
            // 
            // UxProsDescriptionLabel
            // 
            UxProsDescriptionLabel.AutoSize = true;
            UxProsDescriptionLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UxProsDescriptionLabel.Location = new Point(83, 142);
            UxProsDescriptionLabel.Name = "UxProsDescriptionLabel";
            UxProsDescriptionLabel.Size = new Size(194, 90);
            UxProsDescriptionLabel.TabIndex = 2;
            UxProsDescriptionLabel.Text = "Smooth V8 engine.\r\nSupple ride.\r\nStout towing capacity.\r\ngood fit and finish.\r\ncan seat up to nine people.\r\n";
            // 
            // UxConsDescriptionLabel
            // 
            UxConsDescriptionLabel.AutoSize = true;
            UxConsDescriptionLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UxConsDescriptionLabel.Location = new Point(369, 142);
            UxConsDescriptionLabel.Name = "UxConsDescriptionLabel";
            UxConsDescriptionLabel.Size = new Size(270, 72);
            UxConsDescriptionLabel.TabIndex = 3;
            UxConsDescriptionLabel.Text = "Third row seat doesn't fold down\r\nand less spacious than those of many \r\nbig crossovers.\r\nNo telescoping steering wheel.";
            // 
            // ChevyTahoeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(UxConsDescriptionLabel);
            Controls.Add(UxProsDescriptionLabel);
            Controls.Add(UxConsLabel);
            Controls.Add(UxProsLabel);
            Name = "ChevyTahoeForm";
            Text = "Chevy Tahoe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UxProsLabel;
        private Label UxConsLabel;
        private Label UxProsDescriptionLabel;
        private Label UxConsDescriptionLabel;
    }
}