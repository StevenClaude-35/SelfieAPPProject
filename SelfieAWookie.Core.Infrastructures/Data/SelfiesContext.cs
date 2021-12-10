using Microsoft.EntityFrameworkCore;
using SelfieAWookie.Core.Infrastructures.Data.TypeConfiguration;
using SelfieAWookies.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Infrastructures.Data
{

    public class SelfiesContext:DbContext
    {
        public SelfiesContext(DbContextOptions<SelfiesContext> options):base(options)
        {

        }
        #region Internal Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SelfieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WookieEntityTypeConfiguration());
        }
        #endregion
        #region Properties
        public DbSet<Selfie> Selfies { get; set; }
        public DbSet<Wookie> Wookies { get; set; }
        #endregion

    }
}
