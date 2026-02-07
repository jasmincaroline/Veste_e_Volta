using VesteEVolta.Models;
using VesteEVolta.Repositories.Interfaces;
using VesteEVolta.Services.Interfaces;

namespace VesteEVolta.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public List<TbCategory> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
