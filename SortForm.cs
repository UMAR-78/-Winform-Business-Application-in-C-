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
    public partial class SortForm : System.Windows.Forms.Form
    {
        public SortForm()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Admin_menu_form f = new Admin_menu_form();
            f.Show();
            this.Close();
        }

        //Ascending button
        private void button1_Click(object sender, EventArgs e)
        {
            gvSort.DataSource = ProductsDL.SortingINAsccending();
        }

        private void SortForm_Load(object sender, EventArgs e)
        {
            gvSort.DataSource = ProductsDL.Products_list;
        }
        //Descending button
        private void button2_Click(object sender, EventArgs e)
        {
            gvSort.DataSource = ProductsDL.SortingINDesccending();
        }


        // Ascending button sorting


    }
}
