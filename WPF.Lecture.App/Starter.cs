using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Lecture.App;
public class Starter
{
    [STAThread]
    static void Main(string[] args)
    {
        App app= new App();
        app.Run();
    }
}
