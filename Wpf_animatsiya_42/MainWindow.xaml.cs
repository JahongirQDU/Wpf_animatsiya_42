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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_animatsiya_42
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
        private void Kattalashtirish_Animatsiyasi(object sender, RoutedEventArgs e)
        {
            DoubleAnimation Kattalashtirish = new DoubleAnimation
            {
                From = 1,
                To = 2,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true, // yoki true — qaytib kichiklashadi
                RepeatBehavior = RepeatBehavior.Forever
            };
            DoubleAnimation Kichiklashtir = new DoubleAnimation
            {
                From = 1,
                To = 0.5,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true, // yoki true — qaytib kichiklashadi
                RepeatBehavior = RepeatBehavior.Forever
            };

            ImageScale.BeginAnimation(ScaleTransform.ScaleXProperty, Kattalashtirish);
            ImageScale.BeginAnimation(ScaleTransform.ScaleYProperty, Kattalashtirish);
        }
        private void Kattalashtirish_Animatsiyasi1(object sender, RoutedEventArgs e)
        {
            DoubleAnimation Kattalashtirish = new DoubleAnimation
            {
                From = 1,
                To = 2,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true, // yoki true — qaytib kichiklashadi
                RepeatBehavior = RepeatBehavior.Forever
            };
            DoubleAnimation Kichiklashtir = new DoubleAnimation
            {
                From = 1,
                To = 0.5,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true, // yoki true — qaytib kichiklashadi
                RepeatBehavior = RepeatBehavior.Forever
            };

            ImageScale.BeginAnimation(ScaleTransform.ScaleXProperty, Kichiklashtir);
            ImageScale.BeginAnimation(ScaleTransform.ScaleYProperty, Kichiklashtir);
        }
        private void Kattalashtirish_Animatsiyasi_Stop(object sender, RoutedEventArgs e)
        {
            DoubleAnimation Kattalashtirish = new DoubleAnimation
            {
                From = 1,
                To = 2,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true, // yoki true — qaytib kichiklashadi
                RepeatBehavior = RepeatBehavior.Forever
            };
            DoubleAnimation Kichiklashtir = new DoubleAnimation
            {
                From = 1,
                To = 1,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true, // yoki true — qaytib kichiklashadi
                RepeatBehavior = RepeatBehavior.Forever
            };

            ImageScale.BeginAnimation(ScaleTransform.ScaleXProperty, Kichiklashtir);
            ImageScale.BeginAnimation(ScaleTransform.ScaleYProperty, Kichiklashtir);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
         

            DoubleAnimation harakatAnimatsiyasi = new DoubleAnimation
            {
                From = -400,
                To = 2000,
                Duration = TimeSpan.FromSeconds(10),
                RepeatBehavior = RepeatBehavior.Forever
            };
            Matn.BeginAnimation(Canvas.LeftProperty, harakatAnimatsiyasi);
            // Matn.BeginAnimation(Canvas.TopProperty, harakatAnimatsiyasi);


            DoubleAnimation radiusAnim = new DoubleAnimation
            {
                From = 10,
                To = 200,
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            DoubleAnimation radiusAnim1 = new DoubleAnimation
            {
                From = 200,
                To = 10,
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            Tortburchak.BeginAnimation(Rectangle.RadiusXProperty, radiusAnim);
            Tortburchak.BeginAnimation(Rectangle.RadiusYProperty, radiusAnim);

            //// Gradient fon ranglarini animatsiya qilish
            var gradientBrush = new LinearGradientBrush();
            gradientBrush.StartPoint = new Point(0, 0);
            gradientBrush.EndPoint = new Point(1, 1);

            var stop1 = new GradientStop(Colors.Red, 0);
            var stop2 = new GradientStop(Colors.Blue, 1);

            gradientBrush.GradientStops.Add(stop1);
            gradientBrush.GradientStops.Add(stop2);
            Tortburchak.Fill = gradientBrush;

            var colorAnim1 = new ColorAnimation
            {
                From = Colors.Red,
                To = Colors.Orange,
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            var colorAnim2 = new ColorAnimation
            {
                From = Colors.Blue,
                To = Colors.Purple,
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            stop1.BeginAnimation(GradientStop.ColorProperty, colorAnim1);
            stop2.BeginAnimation(GradientStop.ColorProperty, colorAnim2);
        }
      
    }
    }
