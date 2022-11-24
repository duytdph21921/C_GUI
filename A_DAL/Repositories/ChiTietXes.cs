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
                GetIdChiTietXe.SanPhamID = chiTietXe.SanPhamID;
                GetIdChiTietXe.NSXID = chiTietXe.NSXID;
                GetIdChiTietXe.LoaiXeID = chiTietXe.LoaiXeID;
                GetIdChiTietXe.mauSacID = chiTietXe.mauSacID;
                GetIdChiTietXe.DongCoID = chiTietXe.DongCoID;
                GetIdChiTietXe.khoiDongID = chiTietXe.khoiDongID;
                GetIdChiTietXe.anhID = chiTietXe.anhID;
                GetIdChiTietXe.NgayNhap = chiTietXe.NgayNhap;
                GetIdChiTietXe.namBh =chiTietXe.namBh;
                GetIdChiTietXe.soKhung = chiTietXe.soKhung;
                GetIdChiTietXe.soMay = chiTietXe.soMay;
                GetIdChiTietXe.binhXang = chiTietXe.binhXang;
                GetIdChiTietXe.moTa = chiTietXe.moTa;
                GetIdChiTietXe.SoLuongTon = chiTietXe.SoLuongTon;
                GetIdChiTietXe.giaBan = chiTietXe.giaBan;
                GetIdChiTietXe.giaNhap = chiTietXe.giaNhap;
                GetIdChiTietXe.TrangThai = chiTietXe.TrangThai;
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
