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
    public class ContactManagerBL : IContactServiceBL
    {
        private readonly IContactDAL _contactDal;

        public ContactManagerBL(IContactDAL contactDal)
        {
            _contactDal = contactDal;
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void TInsert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
