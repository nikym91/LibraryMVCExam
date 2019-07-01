using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryMVCExam.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ShipmentDate { get; set; }
        public decimal Price { get; set; }
        public string OrderNumber { get; set; }

        public Customer Customer { get; set; }

        public Order()
        {

        }

        public Order(int id, int customerId, DateTime creationDate, DateTime shipmentDate, decimal price, string orderNumber)
        {
            Id = id;
            CustomerId = customerId;
            CreationDate = creationDate;
            ShipmentDate = shipmentDate;
            Price = price;
            OrderNumber = orderNumber;
        }
    }
}
