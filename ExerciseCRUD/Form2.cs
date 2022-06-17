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

namespace ExerciseCRUD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=MYLEGION\\RAFI;Initial Catalog=CRUD;User Id=sa; Password=D3c4d3rs");
            cn.Open();
            //bind data in data grid view  
            GetAllEmployeeRecord();

            //disable delete and update button on load  
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
