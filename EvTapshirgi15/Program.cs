using System.Security.Cryptography;

namespace EvTapshirgi15
{
    internal class Program
    {
        static void Main(string[] args)
        {    //Birinci menfi elementin nomresini tapmaq
            
            Console.Write("Massivin uzunlugunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
