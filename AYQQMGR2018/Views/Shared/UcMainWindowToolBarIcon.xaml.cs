using AYQQMGR2018.Controllers;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AYQQMGR2018.Views.Shared
{
    /// <summary>
    /// UcMainWindowToolBarIcon.xaml 的交互逻辑
    /// </summary>
    public partial class UcMainWindowToolBarIcon : UserControl
    {
        public UcMainWindowToolBarIcon()
        {
            InitializeComponent();
        }

        private void AyToolBoxRightButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void DoubleAnimationUsingKeyFrames_Completed(object sender, EventArgs e)
        {
            if (sb != null)
            {
                sb.Begin();
            }
        }
        Storyboard sb;
        bool isfir = true;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (isfir)
            {
                sb = this.FindResource("SacnAYQQ2") as Storyboard;
                isfir = false;
            }
        }

        private void AyToolBoxRightButton_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Activate();
        }

        private void AyToolBoxRightButton_Click_2(object sender, RoutedEventArgs e)
        {
            var main = Application.Current.MainWindow;
            main.Activate();
            var context = main.DataContext as ViewStartController;
            if (context != null)
            {
                context.Model.ViewIndex = true;
            }


        }

        private void AyToolBoxRightButton_Click_3(object sender, RoutedEventArgs e)
        {
            var main = Application.Current.MainWindow;
            main.Activate();
            var context = main.DataContext as ViewStartController;
            if (context != null)
            {
                context.Model.ViewShaDu = true;
            }
        }

        private void AyToolBoxRightButton_Click_4(object sender, RoutedEventArgs e)
        {
            var main = Application.Current.MainWindow;
            main.Activate();

            var context = main.DataContext as ViewStartController;
            if (context != null)
            {
                context.Model.ViewLaJi = true;
            }

        }

        private void AyToolBoxRightButton_Click_5(object sender, RoutedEventArgs e)
        {
            var main = Application.Current.MainWindow;
            main.Activate();
            var context = main.DataContext as ViewStartController;
            if (context != null)
            {
                context.Model.ViewJiaSu = true;
            }
        }

        private void AyToolBoxRightButton_Click_6(object sender, RoutedEventArgs e)
        {
            var main = Application.Current.MainWindow;
            main.Activate();

            var context = main.DataContext as ViewStartController;
            if (context != null)
            {
                context.Model.ViewZhenSuo = true;
            }
        }
    }
}
