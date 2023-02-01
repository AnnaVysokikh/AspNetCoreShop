namespace itprogershop.Data.Models;

public class ShopCartItem {
    public int id { set; get; }
    public Car car { set; get; }
    public int price { set; get; }
    public string shopCartId { set; get; }
}