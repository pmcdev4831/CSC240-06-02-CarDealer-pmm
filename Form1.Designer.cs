namespace CSC240_06_03_CarDealer_pmm
{
    partial class Form1
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
            UxFordFocusCheckBox = new CheckBox();
            UxToyotaCamryCheckBox = new CheckBox();
            UxChevyTahoeCheckBox = new CheckBox();
            UxCarDealerLabel = new Label();
            SuspendLayout();
            // 
            // UxFordFocusCheckBox
            // 
            UxFordFocusCheckBox.AutoSize = true;
            UxFordFocusCheckBox.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UxFordFocusCheckBox.Location = new Point(123, 98);
            UxFordFocusCheckBox.Name = "UxFordFocusCheckBox";
            UxFordFocusCheckBox.Size = new Size(185, 27);
            UxFordFocusCheckBox.TabIndex = 0;
            UxFordFocusCheckBox.Text = "Ford Focus 2016";
            UxFordFocusCheckBox.UseVisualStyleBackColor = true;
            UxFordFocusCheckBox.CheckedChanged += UxFordFocusCheckBox_CheckedChanged;
            // 
            // UxToyotaCamryCheckBox
            // 
            UxToyotaCamryCheckBox.AutoSize = true;
            UxToyotaCamryCheckBox.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UxToyotaCamryCheckBox.Location = new Point(123, 149);
            UxToyotaCamryCheckBox.Name = "UxToyotaCamryCheckBox";
            UxToyotaCamryCheckBox.Size = new Size(208, 27);
            UxToyotaCamryCheckBox.TabIndex = 1;
            UxToyotaCamryCheckBox.Text = "Toyota Camry 2010";
            UxToyotaCamryCheckBox.UseVisualStyleBackColor = true;
            UxToyotaCamryCheckBox.CheckedChanged += UxToyotaCamryCheckBox_CheckedChanged;
            // 
            // UxChevyTahoeCheckBox
            // 
            UxChevyTahoeCheckBox.AutoSize = true;
            UxChevyTahoeCheckBox.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UxChevyTahoeCheckBox.Location = new Point(124, 201);
            UxChevyTahoeCheckBox.Name = "UxChevyTahoeCheckBox";
            UxChevyTahoeCheckBox.Size = new Size(199, 27);
            UxChevyTahoeCheckBox.TabIndex = 2;
            UxChevyTahoeCheckBox.Text = "Chevy Tahoe 2013";
            UxChevyTahoeCheckBox.UseVisualStyleBackColor = true;
            UxChevyTahoeCheckBox.CheckedChanged += UxChevyTahoeCheckBox_CheckedChanged;
            // 
            // UxCarDealerLabel
            // 
            UxCarDealerLabel.AutoSize = true;
            UxCarDealerLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UxCarDealerLabel.Location = new Point(123, 9);
            UxCarDealerLabel.Name = "UxCarDealerLabel";
            UxCarDealerLabel.Size = new Size(271, 48);
            UxCarDealerLabel.TabIndex = 3;
            UxCarDealerLabel.Text = "Please select a car model\r\n for more information.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UxCarDealerLabel);
            Controls.Add(UxChevyTahoeCheckBox);
            Controls.Add(UxToyotaCamryCheckBox);
            Controls.Add(UxFordFocusCheckBox);
            Name = "Form1";
            Text = "Car Dealer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox UxFordFocusCheckBox;
        private CheckBox UxToyotaCamryCheckBox;
        private CheckBox UxChevyTahoeCheckBox;
        private Label UxCarDealerLabel;
    }
}
