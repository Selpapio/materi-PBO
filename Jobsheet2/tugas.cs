using System;

namespace PenjadwalanKonsultasiDokter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat datang di Layanan Konsultasi Dokter!");
            Console.Write("Masukkan nama dokter yang ingin dikonsultasikan: ");
            string namaDokter = Console.ReadLine();

            Console.Write("Masukkan tanggal konsultasi: ");
            string tanggalKonsultasi = Console.ReadLine();

            Console.Write("Masukkan jam konsultasi: ");
            string jamKonsultasi = Console.ReadLine();

            Console.WriteLine("Konsultasi dengan dokter " + namaDokter + " pada tanggal " + tanggalKonsultasi + " jam " + jamKonsultasi);
        }
    }
}