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
using System.Windows.Shapes;

namespace Final
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        int i = 1;
        public Options()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void pre_Click(object sender, RoutedEventArgs e)
        {
            i--;
            if (i < 1)
            {
                i = 6;
            }
            picture.Source=new BitmapImage(new Uri(@"images/" + i + ".jpg",UriKind.Relative));
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            i++;
            if (i > 6)
            {
                i = 1;
            }
            picture.Source = new BitmapImage(new Uri(@"images/" + i + ".jpg", UriKind.Relative));
        }
    }
}
