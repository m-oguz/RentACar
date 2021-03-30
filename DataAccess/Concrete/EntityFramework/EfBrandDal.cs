using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);

            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null
                    ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();
            }

        }

        public void Modify(Brand entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var modifyEntity = context.Entry(entity);
                modifyEntity.State = EntityState.Modified;
                context.SaveChanges();

            }


        }

        public void Remove(Brand entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var removeEntity = context.Entry(entity);
                removeEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }


        }
    }
}
