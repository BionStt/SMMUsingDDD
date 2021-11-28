using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smm.ContohMvcCQRSEventSourcing.DDD.EventDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRSEventSourcing.Persistence.Configuration
{
    public class StoredMessageConfiguration : IEntityTypeConfiguration<StoredEvent>
    {
        public void Configure(EntityTypeBuilder<StoredEvent> builder)
        {
            builder.ToTable("StoredEvents", "dbo");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.CreatedAt)
                .IsRequired();

            builder.Property(r => r.ProcessedAt);

            builder.Property(r => r.MessageType)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(r => r.Payload)
                .IsRequired();
        }
    }
}
