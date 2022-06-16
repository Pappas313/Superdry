using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Superdry
{
    abstract class Payments
    {
        public abstract bool Pay(decimal amount);
    }

    class CreditCard : Payments
    {
        private bool _valid;
        public CreditCard()
        {
            _valid = CardInfo();
        }

        public override bool Pay(decimal amount)
        {
            if (_valid)
            {
                Console.WriteLine($"Proceeding to Pay  {amount}€ using Card...");
                return _valid;
            }
            else
            {
                Console.WriteLine($"Cannot Pay {amount} using Card!");
                return _valid;
            }

        }

        private bool CardInfo()
        {
            Console.Write("Enter the card number: ");
            var id = CardNumValidation(Console.ReadLine().Trim());


            Console.Write("Enter the expiration date (MM/YYYY): ");
            var exp = ValidExpiration(Input.DateInput());


            Console.Write("Enter the CCV number: ");
            var ccv = CCVValidation(Console.ReadLine().Trim());


            return id && exp && ccv;
        }
        private bool CardNumValidation(string id)
        {
            if (Regex.Replace(id, @"\s+", "").Length != 16)
            {
                return false;
            }
            return true;
        }

        private bool CCVValidation(string ccv)
        {
            return Regex.Match(ccv, @"^\d{3}$").Success;
        }

        private bool ValidExpiration(DateTime exp)
        {
            string[] date = Regex.Split(exp.ToString(), "/");
            string[] currentDate = Regex.Split(DateTime.Now.ToString("MM/yyyy"), "/");
            int compareYears = string.Compare(date[1], currentDate[1]);
            int compareMonths = string.Compare(date[0], currentDate[0]);

            
            if (
                Regex.Match(date[0], @"^[0][1-9]|[1][0-2]$").Success &&
                ((compareYears == 1) || (compareYears == 0 && (compareMonths == 1))))
            {
                return true;
            }

            return false;
        }
    }

    class BankTransfer : Payments
    {
        public override bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 1000)
            {
                Console.WriteLine($"Paying {amount} using Bank transfer declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using Bank transfer");
                return true;
            }
        }
    }

    class Cash : Payments
    {
        public override bool Pay(decimal amount)
        {
            Console.Write("Enter the Money: ");
            decimal paid = Decimal.Parse(Console.ReadLine().Trim());

            if (amount <= paid)
            {
                Console.WriteLine("Payment OK");
                Console.WriteLine("You have {0}€ change", paid - amount);
                return true;
            }
            else
            {
                Console.WriteLine("Payment fail!");
                Console.WriteLine("You paid less.");
                return false;
            }

        }
    }

    class PaymentsChoice
    {
        public void PayBasket(Basket basket)
        {

            switch (Menu.PaymentsMenu())
            {
                case 1:
                    basket.SelectPayments(new CreditCard());
                    break;

                case 2:
                    basket.SelectPayments(new BankTransfer());
                    break;

                case 3:
                    basket.SelectPayments(new Cash());
                    break;

            }
        }
    }
}
