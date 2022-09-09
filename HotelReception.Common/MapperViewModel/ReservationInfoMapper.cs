using HotelReception.DataStorage.Entities;
using HotelReception.ViewModel.Model.Response;

namespace HotelReception.Common.MapperViewModel
{
    public static class ReservationInfoMapper
    {
        public static ReservationInfoViewModel ToViewModel(this ReservationModel model)
        {
            return new ReservationInfoViewModel
            {
                ReservationId = model.Id,
                RoomId = model.RoomId,
                CustomerInfoId = model.CustomerInfoId,
                CheckOutDate = model.CheckOutDate,
                CheckInDate = model.CheckInDate,

                CustomerInfo = model.CustomerInfo?.ToViewModel(),

                RoomInfo = model.Room?.ToViewModel(model.CheckOutDate != null),
            };
        }


    }
}
