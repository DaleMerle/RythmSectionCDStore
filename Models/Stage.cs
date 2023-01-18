using System.ComponentModel.DataAnnotations;

namespace RythmSectionCDStore.Models
{
    public class Stage
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int? StageId { get; set; }

        [Display(Name="Stages")]
        public string? StageLogoURL { get; set; }

        [Display(Name="Stage Name")]
        public string Name { get; set; } = default!;

        [Display(Name="Description")]
        public string? Description { get; set; }

        //Relationships
        public List<Album> Albums { get; set; }
    }
}
