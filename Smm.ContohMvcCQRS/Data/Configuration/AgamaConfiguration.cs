using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smm.ContohMvcCQRS.Domain.EnumInEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.Data.Configuration
{
    public class AgamaConfiguration : IEntityTypeConfiguration<Agama>
    {
        public void Configure(EntityTypeBuilder<Agama> builder)
        {
            builder.ToTable("Agama");
            builder.HasKey(b => b.Id);
        }
    }
}
