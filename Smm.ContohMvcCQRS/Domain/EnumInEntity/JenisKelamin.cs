﻿using Smm.ContohMvcCQRS.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.Domain.EnumInEntity
{
    public class JenisKelamin : AggregateRoot<int>
    {
        public String JenisKelaminKeterangan { get; set; }
    }
}
