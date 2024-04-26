using System.Security;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aralarında boşluk bırakarak 2 adet rakam giriniz:");
            var sayi = Console.ReadLine();

            //Sayıları boşluk ile birbirlerinden ayırdık
            var parts = sayi.Split(' ');
            var result = string.Empty;

            for (int i = 0; i < parts.Length; i += 2)
            {
                if (parts[i] == parts[i+1])
                {
                    result += Math.Pow((Convert.ToInt32(parts[i]) + Convert.ToDouble(parts[i + 1])), 2) + " ";
                }
                else
                {
                    result += Convert.ToInt32(parts[i]) + Convert.ToInt32(parts[i + 1]) + " ";
                }
            }
            Console.WriteLine(result);





        }
    }
}
