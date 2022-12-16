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
    // Class of view which displays detail of order
    public class DetailViewModel : BaseViewModel
    {

        public string Name { get; }
        public string FinishDate { get; }
        public int OrderNumber { get; }
        public int CustomerId { get; }
        public string OrderDescription { get; }
        public string TimeLeft { get; }

        public ICommand Close { get; }

        public DetailViewModel(HomeViewModel homeModelView, MainViewModel mainViewModel)
        {

            Name = homeModelView.SelectedOrder.Name;
            FinishDate = homeModelView.SelectedOrder.FinishOrderDate.ToString("dd.MM.yyyy");
            OrderNumber = homeModelView.SelectedOrder.OrderNumber;
            CustomerId = homeModelView.SelectedOrder.CustomerId;
            OrderDescription = homeModelView.SelectedOrder.OrderDescription;
            TimeLeft = homeModelView.SelectedOrder.TimeLeft.ToString("dd");

            Close = new CommadCloseAddWindow(mainViewModel, homeModelView);
        }
    }
}
