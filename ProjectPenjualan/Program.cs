using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<string> daftarPenjualan = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Write("\nPilih Menu Aplikasi");
            Console.Write("\n");
            Console.Write("\n1. Tambah Penjualan");
            Console.Write("\n2. Tampilkan Penjualan");
            Console.Write("\n3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Penjualan();

            Console.Write("\nNota: ");
            penjualan.Nota = Console.ReadLine();
            Console.Write("\nTanggal: ");
            penjualan.Tanggal = Console.ReadLine();
            Console.Write("\nCustomer : ");
            penjualan.Customer = Console.ReadLine();
            Console.Write("\nJenis [T/K] : ");
            penjualan.Jenis = Console.ReadLine();
            Console.Write("\nTotal Nota : ");
            penjualan.TotalNota = Console.ReadLine();


            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.WriteLine("\nData Penjualan");
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                string jenisAkhir;
                Console.WriteLine("1. {0}, {1}, {2}, {3}, {4}", penjualan.Nota, penjualan.Tanggal, penjualan.Customer, penjualan.Jenis, penjualan.TotalNota);
                Console.WriteLine("\n");
            }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
