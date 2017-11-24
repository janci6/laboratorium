using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labolatorium
{
    abstract class pristroj
    {
        protected bool zapnuty;

        public string nazov;

        abstract public void vypisdetailinfo();

        public virtual void vypisinfo()
        {
            Console.WriteLine("nazov pristroja je {0}", nazov);
        }
        protected void vypisStav()
        {
            Console.WriteLine("zapnute: {0}", zapnuty);
        }
    }
}
