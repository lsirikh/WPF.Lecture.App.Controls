using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Lecture.Library;
public class MainWindowViewModel : INotifyPropertyChanged
{
    public MainWindowViewModel()
    {

    }
    public List<CompanyModel> Items { get; private set; }

    private List<CompanyModel> GetItems()
    {

        List<CompanyModel> sources = new();
        sources.Add(new() { Id = 1, Name = "Google" });
        sources.Add(new() { Id = 2, Name = "MicroSoft" });
        sources.Add(new() { Id = 3, Name = "Tesla" });
        sources.Add(new() { Id = 4, Name = "Amazon" });
        return sources;
    }

    protected void SetProperty<T>(ref T oldValue, ref T newValue,
        [CallerMemberName] string propertyName = null)
    {
        PropertyChangedEventHandler? handler = PropertyChanged;
        if (handler != null)
        {
            oldValue = newValue;
            handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private CompanyModel _currentItem;

    public CompanyModel CurrentItem
    {
        get => _currentItem;
        //set 
        //{ 
        //    _currentItem = value;
        //    //OnPropertyChanged(nameof(CurrentItem));
        //    OnPropertyChanged(ref _currentItem, ref value);
        //}
        set => SetProperty(ref _currentItem, ref value);
    }
}
