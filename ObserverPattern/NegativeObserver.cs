using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    class NegativeObserver : IObserver
    {
        Label _label;
        public NegativeObserver(Label label)
        {
            _label = label;
        }
        public void Notify(string article)
        {
            _label.Text = "Вы видели что пишет эта газета!?!?!?\n" 
                + article + "\n Я думаю, что это не приемлемо!";
        }
    }
}
