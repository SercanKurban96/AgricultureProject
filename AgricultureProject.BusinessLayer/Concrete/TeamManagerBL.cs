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
    public class TeamManagerBL : ITeamServiceBL
    {
        private readonly ITeamDAL _teamDal;

        public TeamManagerBL(ITeamDAL teamDal)
        {
            _teamDal = teamDal;
        }

        public void TDelete(Team t)
        {
            _teamDal.Delete(t);
        }

        public Team TGetByID(int id)
        {
            return _teamDal.GetByID(id);
        }

        public List<Team> TGetListAll()
        {
            return _teamDal.GetListAll();
        }

        public void TInsert(Team t)
        {
            _teamDal.Insert(t);
        }

        public void TUpdate(Team t)
        {
            _teamDal.Update(t);
        }
    }
}
