using System;
using pizza.Entity;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace pizza.Services
{
    public interface IStoreService
    {
        Task<(bool IsSuccess, Exception exception)> InsertPizzaAsync(Pizza pizza);  
        Task<(bool IsSuccess, Exception exception, List<Models.NewPizza> pizza)> GetPizzaAsync(); 
        Task<(bool IsSuccess, Exception exception, Pizza pizzaResult)> GetPizzaIdAsync(Guid Id);
        Task<(bool IsSuccess, Exception exception, Pizza pizza)> UpdatePizzaAsync(Guid id, Pizza pizza);
        Task<(bool IsSuccess, Exception exception)> DeletePizzaAsync(Guid id);
    }
}