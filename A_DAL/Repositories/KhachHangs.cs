using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A_DAL.Repositories
{
    public class KhachHangs : IKhachHang
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(KhachHang khachHang)
        {
            try
            {
                if (khachHang == null) return false;
                _dbcontext.KhachHangs.Add(khachHang);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool delete(KhachHang khachHang)
        {
            try
            {
                if (khachHang.id == null) return false;
                var getIdkhachhang = _dbcontext.KhachHangs.FirstOrDefault(c => c.id == khachHang.id);
                _dbcontext.KhachHangs.Remove(getIdkhachhang);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<KhachHang> GellALL()
        {
            return _dbcontext.KhachHangs.ToList();
        }

        public bool update(KhachHang khachHang)
        {
            try
            {
                if (khachHang.id == null) return false;
                var getIdkhachhang = _dbcontext.KhachHangs.FirstOrDefault(c => c.id == khachHang.id);
                _dbcontext.KhachHangs.Update(getIdkhachhang);
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
