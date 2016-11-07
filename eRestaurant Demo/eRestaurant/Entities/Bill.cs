namespace eRestaurant.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            BillItems = new HashSet<BillItem>();
        }

        public int BillID { get; set; }

        public DateTime BillDate { get; set; }

        public TimeSpan? OrderPlaced { get; set; }

        public TimeSpan? OrderReady { get; set; }

        public TimeSpan? OrderServed { get; set; }

        public TimeSpan? OrderPaid { get; set; }

        public int NumberInParty { get; set; }

        public bool PaidStatus { get; set; }

        public int WaiterID { get; set; }

        public int? TableID { get; set; }

        public int? ReservationID { get; set; }

        [StringLength(50)]
        public string Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillItem> BillItems { get; set; }

        public virtual Reservation Reservation { get; set; }

        public virtual Table Table { get; set; }

        public virtual Waiter Waiter { get; set; }
    }
}
