using Microsoft.EntityFrameworkCore;
using RythmSectionCDStore.Models;

namespace RythmSectionCDStore.Data
{
	public interface IAppDbContext
	{
		DbSet<Album> Albums { get; set; }
		DbSet<Artist_Band> Artists { get; set; }
		DbSet<Artist_Album> Artists_Albums { get; set; }
		DbSet<RecordLabel> RecordLabels { get; set; }
		DbSet<Stage> Stages { get; set; }
	}
}