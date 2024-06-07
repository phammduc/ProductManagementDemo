using System.Collections.Generic;
using Repositories;
using BusinessObjects;

namespace Services
{
    public class CategoryService : ICatergoryService
    {
        private readonly ICatergoryRepository iCategoryRepository;
        public CategoryService()
        {
            iCategoryRepository = new CategoryRepository();
        }

        public List<Category> GetCategories()
        {
            return iCategoryRepository.GetCategories();
        }
    }
}
