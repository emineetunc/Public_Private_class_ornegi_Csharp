using System;

namespace Odev
{
    internal class Ogrenci
    {
        private int Ogrenci_No;
        private string Isım;
        private string Soyısım;
        private string okulısmı;
        private int vize1;
        private int vize2;
        private int final;
       
        public Ogrenci(int Ogrenci_No, string Isım, string Soyısım, string okulısmı, int vize1, int vize2, int final)
        {
            this.Ogrenci_No = Ogrenci_No; //“this” anahtar kelimesi, ilgili nesnenin referansını belirtmek için kullanılır.
            this.Isım = Isım;
            this.Soyısım = Soyısım;
            this.okulısmı = okulısmı;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
        }
        public void Ogrenci_Bilgilerini_Goster()
        {
            Console.WriteLine("Öğrenci numarası: {0}\nÖğrenci ad soyadı: {1} {2}", Ogrenci_No, Isım, Soyısım);
        }

        public void Ortalama_Bul()
        {
            int vizeort = (vize1 + vize2) / 2;
            int ort = Convert.ToInt32(vizeort * 0.4 + final * 0.6);
            Console.WriteLine("Öğrencinin ortalaması: " + ort);
        }

        public void Okulunu_Goster()
        {
            Console.WriteLine("Öğrencinin Okulu: "  + okulısmı);
        }

         public void cıkıs_yap()
        {
            Console.WriteLine("çıkış yapıldı " );
        }
    }
}
