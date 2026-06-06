namespace databaseKP.AddForms
{
    partial class AddEventForm
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
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblBasis = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtEventType = new System.Windows.Forms.TextBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtBasis = new System.Windows.Forms.TextBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Text = "Добавление кадрового события";

            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(12, 55);
            this.lblEventType.Text = "Тип события *:";

            this.txtEventType.Location = new System.Drawing.Point(150, 52);
            this.txtEventType.Size = new System.Drawing.Size(300, 23);

            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(12, 88);
            this.lblEventDate.Text = "Дата события *:";

            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventDate.Location = new System.Drawing.Point(150, 85);
            this.dtpEventDate.Size = new System.Drawing.Size(150, 23);

            this.lblBasis.AutoSize = true;
            this.lblBasis.Location = new System.Drawing.Point(12, 121);
            this.lblBasis.Text = "Основание *:";

            this.txtBasis.Location = new System.Drawing.Point(150, 118);
            this.txtBasis.Size = new System.Drawing.Size(300, 60);
            this.txtBasis.Multiline = true;

            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(12, 190);
            this.lblEmployee.Text = "Сотрудник *:";

            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.Location = new System.Drawing.Point(150, 187);
            this.cmbEmployee.Size = new System.Drawing.Size(300, 23);

            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(12, 223);
            this.lblOrder.Text = "Приказ *:";

            this.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrder.Location = new System.Drawing.Point(150, 220);
            this.cmbOrder.Size = new System.Drawing.Size(300, 23);

            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(12, 256);
            this.lblPosition.Text = "Должность *:";

            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Location = new System.Drawing.Point(150, 253);
            this.cmbPosition.Size = new System.Drawing.Size(300, 23);

            this.btnSave.Location = new System.Drawing.Point(150, 295);
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(270, 295);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.txtEventType);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.lblBasis);
            this.Controls.Add(this.txtBasis);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление кадрового события";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblBasis;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.TextBox txtBasis;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}