namespace ListBoxApp
{
    public partial class Form1 : Form
    {
        List<string> nlist = new()
        {
            "Januari",
            "Februari",
            "Mars",
            "April",
            "Maj",
            "Juni",
            "Juli",
            "Augusti",
            "September",
            "Oktober",
            "November",
            "December"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Add("Måndag");
            //listBox1.Items.Add("Tisdag");
            //listBox1.Items.Add("Onsdag");
            //listBox1.Items.Add("Torsdag");
            //listBox1.Items.Add("Fredag");
            //listBox1.Items.Add("Lördag");
            //listBox1.Items.Add("Söndag");

            listBox1.DataSource = nlist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string items = "";

            foreach (var item in listBox1.SelectedItems)
            {
                items += item.ToString() + "\n";
            }

            MessageBox.Show(items);
        }
    }
}