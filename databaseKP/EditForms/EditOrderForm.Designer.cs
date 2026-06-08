namespace databaseKP
{
    partial class EditOrderForm
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
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtOrderType = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Text = "Редактирование приказа";

            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(12, 55);
            this.lblOrderNumber.Text = "Номер приказа:";

            this.txtOrderNumber.Location = new System.Drawing.Point(150, 52);
            this.txtOrderNumber.Size = new System.Drawing.Size(200, 20);

            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(12, 88);
            this.lblOrderDate.Text = "Дата приказа:";

            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(150, 85);
            this.dtpOrderDate.Size = new System.Drawing.Size(150, 20);

            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(12, 121);
            this.lblOrderType.Text = "Тип приказа:";

            this.txtOrderType.Location = new System.Drawing.Point(150, 118);
            this.txtOrderType.Size = new System.Drawing.Size(300, 20);

            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(12, 154);
            this.lblContent.Text = "Содержание:";

            this.txtContent.Location = new System.Drawing.Point(150, 151);
            this.txtContent.Size = new System.Drawing.Size(300, 60);
            this.txtContent.Multiline = true;

            this.btnSave.Location = new System.Drawing.Point(150, 230);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(270, 230);
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 290);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.txtOrderType);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование приказа";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.TextBox txtOrderType;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}