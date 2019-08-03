using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Painting
    {
        public int ID { get; set; }
        public int ArtistID { get; set; }
        public string SubmittedDescription { get; set; }
        public string LiveDescription { get; set; }
        public string Medium { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public DateTime ForSaleDate { get; set; }
        public string ImgUrl { get; set; }
        public string ThumbUrl { get; set; }
        public decimal CurrentPrice { get; set; }
        public bool IsSubmitted { get; set; }
        public bool IsReviewed { get; set; }
        public bool IsLive { get; set; }
        public bool IsSold { get; set; }
        public bool IsPendingSale { get; set; }




    }
}
