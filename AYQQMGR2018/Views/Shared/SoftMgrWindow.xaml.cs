using Ay.Framework.WPF.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AYQQMGR2018.Views
{
    /// <summary>
    /// SoftMgrWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SoftMgrWindow : Window
    {
        public SoftMgrWindow()
        {
            InitializeComponent();
        }

        private void AyWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
