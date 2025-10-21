using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilai_Rata_rata_Ridwan_XPPLG2
{
    internal class Program
    {
        static double RataRata(double nilai1, double nilai2, double nilai3)
        {
            double hasil = (nilai1 + nilai2 + nilai3) / 3;
            return hasil;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Menghitung Rata-rata nilai");

            Console.Write("Masukkan Nilai Pertama : ");
            double nilai1 = double.Parse(Console.ReadLine());

            Console.Write("Masukkan Nilai Kedua   : ");
            double nilai2 = double.Parse(Console.ReadLine());

            Console.Write("Masukkan Nilai Ketiga  : ");
            double nilai3 = double.Parse(Console.ReadLine());

            double hasil = RataRata(nilai1, nilai2, nilai3);
            Console.WriteLine("Rata-rata Nilai = " + hasil);


        }
    }
}
