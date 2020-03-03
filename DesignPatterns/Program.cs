using System;
using System.Threading.Tasks;
using DesignPatterns.Building;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 单例设计模式
            //      Task.Run(()=>{
            //      for (int i = 0; i < 5; i++)
            //      {
            //          SingetonPattern.CreateSingeton();
            //      }

            // });  
            #endregion
            #region 原型设计模式
                // 孙悟空 原型
            MonkeyKingPrototype prototypeMonkeyKing = new PrototypePattern("MonkeyKing");

            // 变一个
            MonkeyKingPrototype cloneMonkeyKing = prototypeMonkeyKing.Clone() as PrototypePattern;
            Console.WriteLine("Cloned1:\t"+cloneMonkeyKing.Id);

            // 变两个
            MonkeyKingPrototype cloneMonkeyKing2 = prototypeMonkeyKing.Clone() as PrototypePattern;
            Console.WriteLine("Cloned2:\t" + cloneMonkeyKing2.Id);
            #endregion
         
            Console.WriteLine("Hello World!");
        }
    }
}
