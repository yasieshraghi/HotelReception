
namespace HotelReception.Forms
{
    partial class CustomerInfo
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
            this.txt_passport = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_passport
            // 
            this.txt_passport.Location = new System.Drawing.Point(147, 54);
            this.txt_passport.Name = "txt_passport";
            this.txt_passport.Size = new System.Drawing.Size(297, 20);
            this.txt_passport.TabIndex = 35;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(147, 22);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(100, 20);
            this.txt_firstname.TabIndex = 34;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(344, 22);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(100, 20);
            this.txt_lastname.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "PassportNo:";
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.Location = new System.Drawing.Point(274, 85);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(75, 23);
            this.btn_CheckIn.TabIndex = 30;
            this.btn_CheckIn.Text = "Check In";
            this.btn_CheckIn.UseVisualStyleBackColor = true;
            this.btn_CheckIn.Click += new System.EventHandler(this.btn_CheckIn_Click);
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Location = new System.Drawing.Point(369, 85);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(75, 23);
            this.btn_CheckOut.TabIndex = 29;
            this.btn_CheckOut.Text = "Check Out";
            this.btn_CheckOut.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 193);
            this.dataGridView1.TabIndex = 36;
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_passport);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_CheckIn);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerInfo";
            this.Text = "CustomerInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_passport;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}