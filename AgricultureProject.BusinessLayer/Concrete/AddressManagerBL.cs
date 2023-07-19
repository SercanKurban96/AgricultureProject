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
    public class AddressManagerBL : IAddressServiceBL
    {
        private readonly IAddressDAL _addressDal;

        public AddressManagerBL(IAddressDAL addressDal)
        {
            _addressDal = addressDal;
        }

        public void TDelete(Address t)
        {
            _addressDal.Delete(t);
        }

        public Address TGetByID(int id)
        {
            return _addressDal.GetByID(id);
        }

        public List<Address> TGetListAll()
        {
            return _addressDal.GetListAll();
        }

        public void TInsert(Address t)
        {
            _addressDal.Insert(t);
        }

        public void TUpdate(Address t)
        {
            _addressDal.Update(t);
        }
    }
}
