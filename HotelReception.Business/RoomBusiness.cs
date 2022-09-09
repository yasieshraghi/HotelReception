using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using HotelReception.Common.MapperViewModel;
using HotelReception.DataStorage.DbContexts;
using HotelReception.DataStorage.Entities;
using HotelReception.ViewModel.Model;
using HotelReception.ViewModel.Model.Request;
using HotelReception.ViewModel.Model.Response;

namespace HotelReception.Business
{
    public class RoomBusiness
    {

        private static HotelReceptionContext _context;
        private static HotelReceptionContext Instance => _context ?? (_context = new HotelReceptionContext());

        public OperationResult<RoomInfoViewModel> GetById(int id)
        {
            try
            {

                var data = Instance.Room.Include(c=>c.Reservations).SingleOrDefault(x => x.Id == id);
                if (data is null)
                    throw new Exception("Room Not Fund");

                var available = data.Reservations.Any(c => c.CheckOutDate != null);

                return new OperationResult<RoomInfoViewModel>()
                {
                    IsSuccess = true,
                    ErrorMessage = string.Empty,
                    Data = data.ToViewModel(available),
                };
            }
            catch (Exception ex)
            {
                return new OperationResult<RoomInfoViewModel>()
                {
                    Data = null,
                    ErrorMessage = ex.Message,
                    IsSuccess = false,
                };
            }
        }
        public List<RoomInfoViewModel> GetAll()
        {
            //todo: Group by
            var data = Instance.Room.Include(c => c.Reservations).ToList();

            return data.Select(c => c.ToViewModel(c.Reservations.Any(x => x.CheckOutDate != null)))
                              .OrderBy(c=>c.Floor)
                              .ThenBy(c=>c.Number).ToList();
        }
        public OperationResult<RoomInfoViewModel> Add(RoomAdd model)
        {
            try
            {
                var entityModel = new RoomModel
                {
                    Floor = model.Floor,
                    HasWindow = model.HasWindow,
                    IsActive = model.IsActive,
                    Number = model.Number,
                    PricePerDay = model.PricePerDay,
                    CreationDate = DateTime.Now,
                    Type = model.Type,
                    BedNumbers = model.BedNumbers,
                };
                var roomInfoModel = Instance.Room.Add(entityModel);
                Instance.SaveChanges();

                return new OperationResult<RoomInfoViewModel>()
                {
                    IsSuccess = true,
                    ErrorMessage = string.Empty,
                    Data = roomInfoModel.ToViewModel(false)
                };
            }
            catch (Exception ex)
            {
                return new OperationResult<RoomInfoViewModel>()
                {
                    Data = null,
                    ErrorMessage = ex.Message,
                    IsSuccess = false,
                };
            }
        }
        public OperationResult<RoomInfoViewModel> Edit(RoomEdit model)
        {
            try
            {

                var entityModel = Instance.Room
                    .Include(c => c.Reservations)
                    .SingleOrDefault(x => x.Id == model.RoomId);

                if (entityModel is null)
                    throw new Exception("Room Not Fund");

                var available = entityModel.Reservations.Any(c => c.CheckOutDate != null);

                entityModel.IsActive = model.IsActive;
                entityModel.BedNumbers = model.BedNumbers;
                entityModel.Floor = model.Floor;
                entityModel.HasWindow = model.HasWindow;
                entityModel.Number = model.Number;
                entityModel.PricePerDay = model.PricePerDay;
                entityModel.Type = model.Type;

                var roomInfoModel = Instance.Room.Attach(entityModel);
                Instance.Entry(entityModel).State = EntityState.Modified;
                Instance.SaveChanges();

                return new OperationResult<RoomInfoViewModel>()
                {
                    IsSuccess = true,
                    ErrorMessage = string.Empty,
                    Data = roomInfoModel.ToViewModel(available)
                };
            }
            catch (Exception ex)
            {
                return new OperationResult<RoomInfoViewModel>()
                {
                    Data = null,
                    ErrorMessage = ex.Message,
                    IsSuccess = false,
                };
            }
        }

    }
}
