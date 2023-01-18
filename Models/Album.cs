using RythmSectionCDStore.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RythmSectionCDStore.Models
{
    public class Album
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int AlbumId { get; set; } = default!;

        public string AlbumName { get; set; } = default!;

        public int Year { get; set; } = default!;

        public string? AlbumDescription { get; set; }

        public double Price { get; set; } = default!;

        public string? AlbumImageURL { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public AlbumGenre AlbumGenre { get; set; } = default!;

        //Relationships for the Artists_Albums table
        public List<Artist_Album> Artists_Albums { get; set; } = default!;

        //Foreign key relationship for Stage
        [Key]
        public int StageId { get; set; }
        public Stage Stage { get; set; } = default!;

        //Foreign key relationship for RecordLabel
        [Key]
        public int RecordLabelId { get; set; }
        public RecordLabel RecordLabel { get; set; } = default!;

    }
}