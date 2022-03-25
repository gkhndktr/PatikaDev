using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen = new Dikdörtgen();

            dikdörtgen.KısaKenar = 3;
            dikdörtgen.UzunKenar = 4;
            Console.WriteLine("Dikdörtgen alanı {0}", dikdörtgen.AlanHesapla());


            DikdörtgenStruct DikdörtgenStruct = new DikdörtgenStruct();

            DikdörtgenStruct.KısaKenar = 3;
            DikdörtgenStruct.UzunKenar = 4;
            Console.WriteLine("Dikdörtgen alanı {0}", DikdörtgenStruct.AlanHesapla());

        }
    }

    class Dikdörtgen
    {
        public int KısaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KısaKenar * this.UzunKenar;
        }
    }

    struct DikdörtgenStruct
    {
        public int KısaKenar;
        public int UzunKenar;
        public DikdörtgenStruct(int KısaKenar, int UzunKenar)
        {
            this.KısaKenar = KısaKenar;
            this.UzunKenar = UzunKenar;
        }
        public long AlanHesapla()
        {
            return this.KısaKenar * this.UzunKenar;
        }
    }
}
