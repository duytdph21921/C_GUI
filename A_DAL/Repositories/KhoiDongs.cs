using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class KhoiDongs : IkhoiDong
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(khoiDong khoiDong)
        {
            try
            {
                if (khoiDong == null) return false;
                _dbcontext.KhoiDongs.Add(khoiDong);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool delete(khoiDong khoiDong)
        {
            try
            {
                if (khoiDong.id == null) return false;
                var getIdKhoiDong = _dbcontext.KhoiDongs.FirstOrDefault(c=>c.id == khoiDong.id);
                _dbcontext.KhoiDongs.Remove(getIdKhoiDong);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<khoiDong> getAll()
        {
            return _dbcontext.KhoiDongs.ToList();
        }

        public bool update(khoiDong khoiDong)
        {
            try
            {
                if (khoiDong.id == null) return false;
                var getIdKhoiDong = _dbcontext.KhoiDongs.FirstOrDefault(c => c.id == khoiDong.id);
                _dbcontext.KhoiDongs.Update(getIdKhoiDong);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
