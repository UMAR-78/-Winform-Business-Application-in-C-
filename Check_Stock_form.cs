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
    public partial class Check_Stock_form : System.Windows.Forms.Form
    {
        public Check_Stock_form()
        {
            InitializeComponent();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Check_Stock_form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductsDL.Products_list;
        }

        private void chkBtn_Click(object sender, EventArgs e)
        {

            List<Products> p = new List<Products>();
            foreach (Products p1 in ProductsDL.Products_list)
            {
                if(p1.Item_code == codeBox.Text)
                {
                    p.Add(p1);
                }
            }

            dataGridView1.DataSource = p;
        }

        private void btnbACK_Click(object sender, EventArgs e)
        {
            Admin_menu_form f = new Admin_menu_form();
            f.Show();
            this.Close();
        }
    }
}
