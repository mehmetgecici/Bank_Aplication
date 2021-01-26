using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager m1 = new MusteriManager();

            
            Console.WriteLine("Banka işlemlerinden Müşteri eklemek için 1'i Silmek için 2'yi Listelemek için 3'ü" +
                "çıkmak için 0'ı tuşlayınız");
            int select = Convert.ToInt32(Console.ReadLine());
            while(select != 0)
            {
                if(select == 1)
                {
                    m1.add_Musteri();
                }

                if (select == 2)
                {
                    m1.remove();
                }

                if (select == 3)
                {
                    m1.show_Musteri();
                }
                Console.WriteLine("Banka işlemlerinden Müşteri eklemek için 1'i Silmek için 2'yi Listelemek için 3'ü" +
                "çıkmak için 0'ı tuşlayınız");
                select = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
