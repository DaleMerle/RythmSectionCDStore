using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RythmSectionCDStore.Data;

namespace RythmSectionCDStore.Controllers
{
    public class ArtistsController : Controller
    {
        public AppDbContext _context;

        public ArtistsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index1() //Calls for data in the Index1.cshtml View
        {
            var data = _context.Artists.ToList();
            return View(data);
        }
    }
}
