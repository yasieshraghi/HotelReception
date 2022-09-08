using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelReception.DataStorage.BaseEntity;
using HotelReception.ViewModel.Enums;

namespace HotelReception.DataStorage.Entities
{
    public class CustomerInfoModel : BaseModel<int>
    {
        [StringLength(30)]
        public string FirstName { get; set; }
        [StringLength(60)]
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        [StringLength(14)]
        public string PhoneNumber { get; set; }
        [StringLength(70)]
        public string EmailAddress { get; set; }
        [StringLength(12)]
        public string PassportNo { get; set; }
        public int Age { get; set; }

        public virtual ICollection<ReservationModel> Reservations { get; set; }


    }
}