// Program untuk BMI (all region)
// Pembuka
Console.WriteLine("Selamat Datang di Kalulator BMI");
Console.WriteLine("Silahkan masukkan sistem ukuran (1 atau 2):\n1. Kg\n2. Pound");
int metric = Convert.ToInt32(Console.ReadLine());

// Kondisi menggunakan kg atau pound
if (metric == 1){
    Console.WriteLine("Silahkan Masukkan Berat Badan (kg):");
    float bb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Silahkan Masukkan Tinggi Badan (cm):");
    float tb = Convert.ToInt32(Console.ReadLine());
    tb = tb/100;
    tb = tb*tb;
    float total = bb/tb;
    Console.WriteLine($"BMI Anda adalah: {total}");
}
else if (metric == 2){
    Console.WriteLine("Silahkan Masukkan Berat Badan (pounds):");
    float bb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Silahkan Masukkan Tinggi Badan (inches):");
    float tb = Convert.ToInt32(Console.ReadLine());
    tb = tb*tb;
    float total = bb/tb;
    total=total*703;
    Console.WriteLine($"BMI Anda adalah: {total}");
}
else{
    Console.WriteLine("tidak ada nomor selain 1 dan 2");
}
