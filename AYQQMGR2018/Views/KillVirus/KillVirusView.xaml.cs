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

namespace AYQQMGR2018.Views.KillVirus
{
    /// <summary>
    /// KillVirusView.xaml 
    /// 创建时间：2018/5/21 11:59:50
    /// </summary>
    public partial class KillVirusView : AyPage
    {
        public KillVirusView()
        {
            InitializeComponent();
        }
        private void AyAnimationButton_Click(object sender, RoutedEventArgs e)
        {
            AyMessageBox.ShowInformation("开始杀毒了！");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AyMessageBox.ShowInformation("AY全盘杀毒了！");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AyMessageBox.ShowInformation("Ay指定位置杀毒了！");
        }
    }










































    public partial class KillVirusView : AyPage
    {
        #region 控制器
        private Actions<KillVirusController> _mvc;
        public Actions<KillVirusController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<KillVirusController>(DataContext as KillVirusController);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
