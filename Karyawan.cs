using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2262
{
    public class Karyawan
    {
        
        public string NIK { get; set; }
        public string Nama { get; set; }
        public int  GajiBulanan { get; set; }

        public Karyawan(string nik, string nama, int gajibulanan)
        {
            if (gajibulanan < 0)
            {
                Console.WriteLine("Gaji harus di atas 0 !!!!!!!!!!!!!!!!!!!!!!");
            }

            else
            {
                NIK = nik;
                Nama = nama;
                GajiBulanan = gajibulanan;
            }
        }

        public Karyawan()
        {
        }
    }
}
