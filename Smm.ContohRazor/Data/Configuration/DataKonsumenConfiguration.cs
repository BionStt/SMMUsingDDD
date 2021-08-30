using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohRazor.Data.Configuration
{
    public class DataKonsumenConfiguration : IEntityTypeConfiguration<DataKonsumen>
    {
        public void Configure(EntityTypeBuilder<DataKonsumen> builder)
        {
            builder.ToTable("DataKonsumen");

        }

     }
}
