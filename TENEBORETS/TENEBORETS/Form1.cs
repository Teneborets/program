using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TENEBORETS.Data;

namespace TENEBORETS
{
    public partial class Регестрация : Form
    {
        private readonly List<Course> _courses = new List<Course>();
        private readonly CultureInfo _ruCulture = CultureInfo.GetCultureInfo("ru-RU");
        private readonly RegistrationRepository _repository = RegistrationRepository.Instance;

        public Регестрация()
        {
            InitializeComponent();
            SetupExperienceLevels();
            InitializeCourseData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (listCourses.Items.Count > 0)
            {
                listCourses.Items[0].Selected = true;
            }
        }

        private void InitializeCourseData()
        {
            _courses.AddRange(new[]
            {
                new Course
                {
                    Name = "Базовая кулинария",
                    Level = "Новичок",
                    DurationWeeks = 4,
                    Price = 18000,
                    Description = "Освойте ножевые техники и ключевые соусы французской кухни.",
                    Schedule = "Пн/Ср 18:00 - 21:00",
                    Seats = 12
                },
                new Course
                {
                    Name = "Шеф-кондитер",
                    Level = "Любитель",
                    DurationWeeks = 6,
                    Price = 24000,
                    Description = "Десерты, муссы, авторские торты и работа с шоколадом.",
                    Schedule = "Вт/Чт 17:30 - 20:30",
                    Seats = 10
                },
                new Course
                {
                    Name = "Современная гастрономия",
                    Level = "Опытный",
                    DurationWeeks = 8,
                    Price = 36000,
                    Description = "Су-вид, ферментация, plating и управление кухней.",
                    Schedule = "Сб 11:00 - 16:00",
                    Seats = 8
                }
            });

            RefreshCourseList();
        }

        private void RefreshCourseList()
        {
            listCourses.Items.Clear();

            foreach (var course in _courses)
            {
                var item = new ListViewItem(course.Name)
                {
                    Tag = course
                };

                item.SubItems.Add(course.Level);
                item.SubItems.Add($"{course.DurationWeeks} нед.");
                item.SubItems.Add(course.Price.ToString("C0", _ruCulture));
                listCourses.Items.Add(item);
            }
        }

        private void SetupExperienceLevels()
        {
            cmbExperience.Items.Clear();
            cmbExperience.Items.AddRange(new object[]
            {
                "Новичок",
                "Любитель",
                "Опытный"
            });

            if (cmbExperience.Items.Count > 0)
            {
                cmbExperience.SelectedIndex = 0;
            }
        }

        private void listCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCourses.SelectedItems.Count == 0)
            {
                txtCourseDetails.Clear();
                return;
            }

            var course = (Course)listCourses.SelectedItems[0].Tag;
            txtCourseDetails.Text = FormatCourseDetails(course);
        }

        private string FormatCourseDetails(Course course)
        {
            var builder = new StringBuilder();
            builder.AppendLine(course.Description);
            builder.AppendLine();
            builder.AppendLine($"Длительность: {course.DurationWeeks} недель");
            builder.AppendLine($"Стоимость: {course.Price.ToString("C0", _ruCulture)}");
            builder.AppendLine($"Расписание: {course.Schedule}");
            builder.AppendLine($"Свободных мест: {course.Seats}");
            return builder.ToString();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errors.Add("Введите ФИО.");
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                errors.Add("Укажите корректный e-mail.");
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text.Length < 6)
            {
                errors.Add("Добавьте номер телефона для связи.");
            }

            if (listCourses.SelectedItems.Count == 0)
            {
                errors.Add("Выберите курс.");
            }

            if (errors.Any())
            {
                lblStatus.ForeColor = Color.Firebrick;
                lblStatus.Text = string.Join(" ", errors);
                return;
            }

            var course = (Course)listCourses.SelectedItems[0].Tag;
            var registration = new RegistrationRecord
            {
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                ExperienceLevel = cmbExperience.SelectedItem?.ToString() ?? "Не указан",
                CourseName = course.Name,
                NeedsOnlineAccess = chkOnlineAccess.Checked,
                RegisteredAt = DateTime.Now
            };

            _repository.SaveRegistration(registration);
            var ticketNumber = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpperInvariant();

            lblStatus.ForeColor = Color.ForestGreen;
            lblStatus.Text =
                $"Заявка №{ticketNumber}: {txtFullName.Text.Trim()} записан на «{course.Name}». " +
                $"Мы свяжемся по {txtPhone.Text.Trim()} и {txtEmail.Text.Trim()}.";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cmbExperience.SelectedIndex = 0;
            chkOnlineAccess.Checked = false;
            lblStatus.Text = "Проверьте данные и оставьте заявку.";
            txtFullName.Focus();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            using (var loginForm = new AdminLoginForm())
            {
                loginForm.ShowDialog(this);
            }
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {
            // Header label click is not used, but handler is left for designer compatibility.
        }

        private class Course
        {
            public string Name { get; set; }
            public string Level { get; set; }
            public int DurationWeeks { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
            public string Schedule { get; set; }
            public int Seats { get; set; }
        }
    }
}
