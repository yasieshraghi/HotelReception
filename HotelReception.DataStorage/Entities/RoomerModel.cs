using HotelReception.DataStorage.BaseEntity;

namespace HotelReception.DataStorage.Entities
{
    public class RoomerModel : BaseModel<int>
    {
        public int CareTakerId { get; set; }
        public int CustomerPartnerId { get; set; }
    }
}