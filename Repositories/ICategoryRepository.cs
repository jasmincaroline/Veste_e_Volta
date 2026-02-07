using VesteEVolta.Models;

namespace VesteEVolta.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        List<TbCategory> GetAll();
    }
}
