using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.BusinessLayer.Abstract
{
    public interface IGenericServiceBL<T> where T : class, new()
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetListAll();
        T TGetByID(int id);
    }
}
