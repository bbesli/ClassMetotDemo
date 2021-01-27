using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> Musteriler = new List<Musteri>();/* Musteri class'ımıza ait bir Liste oluşturuyoruz. MusteriManager'ın altında tanımlamamızın sebebi metotlar içerisindeki işlemler tekrarlandığında
                                                        * veri kaybı olmaması.*/
        public void MusteriEkle(Musteri musteri)/*Parametreler ile dışarıda bulunan class tipindeki listeye veri ekleme metodu.*/
        {
            
            Musteriler.Add(musteri);

        }
        public void MusteriListele()/*dışarıda bulunan class(Musteri) tipindeki listenin elemanlarını listelemeya yarayan metot*/
        {
            foreach (var item in Musteriler)
            {
                Console.WriteLine(item.KimlikNumrasi + " " + item.MusteriAdi + " " + item.MusteriSoyadi + " " + item.MusteriDogumTarihi);
            }
        }
        public void ArananMusteriListele(int KimlikNumarasi)/*parametreye girdğimiz değere eşit olan kişiyi tespit eden ve bilgilerini yazdıran metot*/
        {
            foreach (var item in Musteriler)
            {
                if (item.KimlikNumrasi == KimlikNumarasi)
                {
                    Console.WriteLine(item.KimlikNumrasi + " " + item.MusteriAdi + " " + item.MusteriSoyadi + " " + item.MusteriDogumTarihi);
                }
            }
        }

        public void MusteriSil(int KimlikNumarasi)/* parametre olarak girilen KimlikNumarası değişkenindeki veriyi Musteriler listesinde bulan ve karşılık gelen değer null değilse
                                                   * yani bir sonuç dönmüşse, dönen sonuca ait verileri listeden silen metot*/
        {
            var itemToRemove = Musteriler.SingleOrDefault(r => r.KimlikNumrasi == KimlikNumarasi);
            if (itemToRemove != null)
                Musteriler.Remove(itemToRemove);
            Console.WriteLine(KimlikNumarasi + " kimlik nolu kişi kaydı silindi.");
            
        }
    }
}
