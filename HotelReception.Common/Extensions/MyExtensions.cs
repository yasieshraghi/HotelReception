using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReception.Common.Extensions
{
    public static class MyExtensions
    {
        public static string GetDescription(this Enum value) => ((DescriptionAttribute)value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault())?.Description ?? "";
    }
}
