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
	public class SocialMediaManagerBL : ISocialMediaServiceBL
	{
		private readonly ISocialMediaDAL _socialMediaDal;

		public SocialMediaManagerBL(ISocialMediaDAL socialMediaDal)
		{
			_socialMediaDal = socialMediaDal;
		}

		public void TDelete(SocialMedia t)
		{
			_socialMediaDal.Delete(t);
		}

		public SocialMedia TGetByID(int id)
		{
			return _socialMediaDal.GetByID(id);
		}

		public List<SocialMedia> TGetListAll()
		{
			return _socialMediaDal.GetListAll();
		}

		public void TInsert(SocialMedia t)
		{
			_socialMediaDal.Insert(t);
		}

		public void TUpdate(SocialMedia t)
		{
			_socialMediaDal.Update(t);
		}
	}
}
