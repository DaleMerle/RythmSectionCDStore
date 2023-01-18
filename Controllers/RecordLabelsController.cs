using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RythmSectionCDStore.Data;

namespace RythmSectionCDStore.Controllers
{
    public class RecordLabelsController : Controller
    {
        public AppDbContext _context;

        public RecordLabelsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index2()
        {
            var allRecordLabels = await _context.RecordLabels.ToListAsync();
            return View(allRecordLabels);
        }
    }
}
