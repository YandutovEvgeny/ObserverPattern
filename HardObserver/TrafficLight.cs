using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardObserver
{
    class TrafficLight : IObserver
    {
        PictureBox _pictureBox;
        Graphics _graphics;

        public TrafficLight(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
            _graphics = _pictureBox.CreateGraphics();
        }
        public void Back(Train train)
        {
            _graphics.FillEllipse
                (new SolidBrush(Color.Green), 0, 0, _pictureBox.Width, _pictureBox.Height);
        }

        public void Come(Train train)
        {
            _graphics.FillEllipse
                (new SolidBrush(Color.Red), 0, 0, _pictureBox.Width, _pictureBox.Height);
        }
    }
}
