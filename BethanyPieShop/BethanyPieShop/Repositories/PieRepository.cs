using BethanyPieShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace BethanyPieShop.Repositories
{
    public class PieRepository : IPieRepository
    {

        public readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _appDbContext.Pies.OrderBy(pie => pie.Name);
        }
    }
}
