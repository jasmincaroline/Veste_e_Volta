using VesteEVolta.Models;
using VesteEVolta.Repositories.Interfaces;

namespace VesteEVolta.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PostgresContext _context;

        public CategoryRepository(PostgresContext context)
        {
            _context = context;
        }

        public List<TbCategory> GetAll()
        {
            return _context.TbCategories.ToList();
        }
    }
}
