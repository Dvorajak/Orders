using Orders.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Xml.Serialization;
using WPF_Orders_Views.Commands;
using WPF_Orders_Views.Models;
using WPF_Orders_Views.Views;

namespace WPF_Orders_Views.ModelViews
{
    // Main class of view which is first displayed
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<OrdersModel> ObservableList { get; set; }
        private ListOfOrdersModel _listOforders;
        private string _path = "Orders.xml";
        public ICommand CommandShowAddWindow { get; }
        public ICommand CommandDetailOrderView { get; }
        public ICommand CommandSearch { get; }
        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }

            set
            {
                _searchText = value;
                OnPropertyChange(nameof(SearchText));
            }
        }

        private OrdersModel _selectedOrder;
        public OrdersModel SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                OnPropertyChange(nameof(SelectedOrder));
            }
        }

        public HomeViewModel(MainViewModel mainViewModel)
        {
            _listOforders = new ListOfOrdersModel();
            ObservableList = new ObservableCollection<OrdersModel>(_listOforders.Orders);

            CommandSearch = new CommandSearchText(this);
            CommandShowAddWindow = new CommadShowAddWindow(mainViewModel, this);
            CommandDetailOrderView = new CommandDetailandDelete(this, mainViewModel);

        }

        /// <summary>
        /// Method for adding order to list
        /// </summary>
        /// <param name="order"></param>
        public void AddNewOrder(OrdersModel order)
        {
            _listOforders.AddOrder(order);
            LoadToObservable();
            SaveList();
        }

        /// <summary>
        /// Loads actual orders from list for diplay
        /// </summary>
        private void LoadToObservable()
        {
            ObservableList.Clear();
            foreach (OrdersModel order in _listOforders.Orders)
            {
                ObservableList.Add(order);
            }
        }

        /// <summary>
        /// Remove order from list
        /// </summary>
        /// <param name="order"></param>
        public void RemoveFromList(OrdersModel order)
        {
            _listOforders.RemoveOrder(order);
            LoadToObservable();
            SaveList();
        }

        /// <summary>
        /// Search text from textbox in orders list
        /// </summary>
        public void Search()
        {
            if (string.IsNullOrEmpty(SearchText))
            {
                LoadToObservable();
            }
            else
            {
                ObservableList.Clear();

                foreach (OrdersModel order in _listOforders.Orders)
                {
                    if (!string.IsNullOrEmpty(order.OrderDescription) && SearchText.ToLower().Contains(order.OrderDescription.ToLower()))
                    {
                        ObservableList.Add(order);
                    }

                    if (SearchText.ToLower().Contains(order.Name.ToLower()) || SearchText.Contains(order.CustomerId.ToString()) || SearchText.Contains(order.OrderNumber.ToString()))
                    {
                        ObservableList.Add(order);
                    }
                }

            }

        }

        /// <summary>
        /// Saves list to file
        /// </summary>
        public void SaveList()
        {
            XmlSerializer serializer = new XmlSerializer(_listOforders.Orders.GetType());
            using (StreamWriter sw = new StreamWriter(_path))
            {
                serializer.Serialize(sw, _listOforders.Orders);
            }
        }

        /// <summary>
        /// Loads orders from file
        /// </summary>
        public void LoadList()
        {
            XmlSerializer serializer = new XmlSerializer(_listOforders.Orders.GetType());
            if (File.Exists(_path))
            {
                using (StreamReader sr = new StreamReader(_path))
                {
                    _listOforders.LoadList((List<OrdersModel>)serializer.Deserialize(sr));
                    LoadToObservable();
                }
            }
            else
                _listOforders = new ListOfOrdersModel();

        }

    }
}
