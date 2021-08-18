using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class StokUnit : Entity<Guid>
    {
        protected StokUnit()
        {

        }
        public StokUnit(string noRangka, string noMesin, string warna,  decimal? harga, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN)
        {
            Id = Guid.NewGuid();
            TanggalInput = DateTime.Now.Date;
            NoRangka = noRangka;
            NoMesin = noMesin;
            Warna = warna;
            Harga = harga;
            Diskon = diskon;
            SellIn = sellIn;
            Harga1 = harga1;
            Diskon2 = diskon2;
            SellIn2 = sellIn2;
            HargaPPN = hargaPPN;
            DiskonPPN = diskonPPN;
            SellInPPN = sellInPPN;
        }

        public string NoRangka { get; private set; }
        public string NoMesin { get; private set; }
        public string Warna { get; private set; }
        public StatusStokUnit Jual { get; private set; }
        public string Kembali { get; private set; }
        public string Faktur { get; private set; }
        public decimal? Harga { get; private set; }
        public decimal? Diskon { get; private set; }
        public decimal? SellIn { get; private set; }
        public decimal? Harga1 { get; private set; }
        public decimal? Diskon2 { get; private set; }
        public decimal? SellIn2 { get; private set; }
        public decimal? HargaPPN { get; private set; }
        public decimal? DiskonPPN { get; private set; }
        public decimal? SellInPPN { get; private set; }

        public DateTime? TanggalInput { get; private set; }

        public Guid PembelianDetailId { get; private set; }
        public PembelianDetail PembelianDetail { get; private set; }
        public Guid MasterBarangId { get; private set; }
        public MasterBarang.MasterBarang MasterBarang { get; private set; }



        public static StokUnit Create(string noRangka, string noMesin, string warna,   decimal? harga, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN){
            return new StokUnit(noRangka,noMesin,warna,harga,diskon,sellIn,harga1,diskon2,sellIn2,hargaPPN,diskonPPN,sellIn);
        }

        public void EditStokUnit(string noRangka, string noMesin, string warna, decimal? harga, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN )
        {
            NoRangka = noRangka;
            NoMesin = noMesin;
            Warna = warna;
            Harga = harga;
            Diskon = diskon;
            SellIn = sellIn;
            Harga1 = harga1;
            Diskon2 = diskon2;
            SellIn2 = sellIn2;
            HargaPPN = hargaPPN;
            DiskonPPN = diskonPPN;
            SellInPPN = sellInPPN;
        }
    }
    public enum StatusStokUnit
    {
        BelumTerjual = 0,
        Terjual=1

    }
}
