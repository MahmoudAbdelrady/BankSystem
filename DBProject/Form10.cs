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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-0B8LODU;Initial Catalog=ProjectDB;Integrated Security=True";

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AdminForm = new Form4();
            AdminForm.Show();
        }

        private void Form10_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet1.LOAN' table. You can move, or remove it, as needed.
            this.lOANTableAdapter.Fill(this.projectDBDataSet1.LOAN);

        }
    }
}
