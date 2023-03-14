using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activ1
{

    class Rerata
    {
        /// <summary>
        /// deklarasi parameter nilaiMTK dan nilaiInggris, dan juga rerata
        /// </summary>
        double nilaiMTK, nilaiInggris, rerata;

        public void inputData()
        {
            ///proses input data matematika
            Console.Write("Masukan Nilai Matematika = ");
            ///convert data matematika
            nilaiMTK = Convert.ToDouble(Console.ReadLine());
            ///proses input data inggris
            Console.Write("Masukan Nilai Bahasa Inggris = ");
            ///convert data inggris
            nilaiInggris = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// metode function rumus
        /// </summary>
        /// <returns></returns>
        public double rumus()
        {
            ///rumus rerata
            rerata = (nilaiMTK + nilaiInggris) / 2;
            return rerata;
        }

        /// <summary>
        /// materiutama output
        /// </summary>
        public void output()
        {
            ///decision making dengan operator
            if (rumus() >= 80)
            {
                ///decision jika mendapatkan nilai lebih dari 80 akan mendapat nilai A
                Console.WriteLine("Nilai rerata = " + rumus());
                Console.WriteLine("Anda Mendapatkan Nilai A");
            }
            else if (rumus() < 80 && rumus() >= 70)
            {
                ///decision jika mendapatkan nilai lebih dari 70 dan kurang dari 80 akan mendapat nilai B
                Console.WriteLine("Nilai rerata = " + rumus());
                Console.WriteLine("Anda Mendapatkan Nilai B");
            }
            else if (rumus() < 70 && rumus() >= 60)
            {
                ///decision jika mendapatkan nilai lebih dari 60 dan kurang dari 70 akan mendapat nilai C
                Console.WriteLine("Nilai rerata = " + rumus());
                Console.WriteLine("Anda Mendapatkan Nilai C");
            }
            else
            {
                ///dan jika mendapat nilai selain itu mendapat nilai D
                Console.WriteLine("Nilai rerata = " + rumus());
                Console.WriteLine("Anda Mendapatkan Nilai D");
            }
        }

        internal class Program
        {
            /// <summary>
            /// memanggil method dari setiap class yang ada
            /// </summary>
            /// <param name="args"></param>
            static void Main(string[] args)
            {
                ///untuk menampilkan hasil index rerata
                Rerata index = new Rerata();
                ///untuk menampilkan index input data sehigga user dapat menginput data
                index.inputData();
                ///untuk menjalankan program yg dibuat
                index.rumus();
                ///untuk menampilkan hasil output sehingga user dapat mengetahui hasilnya
                index.output();


                Console.ReadLine();
            }
        }
    }
}