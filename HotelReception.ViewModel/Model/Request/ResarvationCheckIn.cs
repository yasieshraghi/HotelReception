using System;

namespace HotelReception.ViewModel.Model.Request
{
    public class ReservationCheckIn
    {
        public int CustomerInfoId { get; set; }
        public int RoomId { get; set; }
        public int StayDurationPerDay { get; set; }
        public DateTime CheckInDate { get; set; } 

    }
}