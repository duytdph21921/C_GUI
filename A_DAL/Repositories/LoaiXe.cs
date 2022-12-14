using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class LoaiXe : ILoaiXe
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(loaiXe loaiXe)
        {
            if (loaiXe == null) return false;
           
                _dbcontext.LoaiXes.Add(loaiXe);
                _dbcontext.SaveChanges();
                return true;
            
        }

        public bool delete(loaiXe loaiXe)
        {
            if (loaiXe.id == null) return false;
            var getidloaixe = _dbcontext.LoaiXes.FirstOrDefault(c => c.id == loaiXe.id);
            _dbcontext.LoaiXes.Remove(getidloaixe);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<loaiXe> GetAll()
        {
            return _dbcontext.LoaiXes.ToList();
        }

        public bool update(loaiXe loaiXe)
        {
            if (loaiXe.id == null) return false;
            var getidloaixe = _dbcontext.LoaiXes.FirstOrDefault(c => c.id == loaiXe.id);
            _dbcontext.LoaiXes.Update(getidloaixe);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
