using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager MusteriManager = new MusteriManager();
            Musteri m1 = new Musteri { KimlikNumrasi=1, MusteriAdi="burak", MusteriSoyadi="Besli", MusteriDogumTarihi ="Mayis" };
            Musteri m2 = new Musteri { KimlikNumrasi=2, MusteriAdi="deniz", MusteriSoyadi="Besli", MusteriDogumTarihi ="Ağustos" };
            Musteri m3 = new Musteri { KimlikNumrasi=3, MusteriAdi="bozca", MusteriSoyadi="Besli", MusteriDogumTarihi ="Nisan" };

            MusteriManager.MusteriEkle(m1);
            MusteriManager.MusteriEkle(m2);
            MusteriManager.MusteriEkle(m3);
            

            MusteriManager.MusteriListele();
            //MusteriManager.ArananMusteriListele(2);
            MusteriManager.MusteriSil(2);

            MusteriManager.MusteriListele();


        }
    }
}
