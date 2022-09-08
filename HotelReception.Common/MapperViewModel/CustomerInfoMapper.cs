using HotelReception.Common.Extensions;
using HotelReception.DataStorage.Entities;
using HotelReception.ViewModel.Model.Response;

namespace HotelReception.Common.MapperViewModel
{
    public static class CustomerInfoMapper
    {
        public static CustomerInfoViewModel ToViewModel(this CustomerInfoModel model)
        {
            return new CustomerInfoViewModel
            {
                CustomerInfoId = model.Id,
                Age = model.Age,
                EmailAddress = model.EmailAddress,
                FirstName = model.FirstName, 
                Gender = model.Gender,
                GenderTitle = model.Gender.GetDescription(),
                LastName = model.LastName,
                PassportNo = model.PassportNo,
                PhoneNumber = model.PhoneNumber,

            };
        } 
    }
}
