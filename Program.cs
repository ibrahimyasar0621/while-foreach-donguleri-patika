namespace while_foreach_donguleri;

class Program
{
    static void Main(string[] args)
    {
        // WHİLE
        // 1 den başlayarak console'dan girilenn sayıı dahil oratalama hesaplayıp console'a yazdıran program.
        // Console.WriteLine("Lütfen Bir Sayı Giriniz");
        // int sayi = int.Parse(Console.ReadLine());
        // int sayac =1;
        // int toplam =0;
        // while (sayac<=sayi)  // While Parantez içindeki ifadeyi kullanıyor. Buraya yazdığımız ifade true olduğu sürece komutları yazmaya devam ediyor. Döngünün kaç kere açlışacağını prantez içindeki koşul belirliyor.
        // {
        //     toplam += sayac;
        //     sayac ++;

        // }
        // Console.WriteLine(toplam/sayac);   // eğer yukarıdaki while(sayac<sayi) olsaydı bu satırdaki kodda sayac-1 yapmalıydım.

        //A'dan z'ye kadar olan tüm harfleri console'a yazdıralım.
        char character ='a';
        
        while (character<'z')
        {
            Console.Write(character); 
            character ++;    // karakteri bir arttırıyoruz burada.
        }
        string[] arabalar ={"BMW","FORD","TOYOTA","NİSSAN"};
        foreach (var araba in arabalar)    //var= her türlü veriyi var tipindeki değişkende saklayabilirsiniz.  arabalar dizisinden her bir markayı item olarak aldı. biz item'ı değişrip arba yazdık herbir item aslında araba gibi tanımladık item yerine araba dedik.
        {
            Console.WriteLine(araba);
        }
    }
}
