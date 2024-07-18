using System;

namespace WhileOrnekleri
{
    class Program
    {
        static void Main(string[] args) 
        {
            System.Console.WriteLine("1 -> Konsol ekranına 10 kere Kendime inanıyorum, ben bu yazılım işini hallederim! yazdırınız.");
            System.Console.WriteLine("");

            byte i =1 ; // while döngüsünün içinde artırdığımız değişken
            int total=0; // 4 . problem için kullandık toplam degeri toplayarak gittiğimiz için gerekli
            int evenNumber=0; // 5. problemde çift sayıların toplanması için gerekli
            int oddNumber=0;  // 5. problemde tek sayıların toplanması için gerekli

            while(i<=10) 
            {
                System.Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!"); // istenilen yazının çıktısı
                i++; // teker teker artırıyoruz değerimizi
            }
            i=0;
            System.Console.WriteLine("");
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");
            System.Console.WriteLine("");

            while (i<=20)
            {
                System.Console.Write($"{i}, "); // aralarındaki sayıların çıktısı
                i++; // teker teker artırıyoruz değerimizi
            }
            i=0;
            System.Console.WriteLine("");
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");
            System.Console.WriteLine("");
            i=2;
            while (i<=20)
            {
                System.Console.Write($"{i}, "); // çift sayıların çıktısı
                i += 2; // çift sayı olduğu için ikişer ikişer artırdık burda
            }
            i=0;
            System.Console.WriteLine("");
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");
            System.Console.WriteLine("");
            i=50;
            while(i<=150)
            {
                total += i;
                i++;// teker teker artırıyoruz değerimizi
            }
            System.Console.WriteLine($"Sayının toplamı: {total}"); // aralarında ki sayıların toplamı çıktısı
            i=0;
            System.Console.WriteLine("");
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");
            System.Console.WriteLine("");

            while (i<=120)
            {
                if(i%2==0) // sayının çift olup olmadığını kontrol ettiğimiz yer
                {
                    evenNumber += i;
                }
                else oddNumber += i;

                i++; // teker teker artırıyoruz değerimizi
            }
            System.Console.WriteLine($"Çift sayı toplamı: {evenNumber}"); //çift sayı çıktısı
            System.Console.WriteLine($"Tek sayı toplamı: {oddNumber}");   // tek sayı çıktısı

        }
    }
}