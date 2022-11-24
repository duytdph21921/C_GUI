using A_DAL.DomaninClass;
using A_DAL.IRepositories;
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

namespace C_GUI.View
{
    public partial class QLChuvu : Form
    {
        IChucVuService _chucVuService;
        List<ChuVuViewModel> _Listchuvu;
        Guid _Guid;
        public QLChuvu()
        {
            InitializeComponent();
            _chucVuService = new ChuVuService();
            _Listchuvu = new List<ChuVuViewModel>();
            load();
        }

        private void QLChuvu_Load(object sender, EventArgs e)
        {

        }
        public void load()
        {
            DTG_SHOW.ColumnCount = 3;
            DTG_SHOW.Rows.Clear();
            DTG_SHOW.Columns[0].Name = "id";
            DTG_SHOW.Columns[1].Name = "Mã";
            DTG_SHOW.Columns[2].Name = "Tên";
            DTG_SHOW.Columns[0].Visible = false;
            _Listchuvu = _chucVuService.getall();
            if (TB_Search.Text != "")
            {
                _Listchuvu = _Listchuvu.Where(p => p.Ten.Contains(TB_Search.Text) || p.Ma.Contains(TB_Search.Text)).ToList();

            }

            foreach (var item in _Listchuvu)
            {
                DTG_SHOW.Rows.Add(item.id, item.Ma, item.Ten);
            }
          
        }
        public ChuVuViewModel them()
        {
            ChuVuViewModel chuVuViewModel = new ChuVuViewModel()
            {
                id = new Guid(),
                Ma = TTB_Ma.Text,
                Ten = TB_Ten.Text,
            };
            return chuVuViewModel;
        }
        public ChuVuViewModel suavaxoa()
        {
            ChuVuViewModel chuVuViewModel = new ChuVuViewModel()
            {
                id = _Guid,
                Ma = TTB_Ma.Text,
                Ten = TB_Ten.Text,
            };
            return chuVuViewModel;
        }
        private void BTN_them_Click(object sender, EventArgs e)
        {

            MessageBox.Show(_chucVuService.add(them()));
            load();
           
        }

        private void DTG_SHOW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _Guid = Guid.Parse(DTG_SHOW.CurrentRow.Cells[0].Value.ToString());
            TTB_Ma.Text = (DTG_SHOW.CurrentRow.Cells[1].Value.ToString());
            TB_Ten.Text = (DTG_SHOW.CurrentRow.Cells[2].Value.ToString());
        }

        private void BTN_Sua_Click(object sender, EventArgs e)
        {
          
                MessageBox.Show(_chucVuService.update(suavaxoa()));
                load();
            
        }

        private void BTN_Xoa_Click(object sender, EventArgs e)
        {
           
           
                MessageBox.Show(_chucVuService.delete(suavaxoa()));
                load();
            
        }

        private void TB_Search_TextChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
