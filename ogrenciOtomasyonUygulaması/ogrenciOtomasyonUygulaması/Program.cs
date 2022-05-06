using System;
using System.Collections.Generic;

namespace ogrenciOtomasyonUygulaması
{
    public class okul
    {
        public string adi = "";
        public string adres = "";

        public List<ogrenci> ogrenciler = new List<ogrenci>();
        
        public List<ogretmen> ogretmenler = new List<ogretmen>();
        
        public void ogrenciEkle(string ad , string ogrenciNo,int sinifi, string gsm,string adres)
        {
            ogrenci yeni = new ogrenci();
            yeni.adiSoyadi = ad;
            yeni.ogrenciNo = ogrenciNo;
            yeni.adres = adres;
            yeni.gsm = gsm;
            yeni.sinif = sinifi;

            ogrenciler.Add(yeni);
        }


        public void ogrenciListele()
        {
            foreach (var item in ogrenciler)
            {
                Console.WriteLine("OgrenciNo : {0}, Ad-Soyad : {1}\n" +"Sınıfı {2}\n"+"Telefon numarası : {3}\n" + "Adresi : {4}",item.ogrenciNo, item.adiSoyadi, item.sinif, item.gsm, item.adres);
            }
        }


        public void ogrenciSil(string ogrNo)
        {
            foreach (var item in ogrenciler)
            {
                if (item.ogrenciNo == ogrNo)
                {
                    ogrenciler.Remove(item);
                    break;
                }
            }
        }

        public void ogrenciGuncelle(string ogrNo,string adSoyad)
        {
            foreach (var item in ogrenciler)
            {
                if (item.ogrenciNo == ogrNo)
                {
                    item.adiSoyadi = adSoyad;
                    break;
                }
            }

            Console.WriteLine("Öğrenci Bilgileri Başarıyla Güncellendi.");
        }

        public void hocaEkle(string ad,string egitmenNo,string mail,int dersSayisi)
        {
            ogretmen yeniHoca = new ogretmen();
            yeniHoca.adiSoyadi = ad;
            yeniHoca.egitmenNo = egitmenNo;
            yeniHoca.mail = mail;
            yeniHoca.dersSayisi = dersSayisi;

            ogretmenler.Add(yeniHoca);
        }

        public void HocaSil(string egitmenNo)
        {
            foreach (var item in ogretmenler)
            {
                if (item.egitmenNo == egitmenNo)
                {
                    ogretmenler.Remove(item);
                    break;
                }
            }
        }

        public void HocalariListele()
        {
            foreach (var item in ogretmenler)
            {
                Console.WriteLine("Eğitmen numarası : {0} - Adı-Soyadı : {1}\n Mail adresi : {2}\n Verdiği ders sayısı : {3} ", item.egitmenNo, item.adiSoyadi, item.mail, item.dersSayisi);
            }
    }



    public class ogrenci
    {
        public string adiSoyadi = "";
        public string ogrenciNo = "";
        public string adres = "";
        public string gsm = "";
        public int sinif = 0;
    }

    public class ogretmen
    {
        public string adiSoyadi = "";
        public string egitmenNo = "";
        public string mail = "";
        public int dersSayisi = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            okul yeniOkul = new okul();
            yeniOkul.adi = "Gölhisar Uygulamalı Bilimler";
            yeniOkul.adres = "Gölhisar";


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Öğrenci Eklemek için         : 1");
                Console.WriteLine("Öğrencileri Listelemek için  : 2");
                Console.WriteLine("Öğrenci Silmek için          : 3");
                Console.WriteLine("Öğretmen Eklemek için        : 4");
                Console.WriteLine("Öğretmen Silmek için         : 5");
                Console.WriteLine("Öğretmenleri Listelemek için : 6");
                Console.WriteLine("Çıkış için                   : ESC");

                Console.WriteLine("Tuşlardan birine basınız.");
                var basilanTus = Console.ReadKey();
                if (basilanTus.Key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("Lütfen Eklemek istediğiniz öğrenci için;");
                    Console.Write("Ad Soyad giriniz : ");
                    string ad = Console.ReadLine();

                    Console.Write("Öğrenci numarasını giriniz : ");
                    string ogrNO = Console.ReadLine();

                    Console.Write("Adresini giriniz : ");
                    string adres = Console.ReadLine();

                    Console.Write("GSM numarasını giriniz : ");
                    string gsm = Console.ReadLine();

                    Console.Write("Sınıfını giriniz : ");
                    int sinif = Convert.ToInt32(Console.ReadLine());

                    yeniOkul.ogrenciEkle(ad, ogrNO, sinif, gsm, adres);
                    Console.WriteLine("Öğrenci Başarıyla Eklendi.");

                }
                else if (basilanTus.Key == ConsoleKey.NumPad2)
                {
                    yeniOkul.ogrenciListele();
                }
                else if (basilanTus.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (basilanTus.Key == ConsoleKey.NumPad3)
                {
                    yeniOkul.ogrenciListele();
                    Console.Write("Lütfen Silmek istediğiniz öğrencinin numarasını giriniz : ");
                    string ogrNo = Console.ReadLine();
                    yeniOkul.ogrenciSil(ogrNo);
                }
                else if (basilanTus.Key == ConsoleKey.NumPad4)
                {
                    Console.WriteLine("Eklemek İstediğiniz Öğretmen için;");
                    
                    Console.Write("Adı-Soyadı : ");
                    string ad = Console.ReadLine();

                    Console.Write("Eğitmen Numarası : ");
                    string egitmenNo = Console.ReadLine();

                    Console.Write("Mail adresi : ");
                    string mail = Console.ReadLine();

                    Console.Write("Okulda verdiği ders sayısı : ");
                    int dersSayisi = Convert.ToInt32(Console.ReadLine());

                    yeniOkul.hocaEkle(ad, egitmenNo, mail, dersSayisi);
                    Console.WriteLine("Öğretmen Başarıyla Eklendi.");
                }
                else if (basilanTus.Key == ConsoleKey.NumPad5)
                {
                    yeniOkul.HocalariListele();
                    Console.WriteLine("Silmek istediğiniz eğitmenin numarasını giriniz : ");
                    string egitmenNo = Console.ReadLine();
                    yeniOkul.HocaSil(egitmenNo);

                    Console.WriteLine("Eğitimci Başarıyla silindi.");
                }
                else if (basilanTus.Key == ConsoleKey.NumPad6)
                {
                    yeniOkul.HocalariListele();
                }
                else if (basilanTus.Key == ConsoleKey.NumPad7)
                {
                        Console.WriteLine("Adını değiştirmek istediğiniz öğrencinin numarasını giriniz : ");
                        string ogrNo = Console.ReadLine();

                        Console.WriteLine("Yeni adı giriniz : ");
                        string ad = Console.ReadLine();

                        yeniOkul.ogrenciGuncelle(ogrNo, ad);
                }
                else
                {
                    Console.WriteLine("Doğru kodlama yapınız!");
                }

                Console.WriteLine("Devam etmek için bir tuşa basınız.");
                Console.ReadKey();
            }
        }
    }
}
