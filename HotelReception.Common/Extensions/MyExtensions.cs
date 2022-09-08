using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using HotelReception.ViewModel.Model;

namespace HotelReception.Common.Extensions
{
    public static class MyExtensions
    {
        public static string GetDescription(this Enum value) => ((DescriptionAttribute)value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault())?.Description ?? "";
        public static List<EnumObj> GetListItemsEnum<TEnum>() where TEnum : Enum
        {

            var result = new List<EnumObj>();

            var names = Enum.GetNames(typeof(TEnum)).ToList();

            foreach (var name in names)
            {
                var enumItem = StringToEnum<TEnum>(name);

                var description = enumItem.GetDescription();
                var value = enumItem.GetHashCode();

                var enumObj = new EnumObj()
                {
                    Name = name,
                    Value = value,
                    Description = description
                };
                result.Add(enumObj);
            }

            return result;
        }
         
        public static TEnum StringToEnum<TEnum>(string nameValue) where TEnum : Enum
        {
            var singleOrDefault = Enum.GetNames(typeof(TEnum)).ToList().Single(c => string.Equals(c, nameValue, StringComparison.CurrentCultureIgnoreCase));
            return (TEnum)Enum.Parse(typeof(TEnum), singleOrDefault);
        }
    }
}
