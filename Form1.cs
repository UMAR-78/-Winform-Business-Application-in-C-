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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
           InitializeComponent();
           string path = "Product.txt";
            string Employ_path = "Employ.txt";
            string C_path = "Costumer.txt";
            if (ProductsDL.read_products_data_from_file(path) == true && EmployDL.Load_from_file(Employ_path) == true /*&& CostumerDL.Read_costumer_data(C_path)*/)
            {
                MessageBox.Show("Data Loaded Successfully");
            }
            
            else
            {
                MessageBox.Show("Error while loadig data");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = new Admin_menu_form();
            f.Show();
            //this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmploy_Click(object sender, EventArgs e)
        {
            EmplyLogin_Form f = new EmplyLogin_Form();
            f.Show();
            
        }
    }
}
