using System;

namespace main.OOPs
{
    internal class OverrideWithAbstractClass : ParentClass
    {
        public Override() : base()
        {
            Console.WriteLine("Child Constructor");

        }
        public void Print()
        {
            Console.WriteLine("Derived Print");
        }

        public override void ShowMsg()
        {
            Console.WriteLine("Child Overridden Method");
            base.ShowMsg();
        }
    }

    internal class ParentClass : BaseClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Constructor");
            ShowMsg();
        }
        public override void ShowMsg()
        {
            Console.WriteLine("Parent Overridden Method");
        }

    }

    internal abstract class BaseClass
    {
        public abstract void ShowMsg();
    }

}
 //Output : 
    //    Parent Constructor
    //    Child Overridden Method
    //    Parent Overridden Method
    //    Child Constructor
