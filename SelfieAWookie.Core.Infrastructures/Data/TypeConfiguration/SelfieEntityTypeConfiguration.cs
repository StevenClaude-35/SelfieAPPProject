using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SelfieAWookies.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Infrastructures.Data.TypeConfiguration
{
    public class SelfieEntityTypeConfiguration : IEntityTypeConfiguration<Selfie>
    {
        #region Public Methods
        public void Configure(EntityTypeBuilder<Selfie> builder)
        {
            builder.ToTable("Selfie");
            builder.HasKey(item => item.Id);
            builder.HasOne(item => item.Wookie).WithMany(item => item.Selfies);
        }
        #endregion

    }
}
