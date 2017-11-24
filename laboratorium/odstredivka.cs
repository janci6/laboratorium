using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labolatorium
{
    class odstredivka : pristroj, Iovladanie
    {
        public override void vypisdetailinfo()
        {
            base.vypisinfo();
            Console.WriteLine("som odstredivka");
        }
        public void zapni()
        {
            zapnuty = true;
        }
        public void vypni()
        {
            zapnuty = false;
        }
    }
}
