namespace Kalkulator
{
    class Program
    {
        static void Main()
        {
            int aksi = 1;
            int angka1, angka2, hasil;
            string pertama = "pertama", kedua = "kedua";
            do
            {
                Console.WriteLine("Pilihan Aksi yang bisa dilakukan: ");
                Console.WriteLine("1. Tambah");
                Console.WriteLine("2. Kurang");
                Console.WriteLine("3. Kali");
                Console.WriteLine("4. Bagi");
                Console.WriteLine("0. Keluar");
                Console.Write("Pilih Aksi : ");
                aksi = int.Parse(Console.ReadLine());

                switch (aksi)
                {
                    case 1:
                        // Console.Write("Masukkan angka pertama : ");
                        // angka1 = int.Parse(Console.ReadLine());
                        // Console.Write("Masukkan angka kedua : ");
                        // angka2 = int.Parse(Console.ReadLine());
                        angka1 = MemasukkanAngka(pertama);
                        angka2 = MemasukkanAngka(kedua);
                        hasil = angka1 + angka2;
                        Console.WriteLine($"Hasilnya adalah {hasil}");
                        break;
                    case 2:
                        // Console.Write("Masukkan angka pertama : ");
                        // angka1 = int.Parse(Console.ReadLine());
                        // Console.Write("Masukkan angka kedua : ");
                        // angka2 = int.Parse(Console.ReadLine());
                        angka1 = MemasukkanAngka(pertama);
                        angka2 = MemasukkanAngka(kedua);
                        hasil = angka1 - angka2;
                        Console.WriteLine($"Hasilnya adalah {hasil}");
                        break;
                    case 3:
                        // Console.Write("Masukkan angka pertama : ");
                        // angka1 = int.Parse(Console.ReadLine());
                        // Console.Write("Masukkan angka kedua : ");
                        // angka2 = int.Parse(Console.ReadLine());
                        angka1 = MemasukkanAngka(pertama);
                        angka2 = MemasukkanAngka(kedua);
                        hasil = angka1 * angka2;
                        Console.WriteLine($"Hasilnya adalah {hasil}");
                        break;
                    case 4:
                        // Console.Write("Masukkan angka pertama : ");
                        // angka1 = int.Parse(Console.ReadLine());
                        // Console.Write("Masukkan angka kedua : ");
                        // angka2 = int.Parse(Console.ReadLine());
                        angka1 = MemasukkanAngka(pertama);
                        angka2 = MemasukkanAngka(kedua);
                        hasil = angka1 / angka2;
                        Console.WriteLine($"Hasilnya adalah {hasil}");
                        break;
                    case 0:
                        Console.WriteLine($"Terima kasih sudah memakai kalkulator ini!");
                        break;
                    default:
                        Console.WriteLine($"Aksi Tidak Valid");
                        break;

                }
                Console.WriteLine("\n");
            } while(aksi != 0);
            Console.Read();
        }

        static int MemasukkanAngka(string urutan)
        {
            Console.Write($"Masukkan angka {urutan} : ");
            int nilaiAngka = int.Parse(Console.ReadLine());
            return nilaiAngka;
        }          
    }
}