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
    public partial class Update_employ_form : System.Windows.Forms.Form
    {
        private Employ previous;
        public Update_employ_form()
        {
            InitializeComponent();
        //   this.previous = previous;
        }

       

        private void Update_employ_form_Load(object sender, EventArgs e)
        {
            updateAddressbox.Text = previous.E_address;
            UpdateNamebox.Text = previous.E_name;
            updateDesignBOx.Text = previous.Designatin;
            updateloginbox.Text = previous.E_login;
            updateNObox.Text = previous.E_name;
            updateSalaryBox.Text = previous.E_salary;
        }
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            Employ update = new Employ(UpdateNamebox.Text, updateloginbox.Text, updateSalaryBox.Text, updateNObox.Text, updateAddressbox.Text, updateDesignBOx.Text);
            EmployDL.EditEmployDataFromList(previous, update);
            MessageBox.Show("EMPLOY RECORD HAS BEEN UPDATES SUCCESSFULLY");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Up_Del_Form f = new Up_Del_Form();
            f.Show();
            this.Close();
        }
    }
}
