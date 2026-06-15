namespace databaseKP
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.lblEmpFilter = new System.Windows.Forms.Label();
            this.txtEmpFilter = new System.Windows.Forms.TextBox();
            this.btnEmpAdd = new System.Windows.Forms.Button();
            this.btnEmpEdit = new System.Windows.Forms.Button();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            this.btnEmpExpExcel = new System.Windows.Forms.Button();
            this.btnEmpExpWord = new System.Windows.Forms.Button();
            this.tabDepartments = new System.Windows.Forms.TabPage();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.lblDeptFilter = new System.Windows.Forms.Label();
            this.txtDeptFilter = new System.Windows.Forms.TextBox();
            this.btnDeptAdd = new System.Windows.Forms.Button();
            this.btnDeptEdit = new System.Windows.Forms.Button();
            this.btnDeptDelete = new System.Windows.Forms.Button();
            this.btnDeptExpExcel = new System.Windows.Forms.Button();
            this.btnDeptExpWord = new System.Windows.Forms.Button();
            this.tabPositions = new System.Windows.Forms.TabPage();
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.lblPosFilter = new System.Windows.Forms.Label();
            this.txtPosFilter = new System.Windows.Forms.TextBox();
            this.btnPosAdd = new System.Windows.Forms.Button();
            this.btnPosEdit = new System.Windows.Forms.Button();
            this.btnPosDelete = new System.Windows.Forms.Button();
            this.btnPosExpExcel = new System.Windows.Forms.Button();
            this.btnPosExpWord = new System.Windows.Forms.Button();
            this.tabTimesheet = new System.Windows.Forms.TabPage();
            this.dgvTimesheet = new System.Windows.Forms.DataGridView();
            this.lblTimeFilter = new System.Windows.Forms.Label();
            this.txtTimeFilter = new System.Windows.Forms.TextBox();
            this.lblTimeFrom = new System.Windows.Forms.Label();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTimeTo = new System.Windows.Forms.Label();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.btnTimeAdd = new System.Windows.Forms.Button();
            this.btnTimeDelete = new System.Windows.Forms.Button();
            this.btnTimeExpExcel = new System.Windows.Forms.Button();
            this.btnTimeExpWord = new System.Windows.Forms.Button();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.lblEventFilter = new System.Windows.Forms.Label();
            this.txtEventFilter = new System.Windows.Forms.TextBox();
            this.lblEventFrom = new System.Windows.Forms.Label();
            this.dtpEventFrom = new System.Windows.Forms.DateTimePicker();
            this.lblEventTo = new System.Windows.Forms.Label();
            this.dtpEventTo = new System.Windows.Forms.DateTimePicker();
            this.btnEventAdd = new System.Windows.Forms.Button();
            this.btnEventDelete = new System.Windows.Forms.Button();
            this.btnEventExpExcel = new System.Windows.Forms.Button();
            this.btnEventExpWord = new System.Windows.Forms.Button();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblOrdFilter = new System.Windows.Forms.Label();
            this.txtOrdFilter = new System.Windows.Forms.TextBox();
            this.lblOrdFrom = new System.Windows.Forms.Label();
            this.dtpOrdFrom = new System.Windows.Forms.DateTimePicker();
            this.lblOrdTo = new System.Windows.Forms.Label();
            this.dtpOrdTo = new System.Windows.Forms.DateTimePicker();
            this.btnOrdAdd = new System.Windows.Forms.Button();
            this.btnOrdEdit = new System.Windows.Forms.Button();
            this.btnOrdDelete = new System.Windows.Forms.Button();
            this.btnOrdExpExcel = new System.Windows.Forms.Button();
            this.btnOrdExpWord = new System.Windows.Forms.Button();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.btnStatsExpWord = new System.Windows.Forms.Button();
            this.btnStatsExpExcel = new System.Windows.Forms.Button();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.lblStatType = new System.Windows.Forms.Label();
            this.cmbStatType = new System.Windows.Forms.ComboBox();
            this.btnRefreshStats = new System.Windows.Forms.Button();
            this.pnlEditDelete = new System.Windows.Forms.Panel();
            this.lblEditInfo = new System.Windows.Forms.Label();
            this.lblEditValue = new System.Windows.Forms.Label();
            this.txtEditValue = new System.Windows.Forms.TextBox();
            this.lblDeleteId = new System.Windows.Forms.Label();
            this.numDeleteId = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.tabDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.tabPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).BeginInit();
            this.tabTimesheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimesheet)).BeginInit();
            this.tabEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.pnlEditDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeleteId)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmployees);
            this.tabControl1.Controls.Add(this.tabDepartments);
            this.tabControl1.Controls.Add(this.tabPositions);
            this.tabControl1.Controls.Add(this.tabTimesheet);
            this.tabControl1.Controls.Add(this.tabEvents);
            this.tabControl1.Controls.Add(this.tabOrders);
            this.tabControl1.Controls.Add(this.tabStatistics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 600);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.dgvEmployees);
            this.tabEmployees.Controls.Add(this.lblEmpFilter);
            this.tabEmployees.Controls.Add(this.txtEmpFilter);
            this.tabEmployees.Controls.Add(this.btnEmpAdd);
            this.tabEmployees.Controls.Add(this.btnEmpEdit);
            this.tabEmployees.Controls.Add(this.btnEmpDelete);
            this.tabEmployees.Controls.Add(this.btnEmpExpExcel);
            this.tabEmployees.Controls.Add(this.btnEmpExpWord);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(992, 574);
            this.tabEmployees.TabIndex = 0;
            this.tabEmployees.Text = "Сотрудники";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(6, 40);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(980, 528);
            this.dgvEmployees.TabIndex = 0;
            // 
            // lblEmpFilter
            // 
            this.lblEmpFilter.AutoSize = true;
            this.lblEmpFilter.Location = new System.Drawing.Point(6, 12);
            this.lblEmpFilter.Name = "lblEmpFilter";
            this.lblEmpFilter.Size = new System.Drawing.Size(42, 13);
            this.lblEmpFilter.TabIndex = 1;
            this.lblEmpFilter.Text = "Поиск:";
            // 
            // txtEmpFilter
            // 
            this.txtEmpFilter.Location = new System.Drawing.Point(60, 9);
            this.txtEmpFilter.Name = "txtEmpFilter";
            this.txtEmpFilter.Size = new System.Drawing.Size(250, 20);
            this.txtEmpFilter.TabIndex = 1;
            this.txtEmpFilter.TextChanged += new System.EventHandler(this.txtEmpFilter_TextChanged);
            // 
            // btnEmpAdd
            // 
            this.btnEmpAdd.Location = new System.Drawing.Point(320, 7);
            this.btnEmpAdd.Name = "btnEmpAdd";
            this.btnEmpAdd.Size = new System.Drawing.Size(80, 25);
            this.btnEmpAdd.TabIndex = 2;
            this.btnEmpAdd.Text = "Добавить";
            this.btnEmpAdd.UseVisualStyleBackColor = true;
            this.btnEmpAdd.Click += new System.EventHandler(this.btnEmpAdd_Click);
            // 
            // btnEmpEdit
            // 
            this.btnEmpEdit.Location = new System.Drawing.Point(410, 7);
            this.btnEmpEdit.Name = "btnEmpEdit";
            this.btnEmpEdit.Size = new System.Drawing.Size(80, 25);
            this.btnEmpEdit.TabIndex = 3;
            this.btnEmpEdit.Text = "Изменить";
            this.btnEmpEdit.UseVisualStyleBackColor = true;
            this.btnEmpEdit.Click += new System.EventHandler(this.btnEmpEdit_Click);
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.Location = new System.Drawing.Point(500, 7);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(80, 25);
            this.btnEmpDelete.TabIndex = 4;
            this.btnEmpDelete.Text = "Удалить";
            this.btnEmpDelete.UseVisualStyleBackColor = true;
            this.btnEmpDelete.Click += new System.EventHandler(this.btnEmpDelete_Click);
            // 
            // btnEmpExpExcel
            // 
            this.btnEmpExpExcel.Location = new System.Drawing.Point(600, 7);
            this.btnEmpExpExcel.Name = "btnEmpExpExcel";
            this.btnEmpExpExcel.Size = new System.Drawing.Size(90, 25);
            this.btnEmpExpExcel.TabIndex = 5;
            this.btnEmpExpExcel.Text = "Экспорт Excel";
            this.btnEmpExpExcel.UseVisualStyleBackColor = true;
            this.btnEmpExpExcel.Click += new System.EventHandler(this.btnEmpExpExcel_Click);
            // 
            // btnEmpExpWord
            // 
            this.btnEmpExpWord.Location = new System.Drawing.Point(700, 7);
            this.btnEmpExpWord.Name = "btnEmpExpWord";
            this.btnEmpExpWord.Size = new System.Drawing.Size(90, 25);
            this.btnEmpExpWord.TabIndex = 6;
            this.btnEmpExpWord.Text = "Экспорт Word";
            this.btnEmpExpWord.UseVisualStyleBackColor = true;
            this.btnEmpExpWord.Click += new System.EventHandler(this.btnEmpExpWord_Click);
            // 
            // tabDepartments
            // 
            this.tabDepartments.Controls.Add(this.dgvDepartments);
            this.tabDepartments.Controls.Add(this.lblDeptFilter);
            this.tabDepartments.Controls.Add(this.txtDeptFilter);
            this.tabDepartments.Controls.Add(this.btnDeptAdd);
            this.tabDepartments.Controls.Add(this.btnDeptEdit);
            this.tabDepartments.Controls.Add(this.btnDeptDelete);
            this.tabDepartments.Controls.Add(this.btnDeptExpExcel);
            this.tabDepartments.Controls.Add(this.btnDeptExpWord);
            this.tabDepartments.Location = new System.Drawing.Point(4, 22);
            this.tabDepartments.Name = "tabDepartments";
            this.tabDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartments.Size = new System.Drawing.Size(992, 574);
            this.tabDepartments.TabIndex = 1;
            this.tabDepartments.Text = "Отделы";
            this.tabDepartments.UseVisualStyleBackColor = true;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(6, 40);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDepartments.Size = new System.Drawing.Size(980, 528);
            this.dgvDepartments.TabIndex = 0;
            // 
            // lblDeptFilter
            // 
            this.lblDeptFilter.AutoSize = true;
            this.lblDeptFilter.Location = new System.Drawing.Point(6, 12);
            this.lblDeptFilter.Name = "lblDeptFilter";
            this.lblDeptFilter.Size = new System.Drawing.Size(42, 13);
            this.lblDeptFilter.TabIndex = 1;
            this.lblDeptFilter.Text = "Поиск:";
            // 
            // txtDeptFilter
            // 
            this.txtDeptFilter.Location = new System.Drawing.Point(60, 9);
            this.txtDeptFilter.Name = "txtDeptFilter";
            this.txtDeptFilter.Size = new System.Drawing.Size(250, 20);
            this.txtDeptFilter.TabIndex = 1;
            this.txtDeptFilter.TextChanged += new System.EventHandler(this.txtDeptFilter_TextChanged);
            // 
            // btnDeptAdd
            // 
            this.btnDeptAdd.Location = new System.Drawing.Point(320, 7);
            this.btnDeptAdd.Name = "btnDeptAdd";
            this.btnDeptAdd.Size = new System.Drawing.Size(80, 25);
            this.btnDeptAdd.TabIndex = 2;
            this.btnDeptAdd.Text = "Добавить";
            this.btnDeptAdd.UseVisualStyleBackColor = true;
            this.btnDeptAdd.Click += new System.EventHandler(this.btnDeptAdd_Click);
            // 
            // btnDeptEdit
            // 
            this.btnDeptEdit.Location = new System.Drawing.Point(410, 7);
            this.btnDeptEdit.Name = "btnDeptEdit";
            this.btnDeptEdit.Size = new System.Drawing.Size(80, 25);
            this.btnDeptEdit.TabIndex = 3;
            this.btnDeptEdit.Text = "Изменить";
            this.btnDeptEdit.UseVisualStyleBackColor = true;
            this.btnDeptEdit.Click += new System.EventHandler(this.btnDeptEdit_Click);
            // 
            // btnDeptDelete
            // 
            this.btnDeptDelete.Location = new System.Drawing.Point(500, 7);
            this.btnDeptDelete.Name = "btnDeptDelete";
            this.btnDeptDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDeptDelete.TabIndex = 4;
            this.btnDeptDelete.Text = "Удалить";
            this.btnDeptDelete.UseVisualStyleBackColor = true;
            this.btnDeptDelete.Click += new System.EventHandler(this.btnDeptDelete_Click);
            // 
            // btnDeptExpExcel
            // 
            this.btnDeptExpExcel.Location = new System.Drawing.Point(600, 7);
            this.btnDeptExpExcel.Name = "btnDeptExpExcel";
            this.btnDeptExpExcel.Size = new System.Drawing.Size(90, 25);
            this.btnDeptExpExcel.TabIndex = 5;
            this.btnDeptExpExcel.Text = "Экспорт Excel";
            this.btnDeptExpExcel.UseVisualStyleBackColor = true;
            this.btnDeptExpExcel.Click += new System.EventHandler(this.btnDeptExpExcel_Click);
            // 
            // btnDeptExpWord
            // 
            this.btnDeptExpWord.Location = new System.Drawing.Point(700, 7);
            this.btnDeptExpWord.Name = "btnDeptExpWord";
            this.btnDeptExpWord.Size = new System.Drawing.Size(90, 25);
            this.btnDeptExpWord.TabIndex = 6;
            this.btnDeptExpWord.Text = "Экспорт Word";
            this.btnDeptExpWord.UseVisualStyleBackColor = true;
            this.btnDeptExpWord.Click += new System.EventHandler(this.btnDeptExpWord_Click);
            // 
            // tabPositions
            // 
            this.tabPositions.Controls.Add(this.dgvPositions);
            this.tabPositions.Controls.Add(this.lblPosFilter);
            this.tabPositions.Controls.Add(this.txtPosFilter);
            this.tabPositions.Controls.Add(this.btnPosAdd);
            this.tabPositions.Controls.Add(this.btnPosEdit);
            this.tabPositions.Controls.Add(this.btnPosDelete);
            this.tabPositions.Controls.Add(this.btnPosExpExcel);
            this.tabPositions.Controls.Add(this.btnPosExpWord);
            this.tabPositions.Location = new System.Drawing.Point(4, 22);
            this.tabPositions.Name = "tabPositions";
            this.tabPositions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPositions.Size = new System.Drawing.Size(992, 574);
            this.tabPositions.TabIndex = 2;
            this.tabPositions.Text = "Должности";
            this.tabPositions.UseVisualStyleBackColor = true;
            // 
            // dgvPositions
            // 
            this.dgvPositions.AllowUserToAddRows = false;
            this.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositions.Location = new System.Drawing.Point(6, 40);
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.ReadOnly = true;
            this.dgvPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPositions.Size = new System.Drawing.Size(980, 528);
            this.dgvPositions.TabIndex = 0;
            // 
            // lblPosFilter
            // 
            this.lblPosFilter.AutoSize = true;
            this.lblPosFilter.Location = new System.Drawing.Point(6, 12);
            this.lblPosFilter.Name = "lblPosFilter";
            this.lblPosFilter.Size = new System.Drawing.Size(42, 13);
            this.lblPosFilter.TabIndex = 1;
            this.lblPosFilter.Text = "Поиск:";
            // 
            // txtPosFilter
            // 
            this.txtPosFilter.Location = new System.Drawing.Point(60, 9);
            this.txtPosFilter.Name = "txtPosFilter";
            this.txtPosFilter.Size = new System.Drawing.Size(250, 20);
            this.txtPosFilter.TabIndex = 1;
            this.txtPosFilter.TextChanged += new System.EventHandler(this.txtPosFilter_TextChanged);
            // 
            // btnPosAdd
            // 
            this.btnPosAdd.Location = new System.Drawing.Point(320, 7);
            this.btnPosAdd.Name = "btnPosAdd";
            this.btnPosAdd.Size = new System.Drawing.Size(80, 25);
            this.btnPosAdd.TabIndex = 2;
            this.btnPosAdd.Text = "Добавить";
            this.btnPosAdd.UseVisualStyleBackColor = true;
            this.btnPosAdd.Click += new System.EventHandler(this.btnPosAdd_Click);
            // 
            // btnPosEdit
            // 
            this.btnPosEdit.Location = new System.Drawing.Point(410, 7);
            this.btnPosEdit.Name = "btnPosEdit";
            this.btnPosEdit.Size = new System.Drawing.Size(80, 25);
            this.btnPosEdit.TabIndex = 3;
            this.btnPosEdit.Text = "Изменить";
            this.btnPosEdit.UseVisualStyleBackColor = true;
            this.btnPosEdit.Click += new System.EventHandler(this.btnPosEdit_Click);
            // 
            // btnPosDelete
            // 
            this.btnPosDelete.Location = new System.Drawing.Point(500, 7);
            this.btnPosDelete.Name = "btnPosDelete";
            this.btnPosDelete.Size = new System.Drawing.Size(80, 25);
            this.btnPosDelete.TabIndex = 4;
            this.btnPosDelete.Text = "Удалить";
            this.btnPosDelete.UseVisualStyleBackColor = true;
            this.btnPosDelete.Click += new System.EventHandler(this.btnPosDelete_Click);
            // 
            // btnPosExpExcel
            // 
            this.btnPosExpExcel.Location = new System.Drawing.Point(600, 7);
            this.btnPosExpExcel.Name = "btnPosExpExcel";
            this.btnPosExpExcel.Size = new System.Drawing.Size(90, 25);
            this.btnPosExpExcel.TabIndex = 5;
            this.btnPosExpExcel.Text = "Экспорт Excel";
            this.btnPosExpExcel.UseVisualStyleBackColor = true;
            this.btnPosExpExcel.Click += new System.EventHandler(this.btnPosExpExcel_Click);
            // 
            // btnPosExpWord
            // 
            this.btnPosExpWord.Location = new System.Drawing.Point(700, 7);
            this.btnPosExpWord.Name = "btnPosExpWord";
            this.btnPosExpWord.Size = new System.Drawing.Size(90, 25);
            this.btnPosExpWord.TabIndex = 6;
            this.btnPosExpWord.Text = "Экспорт Word";
            this.btnPosExpWord.UseVisualStyleBackColor = true;
            this.btnPosExpWord.Click += new System.EventHandler(this.btnPosExpWord_Click);
            // 
            // tabTimesheet
            // 
            this.tabTimesheet.Controls.Add(this.dgvTimesheet);
            this.tabTimesheet.Controls.Add(this.lblTimeFilter);
            this.tabTimesheet.Controls.Add(this.txtTimeFilter);
            this.tabTimesheet.Controls.Add(this.lblTimeFrom);
            this.tabTimesheet.Controls.Add(this.dtpTimeFrom);
            this.tabTimesheet.Controls.Add(this.lblTimeTo);
            this.tabTimesheet.Controls.Add(this.dtpTimeTo);
            this.tabTimesheet.Controls.Add(this.btnTimeAdd);
            this.tabTimesheet.Controls.Add(this.btnTimeDelete);
            this.tabTimesheet.Controls.Add(this.btnTimeExpExcel);
            this.tabTimesheet.Controls.Add(this.btnTimeExpWord);
            this.tabTimesheet.Location = new System.Drawing.Point(4, 22);
            this.tabTimesheet.Name = "tabTimesheet";
            this.tabTimesheet.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimesheet.Size = new System.Drawing.Size(992, 574);
            this.tabTimesheet.TabIndex = 3;
            this.tabTimesheet.Text = "Табель учета";
            this.tabTimesheet.UseVisualStyleBackColor = true;
            // 
            // dgvTimesheet
            // 
            this.dgvTimesheet.AllowUserToAddRows = false;
            this.dgvTimesheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimesheet.Location = new System.Drawing.Point(6, 70);
            this.dgvTimesheet.Name = "dgvTimesheet";
            this.dgvTimesheet.ReadOnly = true;
            this.dgvTimesheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTimesheet.Size = new System.Drawing.Size(980, 498);
            this.dgvTimesheet.TabIndex = 0;
            // 
            // lblTimeFilter
            // 
            this.lblTimeFilter.AutoSize = true;
            this.lblTimeFilter.Location = new System.Drawing.Point(6, 12);
            this.lblTimeFilter.Name = "lblTimeFilter";
            this.lblTimeFilter.Size = new System.Drawing.Size(42, 13);
            this.lblTimeFilter.TabIndex = 1;
            this.lblTimeFilter.Text = "Поиск:";
            // 
            // txtTimeFilter
            // 
            this.txtTimeFilter.Location = new System.Drawing.Point(60, 9);
            this.txtTimeFilter.Name = "txtTimeFilter";
            this.txtTimeFilter.Size = new System.Drawing.Size(250, 20);
            this.txtTimeFilter.TabIndex = 1;
            this.txtTimeFilter.TextChanged += new System.EventHandler(this.txtTimeFilter_TextChanged);
            // 
            // lblTimeFrom
            // 
            this.lblTimeFrom.AutoSize = true;
            this.lblTimeFrom.Location = new System.Drawing.Point(6, 42);
            this.lblTimeFrom.Name = "lblTimeFrom";
            this.lblTimeFrom.Size = new System.Drawing.Size(57, 13);
            this.lblTimeFrom.TabIndex = 2;
            this.lblTimeFrom.Text = "Период с:";
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeFrom.Location = new System.Drawing.Point(65, 39);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.Size = new System.Drawing.Size(100, 20);
            this.dtpTimeFrom.TabIndex = 2;
            this.dtpTimeFrom.ValueChanged += new System.EventHandler(this.dtpTimeFrom_ValueChanged);
            // 
            // lblTimeTo
            // 
            this.lblTimeTo.AutoSize = true;
            this.lblTimeTo.Location = new System.Drawing.Point(175, 42);
            this.lblTimeTo.Name = "lblTimeTo";
            this.lblTimeTo.Size = new System.Drawing.Size(22, 13);
            this.lblTimeTo.TabIndex = 3;
            this.lblTimeTo.Text = "по:";
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeTo.Location = new System.Drawing.Point(200, 39);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.Size = new System.Drawing.Size(100, 20);
            this.dtpTimeTo.TabIndex = 3;
            this.dtpTimeTo.ValueChanged += new System.EventHandler(this.dtpTimeTo_ValueChanged);
            // 
            // btnTimeAdd
            // 
            this.btnTimeAdd.Location = new System.Drawing.Point(320, 7);
            this.btnTimeAdd.Name = "btnTimeAdd";
            this.btnTimeAdd.Size = new System.Drawing.Size(80, 25);
            this.btnTimeAdd.TabIndex = 4;
            this.btnTimeAdd.Text = "Добавить";
            this.btnTimeAdd.UseVisualStyleBackColor = true;
            this.btnTimeAdd.Click += new System.EventHandler(this.btnTimeAdd_Click);
            // 
            // btnTimeDelete
            // 
            this.btnTimeDelete.Location = new System.Drawing.Point(500, 7);
            this.btnTimeDelete.Name = "btnTimeDelete";
            this.btnTimeDelete.Size = new System.Drawing.Size(80, 25);
            this.btnTimeDelete.TabIndex = 5;
            this.btnTimeDelete.Text = "Удалить";
            this.btnTimeDelete.UseVisualStyleBackColor = true;
            this.btnTimeDelete.Click += new System.EventHandler(this.btnTimeDelete_Click);
            // 
            // btnTimeExpExcel
            // 
            this.btnTimeExpExcel.Location = new System.Drawing.Point(600, 7);
            this.btnTimeExpExcel.Name = "btnTimeExpExcel";
            this.btnTimeExpExcel.Size = new System.Drawing.Size(90, 25);
            this.btnTimeExpExcel.TabIndex = 6;
            this.btnTimeExpExcel.Text = "Экспорт Excel";
            this.btnTimeExpExcel.UseVisualStyleBackColor = true;
            this.btnTimeExpExcel.Click += new System.EventHandler(this.btnTimeExpExcel_Click);
            // 
            // btnTimeExpWord
            // 
            this.btnTimeExpWord.Location = new System.Drawing.Point(700, 7);
            this.btnTimeExpWord.Name = "btnTimeExpWord";
            this.btnTimeExpWord.Size = new System.Drawing.Size(90, 25);
            this.btnTimeExpWord.TabIndex = 7;
            this.btnTimeExpWord.Text = "Экспорт Word";
            this.btnTimeExpWord.UseVisualStyleBackColor = true;
            this.btnTimeExpWord.Click += new System.EventHandler(this.btnTimeExpWord_Click);
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.dgvEvents);
            this.tabEvents.Controls.Add(this.lblEventFilter);
            this.tabEvents.Controls.Add(this.txtEventFilter);
            this.tabEvents.Controls.Add(this.lblEventFrom);
            this.tabEvents.Controls.Add(this.dtpEventFrom);
            this.tabEvents.Controls.Add(this.lblEventTo);
            this.tabEvents.Controls.Add(this.dtpEventTo);
            this.tabEvents.Controls.Add(this.btnEventAdd);
            this.tabEvents.Controls.Add(this.btnEventDelete);
            this.tabEvents.Controls.Add(this.btnEventExpExcel);
            this.tabEvents.Controls.Add(this.btnEventExpWord);
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(992, 574);
            this.tabEvents.TabIndex = 4;
            this.tabEvents.Text = "Кадровые события";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(6, 70);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEvents.Size = new System.Drawing.Size(980, 498);
            this.dgvEvents.TabIndex = 0;
            // 
            // lblEventFilter
            // 
            this.lblEventFilter.AutoSize = true;
            this.lblEventFilter.Location = new System.Drawing.Point(6, 12);
            this.lblEventFilter.Name = "lblEventFilter";
            this.lblEventFilter.Size = new System.Drawing.Size(42, 13);
            this.lblEventFilter.TabIndex = 1;
            this.lblEventFilter.Text = "Поиск:";
            // 
            // txtEventFilter
            // 
            this.txtEventFilter.Location = new System.Drawing.Point(60, 9);
            this.txtEventFilter.Name = "txtEventFilter";
            this.txtEventFilter.Size = new System.Drawing.Size(250, 20);
            this.txtEventFilter.TabIndex = 1;
            this.txtEventFilter.TextChanged += new System.EventHandler(this.txtEventFilter_TextChanged);
            // 
            // lblEventFrom
            // 
            this.lblEventFrom.AutoSize = true;
            this.lblEventFrom.Location = new System.Drawing.Point(6, 42);
            this.lblEventFrom.Name = "lblEventFrom";
            this.lblEventFrom.Size = new System.Drawing.Size(57, 13);
            this.lblEventFrom.TabIndex = 2;
            this.lblEventFrom.Text = "Период с:";
            // 
            // dtpEventFrom
            // 
            this.dtpEventFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventFrom.Location = new System.Drawing.Point(65, 39);
            this.dtpEventFrom.Name = "dtpEventFrom";
            this.dtpEventFrom.Size = new System.Drawing.Size(100, 20);
            this.dtpEventFrom.TabIndex = 2;
            this.dtpEventFrom.ValueChanged += new System.EventHandler(this.dtpEventFrom_ValueChanged);
            // 
            // lblEventTo
            // 
            this.lblEventTo.AutoSize = true;
            this.lblEventTo.Location = new System.Drawing.Point(175, 42);
            this.lblEventTo.Name = "lblEventTo";
            this.lblEventTo.Size = new System.Drawing.Size(22, 13);
            this.lblEventTo.TabIndex = 3;
            this.lblEventTo.Text = "по:";
            // 
            // dtpEventTo
            // 
            this.dtpEventTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventTo.Location = new System.Drawing.Point(200, 39);
            this.dtpEventTo.Name = "dtpEventTo";
            this.dtpEventTo.Size = new System.Drawing.Size(100, 20);
            this.dtpEventTo.TabIndex = 3;
            this.dtpEventTo.ValueChanged += new System.EventHandler(this.dtpEventTo_ValueChanged);
            // 
            // btnEventAdd
            // 
            this.btnEventAdd.Location = new System.Drawing.Point(320, 7);
            this.btnEventAdd.Name = "btnEventAdd";
            this.btnEventAdd.Size = new System.Drawing.Size(80, 25);
            this.btnEventAdd.TabIndex = 4;
            this.btnEventAdd.Text = "Добавить";
            this.btnEventAdd.UseVisualStyleBackColor = true;
            this.btnEventAdd.Click += new System.EventHandler(this.btnEventAdd_Click);
            // 
            // btnEventDelete
            // 
            this.btnEventDelete.Location = new System.Drawing.Point(500, 7);
            this.btnEventDelete.Name = "btnEventDelete";
            this.btnEventDelete.Size = new System.Drawing.Size(80, 25);
            this.btnEventDelete.TabIndex = 5;
            this.btnEventDelete.Text = "Удалить";
            this.btnEventDelete.UseVisualStyleBackColor = true;
            this.btnEventDelete.Click += new System.EventHandler(this.btnEventDelete_Click);
            // 
            // btnEventExpExcel
            // 
            this.btnEventExpExcel.Location = new System.Drawing.Point(600, 7);
            this.btnEventExpExcel.Name = "btnEventExpExcel";
            this.btnEventExpExcel.Size = new System.Drawing.Size(90, 25);
            this.btnEventExpExcel.TabIndex = 6;
            this.btnEventExpExcel.Text = "Экспорт Excel";
            this.btnEventExpExcel.UseVisualStyleBackColor = true;
            this.btnEventExpExcel.Click += new System.EventHandler(this.btnEventExpExcel_Click);
            // 
            // btnEventExpWord
            // 
            this.btnEventExpWord.Location = new System.Drawing.Point(700, 7);
            this.btnEventExpWord.Name = "btnEventExpWord";
            this.btnEventExpWord.Size = new System.Drawing.Size(90, 25);
            this.btnEventExpWord.TabIndex = 7;
            this.btnEventExpWord.Text = "Экспорт Word";
            this.btnEventExpWord.UseVisualStyleBackColor = true;
            this.btnEventExpWord.Click += new System.EventHandler(this.btnEventExpWord_Click);
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.dgvOrders);
            this.tabOrders.Controls.Add(this.lblOrdFilter);
            this.tabOrders.Controls.Add(this.txtOrdFilter);
            this.tabOrders.Controls.Add(this.lblOrdFrom);
            this.tabOrders.Controls.Add(this.dtpOrdFrom);
            this.tabOrders.Controls.Add(this.lblOrdTo);
            this.tabOrders.Controls.Add(this.dtpOrdTo);
            this.tabOrders.Controls.Add(this.btnOrdAdd);
            this.tabOrders.Controls.Add(this.btnOrdEdit);
            this.tabOrders.Controls.Add(this.btnOrdDelete);
            this.tabOrders.Controls.Add(this.btnOrdExpExcel);
            this.tabOrders.Controls.Add(this.btnOrdExpWord);
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(992, 574);
            this.tabOrders.TabIndex = 5;
            this.tabOrders.Text = "Приказы";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(6, 70);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrders.Size = new System.Drawing.Size(980, 498);
            this.dgvOrders.TabIndex = 0;
            // 
            // lblOrdFilter
            // 
            this.lblOrdFilter.AutoSize = true;
            this.lblOrdFilter.Location = new System.Drawing.Point(6, 12);
            this.lblOrdFilter.Name = "lblOrdFilter";
            this.lblOrdFilter.Size = new System.Drawing.Size(42, 13);
            this.lblOrdFilter.TabIndex = 1;
            this.lblOrdFilter.Text = "Поиск:";
            // 
            // txtOrdFilter
            // 
            this.txtOrdFilter.Location = new System.Drawing.Point(60, 9);
            this.txtOrdFilter.Name = "txtOrdFilter";
            this.txtOrdFilter.Size = new System.Drawing.Size(250, 20);
            this.txtOrdFilter.TabIndex = 1;
            this.txtOrdFilter.TextChanged += new System.EventHandler(this.txtOrdFilter_TextChanged);
            // 
            // lblOrdFrom
            // 
            this.lblOrdFrom.AutoSize = true;
            this.lblOrdFrom.Location = new System.Drawing.Point(6, 42);
            this.lblOrdFrom.Name = "lblOrdFrom";
            this.lblOrdFrom.Size = new System.Drawing.Size(57, 13);
            this.lblOrdFrom.TabIndex = 2;
            this.lblOrdFrom.Text = "Период с:";
            // 
            // dtpOrdFrom
            // 
            this.dtpOrdFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrdFrom.Location = new System.Drawing.Point(65, 39);
            this.dtpOrdFrom.Name = "dtpOrdFrom";
            this.dtpOrdFrom.Size = new System.Drawing.Size(100, 20);
            this.dtpOrdFrom.TabIndex = 2;
            this.dtpOrdFrom.ValueChanged += new System.EventHandler(this.dtpOrdFrom_ValueChanged);
            // 
            // lblOrdTo
            // 
            this.lblOrdTo.AutoSize = true;
            this.lblOrdTo.Location = new System.Drawing.Point(175, 42);
            this.lblOrdTo.Name = "lblOrdTo";
            this.lblOrdTo.Size = new System.Drawing.Size(22, 13);
            this.lblOrdTo.TabIndex = 3;
            this.lblOrdTo.Text = "по:";
            // 
            // dtpOrdTo
            // 
            this.dtpOrdTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrdTo.Location = new System.Drawing.Point(200, 39);
            this.dtpOrdTo.Name = "dtpOrdTo";
            this.dtpOrdTo.Size = new System.Drawing.Size(100, 20);
            this.dtpOrdTo.TabIndex = 3;
            this.dtpOrdTo.ValueChanged += new System.EventHandler(this.dtpOrdTo_ValueChanged);
            // 
            // btnOrdAdd
            // 
            this.btnOrdAdd.Location = new System.Drawing.Point(320, 7);
            this.btnOrdAdd.Name = "btnOrdAdd";
            this.btnOrdAdd.Size = new System.Drawing.Size(80, 25);
            this.btnOrdAdd.TabIndex = 4;
            this.btnOrdAdd.Text = "Добавить";
            this.btnOrdAdd.UseVisualStyleBackColor = true;
            this.btnOrdAdd.Click += new System.EventHandler(this.btnOrdAdd_Click);
            // 
            // btnOrdEdit
            // 
            this.btnOrdEdit.Location = new System.Drawing.Point(410, 7);
            this.btnOrdEdit.Name = "btnOrdEdit";
            this.btnOrdEdit.Size = new System.Drawing.Size(80, 25);
            this.btnOrdEdit.TabIndex = 5;
            this.btnOrdEdit.Text = "Изменить";
            this.btnOrdEdit.UseVisualStyleBackColor = true;
            this.btnOrdEdit.Click += new System.EventHandler(this.btnOrdEdit_Click);
            // 
            // btnOrdDelete
            // 
            this.btnOrdDelete.Location = new System.Drawing.Point(500, 7);
            this.btnOrdDelete.Name = "btnOrdDelete";
            this.btnOrdDelete.Size = new System.Drawing.Size(80, 25);
            this.btnOrdDelete.TabIndex = 6;
            this.btnOrdDelete.Text = "Удалить";
            this.btnOrdDelete.UseVisualStyleBackColor = true;
            this.btnOrdDelete.Click += new System.EventHandler(this.btnOrdDelete_Click);
            // 
            // btnOrdExpExcel
            // 
            this.btnOrdExpExcel.Location = new System.Drawing.Point(600, 7);
            this.btnOrdExpExcel.Name = "btnOrdExpExcel";
            this.btnOrdExpExcel.Size = new System.Drawing.Size(90, 25);
            this.btnOrdExpExcel.TabIndex = 7;
            this.btnOrdExpExcel.Text = "Экспорт Excel";
            this.btnOrdExpExcel.UseVisualStyleBackColor = true;
            this.btnOrdExpExcel.Click += new System.EventHandler(this.btnOrdExpExcel_Click);
            // 
            // btnOrdExpWord
            // 
            this.btnOrdExpWord.Location = new System.Drawing.Point(700, 7);
            this.btnOrdExpWord.Name = "btnOrdExpWord";
            this.btnOrdExpWord.Size = new System.Drawing.Size(90, 25);
            this.btnOrdExpWord.TabIndex = 8;
            this.btnOrdExpWord.Text = "Экспорт Word";
            this.btnOrdExpWord.UseVisualStyleBackColor = true;
            this.btnOrdExpWord.Click += new System.EventHandler(this.btnOrdExpWord_Click);
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.btnStatsExpWord);
            this.tabStatistics.Controls.Add(this.btnStatsExpExcel);
            this.tabStatistics.Controls.Add(this.dgvStatistics);
            this.tabStatistics.Controls.Add(this.lblStatType);
            this.tabStatistics.Controls.Add(this.cmbStatType);
            this.tabStatistics.Controls.Add(this.btnRefreshStats);
            this.tabStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistics.Size = new System.Drawing.Size(992, 574);
            this.tabStatistics.TabIndex = 6;
            this.tabStatistics.Text = "Статистика";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // btnStatsExpWord
            // 
            this.btnStatsExpWord.Location = new System.Drawing.Point(651, 9);
            this.btnStatsExpWord.Name = "btnStatsExpWord";
            this.btnStatsExpWord.Size = new System.Drawing.Size(90, 23);
            this.btnStatsExpWord.TabIndex = 4;
            this.btnStatsExpWord.Text = "Экспорт Word";
            this.btnStatsExpWord.UseVisualStyleBackColor = true;
            this.btnStatsExpWord.Click += new System.EventHandler(this.btnStatsExpWord_Click);
            // 
            // btnStatsExpExcel
            // 
            this.btnStatsExpExcel.Location = new System.Drawing.Point(529, 9);
            this.btnStatsExpExcel.Name = "btnStatsExpExcel";
            this.btnStatsExpExcel.Size = new System.Drawing.Size(93, 23);
            this.btnStatsExpExcel.TabIndex = 3;
            this.btnStatsExpExcel.Text = "Экспорт Excel";
            this.btnStatsExpExcel.UseVisualStyleBackColor = true;
            this.btnStatsExpExcel.Click += new System.EventHandler(this.btnStatsExpExcel_Click);
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.AllowUserToAddRows = false;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Location = new System.Drawing.Point(6, 70);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.ReadOnly = true;
            this.dgvStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStatistics.Size = new System.Drawing.Size(980, 498);
            this.dgvStatistics.TabIndex = 0;
            // 
            // lblStatType
            // 
            this.lblStatType.AutoSize = true;
            this.lblStatType.Location = new System.Drawing.Point(6, 12);
            this.lblStatType.Name = "lblStatType";
            this.lblStatType.Size = new System.Drawing.Size(89, 13);
            this.lblStatType.TabIndex = 1;
            this.lblStatType.Text = "Тип статистики:";
            // 
            // cmbStatType
            // 
            this.cmbStatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatType.FormattingEnabled = true;
            this.cmbStatType.Items.AddRange(new object[] {
            "Количество сотрудников по отделам",
            "Средняя зарплата по категориям",
            "Количество кадровых событий по типу",
            "Суммарные часы по сотрудникам",
            "Количество приказов по типам",
            "Категории должностей с зарплатой больше 30000 (HAVING)",
            "Частые кадровые события (HAVING)"});
            this.cmbStatType.Location = new System.Drawing.Point(110, 9);
            this.cmbStatType.Name = "cmbStatType";
            this.cmbStatType.Size = new System.Drawing.Size(250, 21);
            this.cmbStatType.TabIndex = 1;
            // 
            // btnRefreshStats
            // 
            this.btnRefreshStats.Location = new System.Drawing.Point(370, 7);
            this.btnRefreshStats.Name = "btnRefreshStats";
            this.btnRefreshStats.Size = new System.Drawing.Size(100, 25);
            this.btnRefreshStats.TabIndex = 2;
            this.btnRefreshStats.Text = "Обновить";
            this.btnRefreshStats.UseVisualStyleBackColor = true;
            this.btnRefreshStats.Click += new System.EventHandler(this.btnRefreshStats_Click);
            // 
            // pnlEditDelete
            // 
            this.pnlEditDelete.BackColor = System.Drawing.Color.LightGray;
            this.pnlEditDelete.Controls.Add(this.lblEditInfo);
            this.pnlEditDelete.Controls.Add(this.lblEditValue);
            this.pnlEditDelete.Controls.Add(this.txtEditValue);
            this.pnlEditDelete.Controls.Add(this.lblDeleteId);
            this.pnlEditDelete.Controls.Add(this.numDeleteId);
            this.pnlEditDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditDelete.Location = new System.Drawing.Point(0, 0);
            this.pnlEditDelete.Name = "pnlEditDelete";
            this.pnlEditDelete.Size = new System.Drawing.Size(1000, 50);
            this.pnlEditDelete.TabIndex = 0;
            // 
            // lblEditInfo
            // 
            this.lblEditInfo.AutoSize = true;
            this.lblEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.lblEditInfo.Location = new System.Drawing.Point(10, 15);
            this.lblEditInfo.Name = "lblEditInfo";
            this.lblEditInfo.Size = new System.Drawing.Size(201, 13);
            this.lblEditInfo.TabIndex = 0;
            this.lblEditInfo.Text = "Выберите ячейку для редактирования";
            // 
            // lblEditValue
            // 
            this.lblEditValue.AutoSize = true;
            this.lblEditValue.Location = new System.Drawing.Point(300, 15);
            this.lblEditValue.Name = "lblEditValue";
            this.lblEditValue.Size = new System.Drawing.Size(92, 13);
            this.lblEditValue.TabIndex = 1;
            this.lblEditValue.Text = "Новое значение:";
            // 
            // txtEditValue
            // 
            this.txtEditValue.Location = new System.Drawing.Point(390, 12);
            this.txtEditValue.Name = "txtEditValue";
            this.txtEditValue.Size = new System.Drawing.Size(200, 20);
            this.txtEditValue.TabIndex = 0;
            // 
            // lblDeleteId
            // 
            this.lblDeleteId.AutoSize = true;
            this.lblDeleteId.Location = new System.Drawing.Point(610, 15);
            this.lblDeleteId.Name = "lblDeleteId";
            this.lblDeleteId.Size = new System.Drawing.Size(92, 13);
            this.lblDeleteId.TabIndex = 2;
            this.lblDeleteId.Text = "ID для удаления:";
            // 
            // numDeleteId
            // 
            this.numDeleteId.Location = new System.Drawing.Point(710, 12);
            this.numDeleteId.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDeleteId.Name = "numDeleteId";
            this.numDeleteId.Size = new System.Drawing.Size(80, 20);
            this.numDeleteId.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlEditDelete);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отдел кадров";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            this.tabEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.tabDepartments.ResumeLayout(false);
            this.tabDepartments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.tabPositions.ResumeLayout(false);
            this.tabPositions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).EndInit();
            this.tabTimesheet.ResumeLayout(false);
            this.tabTimesheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimesheet)).EndInit();
            this.tabEvents.ResumeLayout(false);
            this.tabEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.tabOrders.ResumeLayout(false);
            this.tabOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.pnlEditDelete.ResumeLayout(false);
            this.pnlEditDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeleteId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabDepartments;
        private System.Windows.Forms.TabPage tabPositions;
        private System.Windows.Forms.TabPage tabTimesheet;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.Panel pnlEditDelete;

        // Сотрудники
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.TextBox txtEmpFilter;
        private System.Windows.Forms.Label lblEmpFilter;
        private System.Windows.Forms.Button btnEmpAdd;
        private System.Windows.Forms.Button btnEmpEdit;
        private System.Windows.Forms.Button btnEmpDelete;
        private System.Windows.Forms.Button btnEmpExpExcel;
        private System.Windows.Forms.Button btnEmpExpWord;

        // Отделы
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.TextBox txtDeptFilter;
        private System.Windows.Forms.Label lblDeptFilter;
        private System.Windows.Forms.Button btnDeptAdd;
        private System.Windows.Forms.Button btnDeptEdit;
        private System.Windows.Forms.Button btnDeptDelete;
        private System.Windows.Forms.Button btnDeptExpExcel;
        private System.Windows.Forms.Button btnDeptExpWord;

        // Должности
        private System.Windows.Forms.DataGridView dgvPositions;
        private System.Windows.Forms.TextBox txtPosFilter;
        private System.Windows.Forms.Label lblPosFilter;
        private System.Windows.Forms.Button btnPosAdd;
        private System.Windows.Forms.Button btnPosEdit;
        private System.Windows.Forms.Button btnPosDelete;
        private System.Windows.Forms.Button btnPosExpExcel;
        private System.Windows.Forms.Button btnPosExpWord;

        // Табель
        private System.Windows.Forms.DataGridView dgvTimesheet;
        private System.Windows.Forms.TextBox txtTimeFilter;
        private System.Windows.Forms.Label lblTimeFilter;
        private System.Windows.Forms.DateTimePicker dtpTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpTimeTo;
        private System.Windows.Forms.Label lblTimeFrom;
        private System.Windows.Forms.Label lblTimeTo;
        private System.Windows.Forms.Button btnTimeAdd;
        private System.Windows.Forms.Button btnTimeDelete;
        private System.Windows.Forms.Button btnTimeExpExcel;
        private System.Windows.Forms.Button btnTimeExpWord;

        // События
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.TextBox txtEventFilter;
        private System.Windows.Forms.Label lblEventFilter;
        private System.Windows.Forms.DateTimePicker dtpEventFrom;
        private System.Windows.Forms.DateTimePicker dtpEventTo;
        private System.Windows.Forms.Label lblEventFrom;
        private System.Windows.Forms.Label lblEventTo;
        private System.Windows.Forms.Button btnEventAdd;
        private System.Windows.Forms.Button btnEventDelete;
        private System.Windows.Forms.Button btnEventExpExcel;
        private System.Windows.Forms.Button btnEventExpWord;

        // Приказы
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TextBox txtOrdFilter;
        private System.Windows.Forms.Label lblOrdFilter;
        private System.Windows.Forms.DateTimePicker dtpOrdFrom;
        private System.Windows.Forms.DateTimePicker dtpOrdTo;
        private System.Windows.Forms.Label lblOrdFrom;
        private System.Windows.Forms.Label lblOrdTo;
        private System.Windows.Forms.Button btnOrdAdd;
        private System.Windows.Forms.Button btnOrdEdit;
        private System.Windows.Forms.Button btnOrdDelete;
        private System.Windows.Forms.Button btnOrdExpExcel;
        private System.Windows.Forms.Button btnOrdExpWord;

        // Статистика
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.ComboBox cmbStatType;
        private System.Windows.Forms.Label lblStatType;
        private System.Windows.Forms.Button btnRefreshStats;

        // Панель редактирования
        private System.Windows.Forms.TextBox txtEditValue;
        private System.Windows.Forms.Label lblEditInfo;
        private System.Windows.Forms.NumericUpDown numDeleteId;
        private System.Windows.Forms.Label lblDeleteId;
        private System.Windows.Forms.Label lblEditValue;
        private System.Windows.Forms.Button btnStatsExpWord;
        private System.Windows.Forms.Button btnStatsExpExcel;
    }
}