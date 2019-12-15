using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movingPolygons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 10);
            Point[] point = { new Point(100, 100), new Point(200, 100), new Point(200, 200),  new Point(100, 200) };
            Point[] point2 = { new Point(300, 300), new Point(400, 300), new Point(400, 400), new Point(300, 400) };
            Point[] point3 = { new Point(300, 100), new Point(400, 100), new Point(300, 200) };
            g.DrawPolygon(p, point);
            g.DrawPolygon(p, point2);
            g.DrawPolygon(p, point3);
            g.Dispose();
        }
        private static async Task AddAsync()
        {
           
                Console.WriteLine("***** Adding with Thread objects *****");
                Console.WriteLine("ID of thread in Main(): {0}",
                  Thread.CurrentThread.ManagedThreadId);
       
        }
    }
}
