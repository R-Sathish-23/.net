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

namespace WindowsFormsApp1
{
    public partial class ADMINVIEW : Form
    {
        public ADMINVIEW()
        {
            InitializeComponent();
        }

        private void label1_Id_Click(object sender, EventArgs e)
        {

        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PRASANNA\\source\\repos\\WindowsFormsApp14\\WindowsFormsApp14\\Database1.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.CommandText = "insert_adminreg";
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ADMIN_Login_ID", textBox_Loginid.Text);
                        cmd.Parameters.AddWithValue("@ADMIN_Login_Name", textBox_UserName.Text);
                        cmd.Parameters.AddWithValue("@ADMIN_Login_Password", _Password.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("added ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Admin")
            {
            }
            else if (comboBox1.Text == "Staff")
            {
            }
            else 
            {
                (comboBox1.Text == "Student")
            }
        }

        private void ADMINVIEW_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Staff");
            comboBox1.Items.Add("Student");

        }
    }
}
