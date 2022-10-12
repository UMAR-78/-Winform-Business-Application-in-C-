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
    public partial class Add_employ_Form : System.Windows.Forms.Form
    {
        public Add_employ_Form()
        {
            InitializeComponent();
        }

        public void clearForm()
        {
            Namebox.Text = "";
            LoginBox.Text = "";
            SalaryBox.Text = "";
            PhoneBox.Text = "";
            AdressBox.Text = "";
            DesigBox.Text = "";

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            String path = "Employ.txt";
            Employ emp = new Employ(Namebox.Text, LoginBox.Text,SalaryBox.Text, PhoneBox.Text, AdressBox.Text,DesigBox.Text);
            EmployDL.AddIntoEmployList(emp);
            EmployDL.Store_employ_data_in_file(path, emp);
            MessageBox.Show("Data enter successfully");
            clearForm();


        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            Admin_menu_form f = new Admin_menu_form();
            f.Show();
            this.Close();
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            
                long a;
                a = 11;
                if (!long.TryParse(PhoneBox.Text, out a))
                {
                    // If not int clear textbox text or Undo() last operation
                    PhoneBox.Clear();
                }
        }
    }
}
