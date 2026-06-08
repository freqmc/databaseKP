namespace databaseKP
{
    partial class EditDepartmentForm
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
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblDepartmentType = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtDepartmentType = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Text = "Редактирование отдела";

            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(12, 55);
            this.lblDepartmentName.Text = "Название отдела:";

            this.txtDepartmentName.Location = new System.Drawing.Point(150, 52);
            this.txtDepartmentName.Size = new System.Drawing.Size(300, 20);

            this.lblDepartmentType.AutoSize = true;
            this.lblDepartmentType.Location = new System.Drawing.Point(12, 88);
            this.lblDepartmentType.Text = "Тип отдела:";

            this.txtDepartmentType.Location = new System.Drawing.Point(150, 85);
            this.txtDepartmentType.Size = new System.Drawing.Size(300, 20);

            this.btnSave.Location = new System.Drawing.Point(150, 130);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(270, 130);
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 180);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.lblDepartmentType);
            this.Controls.Add(this.txtDepartmentType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование отдела";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblDepartmentType;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}