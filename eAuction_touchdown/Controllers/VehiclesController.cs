using eAuction_touchdown.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
			return View(allVehicles);
		}
	}
}
