using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReception.ViewModel.Model.Response;

namespace HotelReception.Forms
{
    public partial class ReceptionForm : MasterForm
    {
        public ReceptionForm()
        {
            InitializeComponent();
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            new CustomerInfoForm().ShowDialog();

            var data = GetDataCustomer();
            if (data != null)
            {
                lblFirstNameIs.Text = data.FirstName;
                lblLastNameIs.Text = data.LastName;
                btnSelectRoom.Enabled = true;
            }
            else
            {
                btnSelectRoom.Enabled = false;
            }
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            new RoomForm().ShowDialog();

            var data = GetDataRoom();
            if (data != null)
            {
                lblRoomNoIs.Text = data.Number.ToString();
                if (!data.Available && data.IsActive)
                {
                    btnCheckIn.Enabled = true;
                }
                else
                {
                    btnCheckOut.Enabled = true;

                }

            }
            else
            {
                btnCheckIn.Enabled = false;
                btnCheckOut.Enabled = false;
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }


    }
}
