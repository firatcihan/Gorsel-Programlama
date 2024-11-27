class OgretimGorevlisi : Kisi
{
    public string Bolum { get; set; }

    public override void BilgiGoster()
    {
        Console.WriteLine($"İsim: {Isim}, Bölüm: {Bolum}");
    }
}