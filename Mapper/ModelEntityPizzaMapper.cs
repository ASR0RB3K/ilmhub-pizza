using pizza.Entity;
using pizza.Models;

namespace pizza.Mapper
{
    public static class ModelEntityPizzaMapper
    {
        public static Pizza ToPizzaEntity(this NewPizza newPizza)
        {
            return new Pizza(
                title: newPizza.Title,
                shortName: newPizza.ShortName,
                stockStatus: newPizza.StockStatus.ToEntityStockStatus(),
                ingredients: newPizza.Ingredients,
                price: newPizza.Price
            );
        }
        
        public static Entity.EPizzaStockStatus ToEntityStockStatus(this Models.EPizzaStockStatusModel stockStatus)
        {
            return stockStatus switch
            {
                Models.EPizzaStockStatusModel.In => Entity.EPizzaStockStatus.In,
                _ => Entity.EPizzaStockStatus.Out
            };
        }
    }
}