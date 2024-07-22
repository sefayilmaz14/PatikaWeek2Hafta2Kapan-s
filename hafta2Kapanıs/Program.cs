
//1 - Aşağıdaki çıktıyı yazan bir program.

//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?

using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Merhaba \nNasılsın? \nİyiyim \nSen nasılsın?");
Console.WriteLine("---------------------------------------------");
//2 - Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

string isim = "Sefa";
int sayi = 10;

Console.WriteLine($"string değişken:{isim} \nint değişken:{sayi}");
Console.WriteLine("---------------------------------------------");

//3 - Rastgele bir sayı üretip , ekrana yazdırınız.

Random rnd = new Random();
int rndSayi = rnd.Next(10);
Console.WriteLine($"Random sayı:{rndSayi}");
Console.WriteLine("---------------------------------------------");

//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

Random rnd2 = new Random();
int rndSayi2 = rnd.Next(10);
int kalan = 0;
kalan = rndSayi2 % 3;
Console.WriteLine($"Random sayı:{rndSayi2} \nKalan:{kalan}");
Console.WriteLine("---------------------------------------------");

//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

int yas = 0;
Console.WriteLine("Lütfen Yaşınızı Giriniz");
yas = int.Parse(Console.ReadLine());

if (yas >= 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}
Console.WriteLine("---------------------------------------------");

//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.



for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
Console.WriteLine("---------------------------------------------");

//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

Console.WriteLine("Lütfen 1. isimi giriniz");
string isim1 = Console.ReadLine();
Console.WriteLine("Lütfen 2. isimi giriniz");
string isim2 = Console.ReadLine();

Console.WriteLine($"İlk isim {isim1}\nİkinci isim {isim2}");
string tempisim = isim1;
isim1 = isim2;
isim2 = isim1;
Console.WriteLine($"Değişiklik sonrası \nİlk isim:{isim1}\nİkinci isim:{isim2}");
Console.WriteLine("---------------------------------------------");

//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
}
BenDegerDondurmem();
Console.WriteLine("---------------------------------------------");
//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

static int toplamDeger(int num1, int num2)
{
    return num1 + num2;
}
int x = 15;
int y = 5;
Console.WriteLine("İki sayının toplamı :" + toplamDeger(x, y));
Console.WriteLine("---------------------------------------------");

//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

Console.WriteLine("Lütfen true ya da false değeri giriniz.");
string giris = Console.ReadLine();
string sonuc = BooleanCalc(giris);
Console.WriteLine("Sonuç : " + sonuc);
static string BooleanCalc(string giris)
{
    bool trueFalse;
    if (bool.TryParse(giris, out trueFalse))
    {
        return trueFalse.ToString();
    }
    else
    {
        return "Yanlış bir giriş yaptınız. Lütfen sadece true ya da false girişi yapınız.";
    }
}
Console.WriteLine("---------------------------------------------");

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
Console.WriteLine("Lütfen 1.yaşı giriniz");
int age1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen 2.yaşı giriniz");
int age2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen 3.yaşı giriniz");
int age3 = Convert.ToInt32(Console.ReadLine());

int enBuyukYasSonuc = enBuyukYas(age1, age2, age3);
Console.WriteLine("En büyük yaş " + enBuyukYasSonuc);

static int enBuyukYas(int age1, int age2, int age3)
{
    int maxage = 0;
    maxage = Math.Max(age1, age2);
    maxage = Math.Max(maxage, age3);
    return maxage;
}
Console.WriteLine("---------------------------------------------");

//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.


int enBuyukSayi = 0;
Console.WriteLine("Lütfen bir sayı giriniz. Sayı girişini sonlandırmak için 'Bitti' tuşuna basınız.");

while (true)
{
    string giris3 = Console.ReadLine();

    if (giris3.ToLower() == "bitti")    // Burada programı sonlandırmak için bir if bloğu eklendi. Kullanıcı q girişi yaparsa program sonlanır.
    {
        break;
    }
    if (int.TryParse(giris3, out int number))
    {
        enBuyukSayi = MaxNumberCalc(enBuyukSayi, number);
        Console.WriteLine($"Şu ana kadar girilen en yüksek sayı : {enBuyukSayi}");
    }
    else
    {
        Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
    }
}

Console.WriteLine($"En yüksek sayı : {enBuyukSayi}");

static int MaxNumberCalc(int mevcutSayi, int yeniSayi)  // Max girişin belirlendiği metot.
{
    if (yeniSayi > mevcutSayi)
    {
        return yeniSayi;
    }
    else
    {
        return mevcutSayi;
    }
}
Console.WriteLine("---------------------------------------------");

//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

Console.WriteLine("Lütfen 1. ismi giriniz");
string name = Console.ReadLine();
Console.WriteLine("Lütfen 2. ismi giriniz");
string name2 = Console.ReadLine();
isimDeğiştirme(ref name, ref name2);
Console.WriteLine($"Girilen 1.isim :{name}\nGirilen 2.isim:{name2}");

static void isimDeğiştirme (ref string name , ref string name2)
{
    string temp = name;
    name = name2;
    name2 = temp;

}
Console.WriteLine("---------------------------------------------");

//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
Console.WriteLine("Lütfen bir sayı giriniz");
int girisSayi = Convert.ToInt32(Console.ReadLine());
bool sonuc1 = tekCiftKarsılastırma(girisSayi);
if (sonuc1)
{
    Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}

bool tekCiftKarsılastırma (int t)
{
    if (t % 2  == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("---------------------------------------------");

//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

Console.WriteLine("Hız bilgisini giriniz");
int hiz =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zaman bilgisini giriniz");
int zaman = Convert.ToInt32(Console.ReadLine());
int yolSonuc = yolBilgisi(hiz, zaman);
Console.WriteLine("Gidilen Yol:" + yolSonuc);

static int yolBilgisi ( int hiz , int zaman )
{
    int yol = hiz * zaman;
    return yol;
}
Console.WriteLine("---------------------------------------------");

//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
int yaricap = 0;
double pi = 3.14;

Console.WriteLine("Lütfen dairenin yarıçap bilgisini giriniz");
yaricap = Convert.ToInt32(Console.ReadLine());

double alanSonuc = alanHesaplama(yaricap, pi);
Console.WriteLine("Yarıçap bilgisi verilen dairenin alanı:"+ alanSonuc);

static double alanHesaplama (int yaricap , double pi)
{
   double yaricapKaresi= Math.Pow(yaricap, 2);
    double alan = yaricapKaresi * pi;
    return alan;
       
}
Console.WriteLine("---------------------------------------------");

//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string yazi1 = "Zaman bir GeRi SayIm";
string büyükHarfYazim = yazi1.ToUpper();
string kücükHarfYazim = yazi1.ToLower();

Console.WriteLine("Orjinal Yazım:"+yazi1);
Console.WriteLine("Büyük harf ile yazım:"+büyükHarfYazim);
Console.WriteLine("Küçük harf ile yazım:" + kücükHarfYazim);

Console.WriteLine("---------------------------------------------");

//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string yazi3 = "    Selamlar   ";
string duzenlenenYazi = yazi3.Trim();
Console.WriteLine($"Yazının ilk hali {yazi3}\nDüzenlenen yazı:{duzenlenenYazi}");
