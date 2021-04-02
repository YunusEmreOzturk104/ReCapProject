using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfColorsDal : IColorsDal
    {
        public void Add(Colors entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Colors entity)
        {
            throw new NotImplementedException();
        }

        public Colors Get(Expression<Func<Colors, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Colors> GetAll(Expression<Func<Colors, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Colors entity)
        {
            throw new NotImplementedException();
        }
    }
}
