using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp10
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private object _currentPageViewModel;

        public object CurrentPageViewModel
        {
            get { return _currentPageViewModel; }
            set { _currentPageViewModel = value; NotifyPropertyChanged(); }
        }

        public MainWindowVM()
        {
            CurrentPageViewModel = new MainPageVM();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
