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
		[Route("vehicle-details/{id}", Name = "vehicleDetailsRoute")]

		public ViewResult GetVehicle(int id)
		{
			var data = _vehicleRepository.GetVehicleById(id);
			return View(data);
		}
		public ViewResult AddNewVehicle(bool isSuccess = false, int vehicleId = 0)
		{
			ViewBag.IsSuccess = isSuccess;
			ViewBag.VehicleId = vehicleId;	
			return View();
		}

		[HttpPost]
		public IActionResult AddNewVehicle(Vehicles vehicle)
		{
			int id = _vehicleRepository.AddNewVehicle(vehicle);
			if (id > 0)
			{
				return RedirectToAction(nameof(AddNewVehicle), new {isSuccess = true , VehicleId = id});
			}
			return View();
		}
	}
}
