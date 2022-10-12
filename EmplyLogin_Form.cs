using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Application.DL;
using Business_Application.BL;
namespace Business_Application
{
    public partial class EmplyLogin_Form : System.Windows.Forms.Form
    {
        public EmplyLogin_Form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach(Employ emp in EmployDL.Employ_list)
            {
                if(Namebox.Text == emp.E_name && IdBOX.Text == emp.E_login)
                {
                    flag = true;
                    MessageBox.Show("Login Successfull");
                    EmployForm f = new EmployForm();
                    f.Show();
                    this.Close();
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Enter correct name and log in id");
                Namebox.Text = "";
                IdBOX.Text = "";
            }
        }
    }
}
