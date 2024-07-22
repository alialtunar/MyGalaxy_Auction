using MyGalaxy_Auction_Data_Access.Enums;
using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Data_Access.Domain
{
    public class Bid
    {
        [Key]
        public int BidId { get; set; }

        public decimal BidAmount { get; set; }

        public DateTime BidDate { get; set; }

        public string BidStatus { get; set; } = MyGalaxy_Auction_Data_Access.Enums.BidStatus.Pendind.ToString();

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
