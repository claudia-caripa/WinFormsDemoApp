namespace WinFormsDemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = (string)lstCity.SelectedItem;
            MessageBox.Show("Selected city {0}", city);
           

        }
    }
}