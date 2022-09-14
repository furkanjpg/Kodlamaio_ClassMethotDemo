using System;

namespace Kodlamaio_ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tekrar programın başına dönebilmek için basadon: adında bir etiket bıraktık (buna goto etiketiyle dönüyoruz)
            basadon:
            // Müşterilerimizin bilgilerini Customer musteri* şeklinde bizim oluşturduğumuz Customer adındaki değişkenimiz ile oluşturduk
            Customer musteri1 = new Customer();
            musteri1.Id = 1;
            musteri1.Name = "Sibel";
            musteri1.SurName = "Akçalı";
            musteri1.Money = 12500;
            musteri1.BankAccountNo = 2789546;

            Customer musteri2 = new Customer();
            musteri2.Id = 2;
            musteri2.Name = "Hakan";
            musteri2.SurName = "Altintop";
            musteri2.Money = 22120;
            musteri2.BankAccountNo = 7538654;

            Customer musteri3 = new Customer();
            musteri3.Id = 3;
            musteri3.Name = "Buse";
            musteri3.SurName = "Bozkurt";
            musteri3.Money = 640;
            musteri3.BankAccountNo = 5675867;

            Customer musteri4 = new Customer();
            musteri4.Id = 4;
            musteri4.Name = "Ahmet";
            musteri4.SurName = "Han";
            musteri4.Money = 2700;
            musteri4.BankAccountNo = 4754894;

            // Kullanıcıdan islem adında bir değişken oluşturup ona bir değer girmesini istedik.
            // Girilen değere göre aşağıda ki if bloğuyla Ekle Listele Sil değişkenlerini yazdırdık
            Console.WriteLine("[1] Update | [2] List | [3] Delete: ");
            int islem = Convert.ToInt16(Console.ReadLine());

            if (islem == 1)
            {
                // Consoldaki gereksiz yazıları temizledik
                Console.Clear();
                //RANDOM SAYI ÜRETEREK HER TIKLANDIĞINDA O RANDOM SAYISINA KARŞILIK GELEN SAYI İLE EŞLEŞEN MÜŞTERİYİ YAZDIRDIK
                Random rastgele = new Random();
                int sayi = rastgele.Next(3);
                CustomerManager customerManagerEkle = new CustomerManager();
                if (sayi == 0)
                    customerManagerEkle.Ekle(musteri1);
                else if (sayi == 1)
                    customerManagerEkle.Ekle(musteri2);
                else if (sayi == 2)
                    customerManagerEkle.Ekle(musteri3);
                else if (sayi == 3)
                    customerManagerEkle.Ekle(musteri4);
            }
            else if (islem == 2)
            {
                // Consoldaki gereksiz yazıları temizledik
                Console.Clear();
                Customer[] customers = new Customer[] { musteri1,musteri2,musteri3,musteri4};
                foreach (var musteriler in customers)
                {
                    Console.WriteLine("Müşteri Adı: " + musteriler.Name + " Müşteri Soyadı: " + musteriler.SurName + " Müşteri No: " +musteriler.BankAccountNo);
                }
            }
            else if (islem == 3)
            {
                // Consoldaki gereksiz yazıları temizledik
                Console.Clear();
                // Sayi adındaki bir değişkene, random sayı oluşturduk rastgele.Next(3) yi atadığımız değer 0,3 arasında değer üretti
                // ve ekrana o değere eşdeğer bilgiyi random olarak yazdırdık
                Random rastgele = new Random();
                int sayi = rastgele.Next(3);
                CustomerManager customerManagerSil = new CustomerManager();
                if (sayi == 0)
                    customerManagerSil.Sil(musteri1);
                else if (sayi == 1)
                    customerManagerSil.Sil(musteri2);
                else if (sayi == 2)
                    customerManagerSil.Sil(musteri3);
                else if (sayi == 3)
                    customerManagerSil.Sil(musteri4);
            }
            else
            {
                // consol'a yanlış bir sayı girilmesi durumunda hata mesajı verdirdik
                Console.WriteLine(" Yanlış bir sayı girdiniz! ");
            }

            // İşlemler bittikten sonra müşteriye geri dönmek isterse 0 tuşunu girerek dönebilmesi için kullanıcıdan bilgi aldık
            int returnbasadon=0;
            Console.WriteLine("\n--------------------------------\nBaşa dönmek için [0]'ı tuşlayınız.");
            returnbasadon = Convert.ToInt16(Console.ReadLine());
            if (returnbasadon == 0)
            {
                Console.Clear();
                //goto basadon; komutuyla programın başına geri döndük
                goto basadon;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yanlış bir sayı girdiniz. Program kapanıyor..");
            }
 
            Console.ReadKey();
        }

    }
}
