namespace eRestaurant.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BillItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SalePrice { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal UnitCost { get; set; }

        [StringLength(50)]
        public string Notes { get; set; }

        public byte? TableNumber { get; set; }

        public byte? SeatNumber { get; set; }

        public int? QtyServed { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Item Item { get; set; }
    }
}
