using System;

namespace HotelReception.DataStorage.BaseEntity
{
    public class BaseModel<T> where T : struct
    {
        public T Id { get; set; }
        public DateTime CreationDate { get; set; }
    }
}