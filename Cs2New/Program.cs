// Komentar: Program ini menerapkan berbagai konsep dasar dalam pemrograman C#

// Deklarasi variabel dan tipe data

int jumlahSiswa;
Console.Write("Masukan jumlah siswa: ");
jumlahSiswa = Convert.ToInt32(Console.ReadLine());

int[] umurArray = new int[jumlahSiswa]; // Array untuk menyimpan umur beberapa orang
double[] tinggiArray = new double[jumlahSiswa]; // Array untuk menyimpan tinggi beberapa orang
string[] namaArray = new string[jumlahSiswa]; // Array untuk menyimpan nama beberapa orang
bool[] isSiswaArray = new bool[jumlahSiswa]; // Array untuk menyimpan status siswa beberapa orang

// Inputan dari pengguna
for (int i = 0; i < jumlahSiswa; i++)
{
    Console.Write("\nMasukkan nama orang ke-" + (i + 1) + ": ");
    namaArray[i] = Console.ReadLine();

    Console.Write("Masukkan umur " + namaArray[i] + ": ");
    umurArray[i] = int.Parse(Console.ReadLine());

    Console.Write("Masukkan tinggi " + namaArray[i] + " dalam cm: ");
    tinggiArray[i] = double.Parse(Console.ReadLine());

    Console.Write("Apakah " + namaArray[i] + " seorang siswa? (true/false): ");
    isSiswaArray[i] = bool.Parse(Console.ReadLine());
}

// Menampilkan informasi dari array
Console.WriteLine("\nInformasi Anda:");
for (int i = 0; i < jumlahSiswa; i++)
{
    Console.WriteLine("\nNama: " + namaArray[i]);
    Console.WriteLine("Umur: " + umurArray[i]);
    Console.WriteLine("Tinggi: " + tinggiArray[i] + " cm");
    Console.WriteLine("Status Siswa: " + (isSiswaArray[i] ? "Ya" : "Tidak"));

    // Konversi tipe data
    string umurSebagaiTeks = umurArray[i].ToString();
    int tinggiSebagaiInteger = Convert.ToInt32(tinggiArray[i]);

    // Menampilkan konversi tipe data
    Console.WriteLine("Umur sebagai teks: " + umurSebagaiTeks);
    Console.WriteLine("Tinggi sebagai integer: " + tinggiSebagaiInteger);

    // Operator
    int tahunLahir = DateTime.Now.Year - umurArray[i];
    double tinggiDalamMeter = tinggiArray[i] / 100.0;

    Console.WriteLine("Tahun Lahir: " + tahunLahir);
    Console.WriteLine("Tinggi dalam meter: " + tinggiDalamMeter);

    // Fungsi matematika
    double akarTinggi = Math.Sqrt(tinggiArray[i]);
    double pangkatDuaUmur = Math.Pow(umurArray[i], 2);

    Console.WriteLine("Akar kuadrat dari tinggi: " + akarTinggi);
    Console.WriteLine("Pangkat dua dari umur: " + pangkatDuaUmur);

    // Operasi string
    string namaKecil = namaArray[i].ToLower();
    string namaBesar = namaArray[i].ToUpper();
    string salam = "Halo, " + namaArray[i] + "!";

    Console.WriteLine("Nama dalam huruf kecil: " + namaKecil);
    Console.WriteLine("Nama dalam huruf besar: " + namaBesar);
    Console.WriteLine("Salam: " + salam);

    // Operasi boolean
    bool lebihDariDuaPuluh = umurArray[i] > 20;
    bool tinggiLebihDariSatuSetengahMeter = tinggiDalamMeter > 1.5;

    Console.WriteLine("Apakah umur lebih dari 20 tahun? " + lebihDariDuaPuluh);
    Console.WriteLine("Apakah tinggi lebih dari 1.5 meter? " + tinggiLebihDariSatuSetengahMeter);
}