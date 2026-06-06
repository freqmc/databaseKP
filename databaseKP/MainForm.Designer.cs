using System;

namespace databaseKP
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;

        // Вкладки
        private System.Windows.Forms.TabPage tabEmployees, tabDepartments, tabPositions, tabTimesheet, tabEvents, tabOrders;

        // DataGridView для каждой вкладки
        private System.Windows.Forms.DataGridView dgvEmployees, dgvDepartments, dgvPositions, dgvTimesheet, dgvEvents, dgvOrders;

        // TextBox для фильтрации
        private System.Windows.Forms.TextBox txtEmpFilter, txtDeptFilter, txtPosFilter, txtTimeFilter, txtEventFilter, txtOrdFilter;

        // Кнопки для каждой вкладки
        private System.Windows.Forms.Button btnEmpAdd, btnEmpEdit, btnEmpDelete, btnEmpExpExcel, btnEmpExpWord;
        private System.Windows.Forms.Button btnDeptAdd, btnDeptEdit, btnDeptDelete, btnDeptExpExcel, btnDeptExpWord;
        private System.Windows.Forms.Button btnPosAdd, btnPosEdit, btnPosDelete, btnPosExpExcel, btnPosExpWord;
        private System.Windows.Forms.Button btnTimeAdd, btnTimeDelete, btnTimeExpExcel, btnTimeExpWord;
        private System.Windows.Forms.Button btnEventAdd, btnEventDelete, btnEventExpExcel, btnEventExpWord;
        private System.Windows.Forms.Button btnOrdAdd, btnOrdEdit, btnOrdDelete, btnOrdExpExcel, btnOrdExpWord;

        // Панель редактирования (общая для всех вкладок)
        private System.Windows.Forms.Panel pnlEditDelete;
        private System.Windows.Forms.TextBox txtEditValue;
        private System.Windows.Forms.Label lblEditInfo;
        private System.Windows.Forms.NumericUpDown numDeleteId;
        private System.Windows.Forms.Label lblDeleteId;
        private System.Windows.Forms.Label lblEditValue;

        // DateTimePickers для фильтра по дате
        private System.Windows.Forms.DateTimePicker dtpTimeFrom, dtpTimeTo;
        private System.Windows.Forms.DateTimePicker dtpEventFrom, dtpEventTo;
        private System.Windows.Forms.DateTimePicker dtpOrdFrom, dtpOrdTo;
        private System.Windows.Forms.Label lblDateFrom, lblDateTo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.tabDepartments = new System.Windows.Forms.TabPage();
            this.tabPositions = new System.Windows.Forms.TabPage();
            this.tabTimesheet = new System.Windows.Forms.TabPage();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.tabOrders = new System.Windows.Forms.TabPage();

            // Инициализация панели редактирования/удаления
            this.pnlEditDelete = new System.Windows.Forms.Panel();
            this.txtEditValue = new System.Windows.Forms.TextBox();
            this.lblEditInfo = new System.Windows.Forms.Label();
            this.numDeleteId = new System.Windows.Forms.NumericUpDown();
            this.lblDeleteId = new System.Windows.Forms.Label();
            this.lblEditValue = new System.Windows.Forms.Label();

            // Инициализация DateTimePickers
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dtpEventFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpEventTo = new System.Windows.Forms.DateTimePicker();
            this.dtpOrdFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpOrdTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();

            // Настройка NumericUpDown
            ((System.ComponentModel.ISupportInitialize)(this.numDeleteId)).BeginInit();
            this.numDeleteId.Minimum = 0;
            this.numDeleteId.Maximum = 1000000;
            this.numDeleteId.Value = 0;

            // Настройка DateTimePickers
            this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrdFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrdTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Устанавливаем даты по умолчанию
            this.dtpTimeFrom.Value = DateTime.Now.AddDays(-30);
            this.dtpTimeTo.Value = DateTime.Now;
            this.dtpEventFrom.Value = DateTime.Now.AddDays(-30);
            this.dtpEventTo.Value = DateTime.Now;
            this.dtpOrdFrom.Value = DateTime.Now.AddDays(-30);
            this.dtpOrdTo.Value = DateTime.Now;

            this.tabControl1.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.tabDepartments.SuspendLayout();
            this.tabPositions.SuspendLayout();
            this.tabTimesheet.SuspendLayout();
            this.tabEvents.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.pnlEditDelete.SuspendLayout();
            this.SuspendLayout();

            // === Панель редактирования и удаления ===
            this.pnlEditDelete.BackColor = System.Drawing.Color.LightGray;
            this.pnlEditDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditDelete.Height = 50;
            this.pnlEditDelete.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);

            this.lblEditInfo.AutoSize = true;
            this.lblEditInfo.Location = new System.Drawing.Point(10, 15);
            this.lblEditInfo.Text = "Выберите ячейку для редактирования";
            this.lblEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);

            this.lblEditValue.AutoSize = true;
            this.lblEditValue.Location = new System.Drawing.Point(250, 15);
            this.lblEditValue.Text = "Новое значение:";

            this.txtEditValue.Location = new System.Drawing.Point(340, 12);
            this.txtEditValue.Size = new System.Drawing.Size(200, 23);

            this.lblDeleteId.AutoSize = true;
            this.lblDeleteId.Location = new System.Drawing.Point(560, 15);
            this.lblDeleteId.Text = "ID для удаления:";

            this.numDeleteId.Location = new System.Drawing.Point(660, 12);
            this.numDeleteId.Size = new System.Drawing.Size(80, 23);

            this.pnlEditDelete.Controls.Add(this.lblEditInfo);
            this.pnlEditDelete.Controls.Add(this.lblEditValue);
            this.pnlEditDelete.Controls.Add(this.txtEditValue);
            this.pnlEditDelete.Controls.Add(this.lblDeleteId);
            this.pnlEditDelete.Controls.Add(this.numDeleteId);

            // === TabControl ===
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.tabEmployees, this.tabDepartments, this.tabPositions,
                this.tabTimesheet, this.tabEvents, this.tabOrders});
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);

            // Helper для создания стандартной панели управления на вкладке
            void SetupTab(System.Windows.Forms.TabPage tab, System.Windows.Forms.DataGridView dgv,
                System.Windows.Forms.TextBox filter, System.Windows.Forms.Button btnAdd, System.Windows.Forms.Button btnEdit,
                System.Windows.Forms.Button btnDelete, System.Windows.Forms.Button btnExcel, System.Windows.Forms.Button btnWord,
                string filterHint, bool hasDateFilter = false)
            {
                // Метка фильтра
                System.Windows.Forms.Label lblFilter = new System.Windows.Forms.Label();
                lblFilter.AutoSize = true;
                lblFilter.Location = new System.Drawing.Point(10, 10);
                lblFilter.Text = "Поиск:";

                filter.Location = new System.Drawing.Point(60, 7);
                filter.Size = new System.Drawing.Size(250, 23);

                btnAdd.Location = new System.Drawing.Point(320, 5);
                btnAdd.Size = new System.Drawing.Size(80, 25);
                btnAdd.Text = "Добавить";

                btnEdit.Location = new System.Drawing.Point(410, 5);
                btnEdit.Size = new System.Drawing.Size(80, 25);
                btnEdit.Text = "Изменить";

                btnDelete.Location = new System.Drawing.Point(500, 5);
                btnDelete.Size = new System.Drawing.Size(80, 25);
                btnDelete.Text = "Удалить";

                btnExcel.Location = new System.Drawing.Point(600, 5);
                btnExcel.Size = new System.Drawing.Size(90, 25);
                btnExcel.Text = "Экспорт Excel";

                btnWord.Location = new System.Drawing.Point(700, 5);
                btnWord.Size = new System.Drawing.Size(90, 25);
                btnWord.Text = "Экспорт Word";

                // DateTimePickers для фильтра по дате
                if (hasDateFilter)
                {
                    this.lblDateFrom.AutoSize = true;
                    this.lblDateFrom.Location = new System.Drawing.Point(10, 40);
                    this.lblDateFrom.Text = "Период с:";

                    this.lblDateTo.AutoSize = true;
                    this.lblDateTo.Location = new System.Drawing.Point(150, 40);
                    this.lblDateTo.Text = "по:";

                    System.Windows.Forms.DateTimePicker dtpFrom = null;
                    System.Windows.Forms.DateTimePicker dtpTo = null;

                    if (tab.Name == "tabTimesheet") { dtpFrom = this.dtpTimeFrom; dtpTo = this.dtpTimeTo; }
                    else if (tab.Name == "tabEvents") { dtpFrom = this.dtpEventFrom; dtpTo = this.dtpEventTo; }
                    else if (tab.Name == "tabOrders") { dtpFrom = this.dtpOrdFrom; dtpTo = this.dtpOrdTo; }

                    if (dtpFrom != null)
                    {
                        dtpFrom.Location = new System.Drawing.Point(60, 37);
                        dtpFrom.Size = new System.Drawing.Size(100, 23);
                        tab.Controls.Add(dtpFrom);
                    }

                    if (dtpTo != null)
                    {
                        dtpTo.Location = new System.Drawing.Point(180, 37);
                        dtpTo.Size = new System.Drawing.Size(100, 23);
                        tab.Controls.Add(dtpTo);
                    }

                    tab.Controls.Add(this.lblDateFrom);
                    tab.Controls.Add(this.lblDateTo);

                    // Смещаем DataGridView вниз
                    dgv.Location = new System.Drawing.Point(10, 70);
                    dgv.Size = new System.Drawing.Size(950, 470);
                }
                else
                {
                    dgv.Location = new System.Drawing.Point(10, 40);
                    dgv.Size = new System.Drawing.Size(950, 500);
                }

                dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

                tab.Controls.AddRange(new System.Windows.Forms.Control[] { lblFilter, dgv, filter, btnAdd, btnEdit, btnDelete, btnExcel, btnWord });
                tab.Padding = new System.Windows.Forms.Padding(10);
            }

            // 1. Сотрудники (без фильтра по дате)
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.txtEmpFilter = new System.Windows.Forms.TextBox();
            this.btnEmpAdd = new System.Windows.Forms.Button(); this.btnEmpEdit = new System.Windows.Forms.Button(); this.btnEmpDelete = new System.Windows.Forms.Button();
            this.btnEmpExpExcel = new System.Windows.Forms.Button(); this.btnEmpExpWord = new System.Windows.Forms.Button();
            this.tabEmployees.Text = "Сотрудники";
            this.tabEmployees.Name = "tabEmployees";
            SetupTab(this.tabEmployees, this.dgvEmployees, this.txtEmpFilter, this.btnEmpAdd, this.btnEmpEdit, this.btnEmpDelete, this.btnEmpExpExcel, this.btnEmpExpWord, "Поиск по фамилии, имени или табельному...", false);
            this.txtEmpFilter.TextChanged += new System.EventHandler(this.txtEmpFilter_TextChanged);
            this.btnEmpAdd.Click += new System.EventHandler(this.btnEmpAdd_Click);
            this.btnEmpEdit.Click += new System.EventHandler(this.btnEmpEdit_Click);
            this.btnEmpDelete.Click += new System.EventHandler(this.btnEmpDelete_Click);
            this.btnEmpExpExcel.Click += new System.EventHandler(this.btnEmpExpExcel_Click);
            this.btnEmpExpWord.Click += new System.EventHandler(this.btnEmpExpWord_Click);

            // 2. Отделы (без фильтра по дате)
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.txtDeptFilter = new System.Windows.Forms.TextBox();
            this.btnDeptAdd = new System.Windows.Forms.Button(); this.btnDeptEdit = new System.Windows.Forms.Button(); this.btnDeptDelete = new System.Windows.Forms.Button();
            this.btnDeptExpExcel = new System.Windows.Forms.Button(); this.btnDeptExpWord = new System.Windows.Forms.Button();
            this.tabDepartments.Text = "Отделы";
            this.tabDepartments.Name = "tabDepartments";
            SetupTab(this.tabDepartments, this.dgvDepartments, this.txtDeptFilter, this.btnDeptAdd, this.btnDeptEdit, this.btnDeptDelete, this.btnDeptExpExcel, this.btnDeptExpWord, "Поиск по названию или типу отдела...", false);
            this.txtDeptFilter.TextChanged += new System.EventHandler(this.txtDeptFilter_TextChanged);
            this.btnDeptAdd.Click += new System.EventHandler(this.btnDeptAdd_Click);
            this.btnDeptEdit.Click += new System.EventHandler(this.btnDeptEdit_Click);
            this.btnDeptDelete.Click += new System.EventHandler(this.btnDeptDelete_Click);
            this.btnDeptExpExcel.Click += new System.EventHandler(this.btnDeptExpExcel_Click);
            this.btnDeptExpWord.Click += new System.EventHandler(this.btnDeptExpWord_Click);

            // 3. Должности (без фильтра по дате)
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.txtPosFilter = new System.Windows.Forms.TextBox();
            this.btnPosAdd = new System.Windows.Forms.Button(); this.btnPosEdit = new System.Windows.Forms.Button(); this.btnPosDelete = new System.Windows.Forms.Button();
            this.btnPosExpExcel = new System.Windows.Forms.Button(); this.btnPosExpWord = new System.Windows.Forms.Button();
            this.tabPositions.Text = "Должности";
            this.tabPositions.Name = "tabPositions";
            SetupTab(this.tabPositions, this.dgvPositions, this.txtPosFilter, this.btnPosAdd, this.btnPosEdit, this.btnPosDelete, this.btnPosExpExcel, this.btnPosExpWord, "Поиск по названию или категории...", false);
            this.txtPosFilter.TextChanged += new System.EventHandler(this.txtPosFilter_TextChanged);
            this.btnPosAdd.Click += new System.EventHandler(this.btnPosAdd_Click);
            this.btnPosEdit.Click += new System.EventHandler(this.btnPosEdit_Click);
            this.btnPosDelete.Click += new System.EventHandler(this.btnPosDelete_Click);
            this.btnPosExpExcel.Click += new System.EventHandler(this.btnPosExpExcel_Click);
            this.btnPosExpWord.Click += new System.EventHandler(this.btnPosExpWord_Click);

            // 4. Табель (С ФИЛЬТРОМ ПО ДАТЕ)
            this.dgvTimesheet = new System.Windows.Forms.DataGridView();
            this.txtTimeFilter = new System.Windows.Forms.TextBox();
            this.btnTimeAdd = new System.Windows.Forms.Button(); this.btnTimeDelete = new System.Windows.Forms.Button();
            this.btnTimeExpExcel = new System.Windows.Forms.Button(); this.btnTimeExpWord = new System.Windows.Forms.Button();
            this.tabTimesheet.Text = "Табель учета";
            this.tabTimesheet.Name = "tabTimesheet";
            SetupTab(this.tabTimesheet, this.dgvTimesheet, this.txtTimeFilter, this.btnTimeAdd, new System.Windows.Forms.Button(), this.btnTimeDelete, this.btnTimeExpExcel, this.btnTimeExpWord, "Поиск по сотруднику или коду явки...", true);
            this.txtTimeFilter.TextChanged += new System.EventHandler(this.txtTimeFilter_TextChanged);
            this.dtpTimeFrom.ValueChanged += new System.EventHandler(this.dtpTimeFrom_ValueChanged);
            this.dtpTimeTo.ValueChanged += new System.EventHandler(this.dtpTimeTo_ValueChanged);
            this.btnTimeAdd.Click += new System.EventHandler(this.btnTimeAdd_Click);
            this.btnTimeDelete.Click += new System.EventHandler(this.btnTimeDelete_Click);
            this.btnTimeExpExcel.Click += new System.EventHandler(this.btnTimeExpExcel_Click);
            this.btnTimeExpWord.Click += new System.EventHandler(this.btnTimeExpWord_Click);

            // 5. Кадровые события (С ФИЛЬТРОМ ПО ДАТЕ)
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.txtEventFilter = new System.Windows.Forms.TextBox();
            this.btnEventAdd = new System.Windows.Forms.Button(); this.btnEventDelete = new System.Windows.Forms.Button();
            this.btnEventExpExcel = new System.Windows.Forms.Button(); this.btnEventExpWord = new System.Windows.Forms.Button();
            this.tabEvents.Text = "Кадровые события";
            this.tabEvents.Name = "tabEvents";
            SetupTab(this.tabEvents, this.dgvEvents, this.txtEventFilter, this.btnEventAdd, new System.Windows.Forms.Button(), this.btnEventDelete, this.btnEventExpExcel, this.btnEventExpWord, "Поиск по типу события, сотруднику или приказу...", true);
            this.txtEventFilter.TextChanged += new System.EventHandler(this.txtEventFilter_TextChanged);
            this.dtpEventFrom.ValueChanged += new System.EventHandler(this.dtpEventFrom_ValueChanged);
            this.dtpEventTo.ValueChanged += new System.EventHandler(this.dtpEventTo_ValueChanged);
            this.btnEventAdd.Click += new System.EventHandler(this.btnEventAdd_Click);
            this.btnEventDelete.Click += new System.EventHandler(this.btnEventDelete_Click);
            this.btnEventExpExcel.Click += new System.EventHandler(this.btnEventExpExcel_Click);
            this.btnEventExpWord.Click += new System.EventHandler(this.btnEventExpWord_Click);

            // 6. Приказы (С ФИЛЬТРОМ ПО ДАТЕ)
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.txtOrdFilter = new System.Windows.Forms.TextBox();
            this.btnOrdAdd = new System.Windows.Forms.Button(); this.btnOrdEdit = new System.Windows.Forms.Button(); this.btnOrdDelete = new System.Windows.Forms.Button();
            this.btnOrdExpExcel = new System.Windows.Forms.Button(); this.btnOrdExpWord = new System.Windows.Forms.Button();
            this.tabOrders.Text = "Приказы";
            this.tabOrders.Name = "tabOrders";
            SetupTab(this.tabOrders, this.dgvOrders, this.txtOrdFilter, this.btnOrdAdd, this.btnOrdEdit, this.btnOrdDelete, this.btnOrdExpExcel, this.btnOrdExpWord, "Поиск по номеру или типу приказа...", true);
            this.txtOrdFilter.TextChanged += new System.EventHandler(this.txtOrdFilter_TextChanged);
            this.dtpOrdFrom.ValueChanged += new System.EventHandler(this.dtpOrdFrom_ValueChanged);
            this.dtpOrdTo.ValueChanged += new System.EventHandler(this.dtpOrdTo_ValueChanged);
            this.btnOrdAdd.Click += new System.EventHandler(this.btnOrdAdd_Click);
            this.btnOrdEdit.Click += new System.EventHandler(this.btnOrdEdit_Click);
            this.btnOrdDelete.Click += new System.EventHandler(this.btnOrdDelete_Click);
            this.btnOrdExpExcel.Click += new System.EventHandler(this.btnOrdExpExcel_Click);
            this.btnOrdExpWord.Click += new System.EventHandler(this.btnOrdExpWord_Click);

            // Настройка формы
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlEditDelete);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Text = "Главная форма";

            this.tabControl1.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            this.tabEmployees.PerformLayout();
            this.tabDepartments.ResumeLayout(false);
            this.tabDepartments.PerformLayout();
            this.tabPositions.ResumeLayout(false);
            this.tabPositions.PerformLayout();
            this.tabTimesheet.ResumeLayout(false);
            this.tabTimesheet.PerformLayout();
            this.tabEvents.ResumeLayout(false);
            this.tabEvents.PerformLayout();
            this.tabOrders.ResumeLayout(false);
            this.tabOrders.PerformLayout();
            this.pnlEditDelete.ResumeLayout(false);
            this.pnlEditDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeleteId)).EndInit();
            this.ResumeLayout(false);
        }
    }
}