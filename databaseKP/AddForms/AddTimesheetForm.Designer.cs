namespace databaseKP.AddForms
{
    partial class AddTimesheetForm
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

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecordDate = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblAttendanceCode = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.dtpRecordDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.txtAttendanceCode = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Text = "Добавление записи в табель";

            this.lblRecordDate.AutoSize = true;
            this.lblRecordDate.Location = new System.Drawing.Point(12, 55);
            this.lblRecordDate.Text = "Дата *:";

            this.dtpRecordDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecordDate.Location = new System.Drawing.Point(150, 52);
            this.dtpRecordDate.Size = new System.Drawing.Size(150, 23);

            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(12, 88);
            this.lblEmployee.Text = "Сотрудник *:";

            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.Location = new System.Drawing.Point(150, 85);
            this.cmbEmployee.Size = new System.Drawing.Size(300, 23);

            this.lblAttendanceCode.AutoSize = true;
            this.lblAttendanceCode.Location = new System.Drawing.Point(12, 121);
            this.lblAttendanceCode.Text = "Код явки *:";

            this.txtAttendanceCode.Location = new System.Drawing.Point(150, 118);
            this.txtAttendanceCode.Size = new System.Drawing.Size(100, 23);
            this.txtAttendanceCode.MaxLength = 10;

            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(12, 154);
            this.lblHours.Text = "Часы *:";

            this.txtHours.Location = new System.Drawing.Point(150, 151);
            this.txtHours.Size = new System.Drawing.Size(100, 23);

            this.btnSave.Location = new System.Drawing.Point(150, 195);
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(270, 195);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 250);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecordDate);
            this.Controls.Add(this.dtpRecordDate);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.lblAttendanceCode);
            this.Controls.Add(this.txtAttendanceCode);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTimesheetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление записи в табель";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecordDate;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblAttendanceCode;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.DateTimePicker dtpRecordDate;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.TextBox txtAttendanceCode;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}