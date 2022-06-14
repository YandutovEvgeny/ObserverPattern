using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardObserver
{
    class Board : IObserver
    {
        Label _label;
        string _name;

        public Board(Label label, string name)
        {
            _label = label;
            _name = name;
        }

        public void Back(Train train)
        {
            _label.Text = $"Поезд {train.Number} отъезжает от станции {_name}";
        }

        public void Come(Train train)
        {
            _label.Text = $"Поезд {train.Number} подъезжает к станции {_name}";
        }
    }
}
