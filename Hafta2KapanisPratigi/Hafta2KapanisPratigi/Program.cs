// 1. Pratik ---------------------------------------------------------------------------------------

Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");

// 2. Pratik ---------------------------------------------------------------------------------------
string ad = "sefa";
int i = 2;

Console.WriteLine($"{ad} {i}");

// 3. Pratik ---------------------------------------------------------------------------------------
Random random = new Random();

int rastgeleSayi = random.Next(1, 999);

Console.WriteLine(rastgeleSayi);

// 4. Pratik ---------------------------------------------------------------------------------------
Random random = new Random();

int rastgeleSayi = random.Next(1, 999);

int sayi2 = 0;

sayi2 = rastgeleSayi % 3;

Console.WriteLine($"Rastgele üretilen sayi: {rastgeleSayi}");
Console.WriteLine($"Rastgele üretilen sayının 3'e bölümünden kalan:{sayi2}");

// 5. Pratik ---------------------------------------------------------------------------------------
Console.WriteLine("Yasınız nedir? ");

string yasMetin = Console.ReadLine();

int yasSayi = Convert.ToInt32(yasMetin);

if (yasSayi > 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}

// 6. Pratik ------------------------------------------------------------------------------------------
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
// 7. Pratik ------------------------------------------------------------------------------------------
Console.WriteLine("Bir metin giriniz");

string BirinciMetin = Console.ReadLine(); // 1. Metin Gülse Birsel

Console.WriteLine("Bir metin daha giriniz");

string IkinciMetin = Console.ReadLine();  //  2. Metin Demet Evgar

string temp = BirinciMetin;
BirinciMetin = IkinciMetin;
IkinciMetin = temp;

Console.WriteLine($"Birinci metin (değişen): {BirinciMetin}");
Console.WriteLine($"Ikinci metin (değişen) :{IkinciMetin}");

// 8. Pratik ------------------------------------------------------------------------------------------
static void Main()
{
    BenDegerDondurmem();
}
static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

// 9. Pratik ------------------------------------------------------------------------------------------
static void Main()
{
    int toplam = Numaralar(1, 4);
    Console.WriteLine($"Toplam: {toplam}");
}
static int Numaralar(int a, int b)
{
    return a + b;
}

// 10. Pratik ------------------------------------------------------------------------------------------
static void Main()
{

    Console.Write("Lütfen true ya da false girin: ");
    string userInput = Console.ReadLine();


    string result = ConvertToString(userInput);


    Console.WriteLine(result);
}


static string ConvertToString(string input)
{

    if (bool.TryParse(input, out bool booleanValue))
    {
        return booleanValue.ToString();
    }
    else
    {
        return "Geçersiz giriş. Lütfen true veya false girin."; // Geçersiz giriş mesajı
    }
}

// 11. Pratik ------------------------------------------------------------------------------------------
Console.Write("Birinci kişinin yaşını girin: ");
int age1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci kişinin yaşını girin: ");
int age2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Üçüncü kişinin yaşını girin: ");
int age3 = Convert.ToInt32(Console.ReadLine());

// En yaşlı olan kişinin yaşını bul
int oldestAge = FindOldestAge(age1, age2, age3);

// Sonucu ekrana yazdır
Console.WriteLine($"En yaşlı kişinin yaşı: {oldestAge}");


// Üç yaş bilgisinden en yaşlı olanı döndüren metot
static int FindOldestAge(int age1, int age2, int age3)
{
    // Yaşları karşılaştırarak en yaşlı olanını bulun
    int oldest = age1;

    if (age2 > oldest)
    {
        oldest = age2;
    }

    if (age3 > oldest)
    {
        oldest = age3;
    }

    return oldest;
}
// 12. Pratik ------------------------------------------------------------------------------------------
static void Main()
{
    // En büyük sayıyı bulma metodunu çağır
    int largestNumber = FindLargestNumber();

    // En büyük sayıyı ekrana yazdır
    Console.WriteLine($"En büyük sayı: {largestNumber}");
}

