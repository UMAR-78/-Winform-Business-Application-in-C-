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
    public partial class Online_Costumer_form : System.Windows.Forms.Form
    {
        public Online_Costumer_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Product_from f = new View_Product_from();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generate_Bill_form f = new Generate_Bill_form();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your review");
        }
    }
}
