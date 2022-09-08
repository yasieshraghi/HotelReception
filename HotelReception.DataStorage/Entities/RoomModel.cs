using System.Collections.Generic;
using HotelReception.DataStorage.BaseEntity;
using HotelReception.ViewModel.Enums;

namespace HotelReception.DataStorage.Entities
{
    public class RoomModel : BaseModel<int>
    {
        public RoomType Type { get; set; }
        public long PricePerDay { get; set; }
        public byte Floor { get; set; }
        public int Number { get; set; }
        public bool HasWindow { get; set; }
        public byte BedNumbers { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ReservationModel> Reservations { get; set; }
    }
}