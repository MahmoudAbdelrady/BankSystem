using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DBProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-0B8LODU;Initial Catalog=ProjectDB;Integrated Security=True";
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AddCustomer = new Form7();
            AddCustomer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AdminForm = new Form1();
            AdminForm.Show();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.projectDBDataSet1.CUSTOMER);
        }
    }
}
