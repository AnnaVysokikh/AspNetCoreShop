using Microsoft.EntityFrameworkCore;

namespace itprogershop.Data.Models;

public class ShopCart {

    private readonly AppDBContent appDBContent;

    public ShopCart(AppDBContent appDBContent) {
        this.appDBContent = appDBContent;
    }

    public string shopCartId { set; get; }
    public List<ShopCartItem> listShopItems { set; get; }

    public static ShopCart GetCart(IServiceProvider services) {
        ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
        var context = services.GetService<AppDBContent>();
        string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

        session.SetString("CartId", shopCartId);
        return new ShopCart(context) { shopCartId = shopCartId };
    }

    public void AddToCart(Car car) {
        appDBContent.ShopCartItem.Add(new ShopCartItem {
            shopCartId = shopCartId,
            car = car,
            price = car.price
        });

        appDBContent.SaveChanges();
    }

    public List<ShopCartItem> getShopItems() {
        return appDBContent.ShopCartItem.Where(c => c.shopCartId == shopCartId).Include(s => s.car).ToList();
    }
}