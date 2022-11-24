using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class ChiTietXes :IChiTietXe
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();

        public bool add(ChiTietXe chiTietXe)
        {
            try
            {
                if (chiTietXe == null) return false;
                
                    _dbcontext.ChiTietXes.Add(chiTietXe);
                    _dbcontext.SaveChanges();
                    return true;
             
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool delete(ChiTietXe chiTietXe)
        {
            try
            {
                if (chiTietXe.id == null) return false;
                var GetIdChiTietXe = _dbcontext.ChiTietXes.FirstOrDefault(c => c.id == chiTietXe.id);
                _dbcontext.ChiTietXes.Remove(GetIdChiTietXe);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ChiTietXe> GetAll()
        {
            return _dbcontext.ChiTietXes.ToList();
        }

        public bool update(ChiTietXe chiTietXe)
        {
            try
            {
                if (chiTietXe.id == null) return false;
                var GetIdChiTietXe = _dbcontext.ChiTietXes.FirstOrDefault(c => c.id == chiTietXe.id);
                _dbcontext.ChiTietXes.Update(GetIdChiTietXe);
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
