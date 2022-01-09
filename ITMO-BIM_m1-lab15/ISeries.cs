using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_BIM_m1_lab15
{
    interface ISeries
    {
        void setStart(int x); // устанавливает начальное значение

        int getNext(); // возвращает следующее число ряда

        void reset(); // выполняет сброс к начальному значению

    }
}
