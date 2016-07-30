using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MeeCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int RightEyeR = 0;
        int RightEyeG = 0;
        int RightEyeB = 0;
        int LeftEyeR = 0;
        int LeftEyeG = 0;
        int LeftEyeB = 0;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ellipse myEllipse = new Ellipse();
            myEllipse.Width = 500;
            myEllipse.Height = 10;
            myEllipse.Fill = Brushes.Blue;

            FaceCanvas.Children.Add(myEllipse);
        }

        private void LeftEyeSliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            LeftEyeR = (int)e.NewValue;
            refillEyes();
        }

        private void refillEyes()
        {
            if (RightEyeEllipse != null)
            {
                RightEyeEllipse.Fill = new SolidColorBrush(Color.FromRgb((byte)RightEyeR, (byte)RightEyeG, (byte)RightEyeB));
            }
            if (LeftEyeEllipse != null)
            {
                LeftEyeEllipse.Fill = new SolidColorBrush(Color.FromRgb((byte)LeftEyeR, (byte)LeftEyeG, (byte)LeftEyeB));
            }
        }

        private void RightEyeSliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RightEyeR = (int)e.NewValue;
            refillEyes();
        }

        private void RightEyeSliderG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RightEyeG = (int)e.NewValue;
            refillEyes();
        }

        private void RightEyeSliderB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RightEyeB = (int)e.NewValue;
            refillEyes();
        }

        private void LeftEyeSliderG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            LeftEyeG = (int)e.NewValue;
            refillEyes();
        }

        private void LeftEyeSliderB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            LeftEyeG = (int)e.NewValue;
            refillEyes();
        }

        private void Hair1_Checked(object sender, RoutedEventArgs e)
        {
            System.Windows.Point Point1 = new System.Windows.Point(-.8, 0.3);
            System.Windows.Point Point2 = new System.Windows.Point(0.0, 0.0);
            System.Windows.Point Point3 = new System.Windows.Point(0.8, 0.3);
            System.Windows.Point Point4 = new System.Windows.Point(1, 1);
            System.Windows.Point Point5 = new System.Windows.Point(0.4, 0.4);
            System.Windows.Point Point6 = new System.Windows.Point(0.0, 0.5);
            System.Windows.Point Point7 = new System.Windows.Point(-.4, 0.4);
            System.Windows.Point Point8 = new System.Windows.Point(-1, 1);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);
            myPointCollection.Add(Point5);
            myPointCollection.Add(Point6);
            myPointCollection.Add(Point7);
            myPointCollection.Add(Point8);
            Hair.Points = myPointCollection;
        }

        private void Hair2_Checked(object sender, RoutedEventArgs e)
        {
            System.Windows.Point Point1 = new System.Windows.Point(-1, 0);
            System.Windows.Point Point2 = new System.Windows.Point(1, 0);
            System.Windows.Point Point3 = new System.Windows.Point(1, 1);
            System.Windows.Point Point4 = new System.Windows.Point(.8, 1);
            System.Windows.Point Point5 = new System.Windows.Point(0.5, 0.5);
            System.Windows.Point Point6 = new System.Windows.Point(-0.5, 0.5);
            System.Windows.Point Point7 = new System.Windows.Point(-.8, 1);
            System.Windows.Point Point8 = new System.Windows.Point(-1, 1);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);
            myPointCollection.Add(Point5);
            myPointCollection.Add(Point6);
            myPointCollection.Add(Point7);
            myPointCollection.Add(Point8);
            Hair.Points = myPointCollection;
        }
    }
}
