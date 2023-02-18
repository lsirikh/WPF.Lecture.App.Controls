using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Wpf.Lecture.Library;

namespace WPF.Lecture.App;
public class App: Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        MainWindow2 window= new ();
        window.ShowDialog();
    }
}
