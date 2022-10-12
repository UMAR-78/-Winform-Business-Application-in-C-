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
    public partial class EmployForm : System.Windows.Forms.Form
    {
        public EmployForm()
        {
            InitializeComponent();
        }

        private void shoWbtn_Click(object sender, EventArgs e)
        {
            View_Product_from f = new View_Product_from();
            f.Show();
            this.Close();
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            Take_order_form f = new Take_order_form();
            f.Show();
            this.Close();
        }

        private void billbtn_Click(object sender, EventArgs e)
        {
            Generate_Bill_form f = new Generate_Bill_form();
            f.Show();
            this.Close();
        }
    }
}
