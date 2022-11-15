using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overwtch_Logo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen whitePen = new Pen(Color.White, 14);
            Pen white2Pen = new Pen(Color.White, 14);
            Pen orangePen = new Pen(Color.Orange, 14);

            SolidBrush blackBrush = new SolidBrush(Color.Black);

            g.Clear(Color.Black);
    
            g.DrawArc(whitePen, 20, 20, 100, 100, 325, 250);
            g.DrawArc(orangePen, 20, 20, 100, 100, 225, 90);

            g.DrawLine(white2Pen, 80, 80, 100, 100);
            g.DrawLine(white2Pen, 40, 100, 60, 80);

            g.DrawPie(white2Pen, 62, 35, 15, 50, 50, 80);
        }
    }
}
