using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.Lecture.Library.Local.ViewModels;

namespace Wpf.Lecture.Library.UI.Views;

public class MainContent : ContentControl
{
    static MainContent()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MainContent), new FrameworkPropertyMetadata(typeof(MainContent)));
    }

    public MainContent()
    {
        DataContext = new MainContentViewModel();
    }
}
