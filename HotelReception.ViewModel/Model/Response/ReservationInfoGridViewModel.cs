using System;
using HotelReception.ViewModel.Enums;

namespace HotelReception.ViewModel.Model.Response
{
    public class ReservationInfoGridViewModel
    {
        public long ReservationId { get; set; }

        public int CustomerInfoId { get; set; }
        public int RoomId { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }

        public string TypeTitle { get; set; }
        public long? PricePerDay { get; set; }
        public int? Number { get; set; }
        public byte? BedNumbers { get; set; }
        public string ActiveTitle { get; set; }

        public string WindowTitle { get; set; }
        public string AvailableTitle { get; set; }

    }
}