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
    public partial class CustomerInfoForm : MasterForm
    {
        private CustomerInfoViewModel _customerEdit = null;

        private readonly CustomerInfoBusiness _appBusiness;
        public CustomerInfoForm()
        {
            InitializeComponent();

            _appBusiness = new CustomerInfoBusiness();
        }
        private void Frm_Load(object sender, EventArgs e)
        {
            GetList();

            CmbGenderDataBind();
        }
        private void dataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataGridView();
        }
        private void ShowDataGridView()
        {
            if (dataGridCustomer.RowCount == 0) return;

            var value = dataGridCustomer.CurrentRow.Cells["CustomerInfoId"].Value;
            if (value is null)
            {
                ResetForm();
                return;
            }

            var KeyId = value.ToString().ToInt();

            var data = _appBusiness.GetById(KeyId);
            if (data.IsSuccess)
            {
                _customerEdit = data.Data;
                SetItem();
            }
            else
            {
                MessageBox.Show("Customer Not Fund", "Alert");
                ResetForm();
                return;
            }

        }
        private void SetItem()
        {
            if (_customerEdit is null)
            {
                ResetForm();
                return;
            }
            txtFirstName.Text = _customerEdit.FirstName;
            txtLastName.Text = _customerEdit.LastName;
            CmbGender.SelectedValue = _customerEdit.Gender.GetHashCode();
            txtAge.Text = _customerEdit.Age.ToString();
            txtPassport.Text = _customerEdit.PassportNo;
            txtPhoneNumber.Text = _customerEdit.PhoneNumber;
            txtEmailAddress.Text = _customerEdit.EmailAddress;
            btnGoToReception.Enabled = true;
        }

        private void CmbGenderDataBind()
        {
            var itemsEnum = MyExtensions.GetListItemsEnum<GenderType>();
            CmbGender.DataSource = itemsEnum;
            CmbGender.DisplayMember = "Description";
            CmbGender.ValueMember = "Value";
            CmbGender.SelectedIndex = 0;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidationItem()) return;
            if (_customerEdit is null)
            {
                var customerInfo = CreateCustomerInfo();
                var result = _appBusiness.Add(customerInfo);

                if (result.IsSuccess)
                {
                    MessageBox.Show("Customer registration was successful", "Success");

                    ResetForm();
                }
                else
                {
                    MessageBox.Show($"Customer registration has error!. => {result.ErrorMessage}", "Please Try Again");
                }
            }
            else
            {
                var customerInfo = EditCustomerInfo();
                var result = _appBusiness.Edit(customerInfo);

                if (result.IsSuccess)
                {
                    MessageBox.Show("Customer Update was successful", "Success");

                    ResetForm();
                }
                else
                {
                    MessageBox.Show($"Customer Update has error!. => {result.ErrorMessage}", "Please Try Again");
                }
            }
        }

        private CustomerAdd CreateCustomerInfo()
        {
            return new CustomerAdd
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = (GenderType)CmbGender.SelectedValue.GetHashCode(),
                Age = txtAge.Text.ToInt(),
                PassportNo = txtPassport.Text,
                PhoneNumber = txtPhoneNumber.Text,
                EmailAddress = txtEmailAddress.Text,
            };
        }
        private CustomerEdit EditCustomerInfo()
        {
            return new CustomerEdit
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = (GenderType)CmbGender.SelectedValue.GetHashCode(),
                Age = txtAge.Text.ToInt(),
                PassportNo = txtPassport.Text,
                PhoneNumber = txtPhoneNumber.Text,
                EmailAddress = txtEmailAddress.Text,

                CustomerInfoId = _customerEdit.CustomerInfoId
            };
        }

        private bool ValidationItem()
        {
            if (txtAge.Text.IsNullOrWhiteSpace() || !txtAge.Text.IsNumeric())
            {
                MessageBox.Show("Age is Required !, Please enter the correct value.", "Warning");
                return false;
            }

            if (txtFirstName.Text.IsNullOrWhiteSpace() || txtLastName.Text.IsNullOrWhiteSpace() || txtPassport.Text.IsNullOrWhiteSpace())
            {
                MessageBox.Show("First/Last Name ,Passport No,  is Required !, Please enter values.", "Warning");
                return false;
            }

            if (txtEmailAddress.Text.IsNullOrWhiteSpace() && txtPhoneNumber.Text.IsNullOrWhiteSpace())
            {
                MessageBox.Show("Email Address Or Phone Number is Required !, Please enter at least one of them.", "Warning");
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
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            CmbGender.SelectedIndex = 0;
            txtAge.Text = string.Empty;
            txtPassport.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtEmailAddress.Text = string.Empty;

            _customerEdit = null;
            btnGoToReception.Enabled = false;
            GetList();
        }
        private void GetList()
        {
            dataGridCustomer.DataSource = GetInfos();

            SetColumnName();

        }

        private List<CustomerInfoViewModel> GetInfos()
        {
            return _appBusiness.GetAll();
        }
        private void SetColumnName()
        {
            if (dataGridCustomer is null) return;

            dataGridCustomer.Columns["FirstName"].HeaderText = "First Name";

            dataGridCustomer.Columns["LastName"].HeaderText = "Last Name";

            dataGridCustomer.Columns["GenderTitle"].HeaderText = "Gender";

            dataGridCustomer.Columns["PassportNo"].HeaderText = "Passport No";

            dataGridCustomer.Columns["PhoneNumber"].HeaderText = "Phone Number";

            dataGridCustomer.Columns["EmailAddress"].HeaderText = "Email Address";

            dataGridCustomer.Columns["Gender"].Visible = false;

            dataGridCustomer.Columns["CustomerInfoId"].Visible = false;
        }

        private void btnGoToReception_Click(object sender, EventArgs e)
        {
            SetDataCustomer(_customerEdit);

            Close();
        }
    }
}
