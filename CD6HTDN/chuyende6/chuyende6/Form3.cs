using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace chuyende6
{
    public partial class Form3 : Form
    {
        //SqlConnection conn =new SqlConnection("");
        public Form3()
        {
            InitializeComponent();
        }

        private void keHoachDaoTaoTheoKhoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.keHoachDaoTaoTheoKhoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLChuongTrinhDaoTaoDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.Nghe' table. You can move, or remove it, as needed.
            this.ngheTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.Nghe);

            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.MonHoc);
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.ChiTietCTDT' table. You can move, or remove it, as needed.
            this.chiTietCTDTTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.ChiTietCTDT);
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.CTDT' table. You can move, or remove it, as needed.
            this.cTDTTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.CTDT);
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.KeHoachDaoTaoTheoKhoa' table. You can move, or remove it, as needed.
            this.keHoachDaoTaoTheoKhoaTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.KeHoachDaoTaoTheoKhoa);
            LoadMaKhoa();

        }
        private void LoadMaKhoa()
        {
            // Chuỗi kết nối (cập nhật theo thông tin của bạn)
            string connectionString = @"Data Source=LAPTOP-KT2GORU4;Initial Catalog=QLChuongTrinhDaoTao;Persist Security Info=True;User ID=sa;Password=1;TrustServerCertificate=True";

            // Truy vấn lấy MaNghe
            string query = "SELECT DISTINCT Khoa FROM KeHoachDaoTaoTheoKhoa ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxKhoa.DataSource = dt;
                comboBoxKhoa.DisplayMember = "Khoa"; // Tên cột hiển thị
                comboBoxKhoa.ValueMember = "Khoa";   // Giá trị thực sự
            }
        }
       
        private void FilterData()
        {
            // Lấy giá trị đã chọn trong cả hai ComboBox
            string selectedMaCTDT = comboBoxMaCTDT.SelectedValue?.ToString();
            string selectedKhoa = comboBoxKhoa.SelectedValue?.ToString();
           

            // Kiểm tra xem có đủ dữ liệu được chọn không
            if (string.IsNullOrEmpty(selectedMaCTDT) || string.IsNullOrEmpty(selectedKhoa) )
            {
                // Nếu một trong hai giá trị chưa được chọn, không thực hiện lọc
                return;
            }

            // Cập nhật câu truy vấn để lọc dữ liệu theo MaCTDT và Khoa
            string connectionString = @"Data Source=LAPTOP-KT2GORU4;Initial Catalog=QLChuongTrinhDaoTao;Persist Security Info=True;User ID=sa;Password=1;TrustServerCertificate=True";

            string query = "SELECT * FROM KeHoachDaoTaoTheoKhoa WHERE MaCTDT = @MaCTDT AND Khoa = @Khoa";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@MaCTDT", selectedMaCTDT);
                adapter.SelectCommand.Parameters.AddWithValue("@Khoa", selectedKhoa);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Cập nhật dữ liệu vào DataGridView hoặc các control khác
                keHoachDaoTaoTheoKhoaDataGridView.DataSource = dt;
            }
        }


        private void comboBoxMaNghe_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void comboBoxMaCTDT_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FilterData();
        }

       

        private void maNgheComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FilterData();
        }
    }
}
    
