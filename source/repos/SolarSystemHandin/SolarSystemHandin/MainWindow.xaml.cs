using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SolarSystemHandin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private System.Windows.Threading.DispatcherTimer timer;
        private System.Windows.Threading.DispatcherTimer timer2;
        int loopCounter = 10;
        Ellipse ellipse = new Ellipse();
        Ellipse ellipse2 = null;
        int rev = 0;
        double rad = 5;
        double ellipse1width = 100;
        double ellipse1height = 100;
        double ellipse2width = 200;
        double ellipse2height = 200;
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine("got here");

            /* timer = new System.Windows.Threading.DispatcherTimer();
             timer.Interval = TimeSpan.FromSeconds(0.09); //Set the interval period here.
             timer.Tick += timer1_Tick;
             timer.Start();
             timer2 = new System.Windows.Threading.DispatcherTimer();
             timer2.Interval = TimeSpan.FromSeconds(0.09); //Set the interval period here.
             timer2.Tick += timer2_Tick;
             timer2.Start();*/
            //int second;
            TimerCallback timeCB = new TimerCallback(threadTimer);
            System.Threading.Timer something = new System.Threading.Timer(timeCB,null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            PaintCanvas.Children.Remove(ellipse);
           

            rad = rad + 1;
            ellipse = CreateAnEllipse(30, 30);
            PaintCanvas.Children.Add(ellipse);
            //width = width + (Math.cos(rad * Math.PI / 360);
            //height = height  + (Math.Tan(rad * Math.PI / 360);
            ellipse1height = ellipse1height + Math.Sin(rad)* 10;
            ellipse1width = ellipse1width + Math.Cos(rad) * 10;
            Canvas.SetLeft(ellipse, ellipse1width);
            Canvas.SetTop(ellipse, ellipse1height);
            Console.WriteLine("y: " + ellipse1height);
            Console.WriteLine("x: " + ellipse1width);
            rev++;
            if(rev==360)
            {
                
                rev = 0;
                ellipse1height = 100;
                ellipse1width = 100;
                rad = 5;
            }
    }
        public void threadTimer(object obj)
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                ellipse = new Ellipse()
                {
                    Height = 20, Width = 20
                };
                
                PaintCanvas.Children.Remove(ellipse);


                rad = rad + 1;
                
                PaintCanvas.Children.Add(ellipse);
                //width = width + (Math.cos(rad * Math.PI / 360);
                //height = height  + (Math.Tan(rad * Math.PI / 360);
                ellipse1height = ellipse1height + Math.Sin(rad) * 10;
                ellipse1width = ellipse1width + Math.Cos(rad) * 10;
                Canvas.SetLeft(ellipse, ellipse1width);
                Canvas.SetTop(ellipse, ellipse1height);
                Console.WriteLine("y: " + ellipse1height);
                Console.WriteLine("x: " + ellipse1width);
                rev++;
                if (rev == 360)
                {

                    rev = 0;
                    ellipse1height = 100;
                    ellipse1width = 100;
                    rad = 5;
                }
            });



         
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            PaintCanvas.Children.Remove(ellipse2);


            rad = rad + 1;
            ellipse2 = CreateAnEllipse(20, 20);
            PaintCanvas.Children.Add(ellipse2);
            //width = width + (Math.cos(rad * Math.PI / 360);
            //height = height  + (Math.Tan(rad * Math.PI / 360);
            ellipse2height = ellipse2height + Math.Sin(rad) * 10;
            ellipse2width = ellipse2width + Math.Cos(rad) * 10;
            Canvas.SetLeft(ellipse2, ellipse2width);
            Canvas.SetTop(ellipse2, ellipse2height);
            Console.WriteLine("y: " + ellipse2height);
            Console.WriteLine("x: " + ellipse2width);
            rev++;
            if (rev == 360)
            {
               
                rev = 0;
                ellipse2height = 100;
                ellipse2width = 100;
                rad = 5;
            }
        }


        public Ellipse CreateAnEllipse(int height, int width)
        {
            SolidColorBrush fillBrush = new SolidColorBrush() { Color = Colors.Red };
            SolidColorBrush borderBrush = new SolidColorBrush() { Color = Colors.Black };

            return new Ellipse()
            {
                Height = height,
                Width = width,
                StrokeThickness = 1,
                Stroke = borderBrush,
                Fill = fillBrush
            };
        }
    }
}
