namespace Registration_form
{
    public partial class Form1 : Form
    {
        public static string[] username = new string[130];
        public static string[] password = new string[130];
        public static int indexNumber=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            indexNumber++;
            dataGridView1.Rows.Add(username, password, DateTime.Now);
        }
    }
}
