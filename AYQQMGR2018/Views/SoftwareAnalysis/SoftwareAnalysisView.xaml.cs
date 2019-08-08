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

namespace AYQQMGR2018.Views.SoftwareAnalysis
{
    /// <summary>
    /// SoftwareAnalysisView.xaml 
    /// 创建时间：2018/5/21 12:00:59
    /// </summary>
    public partial class SoftwareAnalysisView : AyPage
    {
        public SoftwareAnalysisView()
        {
            InitializeComponent();
        }

        private void AyAnimationButton_Click(object sender, RoutedEventArgs e)
        {
            //AyMessageBox.ShowInformation("开始软件分析了！");
            startAnalysis.Visibility = Visibility.Collapsed;
            startAnalysissing.Visibility = Visibility.Visible;
            AyThread.Instance.InitDispatcher(this.Dispatcher);
            AyTime.setTimeout(5000, () =>
            {
                AyThread.Instance.RunUI(() => {
                    startAnalysis.Visibility = Visibility.Visible;
                    startAnalysissing.Visibility = Visibility.Collapsed;
                });
            });
        }

    }










































    public partial class SoftwareAnalysisView : AyPage
    {
        #region 控制器
        private Actions<SoftwareAnalysisController> _mvc;
        public Actions<SoftwareAnalysisController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<SoftwareAnalysisController>(DataContext as SoftwareAnalysisController);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
