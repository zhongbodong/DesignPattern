using System.Collections.Generic;
namespace DesignPatterns.Behavior
{
    //观察者模式：一个类发生变化导致，这个类依赖的其他类也发生变化，应当在这个类中消除依赖
    public class ObserverPattern
    {
        public static void Show()
        {
            Cat cat=new Cat ();
            cat.AddObserver(new Mouse());
            cat.AddObserver(new Baby());
            cat.AddObserver(new Lady());
            cat.Miao();
        }
    }


    public  interface IObeserver{

        void Action();
    }
    public class Cat
    {  
        List<IObeserver> obeservers=new List<IObeserver> ();
        public void Miao()
        {
            System.Console.WriteLine("Miao miao miao!!!");
            this.NextHappen();
            
        }
        public void AddObserver(IObeserver obeserver)
        {
            obeservers.Add(obeserver);
        }

        public void NextHappen()
        {
            if (obeservers!=null&&obeservers.Count>0)
            {
                foreach (var item in obeservers)
                {
                    item.Action();
                }
            }
        }

    }

    public class Mouse:IObeserver{

        public void Zhizhi()
        {
            System.Console.WriteLine("Zhi zhi zhi!!!");
        }
        public void Action()
        {
            this.Zhizhi();
        }
    }

      public class Baby:IObeserver{

        public void Cry()
        {
            System.Console.WriteLine("Wa wa wa!!!");
        }
        public void Action()
        {
            this.Cry();
        }
    }

     public class Lady:IObeserver{

        public void Poar()
        {
            System.Console.WriteLine("What is the fuck!!!");
        }
        public void Action()
        {
            this.Poar();
        }
    }
}