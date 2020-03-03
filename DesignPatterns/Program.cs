using System;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(()=>{
                 for (int i = 0; i < 5; i++)
                 {
                     SingetonPattern.CreateSingeton();
                 }

            });
            Console.WriteLine("Hello World!");
        }
    }
}
