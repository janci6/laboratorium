using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labolatorium
{
    partial class labolatorium
    {
        public pristroj labolatornypristroj1;
        public pristroj labolatornypristroj2;

        public void Spustvyzkum()
        {

            veduci veduci = new veduci("Mgr.");

            labolatornypristroj1 = new mikroskopcs();
            labolatornypristroj2 = new odstredivka();

            labolatornypristroj1.nazov = "NH12";
            labolatornypristroj2.nazov = "NH24";

            Iovladanie ovladanie = (Iovladanie) labolatornypristroj1;
            ovladanie.zapni();

            labolatornypristroj1.vypisdetailinfo();
            labolatornypristroj2.vypisdetailinfo();
        }
    }
}
