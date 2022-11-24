using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class KhuyenMais : IKhuyenMai
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(KhuyenMai khuyenMai)
        {
            try
            {
                if (khuyenMai == null) return false;
                _dbcontext.KhuyenMais.Add(khuyenMai);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool delete(KhuyenMai khuyenMai)
        {
            try
            {
                if (khuyenMai.id == null) return false;
                var getidkhuyenMai = _dbcontext.KhuyenMais.FirstOrDefault(c => c.id == khuyenMai.id);
                _dbcontext.KhuyenMais.Remove(getidkhuyenMai);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<KhuyenMai> GetAll()
        {
            return _dbcontext.KhuyenMais.ToList();
        }

        public bool update(KhuyenMai khuyenMai)
        {
            try
            {
                if (khuyenMai.id == null) return false;
                var getidkhuyenMai = _dbcontext.KhuyenMais.FirstOrDefault(c => c.id == khuyenMai.id);
                _dbcontext.KhuyenMais.Update(getidkhuyenMai);
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
