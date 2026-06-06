namespace databaseKP
{
    partial class AddEmployeeForm
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
            this.lblPersonnelNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblPassportSeries = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();

            this.txtPersonnelNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtPassportSeries = new System.Windows.Forms.TextBox();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Text = "Добавление сотрудника";

            // lblPersonnelNumber
            this.lblPersonnelNumber.AutoSize = true;
            this.lblPersonnelNumber.Location = new System.Drawing.Point(12, 55);
            this.lblPersonnelNumber.Text = "Табельный номер *:";

            // txtPersonnelNumber
            this.txtPersonnelNumber.Location = new System.Drawing.Point(150, 52);
            this.txtPersonnelNumber.Size = new System.Drawing.Size(200, 23);

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 88);
            this.lblLastName.Text = "Фамилия *:";

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(150, 85);
            this.txtLastName.Size = new System.Drawing.Size(200, 23);

            // lblFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 121);
            this.lblFirstName.Text = "Имя *:";

            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(150, 118);
            this.txtFirstName.Size = new System.Drawing.Size(200, 23);

            // lblMiddleName
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(12, 154);
            this.lblMiddleName.Text = "Отчество:";

            // txtMiddleName
            this.txtMiddleName.Location = new System.Drawing.Point(150, 151);
            this.txtMiddleName.Size = new System.Drawing.Size(200, 23);

            // lblPassportSeries
            this.lblPassportSeries.AutoSize = true;
            this.lblPassportSeries.Location = new System.Drawing.Point(12, 187);
            this.lblPassportSeries.Text = "Серия паспорта *:";

            // txtPassportSeries
            this.txtPassportSeries.Location = new System.Drawing.Point(150, 184);
            this.txtPassportSeries.Size = new System.Drawing.Size(80, 23);
            this.txtPassportSeries.MaxLength = 4;
            this.txtPassportSeries.Leave += new System.EventHandler(this.txtPassportSeries_Leave);

            // lblPassportNumber
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Location = new System.Drawing.Point(240, 187);
            this.lblPassportNumber.Text = "Номер *:";

            // txtPassportNumber
            this.txtPassportNumber.Location = new System.Drawing.Point(300, 184);
            this.txtPassportNumber.Size = new System.Drawing.Size(100, 23);
            this.txtPassportNumber.MaxLength = 6;
            this.txtPassportNumber.Leave += new System.EventHandler(this.txtPassportNumber_Leave);

            // lblEducation
            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(12, 220);
            this.lblEducation.Text = "Образование *:";

            // txtEducation
            this.txtEducation.Location = new System.Drawing.Point(150, 217);
            this.txtEducation.Size = new System.Drawing.Size(300, 23);

            // lblPosition
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(12, 253);
            this.lblPosition.Text = "Должность *:";

            // cmbPosition
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Location = new System.Drawing.Point(150, 250);
            this.cmbPosition.Size = new System.Drawing.Size(300, 23);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(150, 290);
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(270, 290);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AddEmployeeForm
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPersonnelNumber);
            this.Controls.Add(this.txtPersonnelNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblPassportSeries);
            this.Controls.Add(this.txtPassportSeries);
            this.Controls.Add(this.lblPassportNumber);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.txtEducation);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPersonnelNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblPassportSeries;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblPosition;

        private System.Windows.Forms.TextBox txtPersonnelNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtPassportSeries;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.ComboBox cmbPosition;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}