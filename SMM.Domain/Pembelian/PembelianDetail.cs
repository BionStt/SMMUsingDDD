using SMM.Domain.Ddd;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class PembelianDetail:Entity<Guid>
    {
        protected PembelianDetail()
        {

        }

        public decimal? HargaOffTheRoad { get; private set; }
        public decimal? BBN { get; private set; }
        public int Qty { get; private set; }
        public decimal? Diskon { get; private set; }
        public decimal? SellIn { get; private set; }
        public decimal? Harga1 { get; private set; }
        public decimal? Diskon2 { get; private set; }
        public decimal? SellIn2 { get; private set; }
        public decimal? HargaPPN { get; private set; }
        public decimal? DiskonPPN { get; private set; }
        public decimal? SellInPPN { get; private set; }

        public Guid MasterBarangId { get; private set; }
        public MasterBarang.MasterBarang MasterBarang { get; private set; }


        private readonly List<StokUnit> _StokUnit = new List<StokUnit>();
        public IReadOnlyCollection<StokUnit> Stokunit => _StokUnit;

        public PembelianDetail(decimal? hargaOffTheRoad, decimal? bBN, int qty, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN, Guid masterBarangId)
        {
            Id = Guid.NewGuid();
            HargaOffTheRoad = hargaOffTheRoad;
            BBN = bBN;
            Qty = qty;
            Diskon = diskon;
            SellIn = sellIn;
            Harga1 = harga1;
            Diskon2 = diskon2;
            SellIn2 = sellIn2;
            HargaPPN = hargaPPN;
            DiskonPPN = diskonPPN;
            SellInPPN = sellInPPN;
            MasterBarangId = masterBarangId;
        }

        public void EditPembelianDetail(decimal? hargaOffTheRoad, decimal? bBN, int qty, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN, Guid masterBarangId)
        {
            HargaOffTheRoad = hargaOffTheRoad;
            BBN = bBN;
            Qty = qty;
            Diskon = diskon;
            SellIn = sellIn;
            Harga1 = harga1;
            Diskon2 = diskon2;
            SellIn2 = sellIn2;
            HargaPPN = hargaPPN;
            DiskonPPN = diskonPPN;
            SellInPPN = sellInPPN;
            MasterBarangId = masterBarangId;
        }

        public StokUnit AddStokUnit(string noRangka, string noMesin, string warna, string faktur, decimal? harga, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN)
        {
            var Stokunits = new StokUnit(noRangka,noMesin,warna,harga,diskon,sellIn,harga1,diskon2,sellIn2,hargaPPN,diskonPPN,sellInPPN);
            _StokUnit.Add(Stokunits);
            //_StokUnit.AddRange(Stokunits);
            return Stokunits;
        }
        public StokUnit EditStokUnit(string noRangka, string noMesin, string warna,decimal? harga, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN, Guid StokUnitId)
        {
            var ListStokUnit = _StokUnit.FirstOrDefault(i=>i.Id==StokUnitId);
            ListStokUnit.EditStokUnit(noRangka,noMesin,warna,harga,diskon,sellIn,harga1,diskon2,sellIn2,hargaPPN,diskonPPN,sellInPPN);
            return ListStokUnit;
        }


    }
}
