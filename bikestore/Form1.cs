using bikestore.Models;

namespace bikestore
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 uc = new();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 uc = new();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }
    }
}
