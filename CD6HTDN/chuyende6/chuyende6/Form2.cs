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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void chiTietCTDTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiTietCTDTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLChuongTrinhDaoTaoDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.Nghe' table. You can move, or remove it, as needed.
            this.ngheTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.Nghe);
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.MonHoc);
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.CTDT' table. You can move, or remove it, as needed.
            this.cTDTTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.CTDT);
            // TODO: This line of code loads data into the 'qLChuongTrinhDaoTaoDataSet.ChiTietCTDT' table. You can move, or remove it, as needed.
            this.chiTietCTDTTableAdapter.Fill(this.qLChuongTrinhDaoTaoDataSet.ChiTietCTDT);

        }

        private void chiTietCTDTBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 nw = new Form1();
            nw.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chiTietCTDTBindingSource.AddNew();
            maCTDTComboBox.Focus();
            maCTDTComboBox.Enabled = true;
            maMHComboBox.Enabled = true;
            maNgheComboBox.Enabled = true;
            hocKyTextBox.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in chiTietCTDTDataGridView.Rows)
            {

                chiTietCTDTBindingSource.EndEdit();
                chiTietCTDTTableAdapter.Update(qLChuongTrinhDaoTaoDataSet.ChiTietCTDT);
                chiTietCTDTBindingSource.ResetBindings(true);
                chiTietCTDTDataGridView.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in chiTietCTDTDataGridView.Rows)
            {

                chiTietCTDTBindingSource.EndEdit();
                chiTietCTDTTableAdapter.Update(qLChuongTrinhDaoTaoDataSet.ChiTietCTDT);
                chiTietCTDTBindingSource.ResetBindings(true);
                chiTietCTDTDataGridView.Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chiTietCTDTDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in chiTietCTDTDataGridView.SelectedRows)
                {

                    chiTietCTDTBindingSource.Remove(r.DataBoundItem);
                }
                chiTietCTDTBindingSource.EndEdit();
                chiTietCTDTTableAdapter.Update(qLChuongTrinhDaoTaoDataSet.ChiTietCTDT);
                chiTietCTDTDataGridView.Refresh();
            }
        }
    }
}
