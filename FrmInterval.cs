namespace WFA24100301
{
    public partial class FrmInterval : Form
    {
        public FrmInterval()
        {
            InitializeComponent();

            nudMin.Minimum = int.MinValue;
            nudMin.Maximum = int.MaxValue;

            nudMax.Minimum = int.MinValue;
            nudMax.Maximum = int.MaxValue;

            nudNumber.Minimum = int.MinValue;
            nudNumber.Maximum = int.MaxValue;

            lblStatement.Text = string.Empty;

            btnDetermine.Click += BtnDetermine_Click;
        }

        private void BtnDetermine_Click(object? sender, EventArgs e)
        {
            lblStatement.Text =
                nudMin.Value <= nudNumber.Value &&
                nudNumber.Value <= nudMax.Value
                ? "the number is within the interval"
                : "the number is outside the interval";
        }
    }
}
