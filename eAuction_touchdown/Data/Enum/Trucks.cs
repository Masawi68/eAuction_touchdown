using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System;

namespace eAuction_touchdown.Data.Enum
{
	public class Trucks
	{
		[Key]
		public int Id { get; set; }
		public int LotNumber { get; set; }
		public string ProductPicURL { get; set; }
		public VCategory VCategory { get; set; }
		public string Description { get; set; }
		public DateFormat Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public double StartBidPrice { get; set; }

		public DateTime BidEndTime { get; set; }

	}
}
