﻿using Smm.ContohMvcCQRS.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Smm.ContohMvcCQRS.Domain.Events
{
    public class DataKonsumenRegisteredEvent : DomaintEvent
    {
        public DataKonsumenRegisteredEvent(Guid dataKonsumenId, string nama)
        {
            DataKonsumenId = dataKonsumenId;
            Nama = nama;
            AggregateId = dataKonsumenId;
        }

        public Guid DataKonsumenId { get; private set; }
        public string Nama { get; private set; }



    }
}
