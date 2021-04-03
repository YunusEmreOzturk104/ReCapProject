using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IServices<T> where T:class,new()
    {
        List<T> GetAll();
        void Add(T entity);
    }
}
