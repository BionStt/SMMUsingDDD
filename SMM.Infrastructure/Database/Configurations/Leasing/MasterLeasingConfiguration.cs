using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Infrastructure.Database.Configurations.Leasing
{
    public class MasterLeasingConfiguration : IEntityTypeConfiguration<MasterLeasing>
    {
        public void Configure(EntityTypeBuilder<MasterLeasing> builder)
        {
            builder.ToTable("MasterLeasing");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NamaLeasing).HasMaxLength(50);



        }
    }
}
