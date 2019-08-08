using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Threading;
using Ay.Framework.WPF.Controls;
using Ay.MvcFramework;
using AYQQMGR2018.Controllers;


namespace AYQQMGR2018.Views
{
    /// <summary>
    /// _ViewStartView.xaml 
    /// 创建时间：2017/9/5 11:57:44
    /// </summary>
    public partial class _ViewStart : AyWindow
    {
        public _ViewStart()
        {
            InitializeComponent();
            Application.Current.MainWindow = this;
            biEnter = new BitmapImage(new Uri("pack://application:,,,/AYQQMGR2018;component/Contents/Images/dollarHover.png", UriKind.RelativeOrAbsolute));
            biLeave = new BitmapImage(new Uri("pack://application:,,,/AYQQMGR2018;component/Contents/Images/dollarStatic.png", UriKind.RelativeOrAbsolute));
            lvEnter = new BitmapImage(new Uri("pack://application:,,,/AYQQMGR2018;component/Contents/Images/lvHover.png", UriKind.RelativeOrAbsolute));
            lvLeave = new BitmapImage(new Uri("pack://application:,,,/AYQQMGR2018;component/Contents/Images/lvStatic.png", UriKind.RelativeOrAbsolute));
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.ayjs.net");
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            base.Close();
        }
        BitmapImage biEnter = null;
        BitmapImage biLeave = null;
        BitmapImage lvEnter = null;
        BitmapImage lvLeave = null;
        private void Canvas_MouseEnter(object sender, MouseEventArgs e)
        {
            ngbDollar.Image = biEnter;
        }

        private void Canvas_MouseLeave(object sender, MouseEventArgs e)
        {
            ngbDollar.Image = biLeave;
        }

        private void levelRec_MouseEnter(object sender, MouseEventArgs e)
        {
            ngbLevel.Image = lvEnter;

        }

        private void levelRec_MouseLeave(object sender, MouseEventArgs e)
        {
            ngbLevel.Image = lvLeave;
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            ayWinTool.Dispose();
            base.OnClosing(e);
        }


        #region 用于控制浏览器打开网页
        FormsWebBrowser web = null;
        #endregion

        private void rdo1_Checked(object sender, RoutedEventArgs e)
        {
            AyNavRadioButton nrb1 = sender as AyNavRadioButton;
            if (nrb1 != null)
            {
                if (nrb1.Tag != null)
                {
                    var tmd = nrb1.Tag.ToString();
                    if (string.IsNullOrEmpty(tmd)) return;
                    if (tmd.IndexOf("http:/") == 0 || tmd.IndexOf("https:/") == 0 || tmd.IndexOf("file:/") == 0)
                    {
                        this.layoutMain.Child = null;
                        if (web == null)
                        {
                            web = new FormsWebBrowser(this.layoutMain, false); //或者直接this
                        }

                        web.WebBrowser.Navigate(new Uri(tmd));
                    }
                    else
                    {
                        this.layoutMain.Child = null;
                        if (web != null)
                        {
                            web._formCloseLock = true;
                            web._form.Close();
                            web = null;
                        }
                        Frame n = new Frame();
                        n.VerticalAlignment = VerticalAlignment.Stretch;
                        n.HorizontalAlignment = HorizontalAlignment.Stretch;
                        n.NavigationUIVisibility = NavigationUIVisibility.Hidden;
                        n.Source = new Uri(tmd, UriKind.Relative);
                        this.layoutMain.Child = n;
                    }
                    startSb.Begin();
                }
            }
        }
        public Storyboard startSb = new Storyboard();
        private void AyWindow_Loaded(object sender, RoutedEventArgs e)
        {


            DoubleAnimation startOpacityAnimation =
                   new DoubleAnimation(0, 1.0, new Duration(TimeSpan.FromSeconds(0.2)));
            Storyboard.SetTarget(startOpacityAnimation, this.layoutMain);
            Storyboard.SetTargetProperty(startOpacityAnimation, new PropertyPath("Opacity", new object[0]));

            ThicknessAnimation startTopAnimation =
             new ThicknessAnimation(new Thickness(0, 15, 0, 0), new Thickness(0, 0, 0, 0), new Duration(TimeSpan.FromSeconds(0.2)));
            Storyboard.SetTarget(startTopAnimation, this.layoutMain);
            Storyboard.SetTargetProperty(startTopAnimation, new PropertyPath("Margin"));
            startSb.Children.Add(startOpacityAnimation);
            startSb.Children.Add(startTopAnimation);
            startSb.Begin();
        }

        private void Ay_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }

























    public partial class _ViewStart : AyWindow
    {
        #region 控制器
        private Actions<ViewStartController> _mvc;
        public Actions<ViewStartController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<ViewStartController>(DataContext as ViewStartController);
                }
                return _mvc;
            }
        }
        #endregion
    }
}
