using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Orders_Views.Commands;
using WPF_Orders_Views.Views;

namespace WPF_Orders_Views.ModelViews
{
    // Class for adding new order and displays order view
    public class AddOrderViewModel : BaseViewModel
    {

        private string _nameOrder;
        public string NameOrder
        {
            get { return _nameOrder; }
            set
            {
                _nameOrder = value;
                OnPropertyChange(nameof(NameOrder));
            }
        }

        private int _orderNumber;
        public int OrderNumber
        {
            get { return _orderNumber; }
            set
            {
                _orderNumber = value;
                OnPropertyChange(nameof(OrderNumber));
            }
        }
        private int _customerIDField;
        public int CustomerIDField
        {
            get { return _customerIDField; }
            set
            {
                _customerIDField = value;
                OnPropertyChange(nameof(CustomerIDField));
            }
        }
        private DateTime _selectedFinishDate = DateTime.Now;
        public DateTime SelectedFinishDate
        {
            get { return _selectedFinishDate; }
            set
            {
                _selectedFinishDate = value;
                OnPropertyChange(nameof(SelectedFinishDate));
            }
        }

        private string _orderDesription;
        public string OrderDescription
        {
            get { return _orderDesription; }
            set
            {
                _orderDesription = value;
                OnPropertyChange(nameof(OrderDescription));
            }
        }

        public ICommand CommandAddNewOrder { get; set; }
        public ICommand CommandCloseOrderView { get; set; }

        private Random _rand;

        public AddOrderViewModel(MainViewModel mainViewModel, HomeViewModel homeViewModel)
        {
            _rand = new Random();
            OrderNumber = _rand.Next(0, 1000);


            CommandAddNewOrder = new CommandAddNewOrder(mainViewModel, this, homeViewModel);
            CommandCloseOrderView = new CommadCloseAddWindow(mainViewModel, homeViewModel);
        }
    }
}
