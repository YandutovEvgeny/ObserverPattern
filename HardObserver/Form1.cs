using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardObserver
{
    public partial class Form1 : Form
    {
        Train train1;
        Train train2;
        IObserver trafficLight;
        IObserver board;
        IObserver barrier;
        public Form1()
        {
            InitializeComponent();
            train1 = new Train("Е581.Москва - Чебоксары");
            train2 = new Train("К381.Челябинск - Сочи");

            trafficLight = new TrafficLight(pictureBox1);
            board = new Board(label1, "Посёлок \"Авдеевка\"");
            barrier = new Barrier(panel1);

            train1.AddObserver(trafficLight);
            train1.AddObserver(board);
            train1.AddObserver(barrier);

            train2.AddObserver(trafficLight);
            train2.AddObserver(board);
            train2.AddObserver(barrier);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left -= 5;
            if (pictureBox2.Left < -100)
                pictureBox2.Left = Width;
            if (pictureBox2.Left < 650 && pictureBox2.Left > 650)
                train1.Come();
            else if(pictureBox2.Left < 250 && pictureBox2.Left > 200)
                train1.Back();
            
            pictureBox3.Left -= 5;
            if (pictureBox3.Left < -100)
                pictureBox3.Left = Width;
            if (pictureBox3.Left < 650 && pictureBox3.Left > 600)
                train2.Come();
            else if (pictureBox3.Left < 250 && pictureBox3.Left > 200)
                train2.Back();
        }
    }
}
