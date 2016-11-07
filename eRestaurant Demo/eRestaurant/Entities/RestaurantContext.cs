namespace eRestaurant.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantContext : DbContext
    {
        public RestaurantContext()
            : base("name=RestaurantContext")
        {
        }

        public virtual DbSet<BillItem> BillItems { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<MenuCategory> MenuCategories { get; set; }
        public virtual DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<SpecialEvent> SpecialEvents { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Waiter> Waiters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillItem>()
                .Property(e => e.SalePrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BillItem>()
                .Property(e => e.UnitCost)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BillItem>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BillItems)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.CurrentPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.CurrentCost)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.BillItems)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Recipes)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MenuCategory>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.MenuCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recipe>()
                .HasMany(e => e.RecipeIngredients)
                .WithRequired(e => e.Recipe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.ContactPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.ReservationStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.EventCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Reservation>()
                .HasMany(e => e.Tables)
                .WithMany(e => e.Reservations)
                .Map(m => m.ToTable("ReservationTables").MapLeftKey("ReservationID").MapRightKey("TableID"));

            modelBuilder.Entity<SpecialEvent>()
                .Property(e => e.EventCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SpecialEvent>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Waiter>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Waiter>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Waiter>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.Waiter)
                .WillCascadeOnDelete(false);
        }
    }
}
