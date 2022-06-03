using System;

class Bitkiler:Canlılar
{
    public Bitkiler()
    {
        base.Beslenme();
        base.Çoğalmak();
    }

    protected void Fotosentez()
    {
        Console.WriteLine("Bitkiler fotosentez yapar.");
    }
}

class ÇoğalanOt:Bitkiler
{
    public Ot()
    {
        base.Fotosentez();
        base.Çoğalmak();
    }
}
class ÇoğalmayanOt:Bitkiler
{
    public Ot()
    {
        base.Fotosentez;
        base.
    }
}