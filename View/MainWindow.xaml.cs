
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

namespace mvvm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static double X { get; set; }
        public static double Y { get; set; }

        private void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            System.Windows.Point position = e.GetPosition(chartCanvas);
            double pX = position.X;
            double pY = position.Y;
            X = Math.Round(((pX - 200) / 10), 1);
            Y = Math.Round((-(pY - 200) / 10), 1);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RenderTargetBitmap rtb = new RenderTargetBitmap((int)chartCanvas.RenderSize.Width,
(int)chartCanvas.RenderSize.Height, 96d, 96d, System.Windows.Media.PixelFormats.Default);
            rtb.Render(chartCanvas);

            var crop = new CroppedBitmap(rtb, new Int32Rect(50, 50, 350, 350));

            BitmapEncoder pngEncoder = new PngBitmapEncoder();
            pngEncoder.Frames.Add(BitmapFrame.Create(crop));

            using (var fs = System.IO.File.OpenWrite("SavedFile.png"))
            {
                pngEncoder.Save(fs);
            }
            MessageBox.Show("saved!");
        }         


  
    }
}
