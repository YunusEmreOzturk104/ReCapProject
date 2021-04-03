using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorsDal _colorsDal;
        public ColorManager(IColorsDal  colorsDal)
        {
            _colorsDal = colorsDal;
        }

     

        public void Add(Color entity)
        {
            _colorsDal.Add(entity);
        }

        public List<Color> GetAll()
        {
            return _colorsDal.GetAll();
        }
    }
}
