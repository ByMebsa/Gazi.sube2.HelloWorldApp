using System;



namespace Gazi.sube2.HelloWorldApp


{
    internal class Program
    {
        static int sayi = 3;
        static void Main(string[] args)

        {
            System.Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("BM");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("2406Z");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("gs tbmo");



            byte a = 3;
            double d = 2400;
            const byte f = 3;

            
            Console.ForegroundColor =ConsoleColor.Red; Console.WriteLine(a+d+f);

            Console.ReadKey();






        }
    }
}

/*

/////////////////////////////////////////////////////////////        30.09.2024 
namespace:İçinde classları bulunduran yapılardır.
Scope(Blok Yapıları): {} parantezleri arasındaki alanlardır.
Class: İçinde metodları bulunduran yapılardır. (Bu tanım şimdilik yüzeysel olarak yapılmıştır. Daha sonra detaylandıralacaktır.)
Metodlar: İş yapan kod bloklarına metod denir.
Main Metodu: Console uygulamalarının başlangıç noktasıdır.
Ctrl+F5: Hata ayıklama modu olmadan başlatır.

Syntax:Kod yazım kuralları
1- Açılan her parantez mutluka kapatılmalıdır
2- Scope tanımlamaları sonunda noktalı virgül kullanılmaz ancak satır sonlarında kullanılır.


Syntax hatalarını nasıl anlarız
1- Hata olan kodun altı kırmızı ile çizilir
2- Scrool Bar'da hata olan yere yakın kırmızı işaretleme yapılır
/3-VS kod editörünün alt çubuğunda kırmızı renkli X görünür


Syntax hatası olan program çalışır mı?
Hayır çalışmaz çünkü program derlenemez.


IntelliSense: Kod yazarken açılan pencere ile karşımıza çıkan öneriler
IntellienceCode: Yapay zeka destekli kod yazım yardımıcısı. Gelen önerileri TAB tuşu ile kabul edebiliriz


Solution-->Project(s)
View-->Solution Explorer
/////////////////////////////////////////////////////////               07.10.2024

CTRL+K+D Kodları düzenlemek için kullanılır
CTRL+K+C Yazılan Kodu açıklamaya (çift slash yapar)
CTRL+K+U Açıklamayı geri çevirir
CTRL+S Kayıt 
CTRL+B Derleme kısa yolu

.NET Nedir?
Microsoft tarafından geliştirilen bir yazılım geliştirme platformudur
Açık kaynaklıdır
Birden fazla programlama dili baırndırır
Web Mobil Oyun Masaüstü Makine öğrenmesi gibi uygulamalar geliştirilebilir


C# --> Derleme --> MS-IL


/MS-IL (Microsoft Intermediate Language)


C# -> Derleme -> MS-IL -> .NET RUNTIME (Derleme) -> 0-1 (Binary)


Microsoft Intermediate Language
//////////////////////////////////////
//////////////////////////////////////                           14.10.2024

Derlenen kodun dosyası exe uzantılı olur
////////////////////////////////////////

Stack Bölgesi --> Değer tipleri burada saklanır

Heap Bölgesi --> Referans tipleri burada saklanır
///////////////////////////////////////////////
//////////////////////////////////////////////

byte a;
double d;

a=30;
d=40;

byte a = 30;


byte a = 30, b;
b = 40;

byte a, b;
b = 40; A = 30;
////////////////////////////////////////////
////////////////////////////////////////////

Static değişkenler program çalıştığı sürece hafızada kalırlar

static byte a;
a = 30;

static byte a = 30;
/////////////////////////////

Sabit değişken tanımlamak
const byte a=30;
///////////////////////////////

Özel karakter ile başlamaz "_" ile başlayabilir

byte _yas;
int _yas;
/////////////////////////////////////

byte:

8 bitlik işaretsiz sayılar için kullanılır. Değer aralığı 0-255 arasında değişir

                               byte a = 256; //Overflow hatası verir
                               byte b = 250; //Doğru
                               byte c = 0;   //Doğru

//////////////////////////////////////////////

1 bit= 0 veya 1 
1byte= 8 bit
1024 byte = 1 kb (kilobyte)
1024 kb = 1 MB (Megabyte)
1024 mb = 1 gb (gigabyte)
1024 gb = 1 TB (Terabyte)

////////////////////////////////////////

int:

32 bitlik işaretli sayılar için kullanılır. Değer aralığı -2147483648 +2147483648 dir.
////////////////////////////////////////

sbyte (8bit) //signed byte

-128 ve +127 arasında değer alır
//////////////////////////////////////////
short (16bit)

-32768 +32767 arasında değer alır
///////////////////////////////////////////

ushort (16 bit) //unsigned short işaretsiz

0 ile +65535 arasında değer alır
//////////////////////////////////////////

long (64 bit)

çok sayı

-9,223,372,036,854,775,808 ile
+9,223,372,036,854,775,807 arasında değer alır
///////////////////////////////////////////

ulong işaretsiz halı
/////////////////////////////////////////////
float (f) :

32 bitlik reel değerleri saklamak için kullanılır

float f = 3,12f; veya f= 
//////////////////////////////////////////////
Double (D)

Decimal (m)
////////////////////////////////////////

var sayi = 10;

variable sayının boyutuna bakarak gerekli değer verilir
////////////////////////////////////////////

Implicit (veri tipi belirlenmeden yapılan tanımlamalar) yani var ile yazılanlar
//////////////////////////////////////////////////

explicit (veri tipinin açık olarak bleirtiliği tanımlamalar) başında var olmayıp belirtirsek byte float decimal vs.
////////////////////////////////////////////////////////////////

bool: doğru veya yanlış değerlerini saklamak için kullanılır
//////////////////////////////////////////////////////////////

char

tek bir karakter tipinde veri saklamak için kullanılabilir

tek tırnaklar arasına yazılır (' ') 

16 bitlik alan kaplar
///////////////////////////////////////////

string

metinsel ifadeleri veriler olarak tutabilir

string isim = "Ahmet";
string soyad = "Mehmet";





*/



























