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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-0B8LODU;Initial Catalog=ProjectDB;Integrated Security=True";
        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AdminForm = new Form4();
            AdminForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UpEmp = new Form13();
            UpEmp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UpCus = new Form9();
            UpCus.Show();
        }
    }
}
