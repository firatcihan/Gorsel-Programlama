class Ders
{
    public string DersAdi { get; set; }
    public int Kredi { get; set; }
    public OgretimGorevlisi OgretimGorevlisi { get; set; }
    public List<Ogrenci> KayitliOgrenciler { get; set; }

    public Ders()
    {
        KayitliOgrenciler = new List<Ogrenci>();
    }

    public void OgrenciKaydet(Ogrenci ogrenci)
    {
        KayitliOgrenciler.Add(ogrenci);
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"Ders Adı: {DersAdi}, Kredi: {Kredi}");
        Console.WriteLine("Öğretim Görevlisi Bilgileri:");
        OgretimGorevlisi.BilgiGoster();
        Console.WriteLine("Kayıtlı Öğrenciler:");
        foreach (var ogrenci in KayitliOgrenciler)
        {
            ogrenci.BilgiGoster();
        }
    }
}