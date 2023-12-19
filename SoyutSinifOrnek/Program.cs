using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapDergiOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap = new Kitap();
            kitap.Adi = "Suç Ve Ceza";
            kitap.Yazarı = "Dostoyevski";
            kitap.SayfaSayısı = 704;
            kitap.BasımTarihi = "Aralık 1866";
            kitap.Konusu = "Rodion Romanoviç Raskolnikov adındaki bir gencin işlediği çifte cinayet üzerine yaşadıklarını konu alıyor.";
            kitap.Türü = "Psikolojik Kurgu";
            kitap.Oku();
        }
    }
    public class Ortak
    {
        public int SayfaSayısı { get; set; }
        public string Yazarı { get; set; }
        public string BasımTarihi { get; set; }
        public string Konusu { get; set; }
        public string Adi { get; set; }
        public abstract void Oku();
    }
    public class Kitap : Ortak
    {
        public string Türü { get; set; }
        public override void Oku()
        {
            Console.WriteLine("Sayfa Sayısı: {0}", SayfaSayısı);
            Console.WriteLine("Yazarı: {0}", Yazarı);
            Console.WriteLine("Basım Tarihi: {0}", BasımTarihi);
            Console.WriteLine("Konusu: {0}", Konusu);
            Console.WriteLine("Adı: {0}", Adi);
            Console.WriteLine("Kitabın Türü: {0}", Türü);
        }
    }
    public class Dergi : Ortak
    {
        public ushort sayino { get; set; }
        public override void Oku()
        {
            Console.WriteLine("Sayfa Sayısı: {0}", SayfaSayısı);
            Console.WriteLine("Yazarı: {0}", Yazarı);
            Console.WriteLine("Basım Tarihi: {0}", BasımTarihi);
            Console.WriteLine("Konusu: {0}", Konusu);
            Console.WriteLine("Adı: {0}", Adi);
            Console.WriteLine("Dergi No: {0}");
        }
    }
    public class Ansiklopedi : Ortak
    {
        public string Bilgi { get; set; }
        public override void Oku()
        {
            Console.WriteLine("Sayfa Sayısı: {0}", SayfaSayısı);
            Console.WriteLine("Yazarı: {0}", Yazarı);
            Console.WriteLine("Basım Tarihi: {0}", BasımTarihi);
            Console.WriteLine("Konusu: {0}", Konusu);
            Console.WriteLine("Adı: {0}", Adi);
            Console.WriteLine("Verdigi Bilgi: {0}", Bilgi);
        }
    }
}