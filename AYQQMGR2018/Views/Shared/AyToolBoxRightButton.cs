using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;
using System.Windows;

namespace AYQQMGR2018.Views.Shared
{
    public class AyToolBoxRightButton : Button
    {
        /// <summary>
        /// Image4Button
        /// </summary>
        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(ImageSource), typeof(AyToolBoxRightButton), new PropertyMetadata(null));




        public ImageSource HoverIcon
        {
            get { return (ImageSource)GetValue(HoverIconProperty); }
            set { SetValue(HoverIconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HoverIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverIconProperty =
            DependencyProperty.Register("HoverIcon", typeof(ImageSource), typeof(AyToolBoxRightButton), new PropertyMetadata(null));





    }
}
