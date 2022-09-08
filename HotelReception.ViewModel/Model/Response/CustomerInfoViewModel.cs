using HotelReception.ViewModel.Enums;

namespace HotelReception.ViewModel.Model.Response
{
    public class CustomerInfoViewModel
    {
        public int CustomerInfoId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string GenderTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PassportNo { get; set; }
        public int Age { get; set; }
       
    }
}
