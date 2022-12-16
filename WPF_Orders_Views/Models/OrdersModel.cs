using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Orders_Views.Models
{
    // Model class of orders
    public class OrdersModel
    {
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedOrderDate { get; set; }
        public DateTime FinishOrderDate { get; set; }
        public TimeSpan TimeLeft
        {
            get => FinishOrderDate - DateTime.Now;
        }
        public string OrderDescription { get; set; }

        public OrdersModel(string name, int orderNumber, int customerId, DateTime finishOrderDate, string orderDescription)
        {
            Name = name;
            OrderNumber = orderNumber;
            CustomerId = customerId;
            this.CreatedOrderDate = DateTime.Now;
            FinishOrderDate = finishOrderDate;
            OrderDescription = orderDescription;
        }

        public OrdersModel()
        {

        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
