using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReception.Business;
using HotelReception.Common.Extensions;
using HotelReception.ViewModel.Enums;
using HotelReception.ViewModel.Model.Request;
using HotelReception.ViewModel.Model.Response;

namespace HotelReception.Forms
{
    public partial class RoomForm : MasterForm
    {
        private RoomInfoViewModel _roomEdit = null;

        private readonly RoomBusiness _appBusiness;
        public RoomForm()
        {
            InitializeComponent();

            _appBusiness = new RoomBusiness();
        }
        private void Frm_Load(object sender, EventArgs e)
        {
            GetList();

            CmbTypeDataBind();

            CmbFloorDataBind();
        }
        private void dataGridRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataGridView();
        }
        private void ShowDataGridView()
        {
            if (dataGridRoom.RowCount == 0) return;

            var value = dataGridRoom.CurrentRow.Cells["RoomId"].Value;
            if (value is null)
            {
                ResetForm();
                return;
            }

            var KeyId = value.ToString().ToInt();

            var data = _appBusiness.GetById(KeyId);
            if (data.IsSuccess)
            {
                _roomEdit = data.Data;
                SetItem();
            }
            else
            {
                MessageBox.Show("Room Not Fund", "Alert");
                ResetForm();
                return;
            }

        }
        private void SetItem()
        {
            if (_roomEdit is null)
            {
                ResetForm();
                return;
            }

            cmbFloor.SelectedValue = _roomEdit.Floor.GetHashCode();
            txtNumber.Text = _roomEdit.Number.ToString();
            CmbType.SelectedValue = _roomEdit.Type.GetHashCode();
            txtBedNumbers.Text = _roomEdit.BedNumbers.ToString();
            txtPricePerDay.Text = _roomEdit.PricePerDay.ToString();
            chkHasWin.Checked = _roomEdit.HasWindow;
            chkActive.Checked = _roomEdit.IsActive;

            btnGoToReception.Enabled = true;
        }

