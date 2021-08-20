﻿using Smm.DomainEventMediaTR.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.DomainEventMediaTR.Domain.ValueObject
{
    public class Alamat : ValueObject<Alamat>
    {
        public string Jalan { get; private set; }
        public string Kelurahan { get; private set; }
        public string Kecamatan { get; private set; }
        public string Kota { get; private set; }
        public string Propinsi { get; private set; }
        public string KodePos { get; private set; }
        public string NoTelepon { get; private set; }
        public string NoFax { get; private set; }
        public string NoHandphone { get; private set; }


        protected Alamat()
        {

        }

        private Alamat(string jalan, string kelurahan, string kecamatan, string kota, string propinsi, string kodePos, string noTelepon, string noFax, string noHandphone)
        {
            Jalan = jalan;
            Kelurahan = kelurahan;
            Kecamatan = kecamatan;
            Kota = kota;
            Propinsi = propinsi;
            KodePos = kodePos;
            NoTelepon = noTelepon;
            NoFax = noFax;
            NoHandphone = noHandphone;
        }
        public static Alamat CreateAlamat(string jalan, string kelurahan, string kecamatan, string kota, string propinsi, string kodePos, string noTelepon, string noFax, string noHandphone)
        {
            return new Alamat(jalan, kelurahan, kecamatan, kota, propinsi, kodePos, noTelepon, noFax, noHandphone);
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Jalan;
            yield return Kelurahan;
            yield return Kecamatan;
            yield return Kota;
            yield return Propinsi;
            yield return KodePos;
            yield return NoTelepon;
            yield return NoFax;
            yield return NoHandphone;
        }
    }
}
