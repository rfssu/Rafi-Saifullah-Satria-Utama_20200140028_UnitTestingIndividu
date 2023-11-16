using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUAS1
{
    public class administrasi
    {
        public void admsekolah()
        {
            Console.Write("Masukkan Nama Sekolah");
            Console.ReadLine();
            Console.Write("Masukkan Nama Siswa");
            Console.ReadLine();
            Console.Write("Masukkan Kelas");
            Console.ReadLine();
            Console.Write("Masukkan Nama Wali Kelas");
            Console.ReadLine();
            Console.Write("Masukkan Jenis Kelamin");
            Console.ReadLine();
            Console.Write("Masukkan Alamat Siswa");
            Console.ReadLine();
        }
    }
     class program
    {
        static void Main(string[]args)
        {
            //deklarasikan variabel untuk menyimpan kalimat
            string sekolah,nis, nama, kelas,walikelas,jeniskelamin,alamat;

            //deklarasi variabel untuk memberi nama file
            string namaFile;

            try
            {
                //menuliskan nama file
                Console.Write("Nama File : ");

                //membaca nama file dan disimpan di variabel nama file
                namaFile = Console.ReadLine();

                //deklarasi string untuk menyimpan path di drive C pada folder mydocument
                string path = Environment.GetFolderPath
                    (Environment.SpecialFolder.MyDocuments);

                //Lewatkan folder dan nama file yang digunakan untuk menyimpan data di drive C
                StreamWriter sw = new StreamWriter(Path.Combine(path, $"{namaFile}.txt"));

                //Lewatkan folder dan nama file yang digunakan untuk menyimpan data di drive D
                //StreramWriter sw = new StreamWriter("D:\\" + namaFile + ".txt");


                //Menuliskan Nama Sekolah
                Console.Write("Nama Sekolah = ");
                sekolah = Console.ReadLine();
                //Menuliskan NIM
                Console.Write("NIS= ");

                //membaca input dari user dan disimpan pada variabel nim
                nis = Console.ReadLine();

                //Menuliska nama
                Console.Write("Nama = ");

                //membaca input dari user dan disimpan pada variabel nama
                nama = Console.ReadLine();

                //Menuliskan kelas
                Console.Write("kelas = ");

                //membaca input dari user disimpan pada variabel kelas
                kelas = Console.ReadLine();

                //Menuliskan WaliKelas
                Console.Write("Wali Kelas = ");

                //membaca input dari user disimpan pada variabel kelas
                walikelas = Console.ReadLine();

                //Menuliskan jeniskelamin
                Console.Write("Jenis Kelamin = ");

                //membaca input dari user disimpan pada variabel kelas
                jeniskelamin = Console.ReadLine();

                //Menuliskan alamat
                Console.Write("Alamat = ");

                //membaca input dari user disimpan pada variabel kelas
                alamat = Console.ReadLine();

                sw.WriteLine($"=====================");


                //Tulis sekolah kedalam file
                sw.WriteLine($"Selamat Datang di {sekolah}");

                sw.WriteLine($"=====================");

                //Tulis nim tersebut kedalam file
                sw.WriteLine($"Nomor Induk Siswa = {nis}");

                //Tulis nama tersebut kedalam file 
                sw.WriteLine($"Nama Siswa        = {nama}");

                //Tulis kelas tersebut kedalam file
                sw.WriteLine($"Kelas             = {kelas}");

                //Tulis jenis kelamin tersebut kedalam file
                sw.WriteLine($"Jenis Kelamin     = {jeniskelamin}");

                //Tulis alamat tersebut kedalam file
                sw.WriteLine($"Alamat            = {alamat}");

                //Tulis walikelas tersebut kedalam file
                sw.WriteLine($"Wali Kelas        = {walikelas}");

                //Tutup file nya
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}