using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class A : ParentClass
    {
        static void Main(string[] args)
        {
            ChiledClass obj2 = new ChiledClass();
            obj2.b = 6; // public
            obj2.e = 5; // internal
            obj2.mane = "Mane"; //public
            obj2.MethodPublic(5); //public
            obj2.Met();// public

            var objC = new A();
            var onjP = new ParentClass();

            objC.d = 34567;


            Basic  bs= new Basic(7);
            Basic basic = new Basic();

        //Console.WriteLine(basic2.a);
        //Console.WriteLine(basic.a);
        Console.WriteLine(Basic.a);
        }
    }
}
