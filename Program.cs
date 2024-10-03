using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_Proje_5
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Send function again begun
            baslangic:
            //Declaratio of variables
            int gün;

            Console.WriteLine("Lütfen Haftanın Kaçıncı Gün Olduğunu Giriniz: ");
            gün = Convert.ToInt32 (Console.ReadLine());

            if(gün==1)
            {
                Console.WriteLine("Bugün günlerden Pazartesidir.");
            }

           else if (gün == 2)
            {
                Console.WriteLine("Bugün günlerden Salıdır.");
            }

            else if (gün == 3)
            {
                Console.WriteLine("Bugün günlerden Çarşambadır.");
            }

            else if (gün == 4)
            {
                Console.WriteLine("Bugün günlerden Perşembedir.");
            }

            else if (gün == 5)
            {
                Console.WriteLine("Bugün günlerden Cumadır.");
            }

            else if (gün == 6)
            {
                Console.WriteLine("Bugün günlerden Cumartesidir.");
            }

            else if (gün == 7)
            {
                Console.WriteLine("Bugün günlerden Pazardır.");
            }

            else
            {
                Console.WriteLine("Geçersiz Gün girişi , lütfen geçerli bir gün sayısı giriniz.");
                //Send function again begun
                goto baslangic;
            }

            Console.ReadKey();
        }
    }
}
