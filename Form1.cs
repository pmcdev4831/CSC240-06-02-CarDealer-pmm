namespace CSC240_06_03_CarDealer_pmm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UxFordFocusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UxFordFocusCheckBox.Checked)
            {
                FordFocusForm fordFocusForm = new FordFocusForm();
                fordFocusForm.ShowDialog();
                UxFordFocusCheckBox.Checked = false;
            }
        }

        private void UxToyotaCamryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UxToyotaCamryCheckBox.Checked)
            {
                ToyotaCamryForm toyotaCamryForm = new ToyotaCamryForm();
                toyotaCamryForm.ShowDialog();
                UxToyotaCamryCheckBox.Checked = false;
            }
        }

        private void UxChevyTahoeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UxChevyTahoeCheckBox.Checked) 
            {
                ChevyTahoeForm chevyTahoeForm = new ChevyTahoeForm();
                chevyTahoeForm.ShowDialog();
                UxChevyTahoeCheckBox.Checked = false;
            }
        }
    }
}
