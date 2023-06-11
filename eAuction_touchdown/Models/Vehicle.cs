using eAuction_touchdown.Data.Enum;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace eAuction_touchdown.Models
{
    public class Vehicle
	{
		[Key]
		public int Id { get; set; }
		public int LotNumber { get; set; }
		public string ProductPicURL { get; set; }
		public VCategory VCategory { get; set; }
		public string Discription { get; set; }
		public DateFormat Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public double StartBidPrice { get; set; }
   
        public DateTime BidEndTime { get; set; }



    }
}
