using System;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Değişken: İçerisinde değer tutan depolarımız olarak adlandırabiliriz. İçinde tutulacak değere göre veri tipi seçilmelidir. Örneğin; 81 ilin plaka kodlarını tutmak istiyorsak, byte türünde bir değişken oluşturulabilir
             * */
            string mesaj = "Merhaba Dünya"; //string veri türü tanımlanırken "" işaretleri arasında değer yazılmalıdır.
                                            // char karakter = "K"; //char veri türünde bir değişkene değer atarken "" kullanılmaz. Onun yerine '' kullanılır.
            char karakter = 'K';

            //VALUE TYPES
            /*Value Types veri türleri RAM'in Stack bölümünde barındırılır
            /*Value Types veri türleri içinde verilen değerin kendisi tutulur
            /*Value Types veri türlerinde  değişkenler arası kopyalamma işlemi yapıldığında veririnin kkendisi kopyalanır

            Value Types veri türlerinden bazıları:
            byte, sbyte, short, ushort, int, uint, long, ulong, float, decimal, dpuble, char, bool gibi türler Ram'in stcak bölümünde saklanır
             */

            int sayi1 = 10;
            int sayi2 = 25;
            int sayi3 = sayi2;
            sayi1 = 5 + sayi3;
            int sayi4 = sayi1;
            sayi2 = sayi4;

            Console.WriteLine("Sayi 1:" + sayi1); //30
            Console.WriteLine("Sayi 2:" + sayi2); //30
            Console.WriteLine("Sayi 3:" + sayi3);//25
            Console.WriteLine("Sayi 4:" + sayi4);//30
            Console.WriteLine("***************************");
            Console.WriteLine(new string('*',30)); // new anahtar kelimesi ile bir sınıftan instance(örnek) alınır. Burada yeni bir strign oluşturup bu string değerin 30 adet * karakterinden oluşturulması gerçekleşmiştir
            Console.ReadLine();


            //REFERENCE TYPES
            /*Başvuru(Reference) Türleri değişkenleri başvuruları kendi verilerine (nesneler) depolar. RAM'in HEAP alanında değerler tutulur. Bu türdeki verilere erişmek için, STACK bölümünde tutulan adresler kullanılır. Yani, HEAP'te tutulan verinin adresini STACK'te tutulur. Bu sebeple, STACK'te birden fazla değişkende aynı HEAP alanının adresi tutulabilir. Yani, Başvuru Türleri ile iki veya daha fazla değişken de aynı nesneye başvurabilir. Dolayısıyla, HEAP'teki verinin içerisinde yapılan değişiklikler başvuran iki değişkeni de etkilemiş olabilir
             * 
             * Reference Types (Başvuru Türleri) RAM'in HEAP Bölümünde tutulur.
             * Bu tür verilerin HEAP'teki adresleri ise stack bölümünde tutulur 
             * 
             * Reference Types türlerin bazıları string, class, array vb.
             * 
             * GetHashCode() 
             */
        }
    }
}
