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

namespace AYQQMGR2018.Views.ClearGarbage
{
    /// <summary>
    /// ClearGarbageView.xaml 
    /// 创建时间：2018/5/21 12:00:18
    /// </summary>
    public partial class ClearGarbageView : AyPage
    {
        public ClearGarbageView()
        {
            InitializeComponent();
        }


        private void AyAnimationButton_Click(object sender, RoutedEventArgs e)
        {
            AyMessageBox.ShowInformation("开始全面体检了！");
        }

    }










































    public partial class ClearGarbageView : AyPage
    {
        #region 控制器
        private Actions<ClearGarbageController> _mvc;
        public Actions<ClearGarbageController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<ClearGarbageController>(DataContext as ClearGarbageController);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
