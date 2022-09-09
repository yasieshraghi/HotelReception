using System;

namespace HotelReception.ViewModel.Model.Response
{
    public class ReservationInfoViewModel
    {
        public long ReservationId { get; set; }

        public int CustomerInfoId { get; set; }
        public int RoomId { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }

        public CustomerInfoViewModel CustomerInfo { get; set; }
        public RoomInfoViewModel RoomInfo { get; set; }
         
    }
}