namespace DesignPatterns
{
    /*
    单例设计模式（懒汉式）
    */
    public class SingetonPattern
    {
        //1.首先构造函数必须私有化
        private SingetonPattern()
        {
            System.Console.WriteLine("Init Singeton!");
        }
        //2.静态字段
        public static SingetonPattern _singeton { get; set; }

        public static object lockObject =new object ();

        public static SingetonPattern CreateSingeton()
        {
            if (_singeton==null)
            {
                lock(lockObject)
                {
                    if (_singeton==null)
                    {
                        _singeton=new SingetonPattern ();
                    }

                }
                
            }
            return _singeton;
        }
    }
}