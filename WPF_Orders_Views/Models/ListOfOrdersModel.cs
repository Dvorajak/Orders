using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Orders_Views.Models;

namespace Orders.Models
{
    // Model class of list which holds orders
    public class ListOfOrdersModel
    {
        public List<OrdersModel> Orders { get; private set; }


        public ListOfOrdersModel()
        {
            Orders = new List<OrdersModel>();
        }

        public void AddOrder(OrdersModel order)
        {
            Orders.Add(order);
        }

        public void RemoveOrder(OrdersModel order)
        {
            Orders.Remove(order);
        }

        public void LoadList(List<OrdersModel> list)
        {
            Orders = list;
        }
    }
}
