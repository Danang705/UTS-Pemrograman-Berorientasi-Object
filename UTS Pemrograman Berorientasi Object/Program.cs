using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UTS_Pemrograman_Berorientasi_Object
{
    class Book 
    {
        private string ID;
        private string Judul;
        private string Penulis;
        private int Tahun_terbit;
        private string Status;
        
       
        public string id
        {
            get { return ID; }
            set { string id = value; }
        }
        public string judul
        {
            get { return judul; }
            set { string judul = value; }

        }
        public int tahun_terbit
        {
            get { return Tahun_terbit; }
            set { int tahun_tebit = value; }
        }
        public string penulis
        {
            get { return Penulis; }
            set { string penulis = value; }
        }

        public string status
        {
            get { return Status; }
            set { string status = value; }
        }

        


        public Book(string Id, string judul, int tahun_terbit, string status)
        {
            this.ID = Id;
            this.Judul = judul;
            this.Tahun_terbit = tahun_terbit;
            this.Status = status;

        }



    }

    //class Perpustakaan
    //{
    //    public string Judul;
    //    public string Nama_perpus;
    //    public string Alamat_perpus;
    //}







    class Program
    {
        public static void Main()
        {
            Book Bumi = new Book("20", "bumi", 2014, "tersedia");
            Book Bulan = new Book("20", "bumi", 2014, "tersedia");



            Console.WriteLine("Menu");
            Console.WriteLine("1. Menambah Buku");
            Console.WriteLine("2. Cari Buku");
            Console.WriteLine("3. Update Info Buku");
            Console.WriteLine("4. Hapus Buku");
            Console.Write("Masukkan Pilihan: ");

            string Menu = Console.ReadLine();
            if (Menu == "2")
            {

                Console.WriteLine("Pilih Buku");

                string pilih = Console.ReadLine();

                if (pilih == "1")
                {
                    Console.WriteLine("Id buku : " + Bumi.id);
                    Console.WriteLine("Judul Buku : " + Bumi.judul);
                    Console.WriteLine("Tahun Terbit Buku : " + Bumi.tahun_terbit);
                    //Console.WriteLine("Penulis : " + Bumi.penulis);
                    Console.WriteLine("Setatus : " + Bumi.status);
                }
                if (pilih == "2")
                {
                    Console.WriteLine("Id buku : " + Bulan.id);
                    Console.WriteLine("Judul Buku : " + Bulan.judul);
                    Console.WriteLine("Tahun Terbit Buku : " + Bulan.tahun_terbit);
                    //Console.WriteLine("Penulis : " + Bumi.penulis);
                    Console.WriteLine("Setatus : " + Bulan.status);
                }
            }
                
            
        }
    }
}


