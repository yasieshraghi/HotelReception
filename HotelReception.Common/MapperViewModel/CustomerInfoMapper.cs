using HotelReception.Common.Extensions;
using HotelReception.DataStorage.Entities;
using HotelReception.ViewModel.Model;

namespace HotelReception.Common.MapperViewModel
{
    public static class CustomerInfoMapper
    {
        public static CustomerInfo ToViewModel(this CustomerInfoModel model)
        {
            return new CustomerInfo
            {
                Age = model.Age,
                EmailAddress = model.EmailAddress,
                FirstName = model.FirstName,
                Gender = model.Gender,
                GenderTitle = model.Gender.GetDescription(),
                LastName = model.LastName,
                HasCareTaker = model.HasCareTaker,
                PassportNo = model.PassportNo,
                PhoneNumber = model.PhoneNumber,
            };
        }
    }
}
