using B_BUS.IService;
using B_BUS.Service;
using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Winform
{
    public partial class QL_NhanVien : Form
    {
        INhanVien _inhanvienservice;
        List<NhanVienModelView> _ListNhanVien;
        Guid _idgui;
        public QL_NhanVien()
        {
            InitializeComponent();
            _inhanvienservice= new NhanVienService();
            _ListNhanVien = new List<NhanVienModelView>();
            load();
        }
        public void load()
        {
            dtg_shownhanvien.Rows.Clear();
            dtg_shownhanvien.ColumnCount = 11;
            dtg_shownhanvien.Columns[0].Name = "id";
            dtg_shownhanvien.Columns[1].Name = "mã";
            dtg_shownhanvien.Columns[2].Name = "Họ Và Tên";
            dtg_shownhanvien.Columns[3].Name = "ngày sinh";
            dtg_shownhanvien.Columns[4].Name = "giới tính";
            dtg_shownhanvien.Columns[5].Name = "địa chỉ";
            dtg_shownhanvien.Columns[6].Name = "sdt";
            dtg_shownhanvien.Columns[7].Name = "chức vụ";
            dtg_shownhanvien.Columns[8].Name = " người gửi báo cáo";
            dtg_shownhanvien.Columns[9].Name = " link ảnh";
            dtg_shownhanvien.Columns[10].Name = "trạng thái";
            dtg_shownhanvien.Columns[0].Visible = false;
            _ListNhanVien = _inhanvienservice.GetAll();
            if (rd_0.Checked)
            {
                _ListNhanVien = _ListNhanVien.Where(c => c.HTTT == "Nghỉ Việc").ToList();
            }
            if (rd_1.Checked)
            {
                _ListNhanVien = _ListNhanVien.Where(c => c.HTTT == "Đang làm việc").ToList();
            }

            if (tb_Search.Text!= "")
            {
                _ListNhanVien = _ListNhanVien.Where(c => c.Hovaten.Contains(tb_Search.Text)).ToList();
            }
                foreach (var item in _ListNhanVien)
                {
                    dtg_shownhanvien.Rows.Add(item.id,
                        item.Ma,
                        item.Hovaten,
                       item.NgaySinh.Value.ToShortDateString(), item.NamNu, item.DiaChi,
                        item.sdt,
                        item.tenChuVu,
                        item.nhanvienguibaocao,
                        item.linkanh,
                         item.HTTT);
                }

        
        }
       

        private void BTN_Xoa_Click(object sender, EventArgs e)
        {
            var idxoa = _inhanvienservice.GetAll().FirstOrDefault(x => x.id == _idgui);
            idxoa.Trangthai = 0;
                MessageBox.Show(_inhanvienservice.update(idxoa));
           
            load();
        }

        private void dtg_shownhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idgui = Guid.Parse(dtg_shownhanvien.CurrentRow.Cells[0].Value.ToString());
        }

        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            load();
        }

        private void rd_0_CheckedChanged(object sender, EventArgs e)
        {
            load();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            load();
        }

        private void BTN_Them_Click(object sender, EventArgs e)
        {
            load();
            
            var idxoa = _inhanvienservice.GetAll().FirstOrDefault(x => x.id == _idgui);
            idxoa.Trangthai = 1;
            MessageBox.Show(_inhanvienservice.update(idxoa));

            load();
        }
    }
}
