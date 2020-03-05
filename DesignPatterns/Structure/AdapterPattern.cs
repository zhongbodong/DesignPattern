namespace DesignPatterns.Structure
{
    //适配器模式：主要解决新增的接口和之前不匹配问题，下面以sql帮助类来说明
    public class AdapterPattern
    {
        //之前有MySQL和Oracle都实现了IHelper的接口，现在新增了一个redis的接口，
        //但是和之前不匹配，需要新增一个适配器类转换

        public static void Show()
        {
            IHelper mysql=new MySqlHelper();
            mysql.Add<User>();

            IHelper oracle=new OracleHelper();
            oracle.Add<User>();

            IHelper redis=new Adapter(new RedisHelper());
            redis.Add<User>();

        }
      
    }

    public class User
    {
        
    }

    //转换器类,这里还要改造成泛型的
    public class Adapter:IHelper
    {
        private RedisHelper _t=default;
        public Adapter(RedisHelper t)//这里采用构造器来组合的方式，可以泛型
        {
            this._t = t;
        }
          public  void Add<T>()
       {
           this._t.AddRedis<T>();
       }

       public void Delete<T>()
        {
            this._t.DeleteRedis<T>();
        }
       public void Modify<T>()
       {
           this._t.ModifyRedis<T>();
       }
       public void Query<T>(){
            this._t.QueryRedis<T>();
       }
    }

    //这个redisHelper没有实现Ihelper
    public class RedisHelper 
    {
       public  void AddRedis<T>()
       {
           System.Console.WriteLine(" RedisHelper Add");
       }

       public void DeleteRedis<T>()
        {
            System.Console.WriteLine(" RedisHelper Delete");
        }
       public void ModifyRedis<T>()
       {
            System.Console.WriteLine(" RedisHelper Modify");
       }
       public void QueryRedis<T>(){
            System.Console.WriteLine(" RedisHelper Query");
       }

        public void OtherRedis<T>(){
            System.Console.WriteLine(" RedisHelper OtherRedis");
       }
    }


    public interface IHelper
    {
        void Add<T>();

        void Delete<T>();
        void Modify<T>();

        void Query<T>(); 
    }

    public class MySqlHelper:IHelper
    {
       public  void Add<T>()
       {
           System.Console.WriteLine(" MySqlHelper Add");
       }

       public void Delete<T>()
        {
            System.Console.WriteLine(" MySqlHelper Delete");
        }
       public void Modify<T>()
       {
            System.Console.WriteLine(" MySqlHelper Modify");
       }
       public void Query<T>(){
            System.Console.WriteLine(" MySqlHelper Query");
       }
    }

public class OracleHelper:IHelper{

      public  void Add<T>()
       {
           System.Console.WriteLine(" OracleHelper Add");
       }

       public void Delete<T>()
        {
            System.Console.WriteLine(" OracleHelper Delete");
        }
       public void Modify<T>()
       {
            System.Console.WriteLine(" OracleHelper Modify");
       }
       public void Query<T>(){
            System.Console.WriteLine(" OracleHelper Query");
       }

}
}