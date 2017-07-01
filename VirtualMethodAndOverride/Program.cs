using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodAndOverride
{
    class BaseClass
    {
        string currentclass1;
       public virtual void who()
       {
            Console.WriteLine(" Who() in base class");
       }
    }
    class DerivedClass1 : BaseClass
    {
        public override void who()
        {
            Console.WriteLine(" Who() in DerivedClass1 class");
        }
    }
    class DerivedClass2 : BaseClass
    {
        public override void who()
        {
            Console.WriteLine(" Who() in DerivedClass2 class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bobj1 = new BaseClass();
            BaseClass ObjRef;
            DerivedClass1 Dobj1 = new DerivedClass1();
            DerivedClass2 Dobj2 = new DerivedClass2();

            ObjRef = bobj1;
            ObjRef.who();
            ObjRef = Dobj1;
            ObjRef.who();
            ObjRef = Dobj2;
            ObjRef.who();

            Console.Read();
        }
    }
}
