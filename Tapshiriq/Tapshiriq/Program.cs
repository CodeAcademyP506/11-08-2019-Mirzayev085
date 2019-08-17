using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapshiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salam Xosh Gelmishsiniz! Zehmet Olmazsa Adinizi Daxil Edin!");
            string ad = Console.ReadLine().ToUpper();
            Console.WriteLine("Salam " + ad);

            Console.WriteLine("Telebesiniz? He yoxsa Yox?");
            string answer =  Console.ReadLine().ToUpper();
            

                if (answer == "HE")
                {
                Console.WriteLine("Tebrik edirik " + ad + " " + Telebe()) ;
                
                }
                else if(answer == "YOX")
                {
                Console.WriteLine("Isleyirsiniz?");
                string isWorker = Console.ReadLine().ToUpper();
                    if(isWorker == "HE")
                {
                    Console.WriteLine("Tebrik edirik " + ad + " " + Worker());
                }else if(isWorker == "YOX")
                {
                    Console.WriteLine("Cox gumanki " + ad + " " + pupil());
                }
                else
                {
                    Console.WriteLine("Bele bir cavab yoxdu");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Bele bir cavab yoxdu");
                return;
            }

        }

        static string Telebe()
        {
            Console.WriteLine("Hansi  unide oxuyursunuz?");
            string uni = Console.ReadLine();

            Console.WriteLine("Ixtisasiniz nedir?");
            string ixtisas = Console.ReadLine();

            Console.WriteLine("Reqem daxil edin");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 1; i < num; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            return ("Siz " + uni + " de " + ixtisas + " uzre oxuyursunuz ve 1 ile " + num + " arasindaki tek ededlerin ceminin : " + sum + " oldugunu bilirsiniz");

        }

        static string Worker()
        {

            Console.WriteLine("Harada isleyirsiniz?");
            string work = Console.ReadLine();

            Console.WriteLine("Vezifeniz nedir?");
            string company = Console.ReadLine();

            Console.WriteLine("Reqem daxil edin");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            return ("Siz " + work + " de " + company + " vezifesinde isleyirsiniz " + num + " arasindaki tek ededlerin ceminin : " + sum + " oldugunu bilirsiniz");

        }

        static string pupil()
        {

            Console.WriteLine("Reqem daxil edin");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if (i % 6 == 0)
                {
                    sum += i;
                }
            }

            return (" siz sagirdsiniz ama buna baxmayaraq 1 ile " + num + " arasindaki cut ededlerin 3 e bolunenlerinin ceminin : " + sum + " oldugunu bilirsiniz");

        }

    }
}
