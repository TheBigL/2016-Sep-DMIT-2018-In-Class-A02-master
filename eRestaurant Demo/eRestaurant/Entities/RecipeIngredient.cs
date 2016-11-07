namespace eRestaurant.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RecipeIngredient
    {
        public int RecipeIngredientID { get; set; }

        public int RecipeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Quantity { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
