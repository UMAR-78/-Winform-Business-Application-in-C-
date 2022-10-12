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
    public partial class Generate_Bill_form : System.Windows.Forms.Form
    {
        public Generate_Bill_form()
        {
            InitializeComponent();
        }

        private void Generate_Bill_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Total = 0;
            Costumer c = CostumerDL.isExist(int.Parse(tokenBox.Text));
            if (c != null)
            {
              //  flag = true;
               
                
                labname.Text = c.Name;
                lbltoken.Text = c.Token.ToString();
                lblPhone.Text = c.Phone;


                dataGridView1.DataSource = c.Pro;

              
                for(int i = 0; i < c.Pro.Count; i++)
                {
                    Total = Total + c.Pro[i].P_amount;
                }
                lblTotl.Text = Total.ToString();
            }
            if(c==null)
            {
                MessageBox.Show("Record not found");
            }
        }

    

        private void tokenBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployForm f = new EmployForm();
            f.Show();
            this.Close();
        }
    }
}
