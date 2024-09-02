using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Pembelian Tiket Bioskop ===");
        
        // Daftar film dan harga
        string film = "Film A";
        int hargaTiket = 35000;

        // Tampilkan film dan harga
        Console.WriteLine("Film: " + film + " - Harga: Rp" + hargaTiket);
        // Input jumlah tiket
        Console.Write("Masukkan jumlah tiket: ");
        int jumlahTiket = int.Parse(Console.ReadLine());

        // Hitung total harga
        int totalHarga = jumlahTiket * hargaTiket;
        Console.WriteLine("Total Harga: Rp" + totalHarga);

        Console.WriteLine("Terima kasih!");
    }
}