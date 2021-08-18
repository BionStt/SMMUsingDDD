﻿using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain.STNKBPKB
{
    public class DataSTNK : Entity<Guid>
    {
        protected DataSTNK()
        {

        }
        public static DataSTNK CreateDataSTNK(DateTime? tanggalBayarSTNK, string noStnk, decimal pajakStnk, decimal birojasa, decimal biayaTambahan, decimal formA, string nomorPlat, decimal? perwil, decimal? pajakProgresif, decimal? bbnPabrik, int? progresifKe)
        {
            return new DataSTNK(tanggalBayarSTNK,noStnk,pajakStnk,birojasa,biayaTambahan,formA,nomorPlat,perwil,pajakProgresif,bbnPabrik,progresifKe);
        }
        private DataSTNK(DateTime? tanggalBayarSTNK, string noStnk, decimal pajakStnk, decimal birojasa, decimal biayaTambahan, decimal formA, string nomorPlat, decimal? perwil, decimal? pajakProgresif, decimal? bbnPabrik, int? progresifKe)
        {
            TanggalBayarSTNK = tanggalBayarSTNK;
           // PermohonanFakturDBId = permohonanFakturDBId;
            NoStnk = noStnk;
            PajakStnk = pajakStnk;
            Birojasa = birojasa;
            BiayaTambahan = biayaTambahan;
            FormA = formA;
            NomorPlat = nomorPlat;
            Perwil = perwil;
            PajakProgresif = pajakProgresif;
            BbnPabrik = bbnPabrik;
            ProgresifKe = progresifKe;
        }

        public DateTime? TanggalBayarSTNK { get; set; }
        public int? PermohonanFakturDBId { get; set; }
        public string NoStnk { get; set; }
        public decimal PajakStnk { get; set; }
        public decimal Birojasa { get; set; }
        public decimal BiayaTambahan { get; set; }
       public decimal FormA { get; set; }
        public string NomorPlat { get; set; }
        public decimal? Perwil { get; set; }
        public decimal? PajakProgresif { get; set; }
        public decimal? BbnPabrik { get; set; }
        public int? ProgresifKe { get; set; }
    }
}
