class Ogrenci : Kisi
{
    public string OgrenciNo { get; set; }

    public override void BilgiGoster()
    {
        Console.WriteLine($"İsim: {Isim}, Öğrenci Numarası: {OgrenciNo}");
    }
}