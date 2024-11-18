using System;
using System.Linq.Expressions;

namespace Gazi.sube2.HelloWorldApp


{
    internal class Program
    {
        static int sayi = 3;
        static void Main(string[] args)

        {
            //System.Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("BM");
            //Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("2406Z");
            //Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("gs tbmo");


            #region "Değer atama"
            //byte a = 3;
            //double d = 2400;
            //const byte f = 3;

            //Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(a + d + f);

            #endregion



            #region "String tanımlama"
            //string isim = "Osman";
            //string soyad = "Uygun";

            //Console.Write(isim);
            //Console.WriteLine();
            //Console.WriteLine(soyad);

            //Console.WriteLine("Hoşgeldin, " + isim + " " + soyad);
            //Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Hoşgeldin, {0} {1}", soyad, isim);
            //Console.WriteLine($"Hoşgeldin, {isim} {soyad}");
            //Dolar işareti değerlik girer dolarsız sadece isim ve soyad yazar
            #endregion

            try
            {
                #region "Kullanıcı Etkileşimleri"
                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("İsminizi Giriniz:");
                string name = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Soyadınızı Giriniz");
                string soyad = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Yaşınızı giriniz");
                byte yas = byte.Parse(Console.ReadLine());

                Console.WriteLine($"Hoşgeldiniz,\nİsminiz {name}\nSoyadınız:{soyad}\nYaşınız:{yas}");
        }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("YAŞINI SAYIYLA GİRİNİZ.");

            }
            
            //catch(OverflowException)
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine("0-255 arası değer giriniz"); 
            //}
            catch(Exception ex)
            {
                Console.WriteLine("Bir hata oluştu.");

                Console.WriteLine($"Tarih:{DateTime.Now}\nMessage:{ex.Message}\nStack Trace:{ex.StackTrace}");//Kendimiz için tuttuğumuz loglar veritabanı txt vb
            }







    #endregion




    #region "Tür Dönüşümleri"

    //byte sayi = 20;
    //int number = sayi;//Implicit Type Casting 

    //checked
    //{
    //    int sayi = 256;
    //    byte number = (byte)sayi;//Explicit type Casting
    //    Console.WriteLine(number);
    //}

    //string value = "20";
    //string value2 = "30";
    //byte sayi = Convert.ToByte(value);
    //byte sayi2 = Byte.Parse(value2);                           //Pars metodu stringlere dönüştürmek için
    //Console.WriteLine(sayi + sayi2);
    //Console.WriteLine(value + value2);


    //int sayi = 20;                                                 //STACK
    //object value = sayi;                                           //STACK ---> HEAP Boxing yapar ve HEAP bölgesinde saklar
    //int number = (int)value;








    #endregion









    Console.ReadKey();






        }
    }
}

/*

/////////////////////////////////////////////////////////////    30.09.2024     //////////////////////////////////////////////////////
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
/////////////////////////////////////////////////////////        07.10.2024         //////////////////////////////////////////////////

              **KISAYOLLAR** 

CTRL+K+D Kodları düzenlemek için kullanılır
CTRL+K+C Yazılan Kodu açıklamaya (çift slash yapar)
CTRL+K+U Açıklamayı geri çevirir
CTRL+S Kayıt 
CTRL+B Derleme kısa yolu

**.NET Nedir?

Microsoft tarafından geliştirilen bir yazılım geliştirme platformudur
Açık kaynaklıdır
Birden fazla programlama dili baırndırır
Web Mobil Oyun Masaüstü Makine öğrenmesi gibi uygulamalar geliştirilebilir


C# --> Derleme --> MS-IL


/MS-IL (Microsoft Intermediate Language)


C# -> Derleme -> MS-IL -> .NET RUNTIME (Derleme) -> 0-1 (Binary)


Microsoft Intermediate Language
//////////////////////////////////////
//////////////////////////////////////            14.10.2024           ///////////////////////////////////////////////

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

*Static değişkenler program çalıştığı sürece hafızada kalırlar

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

explicit (veri tipinin açık olarak belirtiliği tanımlamalar) başında var olmayıp belirtirsek byte float decimal vs.
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


//////////////////////////////////////////                  21.10.2024                      //////////////////////////////////////////////

string referans tipi (heap bölgesi)

Heap bölgesi stack bölgesine göre daha büyüktür dolayısıyla tek seferde 1 den fazla veri depolayabilir
Örneğin:
Ahmet stringinde 5 tane char vardır

Referans tipi dğeişkenlede, referanslar stack bölgesinde, değerler heap bölgesimde tutulur. Değere ulaşmak için, o değerin heap bölgesindeki adrsini bilen referansına ulaşmak gerekir


Metod Parametresi:Metodların işlerini yapabilmek için ihtiyaç duydukları verilerdir. Bir metod hiç parametre istemeyebilir yada birden fazla veri tipinde parametre de kabul edebilir. 


Void: Bu geri dönüş tipine sahip metodlar işlerini yaptıktan sonra geriye bilgi dönmezler.


----------------------------------------- 18.11.2024 ----------------------------------------------------

C# Programlama dili tip güvenliği (Type Safety) sağlayan bir dildir.


Uyumsuz tipler arası veri ataması yapılamaz
String ---> Byte ataması yapılamaz.


checked blokları büyük türden küçük türe yapılan dönüşümlerde hata atarak veri kaybı ihtimalini önler


Debug: Hata yakalama işlemleri 
Bug: Hata
Hata yönetimleri C#'da try-catch ile yapılır

CTRL + F5: Start without debugging
F5 : Start debugging














































































*/



























