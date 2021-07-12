using System;

namespace BA_11_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1.ÖRNEK: kullanicinin girdigi sayi degeerleri kadar rastgele sayi üretelim. BU sayilar 1-100 arasinda olsun. Bunlari kücükten büyüge dogru siralayalim.

            //Console.WriteLine("Dizi kac elemanli olsun");
            //int eleman = int.Parse(Console.ReadLine());
            //int[] diziElemanlari = new int[eleman];

            //Random rastgele = new Random();  // random sinifindan bir nesne ürettik

            //for (int i = 0; i < diziElemanlari.Length; i++)
            //{
            //    diziElemanlari[i] = rastgele.Next(1, 100); // rastgele sayilar üretildi ve aktarildi.
            //}

            //Array.Sort(diziElemanlari);
            //Array.Reverse(diziElemanlari);  // reverse mevcut siralamayi tam tersine cevirir.

            //foreach (var item in diziElemanlari)
            //{
            //    Console.WriteLine(item);
            //}

            // 2. ÖRNEK :  Elimizde 10 tane not degeri olsun. Bu not degerlerine göre;
            // 1- 50 nin altindaki notlari kaldi seklinde saysin.
            // 2- 50 nin üstündeki notlari gecti seklinde saysin.
            // 3- Gecen ve kalan notlarin ortalamasini yazdirsin.

            int[] notlar = { 40, 50, 70, 20, 15, 89, 36, 99, 29, 39 };

            int gecen = 0;
            int kalan = 0;

            double gecenToplam = 0;
            double kalanToplam = 0;

            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] >= 50)
                {
                    gecenToplam += notlar[i];
                    gecen++;
                }
                else
                {
                    kalanToplam += notlar[i];
                    kalan++;
                }
            }

            Console.WriteLine("Gecen sayisi: " + gecen);
            Console.WriteLine("Kalan sayisi: " + kalan);

            Console.WriteLine("**********************");

            Console.WriteLine("Gecenlerin Ortalamasi :" + gecenToplam / gecen);
            Console.WriteLine("Kalanlarin Ortalamasi :" + kalanToplam / kalan);



        }
    }
}
