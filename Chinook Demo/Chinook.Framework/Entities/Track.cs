    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

namespace Chinook.Framework.Entities
{
    [Table("Track")]
    public partial class Track
    {
        [Key] //Identiifies that this property maps as a Primary in DB
        public int TrackId { get; set; }

        [Required(ErrorMessage ="You gotta have a name, dawg!")] //This property cannot be null
        [StringLength(200, ErrorMessage ="The album name is too damn long! Try 200 characters or less")] //This property has a maximum value string of 200
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage ="What kinda Album is that?")]//This property's value must fit into the min/max range
        public int? AlbumId { get; set; }

        [Range(1, int.MaxValue)]
        public int MediaTypeId { get; set; }

        [Range(1, int.MaxValue)]
        public int? GenreId { get; set; }

        [StringLength(220, MinimumLength = 3)]
        public string Composer { get; set; }

        public int Milliseconds { get; set; }

        public int? Bytes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnitPrice { get; set; }

        public virtual Album Album { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }

        public virtual MediaType MediaType { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }
    }
}
