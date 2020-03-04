namespace DesignPatterns.Building
{
 
    //工厂方法设计模式
    public class FactoryMethod
    {
        //首先有一个抽象的工厂，然后具体的工厂继承抽象工厂，实现
        //每一个工厂只用来生产一种产物
        //虽然上层还是new了对象 但是屏蔽了底层的业务类
        public static void Show()
        {
             IFactory human=new HumanFactory();
             human.Create();

             IFactory car=new CarFactory();
             car.Create();

        }
      
    }

    public interface IFactory{
      
      void Create();
    }

    public class HumanFactory:IFactory{
      
      public void Create()
      {
          System.Console.WriteLine("Create a Human");
      }
    }

      public class CarFactory:IFactory{
      
      public void Create()
      {
          System.Console.WriteLine("Create a Car");
      }
    }
}