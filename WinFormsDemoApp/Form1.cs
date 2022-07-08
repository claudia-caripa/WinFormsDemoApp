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

        //Event Handling for ListBox lstCity
        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = (string)lstCity.SelectedItem;
            MessageBox.Show("Selected city: " + city);
           

        }

        //Event Handling for Submit button btnSubmit
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;

            MessageBox.Show("Welcome " + name + ";" +"\nLocation: " + address);

        }
    }
}