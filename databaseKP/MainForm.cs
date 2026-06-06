using databaseKP;
using databaseKP.AddForms;
using databaseKP.Utils;
using databaseKP.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace databaseKP
{
    public partial class MainForm : Form
    {
        private readonly Employee _empRepo = new Employee();
        private readonly Department _deptRepo = new Department();
        private readonly Position _posRepo = new Position();
        private readonly Timesheet _timeRepo = new Timesheet();
        private readonly Event _eventRepo = new Event();
        private readonly Order _orderRepo = new Order();

        private string _currentEditColumn = "";
        private int _currentEditRowId = 0;
        private string _currentIdColumnName = "";

        public MainForm()
        {
            InitializeComponent();
            this.Text = $"Отдел кадров | {SessionManager.FullName} ({SessionManager.Role})";
            ApplyRolePermissions();
            LoadEmployeesData();
        }

        private void ApplyRolePermissions()
        {
            bool canEdit = SessionManager.CanEdit;

            // Сотрудники
            btnEmpAdd.Enabled = canEdit;
            btnEmpEdit.Enabled = canEdit;
            btnEmpDelete.Enabled = canEdit;
            btnEmpExpExcel.Enabled = canEdit;
            btnEmpExpWord.Enabled = canEdit;
            // Отделы
            btnDeptAdd.Enabled = canEdit;
            btnDeptEdit.Enabled = canEdit;
            btnDeptDelete.Enabled = canEdit;
            btnDeptExpExcel.Enabled = canEdit;
            btnDeptExpWord.Enabled = canEdit;
            // Должности
            btnPosAdd.Enabled = canEdit;
            btnPosEdit.Enabled = canEdit;
            btnPosDelete.Enabled = canEdit;
            btnPosExpExcel.Enabled = canEdit;
            btnPosExpWord.Enabled = canEdit;
            // Табель
            btnTimeAdd.Enabled = canEdit;
            btnTimeDelete.Enabled = canEdit;
            btnTimeExpExcel.Enabled = canEdit;
            btnTimeExpWord.Enabled = canEdit;
            // События
            btnEventAdd.Enabled = canEdit;
            btnEventDelete.Enabled = canEdit;
            btnEventExpExcel.Enabled = canEdit;
            btnEventExpWord.Enabled = canEdit;
            // Приказы
            btnOrdAdd.Enabled = canEdit;
            btnOrdEdit.Enabled = canEdit;
            btnOrdDelete.Enabled = canEdit;
            btnOrdExpExcel.Enabled = canEdit;
            btnOrdExpWord.Enabled = canEdit;
        }

        private void SetGridReadOnly(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            grid.CellClick += DataGridView_CellClick;
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridView grid = (DataGridView)sender;
            object value = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            // Получаем ID текущей строки
            string idColumnName = GetIdColumnName(grid.Name);
            if (idColumnName != "" && grid.Rows[e.RowIndex].Cells[idColumnName].Value != null)
            {
                _currentEditRowId = Convert.ToInt32(grid.Rows[e.RowIndex].Cells[idColumnName].Value);
                _currentIdColumnName = idColumnName;
            }

            _currentEditColumn = grid.Columns[e.ColumnIndex].DataPropertyName;
            if (string.IsNullOrEmpty(_currentEditColumn))
                _currentEditColumn = grid.Columns[e.ColumnIndex].Name;

            txtEditValue.Text = value?.ToString() ?? "";
            lblEditInfo.Text = $"Ячейка: {grid.Columns[e.ColumnIndex].HeaderText} (ID: {_currentEditRowId})";
        }

        private string GetIdColumnName(string gridName)
        {
            switch (gridName)
            {
                case "dgvEmployees": return "EmployeeID";
                case "dgvDepartments": return "DepartmentID";
                case "dgvPositions": return "PositionID";
                case "dgvTimesheet": return "TimesheetID";
                case "dgvEvents": return "EventID";
                case "dgvOrders": return "OrderID";
                default: return "";
            }
        }

        #region 1. Сотрудники
        private void LoadEmployeesData()
        {
            _empRepo.DisplayData(dgvEmployees);
            SetGridReadOnly(dgvEmployees);
            ApplyFilter(dgvEmployees, txtEmpFilter.Text, "LastName", "FirstName", "PersonnelNumber");
        }
        private void txtEmpFilter_TextChanged(object sender, EventArgs e) => ApplyFilter(dgvEmployees, txtEmpFilter.Text, "LastName", "FirstName", "PersonnelNumber");

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            if (numDeleteId.Value == 0)
            {
                MessageBox.Show("Введите ID записи для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DeleteRecord(_empRepo.Delete, Convert.ToInt32(numDeleteId.Value), "сотрудника");
        }

        private void btnEmpEdit_Click(object sender, EventArgs e)
        {
            if (_currentEditRowId == 0 || string.IsNullOrEmpty(_currentEditColumn))
            {
                MessageBox.Show("Сначала выберите ячейку для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Редактирование: {_currentEditColumn} = {txtEditValue.Text}\nID: {_currentEditRowId}\n(Требуется реализация конкретного UPDATE)", "Инфо");
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            using (AddEmployeeForm addForm = new AddEmployeeForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployeesData();
                }
            }
        }
        #endregion

        #region 2. Отделы
        private void LoadDepartmentsData()
        {
            _deptRepo.DisplayData(dgvDepartments);
            SetGridReadOnly(dgvDepartments);
            ApplyFilter(dgvDepartments, txtDeptFilter.Text, "DepartmentName", "DepartmentType");
        }
        private void txtDeptFilter_TextChanged(object sender, EventArgs e) => ApplyFilter(dgvDepartments, txtDeptFilter.Text, "DepartmentName", "DepartmentType");

        private void btnDeptDelete_Click(object sender, EventArgs e)
        {
            if (numDeleteId.Value == 0)
            {
                MessageBox.Show("Введите ID записи для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DeleteRecord(_deptRepo.Delete, Convert.ToInt32(numDeleteId.Value), "отдела");
        }

        private void btnDeptEdit_Click(object sender, EventArgs e)
        {
            if (_currentEditRowId == 0)
            {
                MessageBox.Show("Сначала выберите ячейку для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Редактирование: {_currentEditColumn} = {txtEditValue.Text}\nID: {_currentEditRowId}", "Инфо");
        }

        private void btnDeptAdd_Click(object sender, EventArgs e)
        {
            using (AddDepartmentForm addForm = new AddDepartmentForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadDepartmentsData();
                }
            }
        }
        #endregion

        #region 3. Должности
        private void LoadPositionsData()
        {
            _posRepo.DisplayData(dgvPositions);
            SetGridReadOnly(dgvPositions);
            ApplyFilter(dgvPositions, txtPosFilter.Text, "PositionName", "Category");
        }
        private void txtPosFilter_TextChanged(object sender, EventArgs e) => ApplyFilter(dgvPositions, txtPosFilter.Text, "PositionName", "Category");

        private void btnPosDelete_Click(object sender, EventArgs e)
        {
            if (numDeleteId.Value == 0)
            {
                MessageBox.Show("Введите ID записи для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DeleteRecord(_posRepo.Delete, Convert.ToInt32(numDeleteId.Value), "должности");
        }

        private void btnPosEdit_Click(object sender, EventArgs e)
        {
            if (_currentEditRowId == 0)
            {
                MessageBox.Show("Сначала выберите ячейку для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Редактирование: {_currentEditColumn} = {txtEditValue.Text}\nID: {_currentEditRowId}", "Инфо");
        }

        private void btnPosAdd_Click(object sender, EventArgs e)
        {
            using (AddPositionForm addForm = new AddPositionForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPositionsData();
                }
            }
        }
        #endregion

        #region 4. Табель (с фильтром по дате)
        private void LoadTimesheetData()
        {
            _timeRepo.DisplayData(dgvTimesheet);
            SetGridReadOnly(dgvTimesheet);
            ApplyFilter(dgvTimesheet, txtTimeFilter.Text, "EmployeeName", "AttendanceCode");
            ApplyDateFilter(dgvTimesheet, "RecordDate", dtpTimeFrom.Value.Date, dtpTimeTo.Value.Date);
        }
        private void txtTimeFilter_TextChanged(object sender, EventArgs e) => LoadTimesheetData();
        private void dtpTimeFrom_ValueChanged(object sender, EventArgs e) => LoadTimesheetData();
        private void dtpTimeTo_ValueChanged(object sender, EventArgs e) => LoadTimesheetData();

        private void btnTimeDelete_Click(object sender, EventArgs e)
        {
            if (numDeleteId.Value == 0)
            {
                MessageBox.Show("Введите ID записи для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DeleteRecord(_timeRepo.Delete, Convert.ToInt32(numDeleteId.Value), "записи табеля");
        }

        private void btnTimeAdd_Click(object sender, EventArgs e)
        {
            using (AddTimesheetForm addForm = new AddTimesheetForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTimesheetData();
                }
            }
        }
        #endregion

        #region 5. Кадровые события (с фильтром по дате)
        private void LoadEventsData()
        {
            _eventRepo.DisplayData(dgvEvents);
            SetGridReadOnly(dgvEvents);
            ApplyFilter(dgvEvents, txtEventFilter.Text, "EventType", "EmployeeName", "OrderNumber");
            ApplyDateFilter(dgvEvents, "EventDate", dtpEventFrom.Value.Date, dtpEventTo.Value.Date);
        }
        private void txtEventFilter_TextChanged(object sender, EventArgs e) => LoadEventsData();
        private void dtpEventFrom_ValueChanged(object sender, EventArgs e) => LoadEventsData();
        private void dtpEventTo_ValueChanged(object sender, EventArgs e) => LoadEventsData();

        private void btnEventDelete_Click(object sender, EventArgs e)
        {
            if (numDeleteId.Value == 0)
            {
                MessageBox.Show("Введите ID записи для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DeleteRecord(_eventRepo.Delete, Convert.ToInt32(numDeleteId.Value), "кадрового события");
        }

        private void btnEventAdd_Click(object sender, EventArgs e)
        {
            using (AddEventForm addForm = new AddEventForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEventsData();
                }
            }
        }
        #endregion

        #region 6. Приказы (с фильтром по дате)
        private void LoadOrdersData()
        {
            _orderRepo.DisplayData(dgvOrders);
            SetGridReadOnly(dgvOrders);
            ApplyFilter(dgvOrders, txtOrdFilter.Text, "OrderNumber", "OrderType");
            ApplyDateFilter(dgvOrders, "OrderDate", dtpOrdFrom.Value.Date, dtpOrdTo.Value.Date);
        }
        private void txtOrdFilter_TextChanged(object sender, EventArgs e) => LoadOrdersData();
        private void dtpOrdFrom_ValueChanged(object sender, EventArgs e) => LoadOrdersData();
        private void dtpOrdTo_ValueChanged(object sender, EventArgs e) => LoadOrdersData();

        private void btnOrdDelete_Click(object sender, EventArgs e)
        {
            if (numDeleteId.Value == 0)
            {
                MessageBox.Show("Введите ID записи для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DeleteRecord(_orderRepo.Delete, Convert.ToInt32(numDeleteId.Value), "приказа");
        }

        private void btnOrdEdit_Click(object sender, EventArgs e)
        {
            if (_currentEditRowId == 0)
            {
                MessageBox.Show("Сначала выберите ячейку для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Редактирование: {_currentEditColumn} = {txtEditValue.Text}\nID: {_currentEditRowId}", "Инфо");
        }

        private void btnOrdAdd_Click(object sender, EventArgs e)
        {
            using (AddOrderForm addForm = new AddOrderForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadOrdersData();
                }
            }
        }
        #endregion

        #region Общие методы
        private void ApplyFilter(DataGridView grid, string filterText, params string[] columns)
        {
            if (grid.DataSource is DataTable dt)
            {
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    dt.DefaultView.RowFilter = "";
                }
                else
                {
                    string[] conditions = new string[columns.Length];
                    for (int i = 0; i < columns.Length; i++)
                    {
                        conditions[i] = $"{columns[i]} LIKE '%{filterText}%'";
                    }
                    dt.DefaultView.RowFilter = string.Join(" OR ", conditions);
                }
            }
        }

        private void ApplyDateFilter(DataGridView grid, string columnName, DateTime fromDate, DateTime toDate)
        {
            if (grid.DataSource is DataTable dt)
            {
                string currentFilter = dt.DefaultView.RowFilter;
                string dateFilter = $"{columnName} >= #{fromDate:MM/dd/yyyy}# AND {columnName} <= #{toDate:MM/dd/yyyy}#";

                if (string.IsNullOrEmpty(currentFilter))
                    dt.DefaultView.RowFilter = dateFilter;
                else
                    dt.DefaultView.RowFilter = $"{currentFilter} AND {dateFilter}";
            }
        }

        private void DeleteRecord(Action<int> deleteAction, int id, string recordName)
        {
            if (MessageBox.Show($"Вы уверены, что хотите удалить {recordName} с ID {id}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    deleteAction(id);
                    // Перезагружаем данные активной вкладки
                    if (tabControl1.SelectedTab == tabEmployees) LoadEmployeesData();
                    else if (tabControl1.SelectedTab == tabDepartments) LoadDepartmentsData();
                    else if (tabControl1.SelectedTab == tabPositions) LoadPositionsData();
                    else if (tabControl1.SelectedTab == tabTimesheet) LoadTimesheetData();
                    else if (tabControl1.SelectedTab == tabEvents) LoadEventsData();
                    else if (tabControl1.SelectedTab == tabOrders) LoadOrdersData();

                    numDeleteId.Value = 0;
                    MessageBox.Show("Запись успешно удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления (возможно, есть связанные записи): " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabEmployees) LoadEmployeesData();
            else if (tabControl1.SelectedTab == tabDepartments) LoadDepartmentsData();
            else if (tabControl1.SelectedTab == tabPositions) LoadPositionsData();
            else if (tabControl1.SelectedTab == tabTimesheet) LoadTimesheetData();
            else if (tabControl1.SelectedTab == tabEvents) LoadEventsData();
            else if (tabControl1.SelectedTab == tabOrders) LoadOrdersData();
        }
        #endregion

        #region Экспорт (для всех таблиц)
        private void ExportExcel(DataGridView grid, string defaultName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Files|*.xls", FileName = defaultName })
            {
                if (sfd.ShowDialog() == DialogResult.OK) Exporter.ExportToExcel(grid, sfd.FileName);
            }
        }
        private void ExportWord(DataGridView grid, string defaultName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Word Files|*.doc", FileName = defaultName })
            {
                if (sfd.ShowDialog() == DialogResult.OK) Exporter.ExportToWord(grid, sfd.FileName);
            }
        }

        private void btnEmpExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvEmployees, "Employees.xls");
        private void btnEmpExpWord_Click(object sender, EventArgs e) => ExportWord(dgvEmployees, "Employees.doc");
        private void btnDeptExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvDepartments, "Departments.xls");
        private void btnDeptExpWord_Click(object sender, EventArgs e) => ExportWord(dgvDepartments, "Departments.doc");
        private void btnPosExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvPositions, "Positions.xls");
        private void btnPosExpWord_Click(object sender, EventArgs e) => ExportWord(dgvPositions, "Positions.doc");
        private void btnTimeExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvTimesheet, "Timesheet.xls");
        private void btnTimeExpWord_Click(object sender, EventArgs e) => ExportWord(dgvTimesheet, "Timesheet.doc");
        private void btnEventExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvEvents, "Events.xls");
        private void btnEventExpWord_Click(object sender, EventArgs e) => ExportWord(dgvEvents, "Events.doc");
        private void btnOrdExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvOrders, "Orders.xls");
        private void btnOrdExpWord_Click(object sender, EventArgs e) => ExportWord(dgvOrders, "Orders.doc");
        #endregion
    }
}