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

namespace Keyboard
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

        ResourceDictionary d = new ResourceDictionary();

        private void dark_Checked(object sender, RoutedEventArgs e)
        {
            d.Source = new Uri("DictionaryDark.xaml", UriKind.Relative);
            Resources.MergedDictionaries.Add(d);
            SolidColorBrush w=new SolidColorBrush(Colors.White);
            dark.Foreground = w;
        }

        private void dark_Unchecked(object sender, RoutedEventArgs e)
        {
            d.Source = new Uri("DictionaryLight.xaml", UriKind.Relative);
            Resources.MergedDictionaries.Add(d);
            SolidColorBrush b = new SolidColorBrush(Colors.Black);
            dark.Foreground = b;

        }
    }
}
