namespace BlockedUsers.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BlockedUsersDB : DbContext
    {
        public BlockedUsersDB()
            : base("name=BlockedUsersDB")
        {
        }

        public virtual DbSet<TblBloquedUsers> TblBloquedUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
