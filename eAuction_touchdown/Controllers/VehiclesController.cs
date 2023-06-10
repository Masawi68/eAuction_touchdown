using eAuction_touchdown.Data;
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

        public VehiclesController(AppDbContext context)
        {
            _context = context;
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
    }
}
