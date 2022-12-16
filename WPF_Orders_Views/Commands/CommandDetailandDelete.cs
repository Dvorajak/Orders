using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_Orders_Views.ModelViews;
using WPF_Orders_Views.Views;

namespace WPF_Orders_Views.Commands
{
    public class CommandDetailandDelete : CommandBase
    {

        private HomeViewModel _homeModelView;
        private MainViewModel _mainViewModel;
        public CommandDetailandDelete(HomeViewModel homeModelView, MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            _homeModelView = homeModelView;
            _homeModelView.PropertyChanged += OnPropertyChanged;
        }


        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            OnCanExecuteChanged();
        }

        public override bool CanExecute(object? parameter)
        {
            if (_homeModelView.SelectedOrder == null)
            {
                return false;
            }

            return true;
        }

        public override void Execute(object? parameter)
        {
            if (parameter.ToString() == "Delete")
            {
                _homeModelView.RemoveFromList(_homeModelView.SelectedOrder);
            }
            if (parameter.ToString() == "Detail")
            {
                _mainViewModel.CurrentView = new DetailViewModel(_homeModelView, _mainViewModel);
            }

        }
    }
}
