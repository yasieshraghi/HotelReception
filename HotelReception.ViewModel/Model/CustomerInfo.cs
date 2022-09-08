using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReception.ViewModel.Enums;

namespace HotelReception.ViewModel.Model
{
    public class CustomerInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string GenderTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PassportNo { get; set; }
        public int Age { get; set; }
        public bool HasCareTaker { get; set; }
    }
}