        private void CmbTypeDataBind()
        {
            var itemsEnum = MyExtensions.GetListItemsEnum<RoomType>();
            CmbType.DataSource = itemsEnum;
            CmbType.DisplayMember = "Description";
            CmbType.ValueMember = "Value";
            CmbType.SelectedIndex = 0;
        }
        private void CmbFloorDataBind()
        {
            var itemsEnum = MyExtensions.GetListItemsEnum<FloorType>();
            cmbFloor.DataSource = itemsEnum;
            cmbFloor.DisplayMember = "Description";
            cmbFloor.ValueMember = "Value";
            cmbFloor.SelectedIndex = 0;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidationItem()) return;
            if (_roomEdit is null)
            {
                var roomInfo = CreateRoomInfo();
                var result = _appBusiness.Add(roomInfo);

                if (result.IsSuccess)
                {
                    MessageBox.Show("Room registration was successful", "Success");

                    ResetForm();
                }
                else
                {
                    MessageBox.Show($"Room registration has error!. => {result.ErrorMessage}", "Please Try Again");
                }
            }
            else
            {
                var roomInfo = EditroomInfo();
                var result = _appBusiness.Edit(roomInfo);

                if (result.IsSuccess)
                {
                    MessageBox.Show("Room Update was successful", "Success");

                    ResetForm();
                }
                else
                {
                    MessageBox.Show($"Room Update has error!. => {result.ErrorMessage}", "Please Try Again");
                }
            }
        }

        private RoomAdd CreateRoomInfo()
        {
            return new RoomAdd
            {
                PricePerDay = txtPricePerDay.Text.ToInt(),
                BedNumbers = txtBedNumbers.Text.ToByte(),
                Number = txtNumber.Text.ToInt(),

                Type = (RoomType)CmbType.SelectedValue.GetHashCode(),
                Floor = (FloorType)cmbFloor.SelectedValue.GetHashCode(),
                HasWindow = chkHasWin.Checked,
                IsActive = chkActive.Checked,
            };
        }
        private RoomEdit EditroomInfo()
        {
            return new RoomEdit
            {

                PricePerDay = txtPricePerDay.Text.ToInt(),
                BedNumbers = txtBedNumbers.Text.ToByte(),
                Number = txtNumber.Text.ToInt(),

                Type = (RoomType)CmbType.SelectedValue.GetHashCode(),
                Floor = (FloorType)cmbFloor.SelectedValue.GetHashCode(),
                HasWindow = chkHasWin.Checked,
                IsActive = chkActive.Checked,

                RoomId = _roomEdit.RoomId
            };
        }

        private bool ValidationItem()
        {
            if (txtPricePerDay.Text.IsNullOrWhiteSpace() || !txtPricePerDay.Text.IsNumeric())
            {
                MessageBox.Show("Price Per Day is Required !, Please enter the correct value.", "Warning");
                return false;
            }

            if (txtBedNumbers.Text.IsNullOrWhiteSpace() || !txtBedNumbers.Text.IsNumeric())
            {
                MessageBox.Show("Bed Numbers is Required !, Please enter the correct value.", "Warning");
                return false;
            }
            if (txtNumber.Text.IsNullOrWhiteSpace() || !txtNumber.Text.IsNumeric())
            {
                MessageBox.Show("Number is Required !, Please enter the correct value.", "Warning");
                return false;
            }

            return true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {

            cmbFloor.SelectedValue = 1;
            CmbType.SelectedValue = 0;
            txtNumber.Text = string.Empty;
            txtBedNumbers.Text = string.Empty;
            txtPricePerDay.Text = string.Empty;
            chkHasWin.Checked = false;
            chkActive.Checked = false;

            _roomEdit = null;
            btnGoToReception.Enabled = false;
            GetList();
        }
        private void GetList()
        {
            dataGridRoom.DataSource = GetInfos();

            SetColumnName();

        }

        private List<RoomInfoViewModel> GetInfos()
        {
            return _appBusiness.GetAll();
        }
        private void SetColumnName()
        {
            if (dataGridRoom is null) return;

            dataGridRoom.Columns["AvailableTitle"].HeaderText = "Available";

            dataGridRoom.Columns["ActiveTitle"].HeaderText = "Active";

            dataGridRoom.Columns["WindowTitle"].HeaderText = "Window";


            dataGridRoom.Columns["BedNumbers"].HeaderText = "Bed Numbers";

            dataGridRoom.Columns["TypeTitle"].HeaderText = "Type";

            dataGridRoom.Columns["Number"].HeaderText = "Number";

            dataGridRoom.Columns["Floor"].HeaderText = "Floor";

            dataGridRoom.Columns["PricePerDay"].HeaderText = "Price Per Day";


            dataGridRoom.Columns["Available"].Visible = false;

            dataGridRoom.Columns["IsActive"].Visible = false;

            dataGridRoom.Columns["HasWindow"].Visible = false;

            dataGridRoom.Columns["Type"].Visible = false;

            dataGridRoom.Columns["RoomId"].Visible = false;
        }

        private void btnGoToReception_Click(object sender, EventArgs e)
        {
            if (!ValidationSelectedRoom()) return;

            SetDataRoom(_roomEdit);

            Close();
        }
        private bool ValidationSelectedRoom()
        {
            if (_roomEdit is null)
            {
                MessageBox.Show("Please Select the Room in Grid View.", "Warning");
                return false;
            }

            if (!_roomEdit.IsActive)
            {
                MessageBox.Show("Please Select the Active Room.", "Warning");
                return false;
            }

            if (_roomEdit.Available)
            {
                MessageBox.Show("Please Select the UnAvailable Room.", "Warning");
                return false;
            }
            var selectCustomer = GetDataCustomer();

            if (selectCustomer == null)
            {
                MessageBox.Show("Please Select a Customer", "Warning");
                return false;
            }
             
            return true;
        }
    }
}
