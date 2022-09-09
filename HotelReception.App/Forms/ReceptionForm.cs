using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelReception.Business;
using HotelReception.Common.Extensions;
using HotelReception.ViewModel.Model.Request;
using HotelReception.ViewModel.Model.Response;

namespace HotelReception.Forms
{
    public partial class ReceptionForm : MasterForm
    {

        private readonly ReservationBusiness _appBusiness;

        public ReceptionForm()
        {
            InitializeComponent();

            _appBusiness = new ReservationBusiness();
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            new CustomerInfoForm().ShowDialog();

            var selectCustomer = GetDataCustomer();
            if (selectCustomer != null)
            {
                lblFirstNameIs.Text = selectCustomer.FirstName;
                lblLastNameIs.Text = selectCustomer.LastName;
                btnSelectRoom.Enabled = true;
                btnSelectCustomer.Enabled = false;
            }
            else
            {
                btnSelectCustomer.Enabled = true;
                btnSelectRoom.Enabled = false;
            }
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            new RoomForm().ShowDialog();
            var selectCustomer = GetDataCustomer();

            if (selectCustomer == null)
            {
                MessageBox.Show("Please Select a Customer", "Warning");
                return;
            }
            var selectRoom = GetDataRoom();
            if (selectRoom == null)
            {
                MessageBox.Show("Please Select a Room", "Warning");
                return;
            }

            lblRoomNoIs.Text = selectRoom.Number.ToString();

            var result = new ReservationBusiness().GetByFkId(selectRoom.RoomId, selectCustomer.CustomerInfoId);
            if (result.IsSuccess)
            {
                var isNewRoom = result.Data.RoomId != selectRoom.RoomId;
                if (isNewRoom)
                {
                    if (!selectRoom.Available)
                    {
                        btnCheckIn.Enabled = true;
                        btnCheckOut.Enabled = false;
                        return;
                    }

                    btnCheckIn.Enabled = false;
                    btnCheckOut.Enabled = false;
                    MessageBox.Show("Please Select UnAvailable Room", "Warning");
                    return;
                }
                if (result.Data.CheckOutDate != null)
                {
                    btnCheckIn.Enabled = false;
                    btnCheckOut.Enabled = true;
                    return;
                }

                btnCheckIn.Enabled = true;
                btnCheckOut.Enabled = false;
                return;

            }

            btnCheckIn.Enabled = true;
            btnCheckOut.Enabled = false;
            btnSelectRoom.Enabled = false;
            return;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            var selectCustomer = GetDataCustomer();

            if (selectCustomer == null)
            {
                MessageBox.Show("Please Select a Customer", "Warning");
                return;
            }
            var selectRoom = GetDataRoom();
            if (selectRoom == null)
            {
                MessageBox.Show("Please Select a Room", "Warning");
                return;
            }
            //Todo:Check that the customer has not previously selected a duplicate room
            var dataResult = new ReservationBusiness().GetByFkId(selectRoom.RoomId, selectCustomer.CustomerInfoId);
            if (dataResult.IsSuccess)
            {
                if (dataResult.Data != null)
                {
                    if (dataResult.Data.CheckOutDate != null)
                    {
                        MessageBox.Show("CheckIn was successful", "Success");
                        btnCheckIn.Enabled = false;
                        btnCheckOut.Enabled = true;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("CheckIn has already been done !", "Success");
                        ResetForm();
                        return;
                    }

                }

            }
            var checkIn = new ReservationCheckIn()
            {
                CustomerInfoId = selectCustomer.CustomerInfoId,
                RoomId = selectRoom.RoomId
            };
            var result = _appBusiness.CheckIn(checkIn);
            if (result.IsSuccess)
            {
                MessageBox.Show("CheckIn was successful", "Success");
                ResetForm();
                return;
            }
            else
            {
                MessageBox.Show($"CheckIn has error!. => {result.ErrorMessage}", "Please Try Again");
                return;
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var selectCustomer = GetDataCustomer();

            if (selectCustomer == null)
            {
                MessageBox.Show("Please Select a Customer", "Warning");
                return;
            }
            var selectRoom = GetDataRoom();
            if (selectRoom == null)
            {
                MessageBox.Show("Please Select a Room", "Warning");
                return;
            }

            CheckOutSafe(selectRoom, selectCustomer);
        }

        private void CheckOutSafe(RoomInfoViewModel selectRoom, CustomerInfoViewModel selectCustomer)
        {
            var result = new ReservationBusiness().GetByFkId(selectRoom.RoomId, selectCustomer.CustomerInfoId);
            if (result.IsSuccess)
            {
                if (result.Data != null)
                {
                    if (result.Data.CheckOutDate is null)
                    {
                        var checkOut = new ReservationCheckOut
                        {
                            ReservationId = selectCustomer.CustomerInfoId,
                        };
                        var operationResult = _appBusiness.CheckOut(checkOut);
                        if (operationResult.IsSuccess)
                        {
                            MessageBox.Show("CheckOut was successful", "Success");
                            ResetForm();
                        }
                        else
                        {
                            MessageBox.Show($"CheckOut has error!. => {result.ErrorMessage}", "Please Try Again");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("CheckOut has already been done !", "Success");
                        ResetForm();
                    }


                }
                else
                {
                    MessageBox.Show("Reservation Data Invalid!", "Warning");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Reservation Not Fund!", "Warning");
            }
        }


        private void ResetForm()
        {
            btnSelectCustomer.Enabled = true;
            btnSelectRoom.Enabled = false;
            btnCheckIn.Enabled = false;
            btnCheckOut.Enabled = false;

            lblRoomNoIs.Text = string.Empty;
            lblFirstNameIs.Text = string.Empty;
            lblLastNameIs.Text = string.Empty;

            RemoveDataCustomer();

            RemoveDataRoom();

            GetList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void GetList()
        {
            dataGrid.DataSource = GetInfos();

            SetColumnName();

        }
        private List<ReservationInfoGridViewModel> GetInfos()
        {
            return _appBusiness.GetAll();
        }
        private void SetColumnName()
        {
            if (dataGrid is null) return;



            dataGrid.Columns["RoomId"].Visible = false;

            dataGrid.Columns["CustomerInfoId"].Visible = false;

            dataGrid.Columns["ReservationId"].Visible = false;
        }

        private void ReceptionForm_Load(object sender, EventArgs e)
        {
            GetList();
        }
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataGridView();
        }
        private void ShowDataGridView()
        {
            if (dataGrid.RowCount == 0) return;

            var roomId = dataGrid.CurrentRow.Cells["RoomId"].Value;

            var customerInfoId = dataGrid.CurrentRow.Cells["CustomerInfoId"].Value;

            if (roomId is null || customerInfoId is null)
            {
                ResetForm();
                return;
            }

            var data = _appBusiness.GetByFkId(roomId.GetHashCode(), customerInfoId.GetHashCode());
            if (data.IsSuccess)
            {
                var selectCustomer = data.Data.CustomerInfo;
                SetDataCustomer(selectCustomer);
                lblFirstNameIs.Text = selectCustomer.FirstName;
                lblLastNameIs.Text = selectCustomer.LastName;

                var selectRoom = data.Data.RoomInfo;
                SetDataRoom(selectRoom);
                lblRoomNoIs.Text = selectRoom.Number.ToString();
                btnCheckOut.Enabled = true;
                btnSelectCustomer.Enabled = false;
            }
            else
            {
                MessageBox.Show("Room Not Fund", "Alert");
                ResetForm();
                return;
            }

        }
      


    }
}
