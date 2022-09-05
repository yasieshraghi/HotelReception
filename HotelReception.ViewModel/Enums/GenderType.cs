using System.ComponentModel;

namespace HotelReception.ViewModel.Enums
{
    public enum GenderType : byte
    {
        [Description("Undefined")]
        Undefined,
        [Description("Male")]
        Male,
        [Description("Female")]
        Female,
        [Description("Others")]
        Others,
    }
}