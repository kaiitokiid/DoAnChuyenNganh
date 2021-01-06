using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.Sales
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipEmail { get; set; }

        public string PhoneNumber { get; set; }

        public OrderStatus Status { get; set; }
    }
}
