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
    public partial class Form1 : Form
    {
        public Form1()
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

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {//Admin
            
        }

        private void nEWREGISTRATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {//ADMIN_nEWREGISTRATION
            Registration Radm = new Registration();
            Radm.ShowDialog();

        }

        private void lOGININToolStripMenuItem_Click(object sender, EventArgs e)
        {//ADMIN_LOGIN
            Admin adm = new Admin();
            adm.ShowDialog();
        }

        private void sTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {//staff

        }

        private void nEWREGISTRATIONToolStripMenuItem1_Click(object sender, EventArgs e)
        {//STAFF_nEWREGISTRATION
            Registration Rstf = new Registration();
            Rstf.ShowDialog();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {//STAFF_LOGIN
            Staff stf = new Staff();
            stf.ShowDialog();
        }

        private void sTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {//Student

        }

        private void nEWREGISTRATIONToolStripMenuItem2_Click(object sender, EventArgs e)
        {//Student nEWREGISTRATION
            Registration Rstu = new Registration();
            Rstu.ShowDialog();
        }

        private void lOGINToolStripMenuItem1_Click(object sender, EventArgs e)
        {// Student Login
            Student stu = new Student();
            stu.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
