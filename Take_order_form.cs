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
    public partial class Take_order_form : System.Windows.Forms.Form
    {
        // List<Products> order_products = new List<Products>();
        List<Costumer_order_products> pro = new List<Costumer_order_products>();

        public Take_order_form()
        {
            InitializeComponent();
        }

        public void clear()
        {
            p_nameBox.Text = "";
            p_idbox.Text = "";
            p_quantityBox.Text = "";
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int amount =0;
            foreach (Products p in ProductsDL.Products_list)

            {
                if (p_nameBox.Text == p.Name && p_idbox.Text == p.Item_code && int.Parse(p_quantityBox.Text) <= p.Quantity)
                {
                    flag = true;
                    string path = "Product.txt";
                    
                    p.Quantity = p.Quantity - int.Parse(p_quantityBox.Text);
                    amount = p.Price * int.Parse(p_quantityBox.Text);
                    Costumer_order_products o_p = new Costumer_order_products(p_nameBox.Text, p_idbox.Text, p.Price, int.Parse(p_quantityBox.Text) , amount);
                    pro.Add(o_p);
                    MessageBox.Show("Product added succesffuly");
                    clear();
                    ProductsDL.StoreAllDatainFile(path);
                    break;
                }
                
            }
            if(flag == false)
            {
                MessageBox.Show("You Entered Wrong Information");
            }
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            string path = "Costumer.txt";
            Costumer c = new Costumer(c_namebox.Text, PhoneNumberBox.Text, int.Parse(tokeBox.Text), pro);
            CostumerDL.Add_orders_in_list(c);
            CostumerDL.store_costumer_data_in_file(path, c);
            MessageBox.Show("Data Entered Successfully");

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployForm f = new EmployForm();
            f.Show();
            this.Close();
        }
    }
}
