using System; //используем пространство имен System

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество параметров:");
            Console.WriteLine(args.Length);
            Console.WriteLine("Параметры:");
            for(int i=0; i<args.Length; i++)
            {
                Console.WriteLine(args[i]);
                
            }
            Console.ReadKey();
        }
    }
}
