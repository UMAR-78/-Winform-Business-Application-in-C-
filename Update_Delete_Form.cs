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
    public partial class Update_Delete_Form : System.Windows.Forms.Form
    {
        public Update_Delete_Form()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
            string path = "Product.txt";
            Products p1 = (Products)gvProducts.CurrentRow.DataBoundItem;
            if (gvProducts.Columns["Delete"].Index == e.ColumnIndex)
            {
                ProductsDL.delete_from_list(p1);
                ProductsDL.StoreAllDatainFile(path);
                BindData();
            }
            else if (gvProducts.Columns["Update"].Index == e.ColumnIndex)
            {
                
                Update_Form f = new Update_Form(p1);
                f.ShowDialog();
                ProductsDL.StoreAllDatainFile(path);
                BindData();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Update_Delete_Form_Load(object sender, EventArgs e)
        {
            gvProducts.DataSource = ProductsDL.Products_list;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_menu_form f = new Admin_menu_form();
            f.Show();
            this.Close();
        }
    }
    }

