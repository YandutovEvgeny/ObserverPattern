using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    class PositiveObserver : IObserver
    {
        Label _label;
        public PositiveObserver(Label label)
        {
            _label = label;
        }
        public void Notify(string article)
        {
            _label.Text = "Меня очень радует эта статья!!\n"
                + article + "\n Автору респект!";
        }
    }
}
