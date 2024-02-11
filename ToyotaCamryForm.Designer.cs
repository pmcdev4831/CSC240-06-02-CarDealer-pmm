namespace CSC240_06_03_CarDealer_pmm
{
    partial class ToyotaCamryForm
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
            UxProsLabel.Location = new Point(54, 53);
            UxProsLabel.Name = "UxProsLabel";
            UxProsLabel.Size = new Size(54, 22);
            UxProsLabel.TabIndex = 0;
            UxProsLabel.Text = "Pros";
            // 
            // UxConsLabel
            // 
            UxConsLabel.AutoSize = true;
            UxConsLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxConsLabel.Location = new Point(440, 53);
            UxConsLabel.Name = "UxConsLabel";
            UxConsLabel.Size = new Size(59, 22);
            UxConsLabel.TabIndex = 1;
            UxConsLabel.Text = "Cons";
            // 
            // UxProsDescriptionLabel
            // 
            UxProsDescriptionLabel.AutoSize = true;
            UxProsDescriptionLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UxProsDescriptionLabel.Location = new Point(54, 126);
            UxProsDescriptionLabel.Name = "UxProsDescriptionLabel";
            UxProsDescriptionLabel.Size = new Size(304, 72);
            UxProsDescriptionLabel.TabIndex = 2;
            UxProsDescriptionLabel.Text = "Roomy Cabin.\r\nExtraordinarily refined and fuel-efficient V6.\r\nQuiet and cushy ride.\r\nExcellent crash test scores.";
            // 
            // UxConsDescriptionLabel
            // 
            UxConsDescriptionLabel.AutoSize = true;
            UxConsDescriptionLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UxConsDescriptionLabel.Location = new Point(419, 126);
            UxConsDescriptionLabel.Name = "UxConsDescriptionLabel";
            UxConsDescriptionLabel.Size = new Size(142, 36);
            UxConsDescriptionLabel.TabIndex = 3;
            UxConsDescriptionLabel.Text = "Spotty fit and finish.\r\nSpirtless Handling.";
            // 
            // ToyotaCamryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(UxConsDescriptionLabel);
            Controls.Add(UxProsDescriptionLabel);
            Controls.Add(UxConsLabel);
            Controls.Add(UxProsLabel);
            Name = "ToyotaCamryForm";
            Text = "Toyota Camry";
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