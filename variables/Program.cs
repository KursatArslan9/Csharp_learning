namespace variables;

class Program
{
    static void Main(string[] args)
    {
        byte deger = 1;  // değişken tanımlama

        string bos = null;  // değişkenleri boş bırakma
        string bos2 = "";

        int Deger;        // farklı satırda değişken tanımlama
        Deger = 2;

        int toplam_deger = Deger + deger;

        // Tam Sayı Veri Tipleri
        byte b = 255;                  // 1 byte
        sbyte sb = -128;               // 1 byte
        short s = -32768;              // 2 byte
        ushort us = 65535;             // 2 byte
        int i = -2147483647;           // 4 byte
        uint ui = 4111222333;          // 4 byte
        long l = -5111222333444;       // 8 byte
        ulong ul = 6555444333222111;   // 8 byte

        // Kesirli ve Ondalık Veri Tipleri
        float f = 3.14f;               // 4 byte
        double d = 5.56;               // 8 byte

        decimal de = 700 / 25m;        // 12 byte

        char c = 'k';                  // 2 byte  Tek karakter tuttuk.

        string str = "istemem! \n eksik olsun!";
        string str2 = string.Empty;
        str2 = "gün gördüm, günler gördüm, seni gördüm şad oldum...";
        string str3 = str + " " + str2;

        bool bo = ui > sb;             // 1 byte

        DateTime dt = DateTime.Now;    // çalıştırma tarih ve saati
        DateTime dt2 = DateTime.Today;

        object obj = 0;
        object obj2 = -9888777666;
        object obj3 = 5.56f;
        object obj4 = 'k';
        object obj5 = "uzun hikaye";
        object obj6 = true;

        // Veri Dönüşümleri
        string str4 = "20";      // String dönüşümü
        int i2 = 24;
        string yeniDeger = str4 + i2.ToString();

        string str5 = "20";      // İnteger dönüşümü
        int i3 = 24;
        int i4 = i3 + Convert.ToInt32(str5);

        string str6 = "20";      // İnteger dönüşümü 2
        int i5 = 24;
        int i6 = i5 + int.Parse(str6);

        string zaman = DateTime.Now.ToString();   // datetime > string
        string tarih = DateTime.Now.ToString("dd.MM.yyyy");   // sadece tarih
        string saat = DateTime.Now.ToString("HH:mm:ss");      // sadece saat

        Console.WriteLine(str2);
    }
}
