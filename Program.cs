using System;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Başlangıç mesajı için mavi
            Console.WriteLine($"{"\U0001F389"} Sayı Tahmin Oyununa Hoşgeldiniz! {"\U0001F389"}");
            Console.ResetColor(); // Renk sıfırlama

            while (true) // Oyunu tekrar oynamak için döngü
            {
                Random random = new Random();
                int rastgeleSayi = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı seçiliyor
                int tahminHakki = 5;

                Console.ForegroundColor = ConsoleColor.Yellow; // Kullanıcıya bilgi vermek için sarı
                Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Bakalım bulabilecek misin?");
                Console.WriteLine($"Toplam {tahminHakki} tahmin hakkınız var. Başarılar! 👍");
                Console.ResetColor(); // Renk sıfırlama

                for (int i = 1; i <= tahminHakki; i++)
                {
                    Console.Write($"{i}. tahmininiz: ");
                    int tahmin;

                    // Kullanıcıdan sayı girişi alıyoruz ve sayıya dönüştürüyoruz
                    while (!int.TryParse(Console.ReadLine(), out tahmin))
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Hatalı giriş için kırmızı
                        Console.WriteLine("Lütfen geçerli bir sayı girin! ❌");
                        Console.ResetColor(); // Renk sıfırlama
                        Console.Write($"{i}. tahmininiz: ");
                    }

                    if (tahmin == rastgeleSayi)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Doğru tahmin için yeşil
                        Console.WriteLine($"🎊 Tebrikler! Doğru tahmin ettiniz! Tutulan sayı: {rastgeleSayi} 🎊");
                        break;
                    }
                    else if (tahmin < rastgeleSayi)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue; // Daha yüksek tahmin için mavi
                        Console.WriteLine("Daha yüksek bir sayı girin ↑");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue; // Daha düşük tahmin için mavi
                        Console.WriteLine("Daha düşük bir sayı girin ↓");
                    }
                    Console.ResetColor(); // Renk sıfırlama

                    // Tahmin hakkı azaldığında bilgilendirme yapıyoruz
                    if (i == tahminHakki)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Tahmin hakkı bitti için kırmızı
                        Console.WriteLine($"😢 Ne yazık ki tahmin hakkınız bitti! Tutulan sayı: {rastgeleSayi}");
                        Console.WriteLine("Tekrar oynamak için 'r' harfine basın...");
                        Console.ResetColor(); // Renk sıfırlama

                        // Kullanıcıdan 'r' harfine basmasını bekle
                        string tus = Console.ReadLine(); // Kullanıcıdan giriş al
                        if (tus.ToLower() != "r") // 'r' harfi kontrolü
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow; // Sarı renkle bilgi ver
                            Console.WriteLine("Geçersiz tuş! Oyun sona eriyor.");
                            Console.ResetColor(); // Renk sıfırlama
                            return; // Programı sonlandır
                        }
                        Console.WriteLine(); // Yeni satır
                        Console.WriteLine("Yeni oyuna başlıyoruz! 🎉");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; // Kalan tahmin hakkı için sarı
                        Console.WriteLine($"Kalan tahmin hakkınız: {tahminHakki - i} 🕒");
                    }
                    Console.ResetColor(); // Renk sıfırlama
                }

                Console.ForegroundColor = ConsoleColor.Cyan; // Oyun bitiş mesajı için mavi
                Console.WriteLine("Oyun bitti. Tekrar oynamak için çalıştırın! 🔄");
                Console.ResetColor(); // Renk sıfırlama
            }
        }
    }
}