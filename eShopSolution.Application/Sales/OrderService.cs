using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Utilities.Exceptions;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Sales
{
    public class OrderService : IOrderService
    {
        private readonly EShopDbContext _context;

        public OrderService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateOrder(CheckoutRequest request)
        {
            

            var orderDetails = new List<OrderDetail>();
            foreach(var product in request.OrderDetails)
            {
                orderDetails.Add(new OrderDetail()
                {
                    ProductId = product.ProductId,
                    Quantity = product.Quantity,
                    Price = product.Price
                });
            }

            var order = new Order()
            {
                UserId = Guid.Parse("b3dbb674-4cdb-42b4-258d-08d8a7e05a9c"),
                ShipName = request.Name,
                ShipAddress = request.Address,
                ShipEmail = request.Email,
                ShipPhoneNumber = request.PhoneNumber,
                OrderDate = DateTime.Now,
                Status = Data.Enums.OrderStatus.InProgress,
                OrderDetails = orderDetails
            };
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order.Id;
        }

        public async Task<OrderViewModel> GetOrderById(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null)
                throw new EShopException($"Cannot find an order with id {orderId}");

            var orderViewModel = new OrderViewModel()
            {
                Id = orderId,
                ShipAddress = order.ShipAddress,
                ShipName = order.ShipName,
                ShipEmail = order.ShipEmail,
                PhoneNumber = order.ShipPhoneNumber,
                Status = order.Status,
                UserId = order.UserId
            };
            return orderViewModel;
        }
    }
}
