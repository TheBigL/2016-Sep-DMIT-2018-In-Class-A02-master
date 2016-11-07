namespace eRestaurant.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            Bills = new HashSet<Bill>();
            Tables = new HashSet<Table>();
        }

        public int ReservationID { get; set; }

        [Required]
        [StringLength(40)]
        public string CustomerName { get; set; }

        public DateTime ReservationDate { get; set; }

        public int NumberInParty { get; set; }

        [Required]
        [StringLength(15)]
        public string ContactPhone { get; set; }

        [Required]
        [StringLength(1)]
        public string ReservationStatus { get; set; }

        [StringLength(1)]
        public string EventCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        public virtual SpecialEvent SpecialEvent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table> Tables { get; set; }
    }
}
