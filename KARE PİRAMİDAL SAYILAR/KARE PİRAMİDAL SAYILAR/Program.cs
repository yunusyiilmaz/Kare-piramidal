using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARE_PİRAMİDAL_SAYILAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Yöntem
            //int toplam = 0;
            //Console.Write("BİR SAYI GİRİNİZ :");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++)
            //{
            //    toplam = 0;
            //    for(int j = 1;j<=i; j++)
            //    {
            //        toplam += j * j;
            //        Console.Write(j+"^2");
            //        if(j!=i)
            //        {
            //            Console.Write("+");
            //        }
            //        else
            //        {
            //            Console.Write("=");
            //        }
            //    }
            //    Console.WriteLine(toplam);
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //2.Yöntem
            int toplam = 0;
            Console.Write("BİR SAYI GİRİNİZ :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string line = string.Empty;
            for (int i = 1; i <= sayi; i++)
            {
                toplam += i * i;
                if (line == "")
                    line += i.ToString() + "^2";
                else
                    line += "+" + i.ToString() + "^2";
                Console.Write(line + "=");
                Console.WriteLine(toplam);
            }
            Console.ReadLine();
        }
    }
}
