using Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Orders_Views.Commands;
using WPF_Orders_Views.Models;

namespace WPF_Orders_Views.ModelViews
{
    // Main class witch holding actual View
    public class MainViewModel : BaseViewModel
    {
        private HomeViewModel _home;
        private BaseViewModel _currentView;
        // Actual property of View
        public BaseViewModel CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChange(nameof(CurrentView));
            }
        }

        // Sets Current View on Home view model wich hold datatemplate of view HomeView in App.xaml
        public MainViewModel()
        {
            _home = new HomeViewModel(this);
            // Loads orders from file
            _home.LoadList();
            CurrentView = _home;
        }

    }
}
