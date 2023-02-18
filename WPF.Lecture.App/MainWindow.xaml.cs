using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace WPF.Lecture.App;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public IEnumerable Items { get; private set; }
    public CompanyModel CurrentItem { get; private set; }
    public MainWindow()
    {
        InitializeComponent();

        Items = GetItems();

        //Default Selection
        //userListBox.SelectedIndex = 1;

        //userListBox.SelectedItem = (userListBox.ItemsSource as List<CompanyModel>)[1];

        //userListBox.SelectedValue = "Google";
        DataContext = this;
    }


    private IEnumerable GetItems()
    {

        List<CompanyModel> sources= new ();
        sources.Add(new() {Id = 1, Name = "Google" });
        sources.Add(new() { Id = 2, Name = "MicroSoft" });
        sources.Add(new() { Id = 3, Name = "Tesla" });
        sources.Add(new() { Id = 4 , Name = "Amazon" });
        return sources;
    }
}
