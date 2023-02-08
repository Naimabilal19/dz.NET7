using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Credit
    {
            public string CreditCard { get; set; }
            public string FIO { get; set; }
            string Deadline { get; set; }
            string CVC { get; set; }
        static void Main(string[] args)
        {
            string s = DateTime.Now.Year.ToString();
           // Console.WriteLine(s);
            Credit c = new Credit();
            Console.WriteLine("Input fio");
            c.FIO = Console.ReadLine();
            Console.WriteLine("Input number card");
            c.CreditCard = Console.ReadLine();
            Console.WriteLine("Input year of deadline card");
            c.Deadline = Console.ReadLine();
            Console.WriteLine("Input cvc");
            c.CVC = Console.ReadLine();
            try
            {
                
                if (c.FIO==" ")
                {
                    throw new Exception("Не полный вввод данных!");
                }
                else if (c.Deadline != s)
                {
                    throw new Exception("Срок карты введен неверно");
                }
                else if (c.CreditCard.Length != 16)
                {
                    throw new Exception("Ошибка!\nНомер карты должен состоять из 16 цифр");
                }
                else if(c.CVC.Length<3&&c.CVC.Length>3)
                {
                    throw new Exception("Неверно введен СVC-код");
                }

            }
            catch(Exception a)
            {
                Console.WriteLine();
                Console.WriteLine(a.Message);
            }

            
           
        }

            }
    /*class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string pass = Console.ReadLine();
                if(pass.Length<6)
                {
                    throw new Exception("Pass length min 6 symbol");
                }
            }
            catch(Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }
    }*/
}
