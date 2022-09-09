using System;
using HotelReception.DataStorage.BaseEntity;

namespace HotelReception.DataStorage.Entities
{
    public class ReservationModel : BaseModel<long>
    {

        public int CustomerInfoId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }

        public virtual RoomModel Room { get; set; }

        public virtual CustomerInfoModel CustomerInfo { get; set; }
    }
}