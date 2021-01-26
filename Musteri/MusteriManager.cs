using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       static List<Musteri> Musteriler = new List<Musteri>();
       public void add_Musteri()
        {
            Musteri p1 = new Musteri();

            Console.WriteLine("Müşteri id giriniz : ");
            p1.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Müşteri adını giriniz : ");
            p1.name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Müşteri Soyadını giriniz : ");
            p1.surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Müşteri ülkesini giriniz : ");
            p1.surname = Convert.ToString(Console.ReadLine());
            Musteriler.Add(p1);
            
        }

        public void show_Musteri()
        {
            foreach (var obj in Musteriler)
            {
                Console.WriteLine(obj.id + " Numaralı "+obj.name+" "+ obj.surname + " "+obj.country + "ülkesinden");
            }
        }

        public void remove()
        {
            Console.WriteLine("Silmek istediğiniz müşterinin sırasını giriniz : ");
            int index=Convert.ToInt32(Console.ReadLine());
            Musteriler.RemoveAt(index-1);
            
        }
    }
}
