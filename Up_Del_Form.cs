using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Application.BL;
using Business_Application.DL;

namespace Business_Application
{
    public partial class Up_Del_Form : System.Windows.Forms.Form
    {
        public Up_Del_Form()
        {
            InitializeComponent();
        }
        private void BindData()
        {
            gvEmploy.DataSource = null;
            gvEmploy.DataSource = EmployDL.Employ_list;
            gvEmploy.Refresh();
        }

        private void Up_Del_Form_Load(object sender, EventArgs e)
        {
            gvEmploy.DataSource = EmployDL.Employ_list;
        }

        private void gvEmploy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string path = "Employ.txt";
            Employ emp = (Employ)gvEmploy.CurrentRow.DataBoundItem;
            if (gvEmploy.Columns["Delete"].Index == e.ColumnIndex)
            {
                EmployDL.remove_from_list(emp);
                EmployDL.StoreAll_employ_data_in_file(path);
                BindData();
            }
            else if (gvEmploy.Columns["Update"].Index == e.ColumnIndex)
            {

                Update_employ_form f = new Update_employ_form();
                f.ShowDialog();
                EmployDL.StoreAll_employ_data_in_file(path);
                // ProductsDL.StoreAllDatainFile(path);
                BindData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_menu_form f = new Admin_menu_form();
            f.Show();
            this.Close();
        }
    }
}
