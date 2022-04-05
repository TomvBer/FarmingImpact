﻿using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Ellipse Marker { get; set; }
        public Point Pointer { get; set; }
        public MainWindow()
        {

            InitializeComponent();
            Show();
        }


        private void Mondstadt_GotMouseCapture(object sender, MouseEventArgs e)
        {
        }

        private void Mondstadt_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {


            Ellipse mark = MakeMark();
            MondstadtGrid.Children.Add(mark);

        }
        private Ellipse MakeMark()
        {

            SolidColorBrush brush = new SolidColorBrush();
            Ellipse marker = new Ellipse();

            marker.Fill = Brushes.Blue;
            marker.Stroke = Brushes.Black;
            marker.StrokeThickness = 2;
            marker.Width = 10;
            marker.Height = 10;

            return marker;
        }

        private void Mondstadt_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var point = e.GetPosition(this);
            Ellipse mark = MakeMark();
            mark.SetValue(TopProperty, point.Y);
            mark.SetValue(LeftProperty, point.X);
            MondstadtGrid.Children.Add(mark);
        }
    }
}
