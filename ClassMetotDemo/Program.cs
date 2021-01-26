using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager MusteriManager = new MusteriManager();

            MusteriManager.MusteriEkle(1, "Burak", "Besli", "Mayis");
            MusteriManager.MusteriEkle(2, "Deniz", "Besli", "Ağustos");
            MusteriManager.MusteriEkle(3, "Bozca", "KEDİ", "Nisan");

            MusteriManager.MusteriListele();
            //MusteriManager.ArananMusteriListele(2);
            MusteriManager.MusteriSil(2);

            MusteriManager.MusteriListele();


        }
    }
}
