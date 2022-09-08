using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using HotelReception.Common.MapperViewModel;
using HotelReception.DataStorage.Entities;
using HotelReception.ViewModel.Model;

namespace HotelReception.Business
{
    public class CustomerInfoBusiness : BaseBusiness<CustomerInfoModel>
    {
        public async Task<CustomerInfo> GetByIdAsync(int id)
        {
            var data = await Instance.CustomerInfo.SingleOrDefaultAsync(x => x.Id == id);
            return data?.ToViewModel();
        }
        public async Task<List<CustomerInfoModel>> GetAll(int id)
        {
            return await Instance.CustomerInfo.ToListAsync();
        }
        //public async Task<List<CustomerInfoModel>> Search(string firstName, string lastName)
        //{
        //    //if (firstName is null) return new List<CustomerInfoModel>();

        //    return await Instance.CustomerInfo.Where(c =>

        //            (firstName == null || c.FirstName.ToLower().Contains(firstName.ToLower()))
        //            &&
        //           (lastName == null || c.LastName.ToLower().Contains(lastName.ToLower()))

        //        ).ToListAsync();
        //}

        public async Task<List<CustomerInfo>> SearchQueryable(string firstName, string lastName)
        {
            var data = Instance.CustomerInfo.AsQueryable();

            if (!string.IsNullOrWhiteSpace(firstName))
                data = data.Where(x => x.FirstName.ToLower().Contains(firstName.ToLower()));

            if (!string.IsNullOrWhiteSpace(lastName))
                data = data.Where(x => x.LastName.ToLower().Contains(lastName.ToLower()));


            ////data = data.Where(x => x.RoomerCareTakers.Any(c => c.CareTakerId==10));

            return await data.Select(c => c.ToViewModel()).ToListAsync();
        }
        public async Task<int> Add(CustomerInfoModel model)
        {
            Instance.CustomerInfo.Add(model);
            await Instance.SaveChangesAsync();

            return model.Id;
        }
        public async Task AddRange(IEnumerable<CustomerInfoModel> models)
        {
            Instance.CustomerInfo.AddRange(models);
            await Instance.SaveChangesAsync();

            return;
        }

        public async Task Attach(CustomerInfoModel model)
        {
            Instance.CustomerInfo.Attach(model);
            await Instance.SaveChangesAsync();

            return;
        }
        public async Task Remove(CustomerInfoModel model)
        {
            Instance.CustomerInfo.Remove(model);
            await Instance.SaveChangesAsync();

            return;
        }

    }
}
