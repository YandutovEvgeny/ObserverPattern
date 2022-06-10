using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class Form1 : Form
    {
        WallPaper wallPaper;
        IObserver Petya;
        IObserver Ivan;
        public Form1()
        {
            InitializeComponent();
            wallPaper = new WallPaper();
            Petya = new NegativeObserver(label1);
            Ivan = new PositiveObserver(label2);
            wallPaper.AddObserver(Petya);
            wallPaper.AddObserver(Ivan);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wallPaper.NewArticle(richTextBox1.Text);
        }
    }
}
