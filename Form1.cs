using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
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
            DateTime holiday3 = new DateTime(year, 3, 25);
            DateTime holiday4 = new DateTime(year, 4, 1);
            DateTime holiday5 = new DateTime(year, 5, 1);
            DateTime holiday6 = new DateTime(year, 8, 15);
            DateTime holiday7 = new DateTime(year, 10, 28);
            DateTime holiday8 = new DateTime(year, 12, 25);

            if (DateTime.Now.Date <= holiday1)
            {
                label8.Text = "Πρωτοχρονία " + holiday1.ToString("dddd MMMM yyyy");
            }
            else if (DateTime.Now.Date <= holiday2)
            {
                label8.Text = "Θεοφάνεια " + holiday2.ToString("dddd MMMM yyyy");
            }
            else if (DateTime.Now.Date <= holiday3)
            {
                label8.Text = "25η Μαρτίου " + holiday3.ToString("dddd MMMM yyyy");
            }
            else if (DateTime.Now.Date <= holiday4)
            {
                label8.Text = "Ανεξαρτησία της Κύπρου " + holiday4.ToString("dddd MMMM yyyy");
            }
            else if (DateTime.Now.Date <= holiday5)
            {
                label8.Text = "Εργατική Πρωτομαϊα " + holiday5.ToString("dddd MMMM yyyy");
            }
            else if (DateTime.Now.Date <= holiday6)
            {
                label8.Text = "Κοίμηση της Θεοτόκου " + holiday6.ToString("dddd MMMM yyyy");
            }
            else if (DateTime.Now.Date <= holiday7)
            {
                label8.Text = "Ημέρα του Όχι " + holiday7.ToString("dddd MMMM yyyy");
            }
            else if (DateTime.Now.Date <= holiday8)
            {
                label8.Text = "Χριστούγεννα " + holiday8.ToString("dddd MMMM yyyy");
            }
        }
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);
            AddHolidays(DateTime.Now.Year);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            List<int> values = new List<int> { 2, 3, 5, 7, 10 };
            comboBox1.DataSource = values;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                if (dateTimePicker1.Value > DateTime.Now)
                {
                    label2.Text = "Ημ/νία Παραγγελίας :";
                    return;
                }
                TimeSpan countworkingdays = DateTime.Now - dateTimePicker1.Value;
                int workingDays = Enumerable.Range(0, (int)countworkingdays.TotalDays)
                .Select(i => dateTimePicker1.Value.AddDays(i))
                .Count(d => (d.DayOfWeek != DayOfWeek.Saturday && d.DayOfWeek != DayOfWeek.Sunday) && !cyprusHolidays.Contains(d.Date));
                
                label5.Text = $"{workingDays} εργάσιμες μέρες.";
            }

            // check if the selected year is different from the current year
            if (dateTimePicker1.Value.Year != DateTime.Now.Year)
            {
                // clear the previous year holidays
                //cyprusHolidays.Clear();
                // add the new year holidays
                AddHolidays(dateTimePicker1.Value.Year);
            }

            //Δικαίωμα Επιστροφής//
            TimeSpan doadays = DateTime.Now - dateTimePicker1.Value;

            if (doadays.Days <= 7)
            {
                label10.Text = "DOA";
                label10.ForeColor = Color.Green;
                label10.Font = new Font(label10.Font, FontStyle.Bold);
                label11.Text = "Online Return";
                label11.ForeColor = Color.Green;
                label11.Font = new Font(label11.Font, FontStyle.Bold);
            }
            else if (doadays.Days >= 8 && doadays.Days < 15)
            {
                label10.Text = "DOA expired";
                label10.ForeColor = Color.Red;
                label10.Font = new Font(label10.Font, FontStyle.Bold);
                label11.Text = "Online Return";
                label11.ForeColor = Color.Green;
                label11.Font = new Font(label11.Font, FontStyle.Bold);
            }
            else if (doadays.Days > 15)
            {
                label10.Text = "DOA expired";
                label10.ForeColor = Color.Red;
                label10.Font = new Font(label10.Font, FontStyle.Bold);
                label11.Text = "NO Return !!";
                label11.ForeColor = Color.Red;
                label11.Font = new Font(label11.Font, FontStyle.Bold);
            }

            //Ημέρες Εγγύησης//
            int minusYears = int.Parse(comboBox1.Text);
            DateTime pastDate = DateTime.Now.AddYears(-minusYears);
            DateTime givenDate = dateTimePicker1.Value.Date;
            TimeSpan difference1 = givenDate - pastDate;
            int days = (int)difference1.Days;

            if (days >= 0)
            {
                label6.Text = "Η εγγύηση ισχύει για ακόμα " + days + " ημέρες";
                label6.ForeColor = Color.Green;
                label6.Font = new Font(label1.Font, FontStyle.Regular);
            }

            else
            {
                label6.Text = "Εκτός εγγύησης εδώ και " + days + " ημέρες";
                label6.ForeColor = Color.Red;
                label6.Font = new Font(label1.Font, FontStyle.Bold);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            label6.ForeColor = Color.Black;
            dateTimePicker1_ValueChanged(sender, e);
            comboBox1.SelectedIndex = 0;
            Clipboard.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text1);
            Clipboard.SetDataObject(data);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text2);
            Clipboard.SetDataObject(data);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text3);
            Clipboard.SetDataObject(data);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text4);
            Clipboard.SetDataObject(data);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text5);
            Clipboard.SetDataObject(data);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text6);
            Clipboard.SetDataObject(data);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text7);
            Clipboard.SetDataObject(data);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form form = (Form)((Button)sender).Parent;
            Button toggleButton = (Button)sender;

            if (toggleButton.Text == "more")
            {
                form.Size = new Size(Width = 500, Height = 523);
                toggleButton.Text = "less";
            }
            else
            {
                form.Size = new Size(Width = 500, Height = 234);
                toggleButton.Text = "more";
            }
        }
    }
}
