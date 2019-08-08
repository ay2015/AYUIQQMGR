using AYQQMGR2018.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Ay.MvcFramework;

namespace AYQQMGR2018.Controllers
{
    public class ToolBoxController : Controller
    {
        public ToolBoxModel Model { get; set; } = new ToolBoxModel();
        public ToolBoxController() : base()
        {

            OpenClickCommand = new DelegateCommand((x) =>
            {
                AyMessageBox.ShowInformation("谢谢你的留言");
            });
        }

        public ICommand OpenClickCommand;


    }
}
