using kpl_jurnalmodul4_2311104058;

class Program
{
    static void Main()
    {
        KodeBuah kb = new KodeBuah();
        Console.Write("Masukkan nama buah: ");
        string namaBuah = Console.ReadLine();
        Console.WriteLine("Kode Buah: " + kb.getKodeBuah(namaBuah));

        Console.WriteLine();

        Console.Write("Masukkan NIM: ");
        long nim = long.Parse(Console.ReadLine());

        PosisiKarakterGame karakter = new PosisiKarakterGame(nim);

        karakter.TombolS();
        karakter.PrintState();

        karakter.TombolS();
        karakter.PrintState();

        karakter.TombolW();
        karakter.PrintState();

        karakter.TombolX();
        karakter.PrintState();
    }
}
