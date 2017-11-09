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

namespace AoS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            PrintDialog dlg = new PrintDialog();
            bool? result = dlg.ShowDialog();

            if (result.HasValue && result.Value)
            {
                //CardCanvas.Measure(new Size(dlg.PrintableAreaWidth, dlg.PrintableAreaHeight));
                //var topX = (dlg.PrintableAreaWidth - CardCanvas.DesiredSize.Width) / 4;
                //var topY = (dlg.PrintableAreaHeight - CardCanvas.DesiredSize.Height) / 4;
                ////CardCanvas.Measure(new Size(dlg.PrintableAreaWidth, dlg.PrintableAreaHeight));
                //CardCanvas.Arrange(new Rect(new Point(topX, topY), CardCanvas.DesiredSize));

                dlg.PrintVisual(CardCanvas, "Print a Large Image");
            }
        }
    }
}
