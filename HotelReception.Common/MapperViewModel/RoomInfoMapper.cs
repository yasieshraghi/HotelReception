using HotelReception.Common.Extensions;
using HotelReception.DataStorage.Entities;
using HotelReception.ViewModel.Model.Response;

namespace HotelReception.Common.MapperViewModel
{
    public static class RoomInfoMapper
    { 
        public static RoomInfoViewModel ToViewModel(this RoomModel model,bool available)
        {
            return new RoomInfoViewModel
            {
                RoomId = model.Id,
                BedNumbers = model.BedNumbers,
                Floor = model.Floor, 
                HasWindow = model.HasWindow,
                WindowTitle = model.HasWindow.GetTitle(),
                Type = model.Type,
                TypeTitle = model.Type.GetDescription(),
                IsActive = model.IsActive,
                ActiveTitle = model.IsActive.GetTitle(),
                Number = model.Number,
                PricePerDay = model.PricePerDay,

                Available = available,
                AvailableTitle = available.GetTitle(),
            };
        }

      
    }
}
