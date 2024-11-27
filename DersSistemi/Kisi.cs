abstract class Kisi : IKisi
{
    public string Isim { get; set; }

    public virtual void BilgiGoster()
    {
        Console.WriteLine($"İsim: {Isim}");
    }
}