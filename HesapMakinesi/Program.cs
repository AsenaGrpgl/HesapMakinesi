using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            string islem;
            double sonuc;


            Console.WriteLine("Birinci sayıyı giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+,-,*,/) : ");
            islem = Console.ReadLine();

            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine("sonuç : " + sonuc);

            }

            if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine("sonuç : " + sonuc);
            }

            if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
                Console.WriteLine("sonuç : " + sonuc );

            }

            if (islem == "/")
            {
                sonuc = sayi1 / sayi2;
                Console.WriteLine("sonuç : " + sonuc );

            }

            Console.ReadLine();

        }
    }
}
