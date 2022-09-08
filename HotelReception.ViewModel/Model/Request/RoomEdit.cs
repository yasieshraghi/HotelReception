using HotelReception.ViewModel.Enums;

namespace HotelReception.ViewModel.Model.Request
{
    public class RoomEdit
    {
        public int RoomId { get; set; }

        public RoomType Type { get; set; }
        public long PricePerDay { get; set; }
        public FloorType Floor { get; set; }
        public int Number { get; set; }
        public bool HasWindow { get; set; }
        public byte BedNumbers { get; set; }
        public bool IsActive { get; set; }
    }
}