using kpl_jurnalmodul4_2311104058;

class Program
{
    static void Main()
    {
        KodeBuah kb = new KodeBuah();
        Console.Write("Masukkan nama buah: ");
        string namaBuah = Console.ReadLine();
        Console.WriteLine("Kode Buah: " + kb.getKodeBuah(namaBuah));
    }
}
