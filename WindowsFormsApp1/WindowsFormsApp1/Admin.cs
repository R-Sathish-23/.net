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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_Gavs_Click(object sender, EventArgs e)
        {

        }

        private void label1_Login_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Password_Click(object sender, EventArgs e)
        {

        }

        private void _Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Gavs.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.CommandText = "AdminLogin";
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ADMIN_Login_ID", textBox_Login.Text);
                        cmd.Parameters.AddWithValue("@ADMIN_Login_Name", textBox_UserName.Text);
                        cmd.Parameters.AddWithValue("@ADMIN_Login_Password", _Password.Text);
                                           
                        SqlDataAdapter da = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        da.SelectCommand = cmd;
                        da.Fill(ds, "temp");
                        if (ds.Tables["temp"].Rows.Count > 0)
                        {
                         
                            MessageBox.Show("LOGIN SUCCESSFULLY ");
                            ADMINVIEW adview = new ADMINVIEW();
                            adview.ShowDialog();
                        }
                        else
                            System.Console.WriteLine("Invalid User name or password. Please check the details ");
                        cmd.ExecuteNonQuery();
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void label1_UserName_Click(object sender, EventArgs e)
        {

        }

        private void textBox_UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
