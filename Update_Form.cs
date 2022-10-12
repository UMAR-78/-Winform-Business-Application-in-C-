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
    public partial class Update_Form : System.Windows.Forms.Form
    {
        private Products previous;  
        public Update_Form(Products prevoius)
        {
            InitializeComponent();
            this.previous = prevoius;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Update_Form_Load(object sender, EventArgs e)
        {
            UpdateNamebox.Text = previous.Name;
            updatpricebox.Text= (previous.Price).ToString();
            updateqtybos.Text = previous.Quantity.ToString();
            updateitemcodebox.Text = previous.Item_code;
            updatecompanyBOx.Text = previous.Company;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            Products Update = new Products(UpdateNamebox.Text, int.Parse(updatpricebox.Text), updateitemcodebox.Text, updatecompanyBOx.Text, int.Parse(updateqtybos.Text));
            ProductsDL.EditProductFromList(previous,Update);
            MessageBox.Show("Product has been updated successfully");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Update_Delete_Form f = new Update_Delete_Form();
            f.Show();
            this.Close();
        }
    }
}
