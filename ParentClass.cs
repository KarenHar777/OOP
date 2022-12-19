using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public  class ParentClass
    {
        int a;
        public int b;
        private int c;
        internal int e;
        protected int d = 123;

        public int MethodPublic(int x)
        {
            ChiledClass objChild = new ChiledClass();
           
            return 0;
        }

        void MethodDefault()
        {

        }
        private void MethodPrivate()
        {

        }

    }
}
