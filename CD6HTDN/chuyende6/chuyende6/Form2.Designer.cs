namespace chuyende6
{
    partial class Form2
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
            System.Windows.Forms.Label maCTDTLabel;
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label maNgheLabel;
            System.Windows.Forms.Label hocKyLabel;
            System.Windows.Forms.Label loaiMonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.qLChuongTrinhDaoTaoDataSet = new chuyende6.QLChuongTrinhDaoTaoDataSet();
            this.chiTietCTDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietCTDTTableAdapter = new chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.ChiTietCTDTTableAdapter();
            this.tableAdapterManager = new chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.TableAdapterManager();
            this.cTDTTableAdapter = new chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.CTDTTableAdapter();
            this.monHocTableAdapter = new chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.MonHocTableAdapter();
            this.ngheTableAdapter = new chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.NgheTableAdapter();
            this.chiTietCTDTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.chiTietCTDTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.chiTietCTDTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cTDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ngheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietCTDTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.maCTDTComboBox = new System.Windows.Forms.ComboBox();
            this.maMHComboBox = new System.Windows.Forms.ComboBox();
            this.maNgheComboBox = new System.Windows.Forms.ComboBox();
            this.hocKyTextBox = new System.Windows.Forms.TextBox();
            this.loaiMonTextBox = new System.Windows.Forms.TextBox();
            maCTDTLabel = new System.Windows.Forms.Label();
            maMHLabel = new System.Windows.Forms.Label();
            maNgheLabel = new System.Windows.Forms.Label();
            hocKyLabel = new System.Windows.Forms.Label();
            loaiMonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLChuongTrinhDaoTaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTBindingNavigator)).BeginInit();
            this.chiTietCTDTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // maCTDTLabel
            // 
            maCTDTLabel.AutoSize = true;
            maCTDTLabel.Location = new System.Drawing.Point(128, 72);
            maCTDTLabel.Name = "maCTDTLabel";
            maCTDTLabel.Size = new System.Drawing.Size(69, 16);
            maCTDTLabel.TabIndex = 12;
            maCTDTLabel.Text = "Ma CTDT:";
            // 
            // maMHLabel
            // 
            maMHLabel.AutoSize = true;
            maMHLabel.Location = new System.Drawing.Point(128, 102);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(53, 16);
            maMHLabel.TabIndex = 14;
            maMHLabel.Text = "Ma MH:";
            // 
            // maNgheLabel
            // 
            maNgheLabel.AutoSize = true;
            maNgheLabel.Location = new System.Drawing.Point(128, 132);
            maNgheLabel.Name = "maNgheLabel";
            maNgheLabel.Size = new System.Drawing.Size(65, 16);
            maNgheLabel.TabIndex = 16;
            maNgheLabel.Text = "Ma Nghe:";
            // 
            // hocKyLabel
            // 
            hocKyLabel.AutoSize = true;
            hocKyLabel.Location = new System.Drawing.Point(128, 162);
            hocKyLabel.Name = "hocKyLabel";
            hocKyLabel.Size = new System.Drawing.Size(53, 16);
            hocKyLabel.TabIndex = 18;
            hocKyLabel.Text = "Hoc Ky:";
            // 
            // loaiMonLabel
            // 
            loaiMonLabel.AutoSize = true;
            loaiMonLabel.Location = new System.Drawing.Point(128, 190);
            loaiMonLabel.Name = "loaiMonLabel";
            loaiMonLabel.Size = new System.Drawing.Size(65, 16);
            loaiMonLabel.TabIndex = 20;
            loaiMonLabel.Text = "Loai Mon:";
            // 
            // qLChuongTrinhDaoTaoDataSet
            // 
            this.qLChuongTrinhDaoTaoDataSet.DataSetName = "QLChuongTrinhDaoTaoDataSet";
            this.qLChuongTrinhDaoTaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietCTDTBindingSource
            // 
            this.chiTietCTDTBindingSource.DataMember = "ChiTietCTDT";
            this.chiTietCTDTBindingSource.DataSource = this.qLChuongTrinhDaoTaoDataSet;
            // 
            // chiTietCTDTTableAdapter
            // 
            this.chiTietCTDTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietCTDTTableAdapter = this.chiTietCTDTTableAdapter;
            this.tableAdapterManager.CTDTTableAdapter = this.cTDTTableAdapter;
            this.tableAdapterManager.KeHoachDaoTaoTheoKhoaTableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = this.monHocTableAdapter;
            this.tableAdapterManager.NgheTableAdapter = this.ngheTableAdapter;
            this.tableAdapterManager.UpdateOrder = chuyende6.QLChuongTrinhDaoTaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cTDTTableAdapter
            // 
            this.cTDTTableAdapter.ClearBeforeFill = true;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // ngheTableAdapter
            // 
            this.ngheTableAdapter.ClearBeforeFill = true;
            // 
            // chiTietCTDTBindingNavigator
            // 
            this.chiTietCTDTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.chiTietCTDTBindingNavigator.BindingSource = this.chiTietCTDTBindingSource;
            this.chiTietCTDTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.chiTietCTDTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.chiTietCTDTBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.chiTietCTDTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.chiTietCTDTBindingNavigatorSaveItem});
            this.chiTietCTDTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.chiTietCTDTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.chiTietCTDTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.chiTietCTDTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.chiTietCTDTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.chiTietCTDTBindingNavigator.Name = "chiTietCTDTBindingNavigator";
            this.chiTietCTDTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.chiTietCTDTBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.chiTietCTDTBindingNavigator.TabIndex = 0;
            this.chiTietCTDTBindingNavigator.Text = "bindingNavigator1";
            this.chiTietCTDTBindingNavigator.RefreshItems += new System.EventHandler(this.chiTietCTDTBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // chiTietCTDTBindingNavigatorSaveItem
            // 
            this.chiTietCTDTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chiTietCTDTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("chiTietCTDTBindingNavigatorSaveItem.Image")));
            this.chiTietCTDTBindingNavigatorSaveItem.Name = "chiTietCTDTBindingNavigatorSaveItem";
            this.chiTietCTDTBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.chiTietCTDTBindingNavigatorSaveItem.Text = "Save Data";
            this.chiTietCTDTBindingNavigatorSaveItem.Click += new System.EventHandler(this.chiTietCTDTBindingNavigatorSaveItem_Click);
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
            this.chiTietCTDTDataGridView.DataSource = this.chiTietCTDTBindingSource;
            this.chiTietCTDTDataGridView.Location = new System.Drawing.Point(12, 218);
            this.chiTietCTDTDataGridView.Name = "chiTietCTDTDataGridView";
            this.chiTietCTDTDataGridView.RowHeadersWidth = 51;
            this.chiTietCTDTDataGridView.RowTemplate.Height = 24;
            this.chiTietCTDTDataGridView.Size = new System.Drawing.Size(687, 220);
            this.chiTietCTDTDataGridView.TabIndex = 1;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thêm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(610, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(610, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(610, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Quay Về";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cTDTBindingSource
            // 
            this.cTDTBindingSource.DataMember = "CTDT";
            this.cTDTBindingSource.DataSource = this.qLChuongTrinhDaoTaoDataSet;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.qLChuongTrinhDaoTaoDataSet;
            // 
            // ngheBindingSource
            // 
            this.ngheBindingSource.DataMember = "Nghe";
            this.ngheBindingSource.DataSource = this.qLChuongTrinhDaoTaoDataSet;
            // 
            // chiTietCTDTBindingSource1
            // 
            this.chiTietCTDTBindingSource1.DataMember = "FK_ChiTietCTDT_CTDT";
            this.chiTietCTDTBindingSource1.DataSource = this.cTDTBindingSource;
            // 
            // maCTDTComboBox
            // 
            this.maCTDTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietCTDTBindingSource, "MaCTDT", true));
            this.maCTDTComboBox.DataSource = this.cTDTBindingSource;
            this.maCTDTComboBox.DisplayMember = "MaCTDT";
            this.maCTDTComboBox.FormattingEnabled = true;
            this.maCTDTComboBox.Location = new System.Drawing.Point(203, 69);
            this.maCTDTComboBox.Name = "maCTDTComboBox";
            this.maCTDTComboBox.Size = new System.Drawing.Size(121, 24);
            this.maCTDTComboBox.TabIndex = 13;
            this.maCTDTComboBox.ValueMember = "MaCTDT";
            // 
            // maMHComboBox
            // 
            this.maMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietCTDTBindingSource, "MaMH", true));
            this.maMHComboBox.DataSource = this.monHocBindingSource;
            this.maMHComboBox.DisplayMember = "MaMH";
            this.maMHComboBox.FormattingEnabled = true;
            this.maMHComboBox.Location = new System.Drawing.Point(203, 99);
            this.maMHComboBox.Name = "maMHComboBox";
            this.maMHComboBox.Size = new System.Drawing.Size(121, 24);
            this.maMHComboBox.TabIndex = 15;
            this.maMHComboBox.ValueMember = "MaMH";
            // 
            // maNgheComboBox
            // 
            this.maNgheComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietCTDTBindingSource, "MaNghe", true));
            this.maNgheComboBox.DataSource = this.ngheBindingSource;
            this.maNgheComboBox.DisplayMember = "MaNghe";
            this.maNgheComboBox.FormattingEnabled = true;
            this.maNgheComboBox.Location = new System.Drawing.Point(203, 129);
            this.maNgheComboBox.Name = "maNgheComboBox";
            this.maNgheComboBox.Size = new System.Drawing.Size(121, 24);
            this.maNgheComboBox.TabIndex = 17;
            this.maNgheComboBox.ValueMember = "MaNghe";
            // 
            // hocKyTextBox
            // 
            this.hocKyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietCTDTBindingSource, "HocKy", true));
            this.hocKyTextBox.Location = new System.Drawing.Point(203, 159);
            this.hocKyTextBox.Name = "hocKyTextBox";
            this.hocKyTextBox.Size = new System.Drawing.Size(121, 22);
            this.hocKyTextBox.TabIndex = 19;
            // 
            // loaiMonTextBox
            // 
            this.loaiMonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietCTDTBindingSource, "LoaiMon", true));
            this.loaiMonTextBox.Location = new System.Drawing.Point(203, 187);
            this.loaiMonTextBox.Name = "loaiMonTextBox";
            this.loaiMonTextBox.Size = new System.Drawing.Size(121, 22);
            this.loaiMonTextBox.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(maCTDTLabel);
            this.Controls.Add(this.maCTDTComboBox);
            this.Controls.Add(maMHLabel);
            this.Controls.Add(this.maMHComboBox);
            this.Controls.Add(maNgheLabel);
            this.Controls.Add(this.maNgheComboBox);
            this.Controls.Add(hocKyLabel);
            this.Controls.Add(this.hocKyTextBox);
            this.Controls.Add(loaiMonLabel);
            this.Controls.Add(this.loaiMonTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chiTietCTDTDataGridView);
            this.Controls.Add(this.chiTietCTDTBindingNavigator);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLChuongTrinhDaoTaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTBindingNavigator)).EndInit();
            this.chiTietCTDTBindingNavigator.ResumeLayout(false);
            this.chiTietCTDTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietCTDTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLChuongTrinhDaoTaoDataSet qLChuongTrinhDaoTaoDataSet;
        private System.Windows.Forms.BindingSource chiTietCTDTBindingSource;
        private QLChuongTrinhDaoTaoDataSetTableAdapters.ChiTietCTDTTableAdapter chiTietCTDTTableAdapter;
        private QLChuongTrinhDaoTaoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator chiTietCTDTBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton chiTietCTDTBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView chiTietCTDTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private QLChuongTrinhDaoTaoDataSetTableAdapters.CTDTTableAdapter cTDTTableAdapter;
        private System.Windows.Forms.BindingSource cTDTBindingSource;
        private QLChuongTrinhDaoTaoDataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QLChuongTrinhDaoTaoDataSetTableAdapters.NgheTableAdapter ngheTableAdapter;
        private System.Windows.Forms.BindingSource ngheBindingSource;
        private System.Windows.Forms.BindingSource chiTietCTDTBindingSource1;
        private System.Windows.Forms.ComboBox maCTDTComboBox;
        private System.Windows.Forms.ComboBox maMHComboBox;
        private System.Windows.Forms.ComboBox maNgheComboBox;
        private System.Windows.Forms.TextBox hocKyTextBox;
        private System.Windows.Forms.TextBox loaiMonTextBox;
    }
}