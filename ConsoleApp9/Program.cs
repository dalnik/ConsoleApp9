using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finance;

namespace NamespaseEnum

{
    class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account();
            //Console.WriteLine(account);

            //Finance.Account account1 = new Finance.Account();
            //Console.WriteLine(account1);
            //Console.ReadKey();

            Dictionary.Seasons seasons = Dictionary.Seasons.Undefined;

            String input = Console.ReadLine();
            int month = Int32.Parse(input);

            switch (month)

            {
                case 1:
                case 2:
                case 12:
                    {
                        seasons = Dictionary.Seasons.Winter;
                        break;
                    }
                case 3:
                case 4:
                case 5:
                    {
                        seasons = Dictionary.Seasons.Spring;
                        break;
                    }
                case 6:
                case 7:
                case 8:
                    {
                        seasons = Dictionary.Seasons.Summer;
                        break;
                    }
                case 9:
                case 10:
                case 11:
                    {
                        seasons = Dictionary.Seasons.Autumn;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введите номера месяцев от 1 до 12");
                        break;
                    }




            }

            Console.WriteLine(seasons);

            //Console.ReadKey();
               

            Array array = Enum.GetValues(typeof(Dictionary.Seasons));
            foreach (var item in array) 
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

