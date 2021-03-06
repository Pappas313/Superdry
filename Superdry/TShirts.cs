using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superdry
{
    class TShirts
    {
        public readonly Color Color;
        public readonly Size Size;
        public readonly Fabric Fabric;

        public decimal Price { get; set; }

        public TShirts(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;

        }
    }

    enum Color { RED, ORANGE, YELLOW, GREEN, BLUE, INDIGO, VIOLET }
    enum Size { XS, S, M, L, XL, XXL, XXXL }
    enum Fabric { WOOL, COTTON, POLYESTER, RAYON, LINEN, CASHMERE, SILK }
}