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
    public partial class MasterForm : Form
    {
        protected string FormTitle;
        private static CustomerInfoViewModel _customerEdit = null;
        public MasterForm()
        {
            InitializeComponent();
        }
        public static void CloseApplication()
        {
            Environment.Exit(Environment.ExitCode);
        }
        public void SetDataCustomer(CustomerInfoViewModel customerEdit)
        {
            _customerEdit = customerEdit;
        } 
        public void RemoveDataCustomer()
        {
            _customerEdit = null;
        }
        public CustomerInfoViewModel GetDataCustomer()
        {
            return _customerEdit;
        }
        private void SetTitleForm()
        {
            //lblTitle.Text = FormTitle;
        }
    }
}
