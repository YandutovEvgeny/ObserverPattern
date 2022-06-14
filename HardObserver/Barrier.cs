using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardObserver
{
    class Barrier : IObserver
    {
        public Panel _panel;
        public int top;
        public Barrier(Panel panel)
        {
            _panel = panel;
            top = _panel.Top;

        }
        public void Back(Train train)
        {
            _panel.Top = top;
            _panel.Width = 16;
            _panel.Height = 100;
        }

        public void Come(Train train)
        {
            _panel.Top = top + 120;
            _panel.Width = 100;
            _panel.Height = 16;
        }
    }
}
