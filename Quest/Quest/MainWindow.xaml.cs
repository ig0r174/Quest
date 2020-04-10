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

namespace Quest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var height = Convert.ToInt32(((System.Windows.Controls.Panel)Application.Current.MainWindow.Content).ActualHeight);
            var width = Convert.ToInt32(((System.Windows.Controls.Panel)Application.Current.MainWindow.Content).ActualWidth);

            Random rnd = new Random();
            while (true)
            {
                TranslateTransform translateTransform1 = new TranslateTransform(rnd.Next(0, width), rnd.Next(0, 200));
                Button.RenderTransform = translateTransform1;
            }

        }
    }
}
