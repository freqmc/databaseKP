namespace databaseKP
{
    partial class EditEmployeeForm
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

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Text = "Редактирование сотрудника";

            this.lblPersonnelNumber.AutoSize = true;
            this.lblPersonnelNumber.Location = new System.Drawing.Point(12, 50);
            this.lblPersonnelNumber.Text = "Табельный номер:";

            this.txtPersonnelNumber.Location = new System.Drawing.Point(150, 47);
            this.txtPersonnelNumber.Size = new System.Drawing.Size(200, 20);

            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 80);
            this.lblLastName.Text = "Фамилия:";

            this.txtLastName.Location = new System.Drawing.Point(150, 77);
            this.txtLastName.Size = new System.Drawing.Size(200, 20);

            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 110);
            this.lblFirstName.Text = "Имя:";

            this.txtFirstName.Location = new System.Drawing.Point(150, 107);
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);

            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(12, 140);
            this.lblMiddleName.Text = "Отчество:";

            this.txtMiddleName.Location = new System.Drawing.Point(150, 137);
            this.txtMiddleName.Size = new System.Drawing.Size(200, 20);

            this.lblPassportSeries.AutoSize = true;
            this.lblPassportSeries.Location = new System.Drawing.Point(12, 170);
            this.lblPassportSeries.Text = "Серия паспорта:";

            this.txtPassportSeries.Location = new System.Drawing.Point(150, 167);
            this.txtPassportSeries.Size = new System.Drawing.Size(80, 20);

            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Location = new System.Drawing.Point(250, 170);
            this.lblPassportNumber.Text = "Номер паспорта:";

            this.txtPassportNumber.Location = new System.Drawing.Point(350, 167);
            this.txtPassportNumber.Size = new System.Drawing.Size(100, 20);

            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(12, 200);
            this.lblEducation.Text = "Образование:";

            this.txtEducation.Location = new System.Drawing.Point(150, 197);
            this.txtEducation.Size = new System.Drawing.Size(300, 20);

            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(12, 230);
            this.lblPosition.Text = "Должность:";

            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Location = new System.Drawing.Point(150, 227);
            this.cmbPosition.Size = new System.Drawing.Size(300, 21);

            this.btnSave.Location = new System.Drawing.Point(150, 270);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(270, 270);
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 320);
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
            this.Name = "EditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование сотрудника";
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