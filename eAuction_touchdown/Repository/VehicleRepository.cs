using eAuction_touchdown.Data;
using eAuction_touchdown.Data.Enum;
using eAuction_touchdown.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Data;

namespace eAuction_touchdown.Repository
{
	public class VehicleRepository
	{
		private readonly AppDbContext _context = null;

        public VehicleRepository(AppDbContext context)
		{
			_context = context;
		}
        public int AddNewVehicle(Vehicles model)
		{
			var newVehicle = new Vehicles()
			{
				
				LotNumber = model.LotNumber,
				ProductPicURL = model.ProductPicURL,
				VCategory = model.VCategory,
				Description = model.Description,
				Year = model.Year,
				Make = model.Make,
				Model = model.Model,
				StartBidPrice = model.StartBidPrice,
				BidEndTime = model.BidEndTime,
				
			};
			_context.Vehicles.Add(newVehicle);	
			_context.SaveChanges();	

			return newVehicle.Id;
		}
	}
}
