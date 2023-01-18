using System.ComponentModel.DataAnnotations;

namespace RythmSectionCDStore.Models
{
    public class Artist_Band
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ArtistId { get; set; }

        [Display(Name = "Artist Picture")]
        public string? ArtistPictureURL { get; set; }

        [Display(Name = "Artist or Band Name")]
        public string FullName { get; set; } = default!;

        [Display(Name = "Biography")]
        public string? Bio { get; set; }

        //Relationship
        public List<Artist_Album> Artists_Albums { get; set; } = default!;
    }
}
