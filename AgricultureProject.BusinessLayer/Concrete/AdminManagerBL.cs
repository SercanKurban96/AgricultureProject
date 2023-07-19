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
	public class AdminManagerBL : IAdminServiceBL
	{
		private readonly IAdminDAL _adminDal;

		public AdminManagerBL(IAdminDAL adminDal)
		{
			_adminDal = adminDal;
		}

		public void TDelete(Admin t)
		{
			_adminDal.Delete(t);
		}

		public Admin TGetByID(int id)
		{
			return _adminDal.GetByID(id);
		}

		public List<Admin> TGetListAll()
		{
			return _adminDal.GetListAll();
		}

		public void TInsert(Admin t)
		{
			_adminDal.Insert(t);
		}

		public void TUpdate(Admin t)
		{
			_adminDal.Update(t);
		}
	}
}
