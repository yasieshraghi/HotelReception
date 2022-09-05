using System.ComponentModel;

namespace HotelReception.ViewModel.Enums
{
    public enum RoomType : byte
    {
        [Description("Normal")]
        Normal=0,
        [Description("V.I.P")]
        Vip=1,
        [Description("Luxury")]
        Luxury = 2,
        [Description("UnExpensive")]
        UnExpensive = 3,
    }
}