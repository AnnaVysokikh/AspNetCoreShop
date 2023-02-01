using itprogershop.Data.Models;

namespace itprogershop.Data.Interfaces;

public interface ICarsCategory {
    IEnumerable<Category> AllCategories { get; }
}