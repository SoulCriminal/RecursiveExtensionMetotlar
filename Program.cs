using System;

namespace RecursiveExtensionMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif- Öz yinelemeli 
            // 3 üssü 4 = 3*3*3*3
            int result = 1;
            for(int i =1;i<5;i++)
            {
                result = result*3;
                Console.WriteLine(result);
                // YAzdığımız üst alma fonksiyonunu çağırdık.
                Islemler instance = new ();
                Console.WriteLine(instance.Ust(3,4));


                // Extension Metotlar
                string ifade = "Hakkı AYMAN";
                bool sonuc = ifade.CheckSpaces();
                Console.WriteLine(sonuc);
                if(sonuc)
                {
                    Console.WriteLine(ifade.RemoveWhiteSpaces());
                }
                Console.WriteLine(ifade.MakeUpparCase());

                int[] sayilar = {2,11,4,7,1,5};
                sayilar.SortArray();
                sayilar.EkranaYazdir();


                //Console.WriteLine(ifade.CheckSpaces());
            }
        }

        public class Islemler
        {
            public int Ust(int sayi , int us_) {
                {
                    if(us_<2)
                    {
                        return sayi;
                    }
                    return Ust(sayi,us_-1)*sayi;
                    //Üst alma fonksiyonu
                }
            }
        }
    }
      public static class Extension
        {
            public static bool CheckSpaces(this string param)
            {
                return param.Contains(" ");
            }
            // Boşlukları kaldıran fonksiyon altta
            public static string RemoveWhiteSpaces(this string param)
            {
                string[] dizi = param.Split(" ");
                return string.Join("",dizi);
            }
            // Karakterlerin hepsini büyük yazdıran fonksiyon aşağıda
            public static string MakeUpparCase(this string param)
            {
                return param.ToUpper();
            }
            //Diziyi sıralayan fonksiyon aşağıda
            public static int[] SortArray(this int[] param)
            {
                Array.Sort(param);
                return param;

            }
            //Ekrana yazdırma fonksiyonu aşağıda
            public static void EkranaYazdir(this int[] param)
            {
                foreach(int item in param){
                    Console.WriteLine(item);
                }
            }
        }
}
