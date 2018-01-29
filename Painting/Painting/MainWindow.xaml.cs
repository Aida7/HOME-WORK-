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

namespace Painting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation sizeainme = new DoubleAnimation();
            sizeainme.Duration = new Duration(TimeSpan.FromSeconds(2));
            sizeainme.From = 20;
            sizeainme.To = 45;
            sizeainme.AutoReverse = true;
            sizeainme.RepeatBehavior = RepeatBehavior.Forever;
            rectangle.BeginAnimation(Rectangle.HeightProperty, sizeainme);
        }
    }
}
