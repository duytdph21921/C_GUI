using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IService
{
    public interface INhanVien
    {
        string add(NhanVienModelView nhanVienModelView);
        string update(NhanVienModelView nhanVienModelView);
        string remove(NhanVienModelView nhanVienModelView);
        List<NhanVienModelView> GetAll();
    }
}
