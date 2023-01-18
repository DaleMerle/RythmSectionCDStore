using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RythmSectionCDStore.Data;

namespace RythmSectionCDStore.Controllers
{
    public class AlbumsController : Controller
    {
        private AppDbContext _context;

        public AlbumsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allAlbums = await _context.Albums.ToListAsync();
            return View();
        }
    }
}
