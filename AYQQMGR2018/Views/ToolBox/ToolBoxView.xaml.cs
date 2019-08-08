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

namespace AYQQMGR2018.Views.ToolBox
{
    /// <summary>
    /// ToolBoxView.xaml 
    /// 创建时间：2018/5/21 12:01:20
    /// </summary>
    public partial class ToolBoxView : AyPage
    {
        public ToolBoxView()
        {
            InitializeComponent();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton cb = sender as RadioButton;

            if (cb != null && svToolBox != null)
            {
                string placeBorder = cb.Tag as string;
                Border bd = svToolBox.FindName(placeBorder) as Border;
                if (bd != null)
                {
                    Point relativePoint = ScrollViewerExpand.GetRelativePoint(bd, mainContent);
                    svToolBox.ScrollToPosition(relativePoint.X, relativePoint.Y);
                }
            }

        }
        private void AyToolBoxRightButton_Click(object sender, RoutedEventArgs e)
        {
            AyWindowManager<SoftMgrWindow>.Show();
        }
    }












































    public partial class ToolBoxView : AyPage
    {
        #region 控制器
        private Actions<ToolBoxController> _mvc;
        public Actions<ToolBoxController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<ToolBoxController>(DataContext as ToolBoxController);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
