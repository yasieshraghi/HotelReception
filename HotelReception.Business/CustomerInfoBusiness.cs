using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using HotelReception.Common.Extensions;
using HotelReception.Common.MapperViewModel;
using HotelReception.DataStorage.DbContexts;
using HotelReception.DataStorage.Entities;
using HotelReception.ViewModel.Model;
using HotelReception.ViewModel.Model.Request;
using HotelReception.ViewModel.Model.Response;

namespace HotelReception.Business
{
    public class CustomerInfoBusiness
    {

        private static HotelReceptionContext _context;
        private static HotelReceptionContext Instance => _context ?? (_context = new HotelReceptionContext());

        public OperationResult<CustomerInfoViewModel> GetById(int id)
        {
            try
            {

                var data = Instance.CustomerInfo.SingleOrDefault(x => x.Id == id);
                if (data is null)
                    throw new Exception("Customer Not Fund");

                return new OperationResult<CustomerInfoViewModel>()
                {
                    IsSuccess = true,
                    ErrorMessage = string.Empty,
                    Data = data.ToViewModel(),
                };
            }
            catch (Exception ex)
            {
                return new OperationResult<CustomerInfoViewModel>()
                {
                    Data = null,
                    ErrorMessage = ex.Message,
                    IsSuccess = false,
                };
            }
        }
        public List<CustomerInfoViewModel> GetAll()
        {
            var data = Instance.CustomerInfo.ToList();

            return data.Select(c => c.ToViewModel()).ToList();
        }
        public OperationResult<CustomerInfoViewModel> Add(CustomerAdd model)
        {
            try
            {
                var entityModel = new CustomerInfoModel
                {
                    Gender = model.Gender,
                    PhoneNumber = model.PhoneNumber,
                    EmailAddress = model.EmailAddress,
                    PassportNo = model.PassportNo,
                    Age = model.Age,
                    CreationDate = DateTime.Now,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                };
                var customerInfoModel = Instance.CustomerInfo.Add(entityModel);
                Instance.SaveChanges();

                return new OperationResult<CustomerInfoViewModel>()
                {
                    IsSuccess = true,
                    ErrorMessage = string.Empty,
                    Data = customerInfoModel.ToViewModel()
                };
            }
            catch (Exception ex)
            {
                return new OperationResult<CustomerInfoViewModel>()
                {
                    Data = null,
                    ErrorMessage = ex.Message,
                    IsSuccess = false,
                };
            }
        }
        public OperationResult<CustomerInfoViewModel> Edit(CustomerEdit model)
        {
            try
            {

                var entityModel = Instance.CustomerInfo.SingleOrDefault(x => x.Id == model.CustomerInfoId);
                if (entityModel is null)
                    throw new Exception("Customer Not Fund");

                entityModel.Gender = model.Gender;
                entityModel.PhoneNumber = model.PhoneNumber;
                entityModel.EmailAddress = model.EmailAddress;
                entityModel.PassportNo = model.PassportNo;
                entityModel.Age = model.Age;
                entityModel.FirstName = model.FirstName;
                entityModel.LastName = model.LastName;

                var customerInfoModel = Instance.CustomerInfo.Attach(entityModel);
                Instance.SaveChanges();

                return new OperationResult<CustomerInfoViewModel>()
                {
                    IsSuccess = true,
                    ErrorMessage = string.Empty,
                    Data = customerInfoModel.ToViewModel()
                };
            }
            catch (Exception ex)
            {
                return new OperationResult<CustomerInfoViewModel>()
                {
                    Data = null,
                    ErrorMessage = ex.Message,
                    IsSuccess = false,
                };
            }
        }


        public List<CustomerInfoViewModel> SearchQueryable(string firstName, string lastName)
        {
            var data = Instance.CustomerInfo.AsQueryable();

            if (!firstName.IsNullOrWhiteSpace())
                data = data.Where(x => x.FirstName.ToLower().Contains(firstName.ToLower()));

            if (!lastName.IsNullOrWhiteSpace())
                data = data.Where(x => x.LastName.ToLower().Contains(lastName.ToLower()));

            return data.Select(c => c.ToViewModel()).ToList();
        }


    }
}
