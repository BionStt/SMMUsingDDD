﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smm.ContohCQRSNoEventSourcing.Domain.EnumInEntity;

namespace Smm.ContohCQRSNoEventSourcing.Data.Configuration
{
    public class JenisKelaminConfiguration : IEntityTypeConfiguration<JenisKelamin>
    {
        public void Configure(EntityTypeBuilder<JenisKelamin> builder)
        {
            builder.ToTable("JenisKelamin");
            builder.HasKey(b => b.Id);
        }
    }
}
