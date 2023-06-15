using eAuction_touchdown.Data;
using eAuction_touchdown.Models;
using eAuction_touchdown.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eAuction_touchdown.Controllers
{
	public class VehiclesController : Controller
	{
		private readonly AppDbContext _context;
		private readonly VehicleRepository _vehicleRepository = null;

		public VehiclesController(AppDbContext context, VehicleRepository vehicleRepository)
		{
			_context = context;
			_vehicleRepository = vehicleRepository;
		}

		public async Task<IActionResult> Index()
		{
			var allVehicles = await _context.Vehicles.ToListAsync();

			foreach (var vehicle in allVehicles)
			{
				vehicle.BidEndTime = DateTime.Now.AddMinutes(5); // Set the bid end time for each vehicle (replace with your logic)
			}

			await _context.SaveChangesAsync();

			return View(allVehicles);
		}

		public ViewResult AddNewVehicle()
		{
			return View();
		}

		[HttpPost]
		public ViewResult AddNewVehicle(Vehicles vehicle)
		{
			_vehicleRepository.AddNewVehicle(vehicle);
			return View();
		}
	}
}
