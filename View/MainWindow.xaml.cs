using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System;
using System.Collections.Generic;
using System.IO;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public StackPanel MenuStackPanel { get; set; }
        public Canvas RegionCanvas { get; set; }
        public List<ImageBrush> MapImages { get; set; }

       public UserControls.BattlePassChecks battlePass;


        public Ellipse Marker { get; set; }
        public Point Pointer { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Mapsloaded();
            RegionCanvas = MapRender;

            Show();
        }


        private void Mondstadt_GotMouseCapture(object sender, MouseEventArgs e)
        {
        }

        private void Mondstadt_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {


            Ellipse mark = MakeMark();
            MainGrid.Children.Add(mark);

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
            MainGrid.Children.Add(mark);
        }

        private void MainMapsControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            switch (MainMapsControl.SelectedIndex)
            {
                case 0:
                    RegionCanvas.Background = MapImages[0];
                    return;
                case 1:
                    RegionCanvas.Background = MapImages[1];
                    return;
                case 2:
                    RegionCanvas.Background = MapImages[0];
                    return;

            }
            //Function should be seperated later on 

        }
        public bool Mapsloaded()
        {
            if (MapImages != null) { return true; }
            MapImages = new List<ImageBrush>();
            ImageBrush MondstadtMap = new();
            ImageBrush LiyueMap = new();
            ImageBrush InazumaMap = new();
            MondstadtMap.ImageSource = new BitmapImage(uriSource: new Uri("C:\\Users\\TomVa\\source\\repos\\FarmingImpact\\View\\Regions\\Screenshot 2022-03-19 140634.bmp", UriKind.Absolute));
            LiyueMap.ImageSource = new BitmapImage(uriSource: new Uri("C:\\Users\\TomVa\\source\\repos\\FarmingImpact\\View\\Regions\\Screenshot 2022-04-19 151247.bmp", UriKind.Absolute));
            MapImages.Insert(0, MondstadtMap);
            MapImages.Insert(1, LiyueMap);
            return false;
        }

        private void MainMapsControl_Selected(object sender, RoutedEventArgs e)
        {
            //Function should be seperated later on 
            if (MainMapsControl.SelectedContent == MondstadtTab)
            {
                RegionCanvas.Background = MapImages[0];
                return;
            }
            if (MainMapsControl.SelectedContent == LiyueTab)
            {
                RegionCanvas.Background = MapImages[1];
                return;
            }
            if (MainMapsControl.SelectedContent == InazumaTab)
            {
                RegionCanvas.Background = MapImages[2];
            }
            if (MainMapsControl.SelectedContent == BattlePassTab)
            {
                MainMapsControl.SelectedItem = battlePass;

            }
        }

        private void MainMapsControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
