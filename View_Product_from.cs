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
    public partial class View_Product_from : Form
    {
        public View_Product_from()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BindData()
        {
            gvProducts.DataSource = null;
            gvProducts.DataSource = ProductsDL.Products_list;
            gvProducts.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void View_Product_from_Load(object sender, EventArgs e)
        {
            gvProducts.DataSource = ProductsDL.Products_list;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_menu_form f = new Admin_menu_form();
            f.Show();
            this.Close();
        }
    }
}
