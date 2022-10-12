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
    public partial class Add_product_form : System.Windows.Forms.Form
    {
        public Add_product_form()
        {
            InitializeComponent();
        }

        private void clearForm()
        {
            nameBOX.Text = "";
            PriceBox.Text = "";
            codeBox.Text = "";
            companyBox.Text = "";
            QtyBox.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //bool flag = false;
            if (int.Parse(PriceBox.Text) > 0 && int.Parse(QtyBox.Text) > 0)
            {
                String path = "Product.txt";
              //  flag = true;
                Products p = new Products(nameBOX.Text, int.Parse(PriceBox.Text), codeBox.Text, companyBox.Text, int.Parse(QtyBox.Text));
                ProductsDL.addintoproductsList(p);
                ProductsDL.StoreDatainFile(p,path);
                MessageBox.Show("Data enter successfully");
                clearForm();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Admin_menu_form f = new Admin_menu_form();
                f.Show();
                this.Close();
       }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(PriceBox.Text, "[-]"))
            {
                MessageBox.Show("Invalid Product Price.");
                PriceBox.Text = PriceBox.Text.Remove(PriceBox.Text.Length - 1);
            }
        }

        private void QtyBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(QtyBox.Text, "[-9]"))
            {
                MessageBox.Show("Invalid Quanity.");
                QtyBox.Text = QtyBox.Text.Remove(QtyBox.Text.Length - 1);
            }
        }

     
    }
}
