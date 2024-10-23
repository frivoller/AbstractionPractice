using System;

// abstract base class
abstract class Calisan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Departman { get; set; }

    // constructor
    public Calisan(string ad, string soyad, string departman)
    {
        Ad = ad;
        Soyad = soyad;
        Departman = departman;
    }

    public abstract void Gorev();
}

// yazilim gelistirici sinifi
class YazilimGelistirici : Calisan
{
    public YazilimGelistirici(string ad, string soyad, string departman)
        : base(ad, soyad, departman) { }

    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad}, yazılım geliştiricisi olarak çalışıyorum.");
    }
}

// proje yoneticisi sinifi
class ProjeYoneticisi : Calisan
{
    public ProjeYoneticisi(string ad, string soyad, string departman)
        : base(ad, soyad, departman) { }

    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad}, proje yöneticisi olarak çalışıyorum.");
    }
}

// satis temsilcisi sinifi
class SatisTemsilcisi : Calisan
{
    public SatisTemsilcisi(string ad, string soyad, string departman)
        : base(ad, soyad, departman) { }

    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad}, satış temsilcisi olarak çalışıyorum.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // calisan ornekleri
        Calisan yazilimci = new YazilimGelistirici("Hürrem", "Sultan", "IT");
        Calisan projeYoneticisi = new ProjeYoneticisi("Cevriye", "Ördek", "Yönetim");
        Calisan satisTemsilcisi = new SatisTemsilcisi("İsa", "Kel", "Satış");

        // gorevlerini gerceklestirme
        yazilimci.Gorev();
        projeYoneticisi.Gorev();
        satisTemsilcisi.Gorev();
    }
}
