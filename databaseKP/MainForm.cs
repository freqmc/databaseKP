using databaseKP.AddForms;
using databaseKP.Classes;
using databaseKP.Utils;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        private string _currentTableName = "";

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

            btnEmpAdd.Enabled = canEdit;
            btnEmpEdit.Enabled = canEdit;
            btnEmpDelete.Enabled = canEdit;
            btnEmpExpExcel.Enabled = canEdit;
            btnEmpExpWord.Enabled = canEdit;

            btnDeptAdd.Enabled = canEdit;
            btnDeptEdit.Enabled = canEdit;
            btnDeptDelete.Enabled = canEdit;
            btnDeptExpExcel.Enabled = canEdit;
            btnDeptExpWord.Enabled = canEdit;

            btnPosAdd.Enabled = canEdit;
            btnPosEdit.Enabled = canEdit;
            btnPosDelete.Enabled = canEdit;
            btnPosExpExcel.Enabled = canEdit;
            btnPosExpWord.Enabled = canEdit;

            btnTimeAdd.Enabled = canEdit;
            btnTimeDelete.Enabled = canEdit;
            btnTimeExpExcel.Enabled = canEdit;
            btnTimeExpWord.Enabled = canEdit;

            btnEventAdd.Enabled = canEdit;
            btnEventDelete.Enabled = canEdit;
            btnEventExpExcel.Enabled = canEdit;
            btnEventExpWord.Enabled = canEdit;

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
            grid.CellClick -= DataGridView_CellClick;
            grid.CellClick += DataGridView_CellClick;
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridView grid = (DataGridView)sender;
            object value = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            if (grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                _currentEditRowId = Convert.ToInt32(grid.Rows[e.RowIndex].Cells[0].Value);
            }

            _currentEditColumn = grid.Columns[e.ColumnIndex].Name;
            _currentTableName = GetTableName(grid.Name);

            lblEditInfo.Text = $"Ячейка: {grid.Columns[e.ColumnIndex].HeaderText} (ID: {_currentEditRowId}, Столбец: {_currentEditColumn})";
        }

        private string GetTableName(string gridName)
        {
            switch (gridName)
            {
                case "dgvEmployees": return "Employees";
                case "dgvDepartments": return "Departments";
                case "dgvPositions": return "Positions";
                case "dgvTimesheet": return "TimesheetRecords";
                case "dgvEvents": return "StaffEvents";
                case "dgvOrders": return "Orders";
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
            if (_currentEditRowId == 0)
            {
                MessageBox.Show("Сначала выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (EditEmployeeForm editForm = new EditEmployeeForm(_currentEditRowId))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployeesData();
                }
            }
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
                MessageBox.Show("Сначала выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (EditDepartmentForm editForm = new EditDepartmentForm(_currentEditRowId))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadDepartmentsData();
                }
            }
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
                MessageBox.Show("Сначала выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (EditPositionForm editForm = new EditPositionForm(_currentEditRowId))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPositionsData();
                }
            }
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

        #region 4. Табель
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

        #region 5. Кадровые события
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

        #region 6. Приказы
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
                MessageBox.Show("Сначала выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (EditOrderForm editForm = new EditOrderForm(_currentEditRowId))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadOrdersData();
                }
            }
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

        #region Статистика
        private void btnRefreshStats_Click(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            if (cmbStatType.SelectedIndex == -1) return;

            string selectedStat = cmbStatType.SelectedItem.ToString();

            switch (selectedStat)
            {
                case "Количество сотрудников по отделам":
                    LoadDepartmentStats();
                    break;
                case "Средняя зарплата по категориям":
                    LoadSalaryStats();
                    break;
                case "Количество кадровых событий по типу":
                    LoadEventStats();
                    break;
                case "Суммарные часы по сотрудникам":
                    LoadTimesheetStats();
                    break;
                case "Количество приказов по типам":
                    LoadOrderStats();
                    break;
                case "Категории должностей с зарплатой больше 30000 (HAVING)":
                    LoadSalaryStatsWithHaving();
                    break;
                case "Частые кадровые события (HAVING)":
                    LoadEventStatsWithHaving();
                    break;
            }
        }

        private void LoadDepartmentStats()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(@"
            SELECT d.DepartmentName AS Отдел, 
                   COUNT(e.EmployeeID) AS Количество_сотрудников
            FROM Departments d
            LEFT JOIN Positions p ON d.DepartmentID = p.DepartmentID
            LEFT JOIN Employees e ON p.PositionID = e.PositionID
            GROUP BY d.DepartmentName
            ORDER BY Количество_сотрудников DESC", conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStatistics.DataSource = dt;
            }
        }

        private void LoadSalaryStats()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(@"
            SELECT Category AS Категория, 
                   AVG(Salary) AS Средняя_зарплата,
                   MIN(Salary) AS Минимальная,
                   MAX(Salary) AS Максимальная,
                   COUNT(*) AS Количество_должностей
            FROM Positions
            GROUP BY Category
            ORDER BY Средняя_зарплата DESC", conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStatistics.DataSource = dt;
            }
        }

        private void LoadEventStats()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(@"
            SELECT EventType AS Тип_события, 
                   COUNT(*) AS Количество
            FROM StaffEvents
            GROUP BY EventType
            ORDER BY Количество DESC", conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStatistics.DataSource = dt;
            }
        }

        private void LoadTimesheetStats()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(@"
            SELECT e.LastName + ' ' + e.FirstName AS Сотрудник,
                   SUM(t.Hours) AS Всего_часов,
                   COUNT(t.TimesheetID) AS Рабочих_дней,
                   AVG(t.Hours) AS Среднее_кол_во_часов
            FROM Employees e
            LEFT JOIN TimesheetRecords t ON e.EmployeeID = t.EmployeeID
            GROUP BY e.EmployeeID, e.LastName, e.FirstName
            ORDER BY Всего_часов DESC", conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStatistics.DataSource = dt;
            }
        }

        private void LoadOrderStats()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(@"
            SELECT OrderType AS Тип_приказа, 
                   COUNT(*) AS Количество
            FROM Orders
            GROUP BY OrderType
            ORDER BY Количество DESC", conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStatistics.DataSource = dt;
            }
        }

        private void LoadSalaryStatsWithHaving() {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)) {
                SqlDataAdapter adapter = new SqlDataAdapter(
                    @"SELECT Category AS Категория,
                             AVG(Salary) AS Средняя_зарплата,
                             COUNT(*) AS Количество_должностей
                      FROM Positions
                      GROUP BY Category
                      HAVING AVG(Salary) > 30000
                      ORDER BY Средняя_зарплата DESC", conn
                    );
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStatistics.DataSource = dt;
            }
        }

        private void LoadEventStatsWithHaving()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(
                    @"SELECT EventType AS Тип_события,
                             COUNT(*) AS Количество
                      FROM StaffEvents
                      GROUP BY EventType
                      HAVING COUNT(*) >= 2
                      ORDER BY Количество DESC", conn
                    );
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStatistics.DataSource = dt;
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
            else if (tabControl1.SelectedTab == tabStatistics) LoadStatistics();
        }
        #endregion

        #region Экспорт
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

        private void btnEmpExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvEmployees, "Employees.xlsx");
        private void btnEmpExpWord_Click(object sender, EventArgs e) => ExportWord(dgvEmployees, "Employees.docx");
        private void btnDeptExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvDepartments, "Departments.xlsx");
        private void btnDeptExpWord_Click(object sender, EventArgs e) => ExportWord(dgvDepartments, "Departments.docx");
        private void btnPosExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvPositions, "Positions.xlsx");
        private void btnPosExpWord_Click(object sender, EventArgs e) => ExportWord(dgvPositions, "Positions.docx");
        private void btnTimeExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvTimesheet, "Timesheet.xlsx");
        private void btnTimeExpWord_Click(object sender, EventArgs e) => ExportWord(dgvTimesheet, "Timesheet.doxc");
        private void btnEventExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvEvents, "Events.xlsx");
        private void btnEventExpWord_Click(object sender, EventArgs e) => ExportWord(dgvEvents, "Events.docx");
        private void btnOrdExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvOrders, "Orders.xlsx");
        private void btnOrdExpWord_Click(object sender, EventArgs e) => ExportWord(dgvOrders, "Orders.docx");
        private void btnStatsExpExcel_Click(object sender, EventArgs e) => ExportExcel(dgvStatistics, "Statistic.xlsx");
        private void btnStatsExpWord_Click(object sender, EventArgs e) => ExportWord(dgvStatistics, "Statistic.docx");
        #endregion
    }
}