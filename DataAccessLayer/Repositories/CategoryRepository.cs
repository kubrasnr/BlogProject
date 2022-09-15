using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        //Using kullanmak bellek avantajı sağlar o nesne sadece kullanıldığı esnada bellekte tutulur.
        
        public void AddCategory(Category category)
        {
            using var context = new Context();
            context.Add(category);
            context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            using var context = new Context();
            context.Remove(category);
            context.SaveChanges();
        }

        public Category GetById(int id)
        {
            using var context = new Context();
            return context.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            using var context = new Context();
            return context.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            using var context = new Context();
            context.Update(category);
            context.SaveChanges();
        }
    }
}
