using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smm.ContohMVC.Domain.EnumInEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVC.Data.Configuration
{
    public class AgamaConfiguration : IEntityTypeConfiguration<Agama>
    {
        public void Configure(EntityTypeBuilder<Agama> builder)
        {
            builder.ToTable("Agama");



        }
    }
}
