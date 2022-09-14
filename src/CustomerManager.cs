using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_ClassMethotDemo
{
    class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine("Müşteri Hesabınız Başarıyla Eklendi");
            Console.WriteLine("Eklenen Müşteri" + " : " + customer.Name + " " + customer.SurName + "| Müşteri No: " + customer.BankAccountNo);
            }
            public void Listele(Customer customer)
        {
            // Customer array'i oluşturup onu customers'a atadık ve {}içerisinde customer metotdan aldığımız Customer değişkenlerini atadık
            Customer[] customers = new Customer[] { customer };
            foreach (var musteri in customers)
            {
                Console.WriteLine("Müşteri Hesapları Başarıyla Listelendi!");
                Console.WriteLine(musteri.Name + " " + musteri.SurName);
                Console.WriteLine("----------------------------------");
            }
        }
        public void Sil(Customer customer)
        {
            // Customer array'i oluşturup onu customers'a atadık ve {}içerisinde customer metotdan aldığımız Customer değişkenlerini atadık
            Customer[] customers = new Customer[] { customer };
            // Tüm değişkenleri array'den çekerek işlem yaptık
            foreach (var musteri in customers)
            {
                Console.WriteLine("Kaldırılan Müşteri Hesabı : " + musteri.Name + " " + musteri.SurName);
            }
            Console.WriteLine("Müşteri Hesabı Başarıyla Kaldırıldı !\n-------------------------------------\nParanızı en yakın şubeden teslim alabilirsiniz.");
        }
    }
}
