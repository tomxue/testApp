using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            string fileName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = fileName;
            p.StartInfo.Arguments = "";
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.Verb = "runas";
            p.Start();
        }
    }
}
