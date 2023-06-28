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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Pictures> pictures = new List<Pictures>()
        {
            new Pictures("Pictures\\OIP.jpg"),
            new Pictures("Pictures\\OIP (1).jpg"),
            new Pictures("Pictures\\th.jpg")
        };
        public MainWindow()
        {
            InitializeComponent();
            PhotoShop.ItemsSource = pictures;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            StackPanel stackPanel = button.Parent as StackPanel;
            TextBlock textBlock = stackPanel.Children[0] as TextBlock;
            int index = int.Parse(textBlock.Text);
            string sourcePath = pictures[index - 1].Source;
            BitmapImage bitmapImage = new BitmapImage(new Uri(sourcePath, UriKind.RelativeOrAbsolute));
            Canvas.Source = bitmapImage;

        }

        private void Width_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Canvas.Width = e.NewValue;
        }

        private void Height_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Canvas.Height = e.NewValue;
        }
    }
}
