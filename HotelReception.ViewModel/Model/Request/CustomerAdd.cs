using HotelReception.ViewModel.Enums;

namespace HotelReception.ViewModel.Model.Request
{
    public class CustomerAdd
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PassportNo { get; set; }
        public int Age { get; set; }
    }
}