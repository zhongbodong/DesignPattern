namespace DesignPatterns.Behavior
{
    //责任链模式:类与类之间需要一层一层的相互交互
    //这里以一个审批过程为例
    public class ResponsibilityChainPattern
    {
          public static void Show()
        {

           AuditContext auditContext=new AuditContext (30,"ZZZ");
           AbstractAuditor pm=new PM("PM");
           AbstractAuditor manager=new Manager("Manager");
           AbstractAuditor vice=new VicePresent("Vice");
           AbstractAuditor present=new Present("Present");
           pm.NextApprover=manager;
           manager.NextApprover=vice;
           vice.NextApprover=present;
           var result= pm.ProcessRequest(auditContext);
           if (result)
           {
               System.Console.WriteLine("Thanx boss");
           }
           else{
               System.Console.WriteLine("I will go");
           }

        }
    }

    //待审批的信息
    public class AuditContext{

        //请假时间
         public double LeaveTime { get; set; }
        // 请假人
        public string Name { get; set; }
        public AuditContext(double leaveTime, string name)
        {
            LeaveTime = leaveTime;
            Name = name;
        }

    }
    //抽象审批者
     public abstract class AbstractAuditor{
        public AbstractAuditor NextApprover { get; set; }
        public string Name { get; set; }
        public AbstractAuditor(string name)
        {
            this.Name = name;
        }
        public abstract bool ProcessRequest(AuditContext auditContext);

    }
    //具体审批者（PM）
     public  class PM:AbstractAuditor{
          public PM(string name)
            : base(name)
        { }

        public override bool ProcessRequest(AuditContext request)
        {
            if (request.LeaveTime < 7)
            {
                System.Console.WriteLine("{0}-{1} approved the request of Leave {2}", this, Name, request.Name);
            }
            else if (NextApprover != null)
            {
               System.Console.WriteLine("PM Said:Sorry,I will commit it to Manager,I only handle limit 7");
               return NextApprover.ProcessRequest(request);
            }
            return true;
        }

    }
    //具体审批者（Manager）
    public class Manager:AbstractAuditor
    {

        public Manager(string name): base(name)
        { }

        public override bool ProcessRequest(AuditContext request)
        {
            if (request.LeaveTime < 14)
            {
                System.Console.WriteLine("{0}-{1} approved the request of Leave {2}", this, Name, request.Name);
            }
            else if (NextApprover != null)
            {
               System.Console.WriteLine("Manager Said:Sorry,I will commit it to Manager,I only handle limit 14");
               return NextApprover.ProcessRequest(request);
            }
            return true;
        }
    }
     //具体审批者（VicePresent）
     public  class VicePresent:AbstractAuditor{
           public VicePresent(string name): base(name)
        { }

        public override bool ProcessRequest(AuditContext request)
        {
            if (request.LeaveTime < 21)
            {
                System.Console.WriteLine("{0}-{1} approved the request of Leave {2}", this, Name, request.Name);
            }
            else if (NextApprover != null)
            {
               System.Console.WriteLine("VicePresent Said:Sorry,I will commit it to Manager,I only handle limit 21");
               return  NextApprover.ProcessRequest(request);
            }
            return true;
        }

    }

     //具体审批者（Present）
     public  class Present:AbstractAuditor{

            public Present(string name): base(name)
        { }

        public override bool ProcessRequest(AuditContext request)
        {
            if (request.LeaveTime < 28)
            {
                System.Console.WriteLine("{0}-{1} approved the request of Leave {2}", this, Name, request.Name);
            }
            else 
            {
                 System.Console.WriteLine("Present Said:Sorry,you can not leave so long!");
                return false;
            }
            return true;
        }

    }

}