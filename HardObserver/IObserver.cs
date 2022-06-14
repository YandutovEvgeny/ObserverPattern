using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardObserver
{
    interface IObserver
    {
        void Come(Train train);
        void Back(Train train);
    }
}
