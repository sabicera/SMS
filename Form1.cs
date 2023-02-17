using SMS.Properties;
using System.Globalization;

namespace SMS
{
    public partial class Form1 : Form
    {
        private readonly List<DateTime> cyprusHolidays = new();
        string text1 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. Ο ΕΛΕΓΧΟΣ ΤΟΥ ΠΡΟΙΟΝΤΟΣ ΟΛΟΚΛΗΡΩΘΗΚΕ. ΜΠΟΡΕΙΤΕ ΝΑ ΠΕΡΑΣΕΤΕ ΝΑ ΤΟ ΠΑΡΑΛΑΒΕΤΕ.";
        string text2 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. Η ΕΠΙΣΚΕΥΗ ΤΟΥ ΠΡΟΙΟΝΤΟΣ ΟΛΟΚΛΗΡΩΘΗΚΕ. ΜΠΟΡΕΙΤΕ ΝΑ ΠΕΡΑΣΕΤΕ ΝΑ ΤΟ ΠΑΡΑΛΑΒΕΤΕ.";
        string text3 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. Η ΑΝΤΙΚΑΤΑΣΤΑΣΗ ΤΟΥ ΠΡΟΙΟΝΤΟΣ ΟΛΟΚΛΗΡΩΘΗΚΕ. ΜΠΟΡΕΙΤΕ ΝΑ ΠΕΡΑΣΕΤΕ ΝΑ ΤΟ ΠΑΡΑΛΑΒΕΤΕ.";
        string text4 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΠΑΡΑΚΑΛΩ ΕΠΙΚΟΙΝΩΝΗΣΤΕ ΑΜΕΣΑ ΜΑΖΙ ΜΑΣ.";
        string text5 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΤΟ ΠΡΟΙΟΝ ΣΑΣ ΕΙΝΑΙ ΠΡΟΒΛHMAΤΙΚΟ. ΕΧΕΤΕ  ΠΙΣΤΩΣΗ ΕΥΡΩ. ΓΙΑ ΝΑ ΠΑΡΕΤΕ ΚΑΤΙ ΑΛΛΟ.";
        string text6 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΕΧΕΤΕ ΠΙΣΤΩΣΗ  ΕΥΡΩ. ΓΙΑ ΝΑ ΠΑΡΕΤΕ ΚΑΤΙ ΑΛΛΟ.";
        string text7 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΕΧΕΤΕ ΕΠΙΣΤΡΟΦΗ ΧΡΗΜΑΤΩΝ  ΕΥΡΩ.";
        string text8 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΤΟ ΠΡΟΙΟΝ ΣΑΣ ΠΡΟΩΘΕΙΤΑΙ ΣΤΗΝ ΑΝΤΙΠΡΟΣΩΠΕΙΑ ΓΙΑ ΕΛΕΓΧΟ.";
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
        public Form1()
        {
            InitializeComponent();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            DateTimePicker.ValueChanged += new EventHandler(DateTimePicker1_ValueChanged);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            AddHolidays(DateTime.Now.Year);
            UserComboBox.Text = Settings.Default.SelectedValue;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentDateLabel.Text = DateTime.Now.ToLongDateString();
            List<int> values = new List<int> { 2, 3, 5, 7, 10 };
            WarrantyComboBox.DataSource = values;
            // Display current version
            VersionLabel.Text = "Version: " + Application.ProductVersion;
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
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
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
            DateTimePicker1_ValueChanged(sender, e);
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
        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LanguageComboBox.SelectedItem.ToString() == "English")
            {
                text1 = "LIMASSOL STORE. TECHNICAL DEPARTMENT. PRODUCT CHECK COMPLETED. YOU CAN PICK IT UP";
                text2 = "LIMASSOL STORE. TECHNICAL DEPARTMENT. PRODUCT REPAIR COMPLETED. YOU CAN PICK IT UP.";
                text3 = "LIMASSOL STORE. TECHNICAL DEPARTMENT. PRODUCT REPLACEMENT COMPLETED. YOU CAN PICK IT UP.";
                text4 = "LIMASSOL STORE. TECHNICAL DEPARTMENT. PLEASE CONTACT US DIRECTLY.";
                text5 = "LIMASSOL STORE. TECHNICAL DEPARTMENT. YOUR PRODUCT IS PROBLEMATIC. YOU HAVE  EURO CREDIT. TO GET SOMETHING ELSE.";
                text6 = "LIMASSOL STORE. TECHNICAL DEPARTMENT. YOU HAVE  EURO CREDIT. TO GET SOMETHING ELSE.";
                text7 = "LIMASSOL STORE. TECHNICAL DEPARTMENT. YOU HAVE  EURO MONEY RETURN.";
                text8 = "LIMASSOL STORE. TECHNICAL DEPARTMENT. YOUR PRODUCT IS BEING FORWARDED TO THE DEALERSHIP FOR INSPECTION.";
            }
            else if (LanguageComboBox.SelectedItem.ToString() == "Ελληνικά")
            {
                text1 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. Ο ΕΛΕΓΧΟΣ ΤΟΥ ΠΡΟΙΟΝΤΟΣ ΟΛΟΚΛΗΡΩΘΗΚΕ. ΜΠΟΡΕΙΤΕ ΝΑ ΠΕΡΑΣΕΤΕ ΝΑ ΤΟ ΠΑΡΑΛΑΒΕΤΕ.";
                text2 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. Η ΕΠΙΣΚΕΥΗ ΤΟΥ ΠΡΟΙΟΝΤΟΣ ΟΛΟΚΛΗΡΩΘΗΚΕ. ΜΠΟΡΕΙΤΕ ΝΑ ΠΕΡΑΣΕΤΕ ΝΑ ΤΟ ΠΑΡΑΛΑΒΕΤΕ.";
                text3 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. Η ΑΝΤΙΚΑΤΑΣΤΑΣΗ ΤΟΥ ΠΡΟΙΟΝΤΟΣ ΟΛΟΚΛΗΡΩΘΗΚΕ. ΜΠΟΡΕΙΤΕ ΝΑ ΠΕΡΑΣΕΤΕ ΝΑ ΤΟ ΠΑΡΑΛΑΒΕΤΕ.";
                text4 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΠΑΡΑΚΑΛΩ ΕΠΙΚΟΙΝΩΝΗΣΤΕ ΑΜΕΣΑ ΜΑΖΙ ΜΑΣ.";
                text5 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΤΟ ΠΡΟΙΟΝ ΣΑΣ ΕΙΝΑΙ ΠΡΟΒΛHMAΤΙΚΟ. ΕΧΕΤΕ  ΠΙΣΤΩΣΗ ΕΥΡΩ. ΓΙΑ ΝΑ ΠΑΡΕΤΕ ΚΑΤΙ ΑΛΛΟ.";
                text6 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΕΧΕΤΕ ΠΙΣΤΩΣΗ  ΕΥΡΩ. ΓΙΑ ΝΑ ΠΑΡΕΤΕ ΚΑΤΙ ΑΛΛΟ.";
                text7 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΕΧΕΤΕ ΕΠΙΣΤΡΟΦΗ ΧΡΗΜΑΤΩΝ  ΕΥΡΩ.";
                text8 = "ΚΑΤΑΣΤΗΜΑ ΛΕΜΕΣΟΥ. ΤΕΧΝΙΚΟ ΤΜΗΜΑ. ΤΟ ΠΡΟΙΟΝ ΣΑΣ ΠΡΟΩΘΕΙΤΑΙ ΣΤΗΝ ΑΝΤΙΠΡΟΣΩΠΕΙΑ ΓΙΑ ΕΛΕΓΧΟ.";
            }
        }
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
        private void MoneybackButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text7);
            Clipboard.SetDataObject(data);
        }
        private void ManufacturerButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text8);
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
        // VAT Calculator
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Get the selected item in the ComboBox
            string selectedItem = VATSelectorComboBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedItem))
            {
                // Set the divisor based on the selected item
                double divisor = selectedItem == "19%" ? 1.19 : 1.05;
                // Get the price entered by the user
                if (double.TryParse(PriceInputTextBox.Text, out double price))
                {
                    // Divide the price by the selected value
                    double result = price / divisor;
                    // Display the calculation in the RichTextBox
                    string calculation = $"{price} / {divisor} = {result:F2}";
                    // Display the calculation in the RichTextBox
                    if (HistoryRichTextBox.Text == "")
                    {
                        HistoryRichTextBox.AppendText(price.ToString("F2", CultureInfo.InvariantCulture) + " / " + divisor.ToString("F2", CultureInfo.InvariantCulture) + " = " + result.ToString("F2", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        HistoryRichTextBox.AppendText("\n" + price.ToString("F2", CultureInfo.InvariantCulture) + " / " + divisor.ToString("F2", CultureInfo.InvariantCulture) + " = " + result.ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
                else
                {
                    MessageBox.Show("Invalid price entered. Please enter a valid number.");
                }
            }
            else
            {
                MessageBox.Show("Please select a VAT percentage.");
            }
            // Subscribe back to the TextChanged event
            PriceInputTextBox.TextChanged += PriceInputTextBox_TextChanged;
        }
        private void PriceInputTextBox_TextChanged(object sender, EventArgs e)
        {
            // Code to handle the TextChanged event
        }
        private void ResetCalcButton_Click(object sender, EventArgs e)
        {
            PriceInputTextBox.Clear();
            HistoryRichTextBox.Clear();
        }
    }
}