using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
 class AnaProgram
 {

  public static void AsalSayiBul(int gelen = 100)
  {
   int sayac = 0;
   for (int i = 3; i < gelen; i++)
   {
    sayac = 0;
    for (int j = 1; j < (i / 2) + 1; j++)
    {
     if (i % j == 0)
      sayac++;
    }
    if (sayac < 2)
     Console.WriteLine("Asal sayı: " + i);
   }
  }

  public static bool AsalMi(int gelen)
  {
   int sayac = 0;
   for (int j = 1; j < (gelen / 2) + 1; j++)
   {
    if (gelen % j == 0)
     sayac++;
   }
   if (sayac < 2)
    return true; // gelen sayı asaldır
   return false; // gelen sayı asal değildir
  }

  static void Main()
  {
   int sayi;

   Console.WriteLine("Bir sayı giriniz");
   sayi = Convert.ToInt32(Console.ReadLine());
   //sayi = int.Parse(Console.ReadLine());
   //AsalSayiBul(50);

   //bool asalkontrol = AsalMi(sayi);

   //if(asalkontrol==true)
   // Console.WriteLine(sayi.ToString() + " sayısı asaldır.");
   //else
   // Console.WriteLine(sayi.ToString() + " sayısı asal değildir.");

   if(AsalMi(sayi)) // true ise if çalışır
    Console.WriteLine(sayi.ToString() + " sayısı asaldır.");
   else
    Console.WriteLine(sayi.ToString() + " sayısı asal değildir.");
  }
 }
}
