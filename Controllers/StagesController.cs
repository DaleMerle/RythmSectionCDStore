using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RythmSectionCDStore.Data;

namespace RythmSectionCDStore.Controllers
{
    public class StagesController : Controller
    {
        public AppDbContext _context;

        public StagesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index3() //Make sure to put async before the task. Awaiting for changes in between the view and the db.
        {
            var allStages = await _context.Stages.ToListAsync();
            return View(allStages);
        }
    }
}
