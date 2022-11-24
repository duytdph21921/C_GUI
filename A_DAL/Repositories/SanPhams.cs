﻿using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class SanPhams : ISanPham
    {
        
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(sanPham sanPham)
        {
            if (sanPham == null) return false;
            _dbcontext.SanPhams.Add(sanPham);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool delete(sanPham sanPham)
        {
            if (sanPham == null) return false;
            var getidsanpham = _dbcontext.SanPhams.FirstOrDefault(c => c.id == sanPham.id);
            _dbcontext.SanPhams.Remove(getidsanpham);
            _dbcontext.SaveChanges();
            return true;
        }



       
        public List<sanPham> getAll()
        {
            return _dbcontext.SanPhams.ToList();
        }

        public bool update(sanPham sanPham)
        {
            if (sanPham == null) return false;
            var getidsanpham = _dbcontext.SanPhams.FirstOrDefault(c => c.id == sanPham.id);
            _dbcontext.SanPhams.Update(sanPham);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
