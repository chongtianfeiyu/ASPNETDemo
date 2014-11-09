namespace Test
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AdventureWorksDB : DbContext
    {
        public AdventureWorksDB()
            : base("name=AdventureWorks2012")
        {
        }

        public virtual DbSet<AWBuildVersion> AWBuildVersions { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLogs { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
