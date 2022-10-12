using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Application
{
    public partial class Admin_menu_form : System.Windows.Forms.Form
    {
        public Admin_menu_form()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_product_form f = new Add_product_form();
            f.Show();
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            View_Product_from f = new View_Product_from();
            f.Show();
            this.Close();
        }

        private void updelBTN_Click(object sender, EventArgs e)
        {
            Update_Delete_Form f = new Update_Delete_Form();
            f.Show();
            this.Close();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            SortForm f = new SortForm();
            f.Show();
            this.Close();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            Check_Stock_form f = new Check_Stock_form();
            f.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void AddEmployBtn_Click(object sender, EventArgs e)
        {
            Add_employ_Form f = new Add_employ_Form();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Employ_form f = new View_Employ_form();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Up_Del_Form f = new Up_Del_Form();
            f.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Generate_Bill_form f = new Generate_Bill_form();
            f.Show();
            this.Close();
        }
    }
}
