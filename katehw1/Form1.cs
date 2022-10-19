using System.Security.Cryptography.X509Certificates;

namespace katehw1
{
    public partial class Form1 : Form
    {
     
        int num;
        string num_enter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            num_enter = textBox1.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = false;
            try
            {
                num = Int32.Parse(num_enter);
                check = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (check == true)
            {
                MessageBox.Show("Your entered number: " + num);
                check = false;
            }

        }
    }
}