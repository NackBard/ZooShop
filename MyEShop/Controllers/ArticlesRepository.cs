using Microsoft.EntityFrameworkCore;
using MyEShop.Models;
using System;

namespace MyEShop.Controllers
{
    public class ArticlesRepository
    {
        private readonly ApplicationContext context;
        public ArticlesRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public Guid SaveArticle(Users entity)
        {
            if (entity.ID_User == default)
            {
                context.Entry(entity).State = EntityState.Added;
                context.Users.Add(entity);
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();

            return entity.ID_User;
        }

    }
}