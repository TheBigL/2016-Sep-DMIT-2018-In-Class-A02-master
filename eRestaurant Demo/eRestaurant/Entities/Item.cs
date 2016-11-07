namespace eRestaurant.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            BillItems = new HashSet<BillItem>();
            Recipes = new HashSet<Recipe>();
        }

        public int ItemID { get; set; }

        [Required]
        [StringLength(35)]
        public string Description { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CurrentPrice { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CurrentCost { get; set; }

        public bool Active { get; set; }

        public int? Calories { get; set; }

        [StringLength(50)]
        public string Comment { get; set; }

        public int MenuCategoryID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillItem> BillItems { get; set; }

        public virtual MenuCategory MenuCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
