using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System;
using System.Windows.Input;

namespace AYQQMGR2018.Views.Shared
{
    /// <summary>
    /// 用于替代Hyberlink的
    /// ay 2015年12月9日16:14:48时候开发
    ///    控件.Click = new DelegateCommand(ClickCommand);
    /// private void ClickCommand()
    //  {
    //   
    //   }
    /// </summary>
    public class AyHyberTextBlock : TextBlock
    {
        public Brush ForegroundStatic
        {
            get { return (Brush)GetValue(ForegroundStaticProperty); }
            set { SetValue(ForegroundStaticProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ForegroundStatic.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ForegroundStaticProperty =
            DependencyProperty.Register("ForegroundStatic", typeof(Brush), typeof(AyHyberTextBlock), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));



        public Brush ForegroundMouseEnter
        {
            get { return (Brush)GetValue(ForegroundMouseEnterProperty); }
            set { SetValue(ForegroundMouseEnterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ForegroundMouseEnter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ForegroundMouseEnterProperty =
            DependencyProperty.Register("ForegroundMouseEnter", typeof(Brush), typeof(AyHyberTextBlock), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public Brush ForegroundPressed
        {
            get { return (Brush)GetValue(ForegroundPressedProperty); }
            set { SetValue(ForegroundPressedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ForegroundMouseEnter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ForegroundPressedProperty =
            DependencyProperty.Register("ForegroundPressed", typeof(Brush), typeof(AyHyberTextBlock), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            this.Cursor = Cursors.Hand;

            this.AddHandler(TextBlock.MouseDownEvent, new RoutedEventHandler(HyberMouseDownEvent), false);
            this.AddHandler(TextBlock.MouseEnterEvent, new RoutedEventHandler(HyberMouseEnter), false);
            this.AddHandler(TextBlock.MouseLeaveEvent, new RoutedEventHandler(HyberMouseleave), false);
        }



        public ICommand Click
        {
            get { return (ICommand)GetValue(ClickProperty); }
            set { SetValue(ClickProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Click.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClickProperty =
            DependencyProperty.Register("Click", typeof(ICommand), typeof(AyHyberTextBlock), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));




        public ICommand MouseEnterCommand
        {
            get { return (ICommand)GetValue(MouseEnterCommandProperty); }
            set { SetValue(MouseEnterCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseEnterCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseEnterCommandProperty =
            DependencyProperty.Register("MouseEnterCommand", typeof(ICommand), typeof(AyHyberTextBlock), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));




        public ICommand MouseLeaveCommand
        {
            get { return (ICommand)GetValue(MouseLeaveCommandProperty); }
            set { SetValue(MouseLeaveCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseLeaveCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseLeaveCommandProperty =
            DependencyProperty.Register("MouseLeaveCommand", typeof(ICommand), typeof(AyHyberTextBlock), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));



        //ay 命令模式开发控件 2015年12月9日16:13:14
        //public ICommand Click { get; set; }
        //public ICommand MouseEnterCommand { get; set; }
        //public ICommand MouseLeaveCommand { get; set; }


        private void HyberMouseDownEvent(object sender, RoutedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                AyCommandParameter ap = new AyCommandParameter { Sender = sender, e = e };
                if (Click != null)
                {
                    if (Click.CanExecute(ap))
                    {
                        if (ForegroundPressed != null)
                        {
                            this.Foreground = ForegroundPressed;
                        }
                        Click.Execute(ap);
                    }
                }
                else
                {
                    if (ForegroundPressed != null)
                    {
                        this.Foreground = ForegroundPressed;
                    }

                }
                e.Handled = true;

            }
        }

        private void HyberMouseleave(object sender, RoutedEventArgs e)
        {

            AyCommandParameter ap = new AyCommandParameter { Sender = sender, e = e };


            if (MouseLeaveCommand != null)
            {
                if (MouseLeaveCommand.CanExecute(ap))
                {
                    if (ForegroundStatic != null)
                    {
                        this.Foreground = ForegroundStatic;
                    }
                    MouseLeaveCommand.Execute(ap);
                }
            }
            else
            {
                if (ForegroundStatic != null)
                {
                    this.Foreground = ForegroundStatic;
                }

            }
        }

        private void HyberMouseEnter(object sender, RoutedEventArgs e)
        {
            AyCommandParameter ap = new AyCommandParameter { Sender = sender, e = e };


            if (MouseEnterCommand != null)
            {
                if (MouseEnterCommand.CanExecute(ap))
                {
                    if (ForegroundMouseEnter != null)
                    {
                        this.Foreground = ForegroundMouseEnter;
                    }
                    MouseEnterCommand.Execute(ap);
                }
            }
            else
            {
                if (ForegroundMouseEnter != null)
                {
                    this.Foreground = ForegroundMouseEnter;
                }

            }
        }



    }
    public class AyCommandParameter
    {
        public object Sender { get; set; }
        public EventArgs e { get; set; }
    }
}
