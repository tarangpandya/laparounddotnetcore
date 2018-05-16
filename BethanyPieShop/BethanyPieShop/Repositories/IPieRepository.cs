using BethanyPieShop.Models;
using System.Collections.Generic;

namespace BethanyPieShop.Repositories
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
    }
}
