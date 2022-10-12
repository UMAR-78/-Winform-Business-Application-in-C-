
namespace Business_Application
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnEmploy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(916, 621);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 42);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdmin.Location = new System.Drawing.Point(569, 471);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(93, 44);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnEmploy
            // 
            this.btnEmploy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmploy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmploy.Location = new System.Drawing.Point(769, 471);
            this.btnEmploy.Name = "btnEmploy";
            this.btnEmploy.Size = new System.Drawing.Size(93, 44);
            this.btnEmploy.TabIndex = 8;
            this.btnEmploy.Text = "Employ";
            this.btnEmploy.UseVisualStyleBackColor = false;
            this.btnEmploy.Click += new System.EventHandler(this.btnEmploy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::Business_Application.Properties.Resources.stationery_apointment_book_pencil_ruler;
            this.label2.Location = new System.Drawing.Point(573, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter your desired option:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Image = global::Business_Application.Properties.Resources.stationery_apointment_book_pencil_ruler;
            this.label1.Location = new System.Drawing.Point(93, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welome to Golden Stationers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Business_Application.Properties.Resources.colorful_school_supplies_shopping_basket_gray_background_with_copy_text_space_stack_books_with_colorful_covers_concept_returning_school_new_academic_year;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1046, 710);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 709);
            this.Controls.Add(this.btnEmploy);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnEmploy;
    }
}

