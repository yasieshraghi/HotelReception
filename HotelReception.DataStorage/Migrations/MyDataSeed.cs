using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReception.DataStorage.Entities;
using HotelReception.ViewModel.Enums;

namespace HotelReception.DataStorage.Migrations
{
    public static class MyDataSeed
    {
        public static IEnumerable<RoomModel> DataSeedRooms()
        {
            return new List<RoomModel>
            {
                new RoomModel
                {
                    BedNumbers = 2,
                    CreationDate = DateTime.Now,
                    Floor = 1,
                    HasWindow = true,
                    IsActive = true,
                    Number = 101,
                    Type = RoomType.Normal,
                    PricePerDay = 24
                },
                new RoomModel
                {
                    BedNumbers = 2,
                    CreationDate = DateTime.Now,
                    Floor = 2,
                    HasWindow = true,
                    IsActive = true,
                    Number = 201,
                    Type = RoomType.Normal,
                    PricePerDay = 24
                },
                new RoomModel
                {
                    BedNumbers = 1,
                    CreationDate = DateTime.Now,
                    Floor = 1,
                    HasWindow = true,
                    IsActive = true,
                    Number = 102,
                    Type = RoomType.Normal,
                    PricePerDay = 12,
                },
                new RoomModel
                {
                    BedNumbers = 1,
                    CreationDate = DateTime.Now,
                    Floor = 2,
                    HasWindow = false,
                    IsActive = true,
                    Number = 202,
                    Type = RoomType.Normal,
                    PricePerDay = 12,

                },
                new RoomModel
                {
                    BedNumbers = 3,
                    CreationDate = DateTime.Now,
                    Floor = 1,
                    HasWindow = true,
                    IsActive = false,
                    Number = 100,
                    Type = RoomType.Normal,
                    PricePerDay = 300
                },
                new RoomModel
                {
                    BedNumbers = 3,
                    CreationDate = DateTime.Now,
                    Floor = 2,
                    HasWindow = true,
                    IsActive = false,
                    Number = 205,
                    Type = RoomType.Vip,
                    PricePerDay = 600,

                },
                new RoomModel
                {
                    BedNumbers = 4,
                    CreationDate = DateTime.Now,
                    Floor = 1,
                    HasWindow = true,
                    IsActive = true,
                    Number = 103,
                    Type = RoomType.Luxury,
                    PricePerDay = 450,

                },
                new RoomModel
                {
                    BedNumbers = 2,
                    CreationDate = DateTime.Now,
                    Floor = 4,
                    HasWindow = true,
                    IsActive = true,
                    Number = 408,
                    Type = RoomType.Luxury,
                    PricePerDay = 500,
                },
            };
        }
    }
}
