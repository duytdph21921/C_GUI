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
    public class HoaDons : IHoaDon
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(HoaDon hoaDon)
        {
            try
            {
                if (hoaDon == null) return false;

                _dbcontext.HoaDons.Add(hoaDon);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                //
                return false;
            }
        }

        public bool delete(HoaDon hoaDon)
        {
            try
            {
                if (hoaDon.Id == null) return false;
                {
                 //    var getbyIdAnh = _dbcontext.HoaDons.FirstOrDefault(c => c.Id == hoaDon.Id); 
                    // có thể sửa dụng cách này
                    _dbcontext.HoaDons.Remove(_dbcontext.HoaDons.FirstOrDefault(c => c.Id == hoaDon.Id));
                    _dbcontext.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {

                return false;

            }
        }

        public List<HoaDon> GetAll()
        {
            return _dbcontext.HoaDons.ToList();
        }

        public bool update(HoaDon hoaDon)
        {
            try
            {
                if (hoaDon.Id == null) return false;
                {
                    //    var getbyIdAnh = _dbcontext.HoaDons.FirstOrDefault(c => c.Id == hoaDon.Id); 
                    // có thể sửa dụng cách này
                    _dbcontext.HoaDons.Update(_dbcontext.HoaDons.FirstOrDefault(c => c.Id == hoaDon.Id));
                    _dbcontext.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {

                return false;

            }
        }
    }
}
