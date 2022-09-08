using System;
using HotelReception.ViewModel.Enums;

namespace HotelReception.ViewModel.Model.Response
{
    public class ReservationInfoViewModel
    {
        public long ReservationId { get; set; }

        public int CustomerInfoId { get; set; }
        public int RoomId { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? CheckOutDate { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string GenderTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PassportNo { get; set; }
        public int Age { get; set; }
        public bool HasCareTaker { get; set; }


        public RoomType Type { get; set; }
        public long PricePerDay { get; set; }
        public byte Floor { get; set; }
        public int Number { get; set; }
        public bool HasWindow { get; set; }
        public byte BedNumbers { get; set; }
        public bool IsActive { get; set; }

    }
}