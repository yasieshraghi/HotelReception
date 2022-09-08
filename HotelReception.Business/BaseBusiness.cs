using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReception.DataStorage.DbContexts;

namespace HotelReception.Business
{
    public class BaseBusiness<T> where T : class
    {
        private static HotelReceptionContext _context;
        public static HotelReceptionContext Instance => _context ?? (_context = new HotelReceptionContext());

    }
}
