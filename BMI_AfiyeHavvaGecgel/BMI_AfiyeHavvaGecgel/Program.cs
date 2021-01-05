using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_AfiyeHavvaGecgel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba :)");
            try
            {
                Console.WriteLine("Kilonuzu kilogram cinsinden giriniz:        Örn:70");
                int kilo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("------------------------\n");

                Console.WriteLine("Boyunuzu santimetre cinsinden giriniz:      Örn:180");
                decimal boySantimetre = (Convert.ToDecimal(Console.ReadLine())) / 100;

                Console.WriteLine("------------------------\n");
                decimal bmiValue = (kilo) / (boySantimetre * boySantimetre);
                Console.WriteLine("BMI değeriniz: " + bmiValue);

                if (bmiValue < 18.54M)
                {
                    Console.WriteLine("İdeal kilonuzun altındasınız.");
                }
                else if (bmiValue >= 18.5M && bmiValue < 24.9M)
                {
                    Console.WriteLine("İdeal kilodasınız.");
                }
                else if (bmiValue >= 25M && bmiValue < 29.9M)
                {
                    Console.WriteLine("İdeal kilonuzun üzerindesiniz.");
                }
                else if (bmiValue >= 30M && bmiValue < 34.9M)
                {
                    Console.WriteLine("Obezite - Sınıf 1");
                }
                else if (bmiValue >= 35M && bmiValue < 39.9M)
                {
                    Console.WriteLine("Obezite - Sınıf 2");
                }
                else if (bmiValue > 40)
                {
                    Console.WriteLine("Obezite - Sınıf 3");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Boy değeriniz 0 olamaz.");
            }
            catch(FormatException)
            {
                Console.WriteLine("Hatalı giriş formatı.");
            }
            catch (Exception)
            {
                throw;
            }

            Console.WriteLine("Çıkış yapmak için herhangi bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
