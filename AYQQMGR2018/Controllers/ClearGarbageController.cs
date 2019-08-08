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
    public class ClearGarbageController : Controller
    {
        public ClearGarbageModel Model { get; set; } = new ClearGarbageModel();
        public ClearGarbageController() : base()
        {


        }


    }
}
