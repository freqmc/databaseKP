namespace databaseKP
{
    partial class EditPositionForm
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
            this.lblPositionName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtPositionName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Text = "Редактирование должности";

            this.lblPositionName.AutoSize = true;
            this.lblPositionName.Location = new System.Drawing.Point(12, 55);
            this.lblPositionName.Text = "Название должности:";

            this.txtPositionName.Location = new System.Drawing.Point(150, 52);
            this.txtPositionName.Size = new System.Drawing.Size(300, 20);

            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 88);
            this.lblCategory.Text = "Категория:";

            this.txtCategory.Location = new System.Drawing.Point(150, 85);
            this.txtCategory.Size = new System.Drawing.Size(300, 20);

            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(12, 121);
            this.lblSalary.Text = "Оклад:";

            this.txtSalary.Location = new System.Drawing.Point(150, 118);
            this.txtSalary.Size = new System.Drawing.Size(150, 20);

            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(12, 154);
            this.lblDepartment.Text = "Отдел:";

            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Location = new System.Drawing.Point(150, 151);
            this.cmbDepartment.Size = new System.Drawing.Size(300, 21);

            this.btnSave.Location = new System.Drawing.Point(150, 195);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(270, 195);
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 250);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPositionName);
            this.Controls.Add(this.txtPositionName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPositionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование должности";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPositionName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtPositionName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}