namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Behlül";
            ogrenciler[1] = "Acar";
            ogrenciler[2] = "Flash";

            string[] ogrenciler1 = new string[3]
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

            int[] sayilar1 = new[]
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

            foreach (int intItem in sayilar)
            {
                Console.WriteLine(intItem);
            }
        }
    }
}