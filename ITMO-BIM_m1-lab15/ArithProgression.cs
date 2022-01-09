using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_BIM_m1_lab15
{
    class ArithProgression : ISeries
    {
        int d,x0,xi;

        public ArithProgression(int d) 
        {
            this.d = d;
        }
        public int getNext()
        {
            this.xi += d;
            return xi;
        }

        public void reset()
        {
            this.xi = x0;
        }

        public void setStart(int x)
        {
            this.x0 = x;
            reset();
        }
    }
}
