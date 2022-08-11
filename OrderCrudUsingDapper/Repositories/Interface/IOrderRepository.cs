﻿using OrderCrudUsingDapper.Models;

namespace OrderCrud.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public Task<IEnumerable<Order>> GetOrders();

        public Task<Order> GetOrderById(int id);

        public Task<int> Insert(Order order);

        public Task<int> Update(Order order);

        public Task<int> Delete(int id);
    }
}
