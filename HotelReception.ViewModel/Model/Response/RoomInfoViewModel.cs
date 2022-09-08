using HotelReception.ViewModel.Enums;

namespace HotelReception.ViewModel.Model.Response
{
    public class RoomInfoViewModel
    {
        public int RoomId { get; set; }

        public RoomType Type { get; set; }
        public string TypeTitle { get; set; }

        public long PricePerDay { get; set; }
        public FloorType Floor { get; set; }
        public int Number { get; set; }
        public byte BedNumbers { get; set; }
        public bool IsActive { get; set; }
        public string ActiveTitle { get; set; }

        public bool HasWindow { get; set; }
        public string WindowTitle { get; set; }
        public bool Available { get; set; }
        public string AvailableTitle { get; set; }
    }
}