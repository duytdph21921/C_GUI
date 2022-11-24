using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class ChucVus : IChuVu
    {
        XeMayDbConText _Dbcontext = new XeMayDbConText();
        public bool add(ChucVu chucVu)
        {
            try
            {
                if (chucVu == null) return false;
                _Dbcontext.Add(chucVu); 
               // _Dbcontext.ChucVus.Add(chucVu); cả 2 cái đều đc
                _Dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool delete(ChucVu chucVu)
        {
            try
            {
                if (chucVu == null) return false;
                var getIDChuVu = _Dbcontext.ChucVus.FirstOrDefault(c => c.id == chucVu.id);
                _Dbcontext.Remove(getIDChuVu);
                _Dbcontext.SaveChanges();
                return true;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ChucVu> GetAll()
        {
            return _Dbcontext.ChucVus.ToList();
        }

        public bool update(ChucVu chucVu)
        {
            try
            {
                if (chucVu == null) return false;
                var getIDChuVu = _Dbcontext.ChucVus.FirstOrDefault(c => c.id == chucVu.id);
                _Dbcontext.Update(getIDChuVu);
                _Dbcontext.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
