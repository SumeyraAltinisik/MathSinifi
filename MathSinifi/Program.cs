using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSinifi
{
    class Program
    {
        static void Main(string[] args)
        {
           int enBuyuk =  Math.Max(12, 18);
            Console.WriteLine("12,18 in büyük olanı:{0}", enBuyuk);

           int enKucuk =  Math.Min(12, 18);
            Console.WriteLine("12,18 in küçük olanı:{0}",enKucuk);

            Console.WriteLine("16.123'un tavan değeri:{0}",Math.Ceiling(16.123));

            Console.WriteLine("-2323 Mutlak değeri:{0}", Math.Abs(-2323));

            Console.WriteLine("76.45646 virgülden sonra 3 basamağa duyarlı yuvarlaması:,{0}",Math.Round(76.45646, 3));

            Console.WriteLine("16.123'un taban değeri:{0}", Math.Floor(16.123));

            Console.WriteLine("5'in karekökü:{0}", Math.Sqrt(5));

            Console.WriteLine("8'in 3. kuvveti:{0}", Math.Pow(8, 3));

            Console.WriteLine("30'un sinusu : {0}", Math.Sin(30));

            Console.WriteLine("10 sayısının logaritması : {0}", Math.Log(10));

            Console.WriteLine("E sayısı: {0}", Math.E);

            Console.WriteLine("Pi sayısı : {0}", Math.PI);

            Console.ReadKey();
        }
    }
}
