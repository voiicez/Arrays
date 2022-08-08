namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciler = new string[3]; //Önce array listesi oluşturulur sonra veri girilir.
            ogrenciler[0] = "Behlül";
            ogrenciler[1] = "Acar";
            ogrenciler[2] = "Flash";

            string[] ogrenciler1 = new string[3] //Array list oluşturulurken veri girilir.
            {
                "Beho",
                "Aho",
                "Faho",
            };

            int[] sayilar = new int[3] 
            {
                1,
                2,
                3,

            };

            int[] sayilar1 = new[] //Bu şekilde de yapılabilir.
            {
                1,
            };

            char[] adArray = // New kullanmadan da yapılıyor.
            {
                'B',
                'E',
                'H',
                'L',
                'Ü',
                'L'
            };

            foreach (int intItem in sayilar) // Bu döngü parametre olarak verilen listedeki tüm elemanları kullanır.
            {
                Console.WriteLine(intItem);
            }
        }
    }
}