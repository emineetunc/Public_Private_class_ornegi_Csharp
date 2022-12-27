using System;


namespace Odev

{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci (456, "Emine", "Tunç", "karabük Üniversitesi", 25, 85, 70);

            


            while (true)
            {
                Console.WriteLine("\nBirini Seçiniz: \n1) Öğrenci bilgileri Göster\n2) Öğrencinin ortalamasını Göster \n3) Öğrencinin okulunu Göster\n4) Çıkış Yap \n\n\n\nTERCİHİNİZ:");
                int Kullanıcı_Girisi = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine("\n\t");

                switch (Kullanıcı_Girisi)
                {
                    case 1:
                        ogr.Ogrenci_Bilgilerini_Goster();
                        break;
                    case 2:
                        ogr.Ortalama_Bul();
                        break;
                    case 3:
                        ogr.Okulunu_Goster();
                        break;
                    case 4:
                        ogr.cıkıs_yap();
                        break;
                    default:
                        Console.WriteLine("hatalı tercih!");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? eğer istiyorsanız -a- tuşuna basınız.Eğer istemiyorsanız herhangi bir tuş ile çıkış yapınız. ");
                string Kontrol = Console.ReadLine();

                if (Kontrol != "a")
                    break;
                Console.WriteLine();
            }
            
        }
    }
}