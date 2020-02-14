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


namespace petData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string conString = "Data Source=MS-002126362353\\SQLEXPRESS;Initial Catalog=PetCareSolutionsDB;Integrated Security=True";

        private void Submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Registration", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure; 
                sqlCmd.Parameters.AddWithValue("@LastName", textLN.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@FirstName", textFN.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Email", textEM.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Mobile", textPN.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Notes", textNO.Text.Trim());
                
                sqlCmd.Parameters.AddWithValue("@OwnerID", textOWN.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Entry Successsful");
                Clear();
            }
               
            
        }
        void Clear()
        {
            textLN.Text = textFN.Text = textEM.Text = textPN.Text = textNO.Text = "";
        }

    }
}
