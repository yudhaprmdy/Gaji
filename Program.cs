using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2262
{
    class Program
    {
       

        public static float V1 { get; private set; }

        static void Main(string[] args)
        {
            Karyawan kry1 = new Karyawan();

            kry1.NIK = "18.11.2262";
            kry1.Nama = "Indie Yudha";
            kry1.GajiBulanan = 3000000;

            Karyawan kry2 = new Karyawan();

            kry2.NIK = "400042321";
            kry2.Nama = "Upin Astronot";
            kry2.GajiBulanan = 2000000;

            Console.WriteLine("No.\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1.\t{0} {1}\t\t{2}", kry1.NIK, kry1.Nama, kry1.GajiBulanan);
            Console.WriteLine("2.\t{0} {1}\t\t{2}", kry2.NIK, kry2.Nama, kry2.GajiBulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("Asik nai gaji 10 % hore");
            Console.WriteLine("\n");

            Console.WriteLine("No.\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1.\t{0} {1}\t\t{2}", kry1.NIK, kry1.Nama, kry1.GajiBulanan + (kry1.GajiBulanan * 0.10));
            Console.WriteLine("2.\t{0} {1}\t\t{2}", kry2.NIK, kry2.Nama, kry2.GajiBulanan + (kry2.GajiBulanan * 0.10));
            Console.ReadKey();






        }
    }
}
