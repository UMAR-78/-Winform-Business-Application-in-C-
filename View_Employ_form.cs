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
namespace Business_Application
{
    public partial class View_Employ_form : System.Windows.Forms.Form
    {
        public View_Employ_form()
        {
            InitializeComponent();
        }

        private void View_Employ_form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployDL.Employ_list;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Admin_menu_form f = new Admin_menu_form();
            f.Show();
            this.Close();
        }
    }
}
