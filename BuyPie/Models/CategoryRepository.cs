namespace BuyPie.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly BuyPieDbContext _buyPieDbContext;

        public CategoryRepository(BuyPieDbContext buyPieDbContext)
        {
            _buyPieDbContext = buyPieDbContext;
        }

        public IEnumerable<Category> AllCategories => _buyPieDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
