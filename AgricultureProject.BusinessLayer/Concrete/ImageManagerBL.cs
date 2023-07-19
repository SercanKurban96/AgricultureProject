using AgricultureProject.BusinessLayer.Abstract;
using AgricultureProject.DataAccessLayer.Abstract;
using AgricultureProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.BusinessLayer.Concrete
{
    public class ImageManagerBL : IImageServiceBL
    {
        private readonly IImageDAL _imageDal;

        public ImageManagerBL(IImageDAL imageDal)
        {
            _imageDal = imageDal;
        }

        public void TDelete(Image t)
        {
            _imageDal.Delete(t);
        }

        public Image TGetByID(int id)
        {
            return _imageDal.GetByID(id);
        }

        public List<Image> TGetListAll()
        {
            return _imageDal.GetListAll();
        }

        public void TInsert(Image t)
        {
            _imageDal.Insert(t);
        }

        public void TUpdate(Image t)
        {
            _imageDal.Update(t);
        }
    }
}
