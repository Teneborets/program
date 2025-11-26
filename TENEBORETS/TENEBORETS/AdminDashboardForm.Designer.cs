namespace TENEBORETS
{
    partial class AdminDashboardForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.lvRegistrations = new System.Windows.Forms.ListView();
            this.columnFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnExperience = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOnline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(24, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(351, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Панель администратора — заявки";
            // 
            // lvRegistrations
            // 
            this.lvRegistrations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFullName,
            this.columnCourse,
            this.columnExperience,
            this.columnOnline,
            this.columnEmail,
            this.columnPhone,
            this.columnDate});
            this.lvRegistrations.FullRowSelect = true;
            this.lvRegistrations.HideSelection = false;
            this.lvRegistrations.Location = new System.Drawing.Point(29, 64);
            this.lvRegistrations.MultiSelect = false;
            this.lvRegistrations.Name = "lvRegistrations";
            this.lvRegistrations.Size = new System.Drawing.Size(744, 322);
            this.lvRegistrations.TabIndex = 1;
            this.lvRegistrations.UseCompatibleStateImageBehavior = false;
            this.lvRegistrations.View = System.Windows.Forms.View.Details;
            // 
            // columnFullName
            // 
            this.columnFullName.Text = "ФИО";
            this.columnFullName.Width = 140;
            // 
            // columnCourse
            // 
            this.columnCourse.Text = "Курс";
            this.columnCourse.Width = 110;
            // 
            // columnExperience
            // 
            this.columnExperience.Text = "Опыт";
            this.columnExperience.Width = 80;
            // 
            // columnOnline
            // 
            this.columnOnline.Text = "Онлайн";
            this.columnOnline.Width = 60;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "E-mail";
            this.columnEmail.Width = 140;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Телефон";
            this.columnPhone.Width = 110;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Дата";
            this.columnDate.Width = 100;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(29, 401);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(174, 410);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(92, 13);
            this.lblSummary.TabIndex = 3;
            this.lblSummary.Text = "Всего заявок: 0";
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvRegistrations);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Администрирование курсов";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView lvRegistrations;
        private System.Windows.Forms.ColumnHeader columnFullName;
        private System.Windows.Forms.ColumnHeader columnCourse;
        private System.Windows.Forms.ColumnHeader columnExperience;
        private System.Windows.Forms.ColumnHeader columnOnline;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSummary;
    }
}

