namespace DesignPatterns.Building
{
    public class AbstractFactory
    {
        //首先有一个抽象的工厂，与工厂方法不同，这个工厂生产一系列产品
        //虽然上层还是new了对象 但是屏蔽了底层的业务类
        //比如数据库的连接类IDBProvider就是一个抽象的工厂
        public static void Show()
        {
            IProductFactory car=new  CarProductFactory();
            car.Create();
            car.Marketing();
            car.Selling();

            IProductFactory Building=new  BuildingsProductFactory();
            Building.Create();
            Building.Marketing();
            Building.Selling();
        }

        public interface IProductFactory{
      
            //生产
            void Create();
            //营销
            void Marketing();
            //售卖
            void Selling();
        }

          public class CarProductFactory:IProductFactory
          {
             public  void Create(){
                 System.Console.WriteLine("Creating Car");
             }
            //营销
            public void Marketing()
            {
                 System.Console.WriteLine("Marketing Car");
            }
            //售卖
           public void Selling()
           {
                 System.Console.WriteLine("Selling Car");
           }
          }

           public class BuildingsProductFactory:IProductFactory
          {
             public  void Create(){
                 System.Console.WriteLine("Creating Buildings");
             }
            //营销
            public void Marketing()
            {
                 System.Console.WriteLine("Marketing Buildings");
            }
            //售卖
           public void Selling()
           {
                 System.Console.WriteLine("Selling Buildings");
           }
          }
    }
}