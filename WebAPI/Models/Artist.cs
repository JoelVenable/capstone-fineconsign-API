using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Artist
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

        public decimal AccountBalance { get; set; }

        public string Description { get; set; }

        public string AvatarUrl { get; set; }

        public string Hometown { get; set; }

        public decimal ProfitRatio { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsActive { get; set; }

        public DateTime ActiveDate { get; set; }

        public string ArtistDescription { get; set; }

        public string ImgUrl { get; set; }


    }
}
