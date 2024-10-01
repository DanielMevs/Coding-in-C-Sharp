namespace MyWinFormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private int _count = 0;
        private void IncreaseCounterButton_Click(object sender, EventArgs e)
        {
            _count++;
            CounterLabel.Text = _count.ToString();
        }
    }
}
