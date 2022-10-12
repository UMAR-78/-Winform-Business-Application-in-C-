
namespace Business_Application
{
    partial class EmployForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.billbtn = new System.Windows.Forms.Button();
            this.orderbtn = new System.Windows.Forms.Button();
            this.shoWbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.billbtn);
            this.panel1.Controls.Add(this.orderbtn);
            this.panel1.Controls.Add(this.shoWbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 162);
            this.panel1.TabIndex = 0;
            // 
            // billbtn
            // 
            this.billbtn.BackColor = System.Drawing.Color.Black;
            this.billbtn.ForeColor = System.Drawing.Color.Yellow;
            this.billbtn.Location = new System.Drawing.Point(809, 46);
            this.billbtn.Name = "billbtn";
            this.billbtn.Size = new System.Drawing.Size(107, 48);
            this.billbtn.TabIndex = 2;
            this.billbtn.Text = "Generate Bill";
            this.billbtn.UseVisualStyleBackColor = false;
            this.billbtn.Click += new System.EventHandler(this.billbtn_Click);
            // 
            // orderbtn
            // 
            this.orderbtn.BackColor = System.Drawing.Color.Black;
            this.orderbtn.ForeColor = System.Drawing.Color.Yellow;
            this.orderbtn.Location = new System.Drawing.Point(474, 46);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(107, 48);
            this.orderbtn.TabIndex = 1;
            this.orderbtn.Text = "Take Order";
            this.orderbtn.UseVisualStyleBackColor = false;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click);
            // 
            // shoWbtn
            // 
            this.shoWbtn.BackColor = System.Drawing.Color.Black;
            this.shoWbtn.ForeColor = System.Drawing.Color.Yellow;
            this.shoWbtn.Location = new System.Drawing.Point(116, 46);
            this.shoWbtn.Name = "shoWbtn";
            this.shoWbtn.Size = new System.Drawing.Size(107, 48);
            this.shoWbtn.TabIndex = 0;
            this.shoWbtn.Text = "Show Products";
            this.shoWbtn.UseVisualStyleBackColor = false;
            this.shoWbtn.Click += new System.EventHandler(this.shoWbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 532);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(116, 438);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(207, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "Golden Stationers";
            // 
            // EmployForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "EmployForm";
            this.Text = "EmployForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button billbtn;
        private System.Windows.Forms.Button orderbtn;
        private System.Windows.Forms.Button shoWbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}