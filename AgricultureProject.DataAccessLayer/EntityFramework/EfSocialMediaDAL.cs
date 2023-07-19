using AgricultureProject.DataAccessLayer.Abstract;
using AgricultureProject.DataAccessLayer.Concrete;
using AgricultureProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.DataAccessLayer.EntityFramework
{
	public class EfSocialMediaDAL : RepositoryDAL<SocialMedia>, ISocialMediaDAL
	{
	}
}
