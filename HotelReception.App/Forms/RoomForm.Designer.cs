
namespace HotelReception.Forms
{
    partial class RoomForm
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
            this.txtBedNumbers = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblBedNumbers = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.dataGridRoom = new System.Windows.Forms.DataGridView();
            this.lblType = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.txtPricePerDay = new System.Windows.Forms.TextBox();
            this.lblPricePerDay = new System.Windows.Forms.Label();
            this.lblHasWindow = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGoToReception = new System.Windows.Forms.Button();
            this.chkHasWin = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBedNumbers
            // 
            this.txtBedNumbers.Location = new System.Drawing.Point(303, 52);
            this.txtBedNumbers.MaxLength = 1;
            this.txtBedNumbers.Name = "txtBedNumbers";
            this.txtBedNumbers.Size = new System.Drawing.Size(110, 20);
            this.txtBedNumbers.TabIndex = 4;
            this.txtBedNumbers.WordWrap = false;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(303, 22);
            this.txtNumber.MaxLength = 3;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(110, 20);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.WordWrap = false;
            // 
            // lblBedNumbers
            // 
            this.lblBedNumbers.AutoSize = true;
            this.lblBedNumbers.Location = new System.Drawing.Point(227, 56);
            this.lblBedNumbers.Name = "lblBedNumbers";
            this.lblBedNumbers.Size = new System.Drawing.Size(74, 13);
            this.lblBedNumbers.TabIndex = 238;
            this.lblBedNumbers.Text = "Bed Numbers:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(254, 26);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 13);
            this.lblNumber.TabIndex = 223;
            this.lblNumber.Text = "Number:";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(53, 26);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(33, 13);
            this.lblFloor.TabIndex = 222;
            this.lblFloor.Text = "Floor:";
            // 
            // dataGridRoom
            // 
            this.dataGridRoom.AllowUserToDeleteRows = false;
            this.dataGridRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridRoom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoom.Location = new System.Drawing.Point(12, 184);
            this.dataGridRoom.MultiSelect = false;
            this.dataGridRoom.Name = "dataGridRoom";
            this.dataGridRoom.ReadOnly = true;
            this.dataGridRoom.Size = new System.Drawing.Size(590, 254);
            this.dataGridRoom.TabIndex = 36;
            this.dataGridRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoom_CellClick);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(52, 56);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 37;
            this.lblType.Text = "Type:";
            // 
            // CmbType
            // 
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Location = new System.Drawing.Point(87, 52);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(121, 21);
            this.CmbType.TabIndex = 3;
            // 
            // txtPricePerDay
            // 
            this.txtPricePerDay.Location = new System.Drawing.Point(87, 83);
            this.txtPricePerDay.MaxLength = 6;
            this.txtPricePerDay.Name = "txtPricePerDay";
            this.txtPricePerDay.Size = new System.Drawing.Size(122, 20);
            this.txtPricePerDay.TabIndex = 5;
            this.txtPricePerDay.WordWrap = false;
            // 
            // lblPricePerDay
            // 
            this.lblPricePerDay.AutoSize = true;
            this.lblPricePerDay.Location = new System.Drawing.Point(11, 87);
            this.lblPricePerDay.Name = "lblPricePerDay";
            this.lblPricePerDay.Size = new System.Drawing.Size(75, 13);
            this.lblPricePerDay.TabIndex = 236;
            this.lblPricePerDay.Text = "Price Per Day:";
            // 
            // lblHasWindow
            // 
            this.lblHasWindow.AutoSize = true;
            this.lblHasWindow.Location = new System.Drawing.Point(252, 87);
            this.lblHasWindow.Name = "lblHasWindow";
            this.lblHasWindow.Size = new System.Drawing.Size(49, 13);
            this.lblHasWindow.TabIndex = 239;
            this.lblHasWindow.Text = "Window:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 127);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 34);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGoToReception
            // 
            this.btnGoToReception.Enabled = false;
            this.btnGoToReception.Location = new System.Drawing.Point(468, 127);
            this.btnGoToReception.Name = "btnGoToReception";
            this.btnGoToReception.Size = new System.Drawing.Size(119, 34);
            this.btnGoToReception.TabIndex = 10;
            this.btnGoToReception.Text = "Go To Reception";
            this.btnGoToReception.UseVisualStyleBackColor = true;
            this.btnGoToReception.Click += new System.EventHandler(this.btnGoToReception_Click);
            // 
            // chkHasWin
            // 
            this.chkHasWin.AutoSize = true;
            this.chkHasWin.Location = new System.Drawing.Point(303, 86);
            this.chkHasWin.Name = "chkHasWin";
            this.chkHasWin.Size = new System.Drawing.Size(15, 14);
            this.chkHasWin.TabIndex = 6;
            this.chkHasWin.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(398, 86);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(15, 14);
            this.chkActive.TabIndex = 7;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(352, 87);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(43, 13);
            this.lblActive.TabIndex = 241;
            this.lblActive.Text = "Active :";
            // 
            // cmbFloor
            // 
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(87, 22);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(121, 21);
            this.cmbFloor.TabIndex = 1;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.cmbFloor);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.chkHasWin);
            this.Controls.Add(this.btnGoToReception);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblHasWindow);
            this.Controls.Add(this.lblPricePerDay);
            this.Controls.Add(this.txtPricePerDay);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.dataGridRoom);
            this.Controls.Add(this.txtBedNumbers);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblBedNumbers);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblFloor);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBedNumbers;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblBedNumbers;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.DataGridView dataGridRoom;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.TextBox txtPricePerDay;
        private System.Windows.Forms.Label lblPricePerDay;
        private System.Windows.Forms.Label lblHasWindow;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGoToReception;
        private System.Windows.Forms.CheckBox chkHasWin;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.ComboBox cmbFloor;
    }
}