bool isValidInput = false;

// Sayı girilinceye kadar çalışırs
while (!isValidInput)
{
    // Hata Yakalama
    try
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Gİrilen sayının karesi: "+Math.Pow(sayi, 2)); 
        isValidInput = true;
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
    }
}
