using System;
using Modul4_103022400062;

class Program
{
    static void Main(string[] args)
    {
        KodePaket kp = new KodePaket();
        Console.WriteLine("Masukkan nama Paket: ");

        string nama = Console.ReadLine();
        string kode = kp.getKodePaket(nama);

        Console.WriteLine("Kode Paket: " + kode);

    MesinKopi kopi = new MesinKopi();
        kopi.PowerOn();
        kopi.StartBrew();
        kopi.FinishBrew();
        kopi.StartMaintenance();
        kopi.FinishMaintenance();
        kopi.PowerOff();

    }

}