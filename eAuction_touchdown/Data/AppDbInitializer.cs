using eAuction_touchdown.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;

namespace eAuction_touchdown.Data
{
	public class AppDbInitializer
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

				context.Database.EnsureCreated();

				//Vehicles
				if (!context.Vehicles.Any())
				{
					context.Vehicles.AddRange(new List<Vehicle>()
					{
						new Vehicle()
						{
							LotNumber = 028,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/cars/Benz.jpg",
							VCategory = (Enum.VCategory)1,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2012-01-01),
							Make = "Benz",
							Model = "B74i",
							StartBidPrice = 2000.00
						},
						new Vehicle()
						{
							LotNumber = 029,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/cars/BMW.jpg",
							VCategory = (Enum.VCategory)1,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2012-01-01),
							Make = "BMW",
							Model = "i359z",
							StartBidPrice = 2000.00
						},
						new Vehicle()
						{
							LotNumber = 030,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/cars/Ferari.jpg",
							VCategory = (Enum.VCategory)1,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2015-01-01),
							Make = "Ferari",
							Model = "F23",
							StartBidPrice = 10000.00
						},
						new Vehicle()
						{
							LotNumber = 031,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/Trucks/Chevrolet.jpg",
							VCategory = (Enum.VCategory)2,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2022-01-01),
							Make = "Chevrolet",
							Model = "Tere 0.4",
							StartBidPrice = 10000.00
						},
						new Vehicle()
						{
							LotNumber = 032,
							ProductPicURL ="https://media-ed.s3.amazonaws.com/Media/Vehicles/Trucks/Chevrolet_2.jpg",
							VCategory = (Enum.VCategory)2,
							Discription = "This is a description of the product",
							Year = (DateFormat)(1996-01-01),
							Make = "Chevrolet",
							Model = "clare",
							StartBidPrice = 1000.00
						},
						new Vehicle()
						{
							LotNumber = 033,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/Trucks/Chevrolet_3.jpg",
							VCategory = (Enum.VCategory)2,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2019-01-01),
							Make = "Chevrolet",
							Model = "Rev-22",
							StartBidPrice = 12000.00
						},
						new Vehicle()
						{
							LotNumber = 034,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/MotorCycle/harley-davidson.jpg",
							VCategory = (Enum.VCategory)3,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2018-01-01),
							Make = "harley-davidson",
							Model = "BTF19",
							StartBidPrice = 1500.00
						},
						new Vehicle()
						{
							LotNumber = 035,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/MotorCycle/Honda.jpg",
							VCategory = (Enum.VCategory)3,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2019-01-01),
							Make = "Honda",
							Model = "Ducati",
							StartBidPrice = 1200.00
						},
						new Vehicle()
						{
							LotNumber = 036,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/cars/Ferari.jpg",
							VCategory = (Enum.VCategory)3,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2015-01-01),
							Make = "Yamaha",
							Model = "R1",
							StartBidPrice = 1000.00
						}
					});
					context.SaveChanges();
				}
			}
		}
	}
}
