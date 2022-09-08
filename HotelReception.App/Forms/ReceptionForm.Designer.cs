
namespace HotelReception.Forms
{
    partial class ReceptionForm
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
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lblFirstNameIs = new System.Windows.Forms.Label();
            this.lblLastNameIs = new System.Windows.Forms.Label();
            this.btnSelectRoom = new System.Windows.Forms.Button();
            this.lblRoomNoIs = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblArrow1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 35);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 227;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(13, 12);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 226;
            this.lblFirstName.Text = "First Name:";
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.AllowUserToDeleteRows = false;
            this.dataGridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Location = new System.Drawing.Point(11, 206);
            this.dataGridCustomer.MultiSelect = false;
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.ReadOnly = true;
            this.dataGridCustomer.Size = new System.Drawing.Size(935, 254);
            this.dataGridCustomer.TabIndex = 228;
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(47, 162);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(119, 34);
            this.btnSelectCustomer.TabIndex = 1;
            this.btnSelectCustomer.Text = "Select Customer";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Enabled = false;
            this.btnCheckOut.Location = new System.Drawing.Point(542, 162);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(119, 34);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Enabled = false;
            this.btnCheckIn.Location = new System.Drawing.Point(377, 162);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(119, 34);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lblFirstNameIs
            // 
            this.lblFirstNameIs.AutoSize = true;
            this.lblFirstNameIs.Location = new System.Drawing.Point(78, 11);
            this.lblFirstNameIs.Name = "lblFirstNameIs";
            this.lblFirstNameIs.Size = new System.Drawing.Size(13, 13);
            this.lblFirstNameIs.TabIndex = 245;
            this.lblFirstNameIs.Text = "_";
            // 
            // lblLastNameIs
            // 
            this.lblLastNameIs.AutoSize = true;
            this.lblLastNameIs.Location = new System.Drawing.Point(78, 34);
            this.lblLastNameIs.Name = "lblLastNameIs";
            this.lblLastNameIs.Size = new System.Drawing.Size(13, 13);
            this.lblLastNameIs.TabIndex = 246;
            this.lblLastNameIs.Text = "_";
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.Enabled = false;
            this.btnSelectRoom.Location = new System.Drawing.Point(212, 162);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(119, 34);
            this.btnSelectRoom.TabIndex = 2;
            this.btnSelectRoom.Text = "Select Room";
            this.btnSelectRoom.UseVisualStyleBackColor = true;
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            // 
            // lblRoomNoIs
            // 
            this.lblRoomNoIs.AutoSize = true;
            this.lblRoomNoIs.Location = new System.Drawing.Point(79, 57);
            this.lblRoomNoIs.Name = "lblRoomNoIs";
            this.lblRoomNoIs.Size = new System.Drawing.Size(13, 13);
            this.lblRoomNoIs.TabIndex = 249;
            this.lblRoomNoIs.Text = "_";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(13, 58);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(55, 13);
            this.lblRoomNo.TabIndex = 248;
            this.lblRoomNo.Text = "Room No:";
            // 
            // lblArrow1
            // 
            this.lblArrow1.AutoSize = true;
            this.lblArrow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow1.Location = new System.Drawing.Point(172, 165);
            this.lblArrow1.Name = "lblArrow1";
            this.lblArrow1.Size = new System.Drawing.Size(34, 24);
            this.lblArrow1.TabIndex = 250;
            this.lblArrow1.Text = "=>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 251;
            this.label3.Text = "=>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 252;
            this.label4.Text = "=>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 253;
            this.label5.Text = "=>";
            // 
            // ReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(959, 470);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArrow1);
            this.Controls.Add(this.lblRoomNoIs);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.btnSelectRoom);
            this.Controls.Add(this.lblLastNameIs);
            this.Controls.Add(this.lblFirstNameIs);
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.dataGridCustomer);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "ReceptionForm";
            this.Text = "ReceptionInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblFirstNameIs;
        private System.Windows.Forms.Label lblLastNameIs;
        private System.Windows.Forms.Button btnSelectRoom;
        private System.Windows.Forms.Label lblRoomNoIs;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblArrow1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}