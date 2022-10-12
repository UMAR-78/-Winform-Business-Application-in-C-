
namespace Business_Application
{
    partial class Check_Stock_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnbACK = new System.Windows.Forms.Button();
            this.chkBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Business_Application.Properties.Resources.market_share_competitor_excellent_growing_with_stocks;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnbACK);
            this.panel1.Controls.Add(this.chkBtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.codeBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 694);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(123, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // btnbACK
            // 
            this.btnbACK.BackColor = System.Drawing.Color.Blue;
            this.btnbACK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnbACK.Location = new System.Drawing.Point(46, 602);
            this.btnbACK.Name = "btnbACK";
            this.btnbACK.Size = new System.Drawing.Size(99, 38);
            this.btnbACK.TabIndex = 3;
            this.btnbACK.Text = "Back";
            this.btnbACK.UseVisualStyleBackColor = false;
            this.btnbACK.Click += new System.EventHandler(this.btnbACK_Click);
            // 
            // chkBtn
            // 
            this.chkBtn.BackColor = System.Drawing.Color.Blue;
            this.chkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chkBtn.Location = new System.Drawing.Point(826, 67);
            this.chkBtn.Name = "chkBtn";
            this.chkBtn.Size = new System.Drawing.Size(99, 38);
            this.chkBtn.TabIndex = 2;
            this.chkBtn.Text = "Check";
            this.chkBtn.UseVisualStyleBackColor = false;
            this.chkBtn.Click += new System.EventHandler(this.chkBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(936, 346);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(309, 79);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(442, 26);
            this.codeBox.TabIndex = 0;
            // 
            // Check_Stock_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 694);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Check_Stock_form";
            this.Text = "Check_Stock_form";
            this.Load += new System.EventHandler(this.Check_Stock_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Button chkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbACK;
    }
}