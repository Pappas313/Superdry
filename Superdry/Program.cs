using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superdry
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating new T-Shirts
            TShirts tshirts = new TShirts(
                Menu.ColourChoice(),
                Menu.SizeChoice(),
                Menu.FabricChoice()
                );

            Orders orders = new Orders();
            orders.BuyTShirts(tshirts);

            Console.ReadKey();

        }
    }
}