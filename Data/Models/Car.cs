namespace itprogershop.Data.Models;

public class Car {
    public int id { set; get; }
    public string name { set; get; }
    public string shortDesc { set; get; }
    public string longDesc { set; get; }
    public bool isFavourite { set; get; }
    public string img { set; get; }
    public ushort price { set; get; }
    public bool available { set; get; }
    public int CategoryID { set; get; }
    public virtual Category category { set; get; }
}