// Kullanıcıdan sınırsız sayıda giriş alarak en büyük olanını döndüren metot
static int FindLargestNumber()
{
    int largest = int.MinValue; // Başlangıçta en küçük int değeri

    while (true)
    {
        Console.Write("Bir sayı girin (Çıkmak için 'q' tuşuna basın): ");
        string input = Console.ReadLine();

        // Çıkmak için 'q' tuşuna basılmasını kontrol et
        if (input.ToLower() == "q")
        {
            break;
        }

        // Girdiyi tam sayıya dönüştürmeye çalış
        if (int.TryParse(input, out int number))
        {
            // Sayıyı en büyük sayı ile karşılaştır
            if (number > largest)
            {
                largest = number;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir tam sayı girin.");
        }
    }

    return largest; // En büyük sayıyı döndür
}
// 13. Pratik ------------------------------------------------------------------------------------------
Console.Write("Birinci ismi girin: ");
string firstName = Console.ReadLine();

Console.Write("İkinci ismi girin: ");
string secondName = Console.ReadLine();

// İsimlerin yerlerini değiştirme metodunu çağır
(string newFirstName, string newSecondName) = SwapNames(firstName, secondName);

// Sonuçları ekrana yazdır
Console.WriteLine($"Yer değiştiren isimler:");
Console.WriteLine($"Birinci isim (değiştirilen): {newFirstName}");
Console.WriteLine($"İkinci isim (değiştirilen): {newSecondName}");


// İki ismin yerlerini değiştiren metot
static (string, string) SwapNames(string firstName, string secondName)
{
    // İsimlerin yerlerini değiştir
    return (secondName, firstName);
}
// 14. Pratik ------------------------------------------------------------------------------------------
Console.Write("Bir sayı girin: ");
string input = Console.ReadLine();

// Metni sayıya dönüştür
if (int.TryParse(input, out int number))
{
    // Tek mi çift mi olduğunu kontrol et ve sonucu al
    bool isEven = IsEven(number);
    bool isOdd = !isEven;

    // Sonuçları ekrana yazdır
    Console.WriteLine($"Sayı çift mi? {isEven}");
    Console.WriteLine($"Sayı tek mi? {isOdd}");
}
else
{
    Console.WriteLine("Geçersiz sayı girişi.");
}


// Sayının çift olup olmadığını kontrol eden metot
static bool IsEven(int number)
{
    return number % 2 == 0;
}
// 15. Pratik ------------------------------------------------------------------------------------------
Console.Write("Hızı girin (km/saat): ");
string speedInput = Console.ReadLine();

Console.Write("Zamanı girin (saat): ");
string timeInput = Console.ReadLine();

// Hız ve zamanı sayıya dönüştürme
if (double.TryParse(speedInput, out double speed) && double.TryParse(timeInput, out double time))
{
    // Yolu hesapla
    double distance = CalculateDistance(speed, time);

    // Sonucu ekrana yazdır
    Console.WriteLine($"Gidilen yol: {distance} km");
}
else
{
    Console.WriteLine("Geçersiz hız veya zaman girişi.");
}


// Yolu hesaplayan metot
static double CalculateDistance(double speed, double time)
{
    return speed * time;
}
// 16. Pratik ------------------------------------------------------------------------------------------
Console.Write("Dairenin yarıçapını girin: ");
string radiusInput = Console.ReadLine();

// Yarıçapı sayıya dönüştürme
if (double.TryParse(radiusInput, out double radius))
{
    // Dairenin alanını hesapla
    double area = CalculateCircleArea(radius);

    // Sonucu ekrana yazdır
    Console.WriteLine($"Dairenin alanı: {area} kare birim");
}
else
{
    Console.WriteLine("Geçersiz yarıçap girişi.");
}


// Dairenin alanını hesaplayan metot
static double CalculateCircleArea(double radius)
{
    const double Pi = 3.141592653589793;
    return Pi * radius * radius;
}
// 17. Pratik ------------------------------------------------------------------------------------------
string cumle = "Zaman bir GeRi SayIm";

// Cümleyi büyük harflerle yazdır
string upperCaseCumle = cumle.ToUpper();
Console.WriteLine("Büyük harflerle: " + upperCaseCumle);

// Cümleyi küçük harflerle yazdır
string lowerCaseCumle = cumle.ToLower();
Console.WriteLine("Küçük harflerle: " + lowerCaseCumle);
// 18. Pratik ------------------------------------------------------------------------------------------
string text = "    Selamlar   ";

text = text.Trim();

Console.WriteLine($"{text}");












