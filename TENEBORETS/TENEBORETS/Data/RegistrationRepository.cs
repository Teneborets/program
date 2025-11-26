using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TENEBORETS.Data
{
    /// <summary>
    /// Простая файловая база данных на XML для хранения заявок и админов.
    /// </summary>
    public sealed class RegistrationRepository
    {
        private static readonly Lazy<RegistrationRepository> _instance =
            new Lazy<RegistrationRepository>(() => new RegistrationRepository());

        private readonly object _syncRoot = new object();
        private readonly string _databasePath;
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(ChefDatabase));

        public static RegistrationRepository Instance => _instance.Value;

        private RegistrationRepository()
        {
            var dataDirectory = Path.Combine(Application.StartupPath, "Data");
            Directory.CreateDirectory(dataDirectory);
            _databasePath = Path.Combine(dataDirectory, "chefDatabase.xml");
            EnsureDatabase();
        }

        public IReadOnlyList<RegistrationRecord> GetRegistrations()
        {
            lock (_syncRoot)
            {
                return LoadDatabase().Registrations
                    .OrderByDescending(r => r.RegisteredAt)
                    .ToList();
            }
        }

        public void SaveRegistration(RegistrationRecord record)
        {
            if (record == null)
            {
                throw new ArgumentNullException(nameof(record));
            }

            lock (_syncRoot)
            {
                var db = LoadDatabase();
                db.Registrations.Add(record);
                SaveDatabase(db);
            }
        }

        public bool ValidateAdmin(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            var hash = ComputeHash(password.Trim());

            lock (_syncRoot)
            {
                var db = LoadDatabase();
                return db.Admins.Any(a =>
                    string.Equals(a.Login, login.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(a.PasswordHash, hash, StringComparison.Ordinal));
            }
        }

        private void EnsureDatabase()
        {
            if (File.Exists(_databasePath))
            {
                return;
            }

            var seed = new ChefDatabase
            {
                Admins = new List<AdminAccount>
                {
                    new AdminAccount
                    {
                        Login = "admin",
                        PasswordHash = ComputeHash("chef2024")
                    }
                },
                Registrations = new List<RegistrationRecord>()
            };

            SaveDatabase(seed);
        }

        private ChefDatabase LoadDatabase()
        {
            using (var stream = File.OpenRead(_databasePath))
            {
                return (ChefDatabase)_serializer.Deserialize(stream);
            }
        }

        private void SaveDatabase(ChefDatabase database)
        {
            using (var stream = File.Create(_databasePath))
            {
                _serializer.Serialize(stream, database);
            }
        }

        private static string ComputeHash(string input)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(input);
                var hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }

    [Serializable]
    public class ChefDatabase
    {
        public List<RegistrationRecord> Registrations { get; set; } = new List<RegistrationRecord>();
        public List<AdminAccount> Admins { get; set; } = new List<AdminAccount>();
    }

    [Serializable]
    public class RegistrationRecord
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ExperienceLevel { get; set; }
        public string CourseName { get; set; }
        public bool NeedsOnlineAccess { get; set; }
        public DateTime RegisteredAt { get; set; }
    }

    [Serializable]
    public class AdminAccount
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
    }
}

