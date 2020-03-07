using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DesignPatterns.Behavior;
using DesignPatterns.Building;
using DesignPatterns.Structure;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 创建型设计模式：关注类型的创建
                  #region 单例设计模式
            //      Task.Run(()=>{
            //      for (int i = 0; i < 5; i++)
            //      {
            //          SingetonPattern.CreateSingeton();
            //      }

            // });  
            #endregion
            #region 原型设计模式
            //     // 孙悟空 原型
            // MonkeyKingPrototype prototypeMonkeyKing = new PrototypePattern("MonkeyKing");

            // // 变一个
            // MonkeyKingPrototype cloneMonkeyKing = prototypeMonkeyKing.Clone() as PrototypePattern;
            // Console.WriteLine("Cloned1:\t"+cloneMonkeyKing.Id);

            // // 变两个
            // MonkeyKingPrototype cloneMonkeyKing2 = prototypeMonkeyKing.Clone() as PrototypePattern;
            // Console.WriteLine("Cloned2:\t" + cloneMonkeyKing2.Id);
            #endregion
            #region 工厂方法
            //FactoryMethod.Show();
            #endregion
            #region 抽象工厂
            //AbstractFactory.Show();
            #endregion

            #endregion


           #region 结构型设计模式：关注类与类之间的关系

           //纵向关系：继承
           //横向关系：组合>聚合>关联>依赖  组合由于继承
           //person+header 组合
           //person+foot   聚合
           //person+iphone 关联
           #region 适配器设计模式
           //AdapterPattern.Show();
           #endregion

           #region 装饰器设计模式
           //DecoratorPattern.Show();
           #endregion

           #region 观察者设计模式
           ObserverPattern.Show();
           #endregion
            
           #endregion
          

          
            Console.WriteLine("Hello World!");
        }
    }
}
