using System.Windows;
using System;
using Ay.MvcFramework;
using Ay.MvcFramework.Wpf;

namespace AYQQMGR2018
{
    public class Global : AYUIGlobal
    {
        public override void Application_Start(StartupEventArgs e, Application appliation)
        {
            //appliation.AddExceptionSimply();
            LanuageManager.DisabledLanuage = true;
        }
        //此方法重写，为了导入AYUI
        public override void Application_Run(Application appliation)
        {
            appliation.AYUI();
        }
        public override void RegisterResourceDictionary(ClientResourceDictionaryCollection resources)
        {
            resources.Add("Contents/Styles/AYUIProjectDictionary.xaml".ToApplicationCurrentResourceDictionary());
        }
        public override void RegisterLanuages(ClientLanuagesCollection languages)
        {
            languages.Add(new LanguageSelectModel { LanuageName = "简体中文", ResourceName = "zh-cn" });
            languages.Add(new LanguageSelectModel { LanuageName = "English", ResourceName = "en-us" });
        }

    }
}
