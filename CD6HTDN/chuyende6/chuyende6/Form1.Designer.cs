namespace chuyende6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.maCTDTComboBox = new System.Windows.Forms.ComboBox();
            this.cTDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLChuongTrinhDaoTaoDataSet = new chuyende6.QLChuongTrinhDaoTaoDataSet();
            this.comboBoxNghe = new System.Windows.Forms.ComboBox();
            this.ngheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietCTDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietCTDTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietCTDTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietCTDTTableAdapter = new chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.ChiTietCTDTTableAdapter();
            this.tableAdapterManager = new chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.TableAdapterManager();
            this.cTDTTableAdapter = new chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.CTDTTableAdapter();
            this.keHoachDaoTaoTheoKhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keHoachDaoTaoTheoKhoaTableAdapter = new chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.KeHoachDaoTaoTheoKhoaTableAdapter();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocTableAdapter = new chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.MonHocTableAdapter();
            this.ngheTableAdapter = new chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.NgheTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cTDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLChuongTrinhDaoTaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keHoachDaoTaoTheoKhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maCTDTComboBox
            // 
            this.maCTDTComboBox.DataSource = this.cTDTBindingSource;
            this.maCTDTComboBox.DisplayMember = "MaCTDT";
            this.maCTDTComboBox.FormattingEnabled = true;
            this.maCTDTComboBox.Location = new System.Drawing.Point(94, 58);
            this.maCTDTComboBox.Name = "maCTDTComboBox";
            this.maCTDTComboBox.Size = new System.Drawing.Size(176, 24);
            this.maCTDTComboBox.TabIndex = 0;
            this.maCTDTComboBox.ValueMember = "MaCTDT";
            // 
            // cTDTBindingSource
            // 
            this.cTDTBindingSource.DataMember = "CTDT";
            this.cTDTBindingSource.DataSource = this.qLChuongTrinhDaoTaoDataSet;
            // 
            // qLChuongTrinhDaoTaoDataSet
            // 
            this.qLChuongTrinhDaoTaoDataSet.DataSetName = "QLChuongTrinhDaoTaoDataSet";
            this.qLChuongTrinhDaoTaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxNghe
            // 
            this.comboBoxNghe.DataSource = this.ngheBindingSource;
            this.comboBoxNghe.DisplayMember = "TenNghe";
            this.comboBoxNghe.FormattingEnabled = true;
            this.comboBoxNghe.Location = new System.Drawing.Point(410, 58);
            this.comboBoxNghe.Name = "comboBoxNghe";
            this.comboBoxNghe.Size = new System.Drawing.Size(236, 24);
            this.comboBoxNghe.TabIndex = 0;
            this.comboBoxNghe.ValueMember = "MaNghe";
            // 
            // ngheBindingSource
            // 
            this.ngheBindingSource.DataMember = "Nghe";
            this.ngheBindingSource.DataSource = this.qLChuongTrinhDaoTaoDataSet;
            // 
            // chiTietCTDTBindingSource
            // 
            this.chiTietCTDTBindingSource.DataMember = "ChiTietCTDT";
            this.chiTietCTDTBindingSource.DataSource = this.qLChuongTrinhDaoTaoDataSet;
            // 
            // chiTietCTDTBindingSource1
            // 
            this.chiTietCTDTBindingSource1.DataMember = "FK_ChiTietCTDT_CTDT";
            this.chiTietCTDTBindingSource1.DataSource = this.cTDTBindingSource;
            // 
            // chiTietCTDTDataGridView
            // 
            this.chiTietCTDTDataGridView.AutoGenerateColumns = false;
            this.chiTietCTDTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiTietCTDTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.chiTietCTDTDataGridView.DataSource = this.chiTietCTDTBindingSource1;
            this.chiTietCTDTDataGridView.Location = new System.Drawing.Point(12, 99);
            this.chiTietCTDTDataGridView.Name = "chiTietCTDTDataGridView";
            this.chiTietCTDTDataGridView.RowHeadersWidth = 51;
            this.chiTietCTDTDataGridView.RowTemplate.Height = 24;
            this.chiTietCTDTDataGridView.Size = new System.Drawing.Size(681, 339);
            this.chiTietCTDTDataGridView.TabIndex = 3;
            this.chiTietCTDTDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chiTietCTDTDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaCTDT";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaCTDT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaMH";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaMH";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaNghe";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaNghe";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HocKy";
            this.dataGridViewTextBoxColumn4.HeaderText = "HocKy";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LoaiMon";
            this.dataGridViewTextBoxColumn5.HeaderText = "LoaiMon";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // chiTietCTDTTableAdapter
            // 
            this.chiTietCTDTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietCTDTTableAdapter = this.chiTietCTDTTableAdapter;
            this.tableAdapterManager.CTDTTableAdapter = null;
            this.tableAdapterManager.KeHoachDaoTaoTheoKhoaTableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.NgheTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cTDTTableAdapter
            // 
            this.cTDTTableAdapter.ClearBeforeFill = true;
            // 
            // keHoachDaoTaoTheoKhoaBindingSource
            // 
            this.keHoachDaoTaoTheoKhoaBindingSource.DataMember = "KeHoachDaoTaoTheoKhoa";
            this.keHoachDaoTaoTheoKhoaBindingSource.DataSource = this.qLChuongTrinhDaoTaoDataSet;
            // 
            // keHoachDaoTaoTheoKhoaTableAdapter
            // 
            this.keHoachDaoTaoTheoKhoaTableAdapter.ClearBeforeFill = true;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.qLChuongTrinhDaoTaoDataSet;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // ngheTableAdapter
            // 
            this.ngheTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm Sửa Chi Tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 492);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chiTietCTDTDataGridView);
            this.Controls.Add(this.comboBoxNghe);
            this.Controls.Add(this.maCTDTComboBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cTDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLChuongTrinhDaoTaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keHoachDaoTaoTheoKhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox maCTDTComboBox;
        private System.Windows.Forms.ComboBox comboBoxNghe;
        private QLChuongTrinhDaoTaoDataSet qLChuongTrinhDaoTaoDataSet;
        private System.Windows.Forms.BindingSource chiTietCTDTBindingSource;
        private QLChuongTrinhDaoTaoDataSetTableAdapters.ChiTietCTDTTableAdapter chiTietCTDTTableAdapter;
        private QLChuongTrinhDaoTaoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cTDTBindingSource;
        private QLChuongTrinhDaoTaoDataSetTableAdapters.CTDTTableAdapter cTDTTableAdapter;
        private System.Windows.Forms.BindingSource keHoachDaoTaoTheoKhoaBindingSource;
        private QLChuongTrinhDaoTaoDataSetTableAdapters.KeHoachDaoTaoTheoKhoaTableAdapter keHoachDaoTaoTheoKhoaTableAdapter;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QLChuongTrinhDaoTaoDataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.BindingSource ngheBindingSource;
        private QLChuongTrinhDaoTaoDataSetTableAdapters.NgheTableAdapter ngheTableAdapter;
        private System.Windows.Forms.BindingSource chiTietCTDTBindingSource1;
        private System.Windows.Forms.DataGridView chiTietCTDTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

