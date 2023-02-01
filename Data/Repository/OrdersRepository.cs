using itprogershop.Data.Interfaces;
using itprogershop.Data.Models;

namespace itprogershop.Data.Repository;

public class OrdersRepository : IAllOrders {

    private readonly AppDBContent appDBContent;
    private readonly ShopCart shopCart;

    public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart) {
        this.appDBContent = appDBContent;
        this.shopCart = shopCart;
    }

    public void createOrder(Order order) {
        order.orderTime = DateTime.Now;
        order.orderDetails = new List<OrderDetail>();
        appDBContent.Order.Add(order);

        var items = shopCart.listShopItems;

        foreach(var el in items) {
            var orderDetail = new OrderDetail() {
                carID = el.car.id,
                orderID = order.id,
                price = el.car.price
            };
            order.orderDetails.Add(orderDetail);
            appDBContent.OrderDetail.Add(orderDetail);
        }
        appDBContent.SaveChanges();
    }
}