namespace ErrorAmplifierCalculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BNError1_Click(object sender, EventArgs e)
        {
            FormError1 fe1 = new FormError1();
            fe1.ShowDialog();
        }

        private void BNError2_Click(object sender, EventArgs e)
        {
            FormError2 fe1 = new FormError2();
            fe1.ShowDialog();
        }
    }
}