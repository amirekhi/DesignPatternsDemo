// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns.Structural;

OrderRequest order = new OrderRequest(1, "Laptop", 1);
OrderServiceFacade orderService = new OrderServiceFacade();
orderService.PlaceOrder("admin", "password", order);