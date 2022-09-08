using System;

namespace HotelReception.ViewModel.Model.Request
{
    public class ReservationCheckOut
    {
        public long ReservationId { get; set; }

        public DateTime? CheckOutDate { get; set; }
    }
}