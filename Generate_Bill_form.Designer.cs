
namespace Business_Application
{
    partial class Generate_Bill_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.labname = new System.Windows.Forms.Label();
            this.lbltoken = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.lblTotl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(94, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costumer name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(635, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costumer Token:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(94, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costumer phone#:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(749, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Bill:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(93, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter costumer token#";
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(471, 8);
            this.tokenBox.Multiline = true;
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(100, 36);
            this.tokenBox.TabIndex = 6;
            this.tokenBox.TextChanged += new System.EventHandler(this.tokenBox_TextChanged);
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGen.Location = new System.Drawing.Point(699, 5);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(90, 39);
            this.btnGen.TabIndex = 7;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.button1_Click);
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(364, 104);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(0, 20);
            this.labname.TabIndex = 8;
            // 
            // lbltoken
            // 
            this.lbltoken.AutoSize = true;
            this.lbltoken.Location = new System.Drawing.Point(911, 104);
            this.lbltoken.Name = "lbltoken";
            this.lbltoken.Size = new System.Drawing.Size(0, 20);
            this.lbltoken.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(346, 189);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 20);
            this.lblPhone.TabIndex = 10;
            // 
            // lbldisplay
            // 
            this.lbldisplay.AutoSize = true;
            this.lbldisplay.Location = new System.Drawing.Point(429, 294);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(0, 20);
            this.lbldisplay.TabIndex = 11;
            // 
            // lblTotl
            // 
            this.lblTotl.AutoSize = true;
            this.lblTotl.Location = new System.Drawing.Point(901, 625);
            this.lblTotl.Name = "lblTotl";
            this.lblTotl.Size = new System.Drawing.Size(0, 20);
            this.lblTotl.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 260);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(99, 625);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 39);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Generate_Bill_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 694);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotl);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lbltoken);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.tokenBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Generate_Bill_form";
            this.Text = "Generate_Bill_form";
            this.Load += new System.EventHandler(this.Generate_Bill_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label lbltoken;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Label lblTotl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
    }
}