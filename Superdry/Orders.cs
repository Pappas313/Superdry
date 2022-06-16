using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superdry
{
    class Orders
    {
        public void BuyTShirts(TShirts tshirts)
        {
            var amount = Convert.ToDecimal(new ColorVariation().AddCost(tshirts));
            amount += Convert.ToDecimal(new SizeVariation().AddCost(tshirts));
            amount += Convert.ToDecimal(new FabricVariation().AddCost(tshirts));

            var basket = new Basket();
            basket.SetDueAmount(amount);

            var pay = new PaymentsChoice();
            pay.PayBasket(basket);



            if (basket.Pay())
            {
                Console.WriteLine("Completed!");
            }
            else
            {
                Console.WriteLine("Cancelled!");
                Console.WriteLine("Pleaae try again.");
            }


        }
    }

    class Basket
    {
        private Payments _payments;
        private decimal _amount;

        public void SelectPayments(Payments payments)
        {

            _payments = payments;
        }

        public void SetDueAmount(decimal amount)
        {
            _amount = amount;
            Console.WriteLine("The price is: {0}€", amount);
        }

        public bool Pay()
        {

            return _payments.Pay(_amount);
        }
    }


}
