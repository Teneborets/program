using System;
using System.Windows.Forms;
using TENEBORETS.Data;

namespace TENEBORETS
{
    public partial class AdminDashboardForm : Form
    {
        private readonly RegistrationRepository _repository = RegistrationRepository.Instance;

        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadRegistrations();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRegistrations();
        }

        private void LoadRegistrations()
        {
            lvRegistrations.BeginUpdate();
            lvRegistrations.Items.Clear();

            var registrations = _repository.GetRegistrations();

            foreach (var record in registrations)
            {
                var item = new ListViewItem(record.FullName);
                item.SubItems.Add(record.CourseName);
                item.SubItems.Add(record.ExperienceLevel);
                item.SubItems.Add(record.NeedsOnlineAccess ? "Да" : "Нет");
                item.SubItems.Add(record.Email);
                item.SubItems.Add(record.Phone);
                item.SubItems.Add(record.RegisteredAt.ToString("dd.MM.yyyy HH:mm"));
                lvRegistrations.Items.Add(item);
            }

            lvRegistrations.EndUpdate();
            lblSummary.Text = $"Всего заявок: {registrations.Count}";
        }
    }
}

