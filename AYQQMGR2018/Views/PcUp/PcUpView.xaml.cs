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

namespace AYQQMGR2018.Views.PcUp
{
    /// <summary>
    /// PcUpView.xaml 
    /// 创建时间：2018/5/21 12:00:42
    /// </summary>
    public partial class PcUpView : AyPage
    {
        public PcUpView()
        {
            InitializeComponent();
        }
  

        private void AyAnimationButton_Click(object sender, RoutedEventArgs e)
        {
            AyMessageBox.ShowInformation("开始加速了！");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            openHuoJian.Click = new DelegateCommand((x) =>
            {
                AyMessageBox.ShowInformation("小火箭已经开启！");
            });
        }

    }










































    public partial class PcUpView : AyPage
    {
        #region 控制器
        private Actions<PcUpController> _mvc;
        public Actions<PcUpController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<PcUpController>(DataContext as PcUpController);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
