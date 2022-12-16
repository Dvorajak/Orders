using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Orders_Views.Models;
using WPF_Orders_Views.ModelViews;
using WPF_Orders_Views.Views;

namespace WPF_Orders_Views.Commands
{
    public class CommandAddNewOrder : CommandBase
    {
        private MainViewModel _mainViewModel;
        private HomeViewModel _homeViewModel;
        private AddOrderViewModel _addOrderModelView;

        public CommandAddNewOrder(MainViewModel mainViewModel, AddOrderViewModel addOrderModelView, HomeViewModel homeViewModel)
        {
            _mainViewModel = mainViewModel;
            _addOrderModelView = addOrderModelView;
            _homeViewModel = homeViewModel;

            _addOrderModelView.PropertyChanged += OnPropertyChanged;
        }

        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            OnCanExecuteChanged();
        }

        public override bool CanExecute(object? parameter)
        {
            if (string.IsNullOrEmpty(_addOrderModelView.NameOrder) || _addOrderModelView.OrderNumber == 0 || _addOrderModelView.CustomerIDField == 0 || _addOrderModelView.SelectedFinishDate.Date < DateTime.Now.Date)
            {
                return false;
            }
            return true;
        }
        public override void Execute(object? parameter)
        {
            var order = new OrdersModel(_addOrderModelView.NameOrder, _addOrderModelView.OrderNumber, _addOrderModelView.CustomerIDField, _addOrderModelView.SelectedFinishDate, _addOrderModelView.OrderDescription);
            _homeViewModel.AddNewOrder(order);
            _mainViewModel.CurrentView = _homeViewModel;
        }
    }
}
