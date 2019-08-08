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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ay.MvcFramework;
using Ay.MvcFramework.AyMarkupExtension;
using AYQQMGR2018.Controllers;
using Ay.Framework.WPF.Controls;

namespace AYQQMGR2018.Views.Index
{
    /// <summary>
    /// IndexView.xaml 
    /// 创建时间：2018/5/21 11:57:36
    /// </summary>
    public partial class IndexView : AyPage
    {
        public IndexView()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            qqpc.Visibility = Visibility.Visible;
            qqanquan.Visibility = Visibility.Collapsed;
            tb1.Visibility = Visibility.Collapsed;
            tb2.Visibility = Visibility.Collapsed;
            tb3.Visibility = Visibility.Collapsed;
            tb4.Visibility = Visibility.Collapsed;

            tb5.Visibility = Visibility.Visible;
            tb6.Visibility = Visibility.Visible;
            tb7.Visibility = Visibility.Visible;

            e.Handled = true;
        }

        private void AyAnimationButton_Click(object sender, RoutedEventArgs e)
        {
            AyMessageBox.ShowInformation("开始全面体检了！");
        }
        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AyWindowManager<SoftMgrWindow>.Show();
             e.Handled = true;
        }


    }










































    public partial class IndexView : AyPage
    {
        #region 控制器
        private Actions<IndexController> _mvc;
        public Actions<IndexController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<IndexController>(DataContext as IndexController);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
