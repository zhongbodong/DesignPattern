namespace DesignPatterns.Structure
{
    //装饰器模式：通过组合加继承的方式
    public class DecoratorPattern
    {
        public static void Show()
        {

            AbstactStudent student = new VipStudent();
            student=new VidoeDecorator(student);
            student=new HomeworkDecorator(student);
            student.Study();

        }
    }

    //抽象学生类
    public abstract class AbstactStudent{
        public abstract void Study();

     }

      //具体学生类
    public  class VipStudent:AbstactStudent
    {
          public override void Study()
          {
             System.Console.WriteLine("Join Vip!!!");
          }

          
     }
    //抽象装饰器类
    public  class BaseDecorator:AbstactStudent
    {
        private AbstactStudent baseDecorator;
        public BaseDecorator(AbstactStudent baseDecorator)
        {
            this.baseDecorator = baseDecorator;
        }
        public override void Study()
        {
            baseDecorator.Study();
        }
    }

    //具体装饰器类
    public  class VidoeDecorator:BaseDecorator
    {
      
        public VidoeDecorator(AbstactStudent baseDecorator) : base(baseDecorator)
        {
         
        }
       public override  void Study(){
           base.Study();
           System.Console.WriteLine("Video!!!");

       }
    }

     public  class HomeworkDecorator:BaseDecorator
    {
   
        public HomeworkDecorator(AbstactStudent baseDecorator) : base(baseDecorator)
        {
           
        }
        public override  void Study(){
           base.Study();
           System.Console.WriteLine("Homework!!!");

       }
    }


}