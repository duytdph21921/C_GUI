using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class NhaViens : INhavien
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(NhanVien nhanVien)
        {
            if (nhanVien == null) return false;
            _dbcontext.NhanViens.Add(nhanVien);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool delete(NhanVien nhanVien)
        {
            if (nhanVien == null) return false;
            var getidnhavien = _dbcontext.NhanViens.FirstOrDefault(c => c.id == nhanVien.id);
            _dbcontext.NhanViens.Remove(getidnhavien);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<NhanVien> getAll()
        {
            
            return _dbcontext.NhanViens.ToList();
        }

        public bool update(NhanVien nhanVien)
        {
            if (nhanVien == null) return false;
            var getidnhavien = _dbcontext.NhanViens.FirstOrDefault(c => c.id == nhanVien.id);
            _dbcontext.NhanViens.Update(getidnhavien);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
