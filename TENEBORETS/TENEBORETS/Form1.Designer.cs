namespace TENEBORETS
{
    partial class Регестрация
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHeader = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.chkOnlineAccess = new System.Windows.Forms.CheckBox();
            this.cmbExperience = new System.Windows.Forms.ComboBox();
            this.labelExperience = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.groupBoxCourses = new System.Windows.Forms.GroupBox();
            this.txtCourseDetails = new System.Windows.Forms.TextBox();
            this.labelDetails = new System.Windows.Forms.Label();
            this.listCourses = new System.Windows.Forms.ListView();
            this.columnCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelHeader.Location = new System.Drawing.Point(22, 18);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(303, 30);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Регистрация на курсы шефов";
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.chkOnlineAccess);
            this.groupBoxUser.Controls.Add(this.cmbExperience);
            this.groupBoxUser.Controls.Add(this.labelExperience);
            this.groupBoxUser.Controls.Add(this.txtPhone);
            this.groupBoxUser.Controls.Add(this.labelPhone);
            this.groupBoxUser.Controls.Add(this.txtEmail);
            this.groupBoxUser.Controls.Add(this.labelEmail);
            this.groupBoxUser.Controls.Add(this.txtFullName);
            this.groupBoxUser.Controls.Add(this.labelFullName);
            this.groupBoxUser.Location = new System.Drawing.Point(27, 63);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(347, 259);
            this.groupBoxUser.TabIndex = 1;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Контакты участника";
            // 
            // chkOnlineAccess
            // 
            this.chkOnlineAccess.AutoSize = true;
            this.chkOnlineAccess.Location = new System.Drawing.Point(19, 214);
            this.chkOnlineAccess.Name = "chkOnlineAccess";
            this.chkOnlineAccess.Size = new System.Drawing.Size(239, 17);
            this.chkOnlineAccess.TabIndex = 5;
            this.chkOnlineAccess.Text = "Нужен онлайн-доступ к материалам курса";
            this.chkOnlineAccess.UseVisualStyleBackColor = true;
            // 
            // cmbExperience
            // 
            this.cmbExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExperience.FormattingEnabled = true;
            this.cmbExperience.Location = new System.Drawing.Point(19, 182);
            this.cmbExperience.Name = "cmbExperience";
            this.cmbExperience.Size = new System.Drawing.Size(301, 21);
            this.cmbExperience.TabIndex = 4;
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(16, 166);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(87, 13);
            this.labelExperience.TabIndex = 7;
            this.labelExperience.Text = "Уровень опыта*";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(19, 135);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(301, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(16, 119);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(58, 13);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Телефон*";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(19, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(16, 72);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 13);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "E-mail*";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(19, 41);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(301, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(16, 25);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(34, 13);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "ФИО*";
            // 
            // groupBoxCourses
            // 
            this.groupBoxCourses.Controls.Add(this.txtCourseDetails);
            this.groupBoxCourses.Controls.Add(this.labelDetails);
            this.groupBoxCourses.Controls.Add(this.listCourses);
            this.groupBoxCourses.Location = new System.Drawing.Point(394, 63);
            this.groupBoxCourses.Name = "groupBoxCourses";
            this.groupBoxCourses.Size = new System.Drawing.Size(394, 333);
            this.groupBoxCourses.TabIndex = 2;
            this.groupBoxCourses.TabStop = false;
            this.groupBoxCourses.Text = "Доступные программы";
            // 
            // txtCourseDetails
            // 
            this.txtCourseDetails.Location = new System.Drawing.Point(18, 230);
            this.txtCourseDetails.Multiline = true;
            this.txtCourseDetails.Name = "txtCourseDetails";
            this.txtCourseDetails.ReadOnly = true;
            this.txtCourseDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCourseDetails.Size = new System.Drawing.Size(357, 86);
            this.txtCourseDetails.TabIndex = 2;
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(15, 214);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(107, 13);
            this.labelDetails.TabIndex = 1;
            this.labelDetails.Text = "Описание программы";
            // 
            // listCourses
            // 
            this.listCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCourse,
            this.columnLevel,
            this.columnDuration,
            this.columnPrice});
            this.listCourses.FullRowSelect = true;
            this.listCourses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listCourses.HideSelection = false;
            this.listCourses.Location = new System.Drawing.Point(18, 29);
            this.listCourses.MultiSelect = false;
            this.listCourses.Name = "listCourses";
            this.listCourses.Size = new System.Drawing.Size(357, 171);
            this.listCourses.TabIndex = 0;
            this.listCourses.UseCompatibleStateImageBehavior = false;
            this.listCourses.View = System.Windows.Forms.View.Details;
            this.listCourses.SelectedIndexChanged += new System.EventHandler(this.listCourses_SelectedIndexChanged);
            // 
            // columnCourse
            // 
            this.columnCourse.Text = "Курс";
            this.columnCourse.Width = 140;
            // 
            // columnLevel
            // 
            this.columnLevel.Text = "Уровень";
            this.columnLevel.Width = 80;
            // 
            // columnDuration
            // 
            this.columnDuration.Text = "Срок";
            this.columnDuration.Width = 60;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Стоимость";
            this.columnPrice.Width = 75;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(27, 343);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(149, 30);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Записаться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(202, 343);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(172, 30);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистить форму";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(27, 389);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(203, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Проверьте данные и оставьте заявку.";
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(647, 18);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(141, 30);
            this.buttonAdmin.TabIndex = 6;
            this.buttonAdmin.Text = "Кабинет администратора";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // Регестрация
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 421);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.groupBoxCourses);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.labelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Регестрация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация на курсы поваров";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxCourses.ResumeLayout(false);
            this.groupBoxCourses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ComboBox cmbExperience;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.GroupBox groupBoxCourses;
        private System.Windows.Forms.ListView listCourses;
        private System.Windows.Forms.ColumnHeader columnCourse;
        private System.Windows.Forms.ColumnHeader columnLevel;
        private System.Windows.Forms.ColumnHeader columnDuration;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.TextBox txtCourseDetails;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkOnlineAccess;
        private System.Windows.Forms.Button buttonAdmin;
    }
}

