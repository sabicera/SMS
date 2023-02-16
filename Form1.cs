using SMS.Properties;
using System;
using System.Net.Http;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace SMS
{
    public partial class Form1 : Form
    {
        private const string repoUrl = "https://github.com/sabicera/SMS/blob/master/SMS.exe";
        private const string downloadUrl = "https://github.com/sabicera";

        private List<DateTime> cyprusHolidays = new List<DateTime>();
        string text1 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. Ο ΕΛΕΓΧΟΣ ΤΟΥ ΠΡΟΙΟΝΤΟΣ ΟΛΟΚΛΗΡΩΘΗΚΕ. ΜΠΟΡΕΙΤΕ ΝΑ ΠΕΡΑΣΕΤΕ ΝΑ ΤΟ ΠΑΡΑΛΑΒΕΤΕ.";
        string text2 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. Η ΕΠΙΣΚΕΥΗ ΤΟΥ ΠΡΟΙΟΝΤΟΣ ΟΛΟΚΛΗΡΩΘΗΚΕ. ΜΠΟΡΕΙΤΕ ΝΑ ΠΕΡΑΣΕΤΕ ΝΑ ΤΟ ΠΑΡΑΛΑΒΕΤΕ.";
        string text3 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. Η ΑΝΤΙΚΑΤΑΣΤΑΣΗ ΤΟΥ ΠΡΟΙΟΝΤΟΣ ΟΛΟΚΛΗΡΩΘΗΚΕ. ΜΠΟΡΕΙΤΕ ΝΑ ΠΕΡΑΣΕΤΕ ΝΑ ΤΟ ΠΑΡΑΛΑΒΕΤΕ.";
        string text4 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΠΑΡΑΚΑΛΩ ΕΠΙΚΟΙΝΩΝΗΣΤΕ ΑΜΕΣΑ ΜΑΖΙ ΜΑΣ.";
        string text5 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΤΟ ΠΡΟΙΟΝ ΣΑΣ ΕΙΝΑΙ ΠΡΟΒΛHMAΤΙΚΟ. ΕΧΕΤΕ  ΠΙΣΤΩΣΗ ΕΥΡΩ. ΓΙΑ ΝΑ ΠΑΡΕΤΕ ΚΑΤΙ ΑΛΛΟ.";
        string text6 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΕΧΕΤΕ ΠΙΣΤΩΣΗ  ΕΥΡΩ. ΓΙΑ ΝΑ ΠΑΡΕΤΕ ΚΑΤΙ ΑΛΛΟ.";
        string text7 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΤΟ ΠΡΟΙΟΝ ΣΑΣ ΠΡΟΩΘΕΙΤΑΙ ΣΤΗΝ ΑΝΤΙΠΡΟΣΩΠΕΙΑ ΓΙΑ ΕΛΕΓΧΟ.";
        private void AddHolidays(int year)
        {
            //Σταθερές Εορτές
            cyprusHolidays.Add(new DateTime(year, 1, 1)); // Πρωτοχρονία
            cyprusHolidays.Add(new DateTime(year, 1, 6)); // Θεοφάνεια
            cyprusHolidays.Add(new DateTime(year, 3, 25)); // 25η Μαρτίου
            cyprusHolidays.Add(new DateTime(year, 4, 1)); // Ανεξαρτησία της Κύπρου
            cyprusHolidays.Add(new DateTime(year, 5, 1)); // Εργατική Πρωτομαϊα
            cyprusHolidays.Add(new DateTime(year, 8, 15)); // Κοίμηση της Θεοτόκου
            cyprusHolidays.Add(new DateTime(year, 10, 1)); // Ημέρα Ανεξαρτησίας της Κύπρου
            cyprusHolidays.Add(new DateTime(year, 10, 28)); // Ημέρα του Όχι
            cyprusHolidays.Add(new DateTime(year, 12, 25)); // Χριστούγεννα

            //Κινητές Εορτές
            cyprusHolidays.Add(new DateTime(2022, 12, 26)); // Χριστούγεννα 2023
            cyprusHolidays.Add(new DateTime(2023, 1, 2)); // Πρωτοχρονία 2023
            cyprusHolidays.Add(new DateTime(2023, 2, 27)); // Καθαρά Δευτέρα 2023

            DateTime holiday1 = new DateTime(year, 1, 1);
            DateTime holiday2 = new DateTime(year, 1, 6);
            DateTime holiday21 = new DateTime(year, 2, 27);
            DateTime holiday3 = new DateTime(year, 3, 25);
            DateTime holiday4 = new DateTime(year, 4, 1);
            DateTime holiday5 = new DateTime(year, 5, 1);
            DateTime holiday6 = new DateTime(year, 8, 15);
            DateTime holiday7 = new DateTime(year, 10, 28);
            DateTime holiday8 = new DateTime(year, 12, 25);

            if (DateTime.Now.Date <= holiday1)
            {
                HolidayLabel.Text = "Πρωτοχρονία - " + holiday1.ToString("dddd d MMMM");
            }
            else if (DateTime.Now.Date <= holiday2)
            {
                HolidayLabel.Text = "Θεοφάνεια - " + holiday2.ToString("dddd d MMMM");
            }
            else if (DateTime.Now.Date <= holiday21)
            {
                HolidayLabel.Text = "Καθαρά Δευτέρα - " + holiday21.ToString("dddd d MMMM");
            }
            else if (DateTime.Now.Date <= holiday3)
            {
                HolidayLabel.Text = "25η Μαρτίου - " + holiday3.ToString("dddd d MMMM");
            }
            else if (DateTime.Now.Date <= holiday4)
            {
                HolidayLabel.Text = "Ανεξαρτησία της Κύπρου - " + holiday4.ToString("dddd d MMMM");
            }
            else if (DateTime.Now.Date <= holiday5)
            {
                HolidayLabel.Text = "Εργατική Πρωτομαϊα - " + holiday5.ToString("dddd d MMMM");
            }
            else if (DateTime.Now.Date <= holiday6)
            {
                HolidayLabel.Text = "Κοίμηση της Θεοτόκου - " + holiday6.ToString("dddd d MMMM");
            }
            else if (DateTime.Now.Date <= holiday7)
            {
                HolidayLabel.Text = "Ημέρα του Όχι - " + holiday7.ToString("dddd d MMMM");
            }
            else if (DateTime.Now.Date <= holiday8)
            {
                HolidayLabel.Text = "Χριστούγεννα - " + holiday8.ToString("dddd d MMMM");
            }
        }
        public Form1(string selectedUser)
        {
            InitializeComponent();
        }
        public Form1()
        {
            InitializeComponent();
            DateTimePicker.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);
            AddHolidays(DateTime.Now.Year);
            UserComboBox.Text = Settings.Default.SelectedValue;
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            CurrentDateLabel.Text = DateTime.Now.ToLongDateString();
            List<int> values = new List<int> { 2, 3, 5, 7, 10 };
            WarrantyComboBox.DataSource = values;
            // Display current version
            VersionLabel.Text = "Version: " + Application.ProductVersion;
            try
            {
                string currentVersion = Application.ProductVersion;
                string latestVersion = await GetLatestVersionAsync();

                if (latestVersion != null && latestVersion.CompareTo(currentVersion) > 0)
                {
                    DialogResult result = MessageBox.Show(
                        "A new version of the app is available. Do you want to download and install it?",
                        "Update available",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        await DownloadUpdateAsync();
                    }
                }
                else
                {
                    MessageBox.Show("You have the latest version of the app.", "Up to date", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update check failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<string> GetLatestVersionAsync()
        {
            string version = null;
            HttpClient client = new HttpClient();

            // Download the HTML page of the repo to find the latest version tag
            string html = await client.GetStringAsync(repoUrl);
            int index = html.IndexOf("latest-version-badge");

            if (index >= 0)
            {
                int startIndex = html.IndexOf("title=\"", index) + 7;
                int endIndex = html.IndexOf("\"", startIndex);
                version = html.Substring(startIndex, endIndex - startIndex);
            }

            return version;
        }

        private async Task DownloadUpdateAsync()
        {
            HttpClient client = new HttpClient();
            Stream stream = null;

            try
            {
                // Open a web stream to the latest version download URL
                stream = await client.GetStreamAsync(downloadUrl);

                // Create a FileStream to save the downloaded file
                FileStream fileStream = new FileStream("SMS.exe", FileMode.Create);

                // Create a buffer to read from the web stream and write to the file stream
                byte[] buffer = new byte[1024];
                int bytesRead;

                // Set up the progress bar
                UpdateProgressBar.Minimum = 0;
                UpdateProgressBar.Maximum = (int)(stream.Length / 1024) + 1;
                UpdateProgressBar.Value = 0;

                // Read from the web stream and write to the file stream until the end
                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    fileStream.Write(buffer, 0, bytesRead);
                    UpdateProgressBar.Value++;
                }

                fileStream.Close();
                stream.Close();

                MessageBox.Show("Update downloaded successfully. The app will now restart.", "Update downloaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Restart the app to apply the update
                Process.Start("SMS.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update download failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.SelectedValue = UserComboBox.Text;
            Settings.Default.Save();
        }
        //Calendar Tab//
        private void WarrantyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateRemainingDays();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CalculateRemainingDays();
        }
        private void CalculateRemainingDays()
        {
            {
                if (DateTimePicker.Value > DateTime.Now)
                {
                    OrderDateLabel.Text = "Ημ/νία Παραγγελίας :";
                    return;
                }
                TimeSpan countworkingdays = DateTime.Now - DateTimePicker.Value;
                int workingDays = Enumerable.Range(0, (int)countworkingdays.TotalDays)
                .Select(i => DateTimePicker.Value.AddDays(i))
                .Count(d => (d.DayOfWeek != DayOfWeek.Saturday && d.DayOfWeek != DayOfWeek.Sunday) && !cyprusHolidays.Contains(d.Date));

                DaysPassedLabel.Text = $"{workingDays} εργάσιμες ημέρες.";

                if (workingDays <= 0)
                {
                    DaysPassedLabel.ForeColor = Color.Black;
                    DaysPassedLabel.Font = new Font(DaysPassedLabel.Font, FontStyle.Regular);
                }
                else if (workingDays >= 3 && workingDays < 15)
                {
                    DaysPassedLabel.ForeColor = Color.MediumBlue;
                    DaysPassedLabel.Font = new Font(DaysPassedLabel.Font, FontStyle.Regular);
                }
                else if (workingDays > 15)
                {
                    DaysPassedLabel.ForeColor = Color.Red;
                    DaysPassedLabel.Font = new Font(DaysPassedLabel.Font, FontStyle.Bold);
                }
            }

            // check if the selected year is different from the current year
            if (DateTimePicker.Value.Year != DateTime.Now.Year)
            {
                // clear the previous year holidays
                //cyprusHolidays.Clear();
                // add the new year holidays
                AddHolidays(DateTimePicker.Value.Year);
            }

            //Δικαίωμα Επιστροφής//
            TimeSpan doadays = DateTime.Now - DateTimePicker.Value;

            if (doadays.Days <= 7)
            {
                DOALabel.Text = "DOA";
                DOALabel.ForeColor = Color.Green;
                DOALabel.Font = new Font(DOALabel.Font, FontStyle.Bold);
                ReturnLabel.Text = "Online Return";
                ReturnLabel.ForeColor = Color.Green;
                ReturnLabel.Font = new Font(ReturnLabel.Font, FontStyle.Bold);
            }
            else if (doadays.Days >= 8 && doadays.Days < 15)
            {
                DOALabel.Text = "DOA expired";
                DOALabel.ForeColor = Color.Red;
                DOALabel.Font = new Font(DOALabel.Font, FontStyle.Bold);
                ReturnLabel.Text = "Online Return";
                ReturnLabel.ForeColor = Color.Green;
                ReturnLabel.Font = new Font(ReturnLabel.Font, FontStyle.Bold);
            }
            else if (doadays.Days > 15)
            {
                DOALabel.Text = "DOA expired";
                DOALabel.ForeColor = Color.Red;
                DOALabel.Font = new Font(DOALabel.Font, FontStyle.Bold);
                ReturnLabel.Text = "NO Return !!";
                ReturnLabel.ForeColor = Color.Red;
                ReturnLabel.Font = new Font(ReturnLabel.Font, FontStyle.Bold);
            }

            //Ημέρες Εγγύησης//
            int minusYears = int.Parse(WarrantyComboBox.Text);
            DateTime pastDate = DateTime.Now.AddYears(-minusYears);
            DateTime givenDate = DateTimePicker.Value.Date;
            TimeSpan difference1 = givenDate - pastDate;
            int days = (int)difference1.Days;

            if (days >= 0)
            {
                WarrantyDays.Text = "Η εγγύηση ισχύει για ακόμα " + days + " ημέρες";
                WarrantyDays.ForeColor = Color.Green;
                WarrantyDays.Font = new Font(TodayLabel.Font, FontStyle.Regular);
            }

            else
            {
                WarrantyDays.Text = "Εκτός εγγύησης εδώ και " + days + " ημέρες";
                WarrantyDays.ForeColor = Color.Red;
                WarrantyDays.Font = new Font(TodayLabel.Font, FontStyle.Bold);
            }
        }
        private void ResetCalendar_Click(object sender, EventArgs e)
        {
            DateTimePicker.Value = DateTime.Now;
            WarrantyDays.ForeColor = Color.Black;
            dateTimePicker1_ValueChanged(sender, e);
            WarrantyComboBox.SelectedIndex = 0;
            Clipboard.Clear();
        }
        //Notes Tab//
        public void InformComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = "Ο πελάτης ενημερώθηκε για " + InformComboBox.Text + " = " + UserComboBox.Text + " " + DateTime.Now.ToString("dd/MM/yy"); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        public void CancelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = "Αιτία ακύρωσης: " + CancelComboBox.Text + "=" + UserComboBox.Text + " " + DateTime.Now.ToString("dd/MM/yy");
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (NotesRichTextBox.SelectionLength > 0)
            {
                DataObject data = new DataObject();
                data.SetData(DataFormats.UnicodeText, NotesRichTextBox.SelectedText);
                Clipboard.SetDataObject(data, true);
            }
            else
            {
                DataObject data = new DataObject();
                data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
                Clipboard.SetDataObject(data, true);
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            NotesRichTextBox.Text = string.Empty;
        }
        //SMS Tab//
        private void CompleteButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text1);
            Clipboard.SetDataObject(data);
        }
        private void RepairButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text2);
            Clipboard.SetDataObject(data);
        }
        private void ReplacedButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text3);
            Clipboard.SetDataObject(data);
        }
        private void ContactButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text4);
            Clipboard.SetDataObject(data);
        }
        private void VoucherFaultyButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text5);
            Clipboard.SetDataObject(data);
        }
        private void VoucherButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text6);
            Clipboard.SetDataObject(data);
        }
        private void ManufacturerButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text7);
            Clipboard.SetDataObject(data);
        }
        public void VoucherSMSButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText("Ο πελάτης επέστρεψε το  και έχει πίστωση " + " € (ΟΧΙ ΕΠΙΣΤΡΟΦΗ !!!)=" + UserComboBox.Text + " " + DateTime.Now.ToShortDateString());
            DataObject data = new DataObject();
            data.SetData(Clipboard.GetText());
            Clipboard.SetDataObject(data);
        }
        public void ReturnMoneySMSButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText("Ο πελάτης επέστρεψε το  και έχει επιστροφή χρημάτων " + " € =" + UserComboBox.Text + " " + DateTime.Now.ToShortDateString());
            DataObject data = new DataObject();
            data.SetData(Clipboard.GetText());
            Clipboard.SetDataObject(data);
        }
    }
}