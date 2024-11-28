using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuyende6
{
    
    public partial class Form1 : Form
    {
        private string lastSelectedMaCTDT = null;
        private string lastSelectedMaNghe = null; // Biến lưu trữ MaNghe đã chọn
        public Form1()
        {
            InitializeComponent();
        }

        private void chiTietCTDTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiTietCTDTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLChuongTrinhDaoTaoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.Nghe' table. You can move, or remove it, as needed.
            this.ngheTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.Nghe);
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.MonHoc);
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.KeHoachDaoTaoTheoKhoa' table. You can move, or remove it, as needed.
            this.keHoachDaoTaoTheoKhoaTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.KeHoachDaoTaoTheoKhoa);
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.CTDT' table. You can move, or remove it, as needed.
            this.cTDTTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.CTDT);
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.ChiTietCTDT' table. You can move, or remove it, as needed.
            this.chiTietCTDTTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.ChiTietCTDT);
            if (maCTDTComboBox.SelectedValue != null)
            {
                lastSelectedMaCTDT = maCTDTComboBox.SelectedValue.ToString();
                SetUpDataGridView(lastSelectedMaCTDT, null); // Gọi SetUpDataGridView khi form load
            }

            maCTDTComboBox.SelectedIndexChanged += ComboBoxMaCTDT_SelectedIndexChanged;
            comboBoxNghe.SelectedIndexChanged += ComboBoxNghe_SelectedIndexChanged; // Sự kiện thay đổi cho comboBoxNghe
        

        }

        private void chiTietCTDTDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ComboBoxMaCTDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cập nhật dữ liệu của DataGridView khi chọn MaCTDT mới từ ComboBox
            if (maCTDTComboBox.SelectedValue != null && maCTDTComboBox.SelectedValue.ToString() != lastSelectedMaCTDT)
            {
                lastSelectedMaCTDT = maCTDTComboBox.SelectedValue.ToString(); // Cập nhật giá trị mới
                SetUpDataGridView(lastSelectedMaCTDT, lastSelectedMaNghe); // Cập nhật DataGridView theo MaCTDT và MaNghe
            }
        }
        private void ComboBoxNghe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cập nhật dữ liệu của DataGridView khi chọn MaNghe từ ComboBox
            if (comboBoxNghe.SelectedValue != null && comboBoxNghe.SelectedValue.ToString() != lastSelectedMaNghe)
            {
                lastSelectedMaNghe = comboBoxNghe.SelectedValue.ToString(); // Cập nhật giá trị mới
                SetUpDataGridView(lastSelectedMaCTDT, lastSelectedMaNghe); // Cập nhật DataGridView theo MaCTDT và MaNghe
            }
        }
        private void SetUpDataGridView(string selectedMaCTDT, string selectedMaNghe)
        {
            // Đặt AutoGenerateColumns là false nếu bạn muốn thêm cột thủ công
            chiTietCTDTDataGridView.Columns.Clear();
            chiTietCTDTDataGridView.AutoGenerateColumns = false;


            // Thêm các cột vào DataGridView
            chiTietCTDTDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "TenMH", DataPropertyName = "TenMH" });
            chiTietCTDTDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "SoTinChi", DataPropertyName = "SoTinChi" });
            chiTietCTDTDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "LyThuyet", DataPropertyName = "LyThuyet" });
            chiTietCTDTDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ThucHanh", DataPropertyName = "ThucHanh" });
            chiTietCTDTDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "KiemTra", DataPropertyName = "KiemTra" });
            chiTietCTDTDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ThuongXuyen", DataPropertyName = "ThuongXuyen" });
            chiTietCTDTDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "DinhKi", DataPropertyName = "DinhKi" });
            chiTietCTDTDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "HetMon", DataPropertyName = "HetMon" });
            chiTietCTDTDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "GhiChu", DataPropertyName = "GhiChu" });

            // Lọc dữ liệu theo MaCTDT và MaNghe
            var query = from chiTiet in qLChuongTrinhDaoTaoDataSet.ChiTietCTDT
                        join monHoc in qLChuongTrinhDaoTaoDataSet.MonHoc
                        on chiTiet.MaMH equals monHoc.MaMH
                        where chiTiet.MaCTDT == selectedMaCTDT
                        && chiTiet.MaNghe == selectedMaNghe // Kiểm tra MaNghe nếu có chọn
                        select new
                        {

                            TenMH = monHoc.TenMH,
                            SoTinChi = monHoc.SoTinChi,
                            LyThuyet = monHoc.LyThuyet,
                            ThucHanh = monHoc.ThucHanh,
                            KiemTra = monHoc.KiemTra,
                            ThuongXuyen = monHoc.ThuongXuyen,
                            DinhKi = monHoc.DinhKy,
                            HetMon = monHoc.HetMon,
                            GhiChu = monHoc.GhiChu
                        };

            // Gán dữ liệu vào DataGridView
            chiTietCTDTDataGridView.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nw = new Form2();
            nw.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chiTietCTDTTableAdapter.FillBytim(qLChuongTrinhDaoTaoDataSet.ChiTietCTDT, maCTDTComboBox.SelectedValue.ToString(), comboBoxNghe.SelectedValue.ToString());
            //this.chiTietCTDTTableAdapter.FillBytongtinchi(qLChuongTrinhDaoTaoDataSet.ChiTietCTDT, maCTDTComboBox.SelectedValue.ToString(), comboBoxNghe.SelectedValue.ToString());
            XtraReport1 r = new XtraReport1();
            r.DataSource = qLChuongTrinhDaoTaoDataSet;
            r.DataMember = qLChuongTrinhDaoTaoDataSet.ChiTietCTDT.TableName;
            r.ShowRibbonPreviewDialog();
        }
       

    }
}
