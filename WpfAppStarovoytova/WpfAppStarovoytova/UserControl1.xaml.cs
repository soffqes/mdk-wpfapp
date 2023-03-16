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

namespace WpfAppStarovoytova
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public ImageSource ColoredSource { get; set; }
        public ImageSource BlackWhiteSource =>
            (ColoredSource == null) ? null : new FormatConvertedBitmap((BitmapSource)ColoredSource, PixelFormats.Gray8, null, 0);
        public UserControl1()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void BthAction_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Description, Header, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
