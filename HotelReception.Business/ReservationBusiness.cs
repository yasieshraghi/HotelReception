using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using HotelReception.Common.Extensions;
using HotelReception.Common.MapperViewModel;
using HotelReception.DataStorage.DbContexts;
using HotelReception.DataStorage.Entities;
using HotelReception.ViewModel.Model;
using HotelReception.ViewModel.Model.Request;
using HotelReception.ViewModel.Model.Response;

namespace HotelReception.Business
{
    public class ReservationBusiness
    {

        private static HotelReceptionContext _context;
        private static HotelReceptionContext Instance => _context ?? (_context = new HotelReceptionContext());


        public OperationResult<ReservationInfoViewModel> CheckIn(ReservationCheckIn model)
        {
            try
            {
                var entityModel = new ReservationModel
                {
                    CheckInDate = DateTime.Now,
                    CreationDate = DateTime.Now,
                    CheckOutDate = null,
                    CustomerInfoId = model.CustomerInfoId,
                    RoomId = model.RoomId,
                };
                var roomInfoModel = Instance.Reservation.Add(entityModel);
                Instance.SaveChanges();

                return new OperationResult<ReservationInfoViewModel>()
                {
                    IsSuccess = true,
                    ErrorMessage = string.Empty,
                    Data = roomInfoModel.ToViewModel()
                };
            }
            catch (Exception ex)
            {
                return new OperationResult<ReservationInfoViewModel>()
                {
                    Data = null,
                    ErrorMessage = ex.Message,
                    IsSuccess = false,
                };
            }
        }
        public OperationResult<ReservationInfoViewModel> CheckOut(ReservationCheckOut model)
        {
            try
            {
                var entityModel = Instance.Reservation.SingleOrDefault(x => x.Id == model.ReservationId);

                if (entityModel is null)
                    throw new Exception("Reservation Not Fund");

                entityModel.CheckOutDate = DateTime.Now;

                var roomInfoModel = Instance.Reservation.Attach(entityModel);
                Instance.Entry(entityModel).State = EntityState.Modified;
                Instance.SaveChanges();

                return new OperationResult<ReservationInfoViewModel>()
                {
                    IsSuccess = true,
                    ErrorMessage = string.Empty,
                    Data = roomInfoModel.ToViewModel()
                };
            }
            catch (Exception ex)
            {
                return new OperationResult<ReservationInfoViewModel>()
                {
                    Data = null,
                    ErrorMessage = ex.Message,
                    IsSuccess = false,
                };
            }
        }

        public OperationResult<ReservationInfoViewModel> GetByFkId(int roomId, int customerInfoId)
        {
            try
            {

                var data = Instance.Reservation.FirstOrDefault(x => x.RoomId == roomId && x.CustomerInfoId == customerInfoId);

                if (data is null)
                    throw new Exception("Reservation Not Fund");

                return new OperationResult<ReservationInfoViewModel>()
                {
                    IsSuccess = true,
                    ErrorMessage = string.Empty,
                    Data = data.ToViewModel(),
                };
            }
            catch (Exception ex)
            {
                return new OperationResult<ReservationInfoViewModel>()
                {
                    Data = null,
                    ErrorMessage = ex.Message,
                    IsSuccess = false,
                };
            }
        }
        public List<ReservationInfoGridViewModel> GetAll()
        {
            var data = Instance.Reservation
                      .Include(c => c.Room)
                      .Include(c => c.CustomerInfo)
                      .ToList();

            return data.Select(c => new ReservationInfoGridViewModel
            {
                RoomId = c.RoomId,
                CheckOutDate = c.CheckOutDate,

                CustomerInfoId = c.CustomerInfoId,
                CheckInDate = c.CheckInDate,
                ReservationId = c.Id,
                Age = c.CustomerInfo?.Age,
                FirstName = c.CustomerInfo?.FirstName,
                LastName = c.CustomerInfo?.LastName,
                AvailableTitle = (c.CheckOutDate != null).GetTitle(),
                ActiveTitle = c.Room?.IsActive.GetTitle(),
                Number = c.Room?.Number ?? 0,
                PricePerDay = c.Room?.PricePerDay ?? 0,
                BedNumbers = c.Room?.BedNumbers ?? 0,
                WindowTitle = (c.Room?.HasWindow ?? false).GetTitle(),
                TypeTitle = c.Room?.Type.GetDescription(),

            }).ToList();
        }

    }
}
