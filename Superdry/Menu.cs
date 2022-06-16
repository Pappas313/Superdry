using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Superdry
{
    static class Menu
    {
        public static Color ColourChoice()
        {
            //{ RED, ORANGE, YELLOW, GREEN, BLUE, INDIGO, VIOLET }
            int choice;

            do
            {
                Console.WriteLine("Enter the number of color: ");
                Console.WriteLine("1: RED");
                Console.WriteLine("2: ORANGE");
                Console.WriteLine("3: YELLOW");
                Console.WriteLine("4: GREEN");
                Console.WriteLine("5: BLUE");
                Console.WriteLine("6: INDIGO");
                Console.WriteLine("7: VIOLET");
                Console.Write("***********************");
                choice = Input.IntInput();

            } while (choice < 1 || choice > 7);


            switch (choice)
            {
                case 1:
                    return Color.RED;
                case 2:
                    return Color.ORANGE;
                case 3:
                    return Color.YELLOW;
                case 4:
                    return Color.GREEN;
                case 5:
                    return Color.BLUE;
                case 6:
                    return Color.INDIGO;
                case 7:
                    return Color.VIOLET;
                default:
                    return Color.BLUE;


            }

        }

        public static Size SizeChoice()
        {
            //{ XS, S, M, L, XL, XXL, XXXL }
            int choice;

            do
            {
                Console.WriteLine("Enter the related number for the preffered size: ");
                Console.WriteLine("1: XS");
                Console.WriteLine("2: S");
                Console.WriteLine("3: M");
                Console.WriteLine("4: L");
                Console.WriteLine("5: XL");
                Console.WriteLine("6: XXL");
                Console.WriteLine("7: XXXL");
                Console.Write("*****************");
                choice = Input.IntInput();

            } while (choice < 1 || choice > 7);


            switch (choice)
            {
                case 1:
                    return Size.XS;
                case 2:
                    return Size.S;
                case 3:
                    return Size.M;
                case 4:
                    return Size.L;
                case 5:
                    return Size.XL;
                case 6:
                    return Size.XXL;
                case 7:
                    return Size.XXXL;
                default:
                    return Size.M;


            }

        }
        public static Fabric FabricChoice()
        {
            //{ WOOL, COTTON, POLYESTER, RAYON, LINEN, CASHMERE, SILK }            
            int choice;

            do
            {
                Console.WriteLine("Enter the number: ");
                Console.WriteLine("1: WOOL");
                Console.WriteLine("2: COTTON");
                Console.WriteLine("3: POLYESTER");
                Console.WriteLine("4: RAYON");
                Console.WriteLine("5: LINEN");
                Console.WriteLine("6: CASHMERE");
                Console.WriteLine("7: SILK");
                Console.Write("*********************");

                choice = Input.IntInput();

            } while (choice < 1 || choice > 7);


            switch (choice)
            {
                case 1:
                    return Fabric.WOOL;
                case 2:
                    return Fabric.COTTON;
                case 3:
                    return Fabric.POLYESTER;
                case 4:
                    return Fabric.RAYON;
                case 5:
                    return Fabric.LINEN;
                case 6:
                    return Fabric.CASHMERE;
                case 7:
                    return Fabric.SILK;
                default:
                    return Fabric.COTTON;


            }

        }

        public static int PaymentsMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("How do you want to pay? ");
                Console.WriteLine("1: Credit/Debit Card");
                Console.WriteLine("2: Bank Transfer");
                Console.WriteLine("3: Cash");
                Console.Write("-------------> ");

                choice = Input.IntInput();

            } while (choice < 1 || choice > 3);



            return choice;
        }
    }
}
