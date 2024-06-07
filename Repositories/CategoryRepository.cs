using BusinessObjects;
using DataAccessLayer;
using System.Collections.Generic;

namespace Repositories
{
    public class CategoryRepository : ICatergoryRepository
    {
        public List<Category> GetCategories() => CategoryDAO.GetCategories();
    }
}
