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
        private static CustomerInfoViewModel _customerEdit = null;

        private static RoomInfoViewModel _roomEdit = null;
        public MasterForm()
        {
            InitializeComponent();
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


        public void SetDataRoom(RoomInfoViewModel customerEdit)
        {
            _roomEdit = customerEdit;
        }
        public void RemoveDataRoom()
        {
            _roomEdit = null;
        }
        public RoomInfoViewModel GetDataRoom()
        {
            return _roomEdit;
        }

    }
}
