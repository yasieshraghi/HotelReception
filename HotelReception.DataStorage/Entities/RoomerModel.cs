using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReception.DataStorage.BaseEntity;

namespace HotelReception.DataStorage.Entities
{
    public class RoomerModel : BaseModel<int>
    {
        public int CareTakerId { get; set; }
        public int CustomerPartnerId { get; set; }

        public virtual CustomerInfoModel CareTaker { get; set; }
        public virtual CustomerInfoModel Partner { get; set; }
    }
}
