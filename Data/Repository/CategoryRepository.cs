using System.Linq;

using itprogershop.Data.Interfaces;
using itprogershop.Data.Models;
using itprogershop.Data;

namespace itprogershop.Data.Repository;

public class CategoryRepository : ICarsCategory {
    private readonly AppDBContent appDBContent;

    public CategoryRepository(AppDBContent appDBContent) {
        this.appDBContent = appDBContent;
    }
    public IEnumerable<Category> AllCategories => appDBContent.Category;
}