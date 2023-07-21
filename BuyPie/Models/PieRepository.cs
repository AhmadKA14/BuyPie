using Microsoft.EntityFrameworkCore;

namespace BuyPie.Models
{
    public class PieRepository: IPieRepository
    {
        public readonly BuyPieDbContext _buyPieDbContext;
    
        public PieRepository(BuyPieDbContext buyPieDbContext)
        {
            _buyPieDbContext = buyPieDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _buyPieDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _buyPieDbContext.Pies.Include(c => c.Category).Where(p=>p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _buyPieDbContext.Pies.FirstOrDefault(p=>p.PieId == pieId);
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            return _buyPieDbContext.Pies.Where(p => p.Name.Contains(searchQuery));
        }
    }
}
