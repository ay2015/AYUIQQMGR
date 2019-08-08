using System;
using Ay.MvcFramework;
using AYQQMGR2018.Views;

namespace AYQQMGR2018
{
    public class Startup
    {
        [STAThread]
        static void Main()
        {

            new AYUIApplication<_ViewStart>(new Global(), true).Run();

        }

    }
}
