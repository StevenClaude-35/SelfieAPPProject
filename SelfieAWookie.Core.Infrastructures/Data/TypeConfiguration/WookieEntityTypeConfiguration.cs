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
    public class WookieEntityTypeConfiguration : IEntityTypeConfiguration<Wookie>
    {
        #region Public Methods
        public void Configure(EntityTypeBuilder<Wookie> builder)
        {
            builder.ToTable("Wookie");
        }
        #endregion

    }
}
