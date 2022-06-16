using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superdry
{
    abstract class Variation
    {
        public abstract decimal AddCost(TShirts tshirts);
    }

    class ColorVariation : Variation
    {
        private static Dictionary<Color, decimal> _ColorPrice = new Dictionary<Color, decimal>()
            {
               {Color.RED, 5m },
               {Color.ORANGE, 6m },
               {Color.YELLOW, 8m },
               {Color.GREEN, 10m },
               {Color.BLUE, 12m },
               {Color.INDIGO, 15m },
               {Color.VIOLET, 17m }
            };
        public override decimal AddCost(TShirts tshirts)
        {
            tshirts.Price = _ColorPrice[tshirts.Color];
            return tshirts.Price;
        }
    }

    class SizeVariation : Variation
    {
        private static Dictionary<Size, decimal> _SizePrice = new Dictionary<Size, decimal>()
            {
                { Size.XS, 3.0m },
                { Size.S, 3.5m },
                { Size.M, 3.0m },
                { Size.L, 4.5m },
                { Size.XL, 5.7m },
                { Size.XXL, 7.5m },
                { Size.XXXL, 10.0m }
            };

        public override decimal AddCost(TShirts tshirts)
        {
            tshirts.Price = _SizePrice[tshirts.Size];
            return tshirts.Price;
        }
    }

    class FabricVariation : Variation
    {
        private static Dictionary<Fabric, decimal> _FabricPrice = new Dictionary<Fabric, decimal>()
            {
                { Fabric.CASHMERE, 12m },
                { Fabric.COTTON, 22m },
                { Fabric.LINEN, 23m },
                { Fabric.POLYESTER, 5m },
                { Fabric.RAYON, 7m },
                { Fabric.SILK, 26m },
                { Fabric.WOOL, 30m }
            };

        public override decimal AddCost(TShirts tshirts)
        {
            tshirts.Price = _FabricPrice[tshirts.Fabric];
            return tshirts.Price;
        }
    }
}
