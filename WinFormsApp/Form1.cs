namespace WinFormsApp
{
    public partial class MinKalkylator : Form
    {
        public MinKalkylator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, sum;
            i = int.Parse(tbTal1.Text);
            j = int.Parse(tbTal2.Text);
            sum = i + j;

            MessageBox.Show($"Summa = {sum}");
        }

        
    }
}