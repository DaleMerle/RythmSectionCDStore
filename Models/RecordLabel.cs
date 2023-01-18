using System.ComponentModel.DataAnnotations;

namespace RythmSectionCDStore.Models
{
    public class RecordLabel
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int RecordLabelId { get; set; }

        [Display(Name = "Record Label Picture")]
        public string? LabelPictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; } = default!;

        [Display(Name = "Bio")]
        public string? Bio { get; set; }

        //Relationships
        public List<Album> Albums { get; set; } = default!; 
    }
}
