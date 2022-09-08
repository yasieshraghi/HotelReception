using HotelReception.ViewModel.Enums;

namespace HotelReception.ViewModel.Model.Response
{
    public class RoomInfoViewModel
    {
        public int RoomId { get; set; }
        public RoomType Type { get; set; }
        public long PricePerDay { get; set; }
        public byte Floor { get; set; }
        public int Number { get; set; }
        public bool HasWindow { get; set; }
        public byte BedNumbers { get; set; }
        public bool Available { get; set; }
    }
}