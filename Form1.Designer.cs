namespace SMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CompleteButton = new System.Windows.Forms.Button();
            this.RepairButton = new System.Windows.Forms.Button();
            this.ReplacedButton = new System.Windows.Forms.Button();
            this.ContactButton = new System.Windows.Forms.Button();
            this.VoucherFaultyButton = new System.Windows.Forms.Button();
            this.VoucherButton = new System.Windows.Forms.Button();
            this.ManufacturerButton = new System.Windows.Forms.Button();
            this.VoucherSMSButton = new System.Windows.Forms.Button();
            this.ReturnMoneySMSButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.CalendarTabPage = new System.Windows.Forms.TabPage();
            this.ReturnLabel = new System.Windows.Forms.Label();
            this.DOALabel = new System.Windows.Forms.Label();
            this.NextHolidayLabel = new System.Windows.Forms.Label();
            this.HolidayLabel = new System.Windows.Forms.Label();
            this.WarrantyComboBox = new System.Windows.Forms.ComboBox();
            this.ResetCalendar = new System.Windows.Forms.Button();
            this.WarrantyDays = new System.Windows.Forms.Label();
            this.WarrantyLabel = new System.Windows.Forms.Label();
            this.DaysPassedLabel = new System.Windows.Forms.Label();
            this.CurrentDateLabel = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.TodayLabel = new System.Windows.Forms.Label();
            this.NotesPage = new System.Windows.Forms.TabPage();
            this.CancelComboBox = new System.Windows.Forms.ComboBox();
            this.CancelLabel = new System.Windows.Forms.Label();
            this.InformComboBox = new System.Windows.Forms.ComboBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.NotesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.InformLabel = new System.Windows.Forms.Label();
            this.SMSTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.DeveloperLabel = new System.Windows.Forms.Label();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.TabControl.SuspendLayout();
            this.CalendarTabPage.SuspendLayout();
            this.NotesPage.SuspendLayout();
            this.SMSTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompleteButton
            // 
            this.CompleteButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompleteButton.Location = new System.Drawing.Point(10, 10);
            this.CompleteButton.Margin = new System.Windows.Forms.Padding(7);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(200, 35);
            this.CompleteButton.TabIndex = 16;
            this.CompleteButton.Text = "Ολοκλήρωση Ελεγχου";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // RepairButton
            // 
            this.RepairButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepairButton.Location = new System.Drawing.Point(10, 58);
            this.RepairButton.Margin = new System.Windows.Forms.Padding(7);
            this.RepairButton.Name = "RepairButton";
            this.RepairButton.Size = new System.Drawing.Size(200, 35);
            this.RepairButton.TabIndex = 17;
            this.RepairButton.Text = "Ολοκλήρωση Επισκευής";
            this.RepairButton.UseVisualStyleBackColor = true;
            this.RepairButton.Click += new System.EventHandler(this.RepairButton_Click);
            // 
            // ReplacedButton
            // 
            this.ReplacedButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReplacedButton.Location = new System.Drawing.Point(10, 106);
            this.ReplacedButton.Margin = new System.Windows.Forms.Padding(7);
            this.ReplacedButton.Name = "ReplacedButton";
            this.ReplacedButton.Size = new System.Drawing.Size(200, 35);
            this.ReplacedButton.TabIndex = 18;
            this.ReplacedButton.Text = "Αντικατάσταση";
            this.ReplacedButton.UseVisualStyleBackColor = true;
            this.ReplacedButton.Click += new System.EventHandler(this.ReplacedButton_Click);
            // 
            // ContactButton
            // 
            this.ContactButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactButton.Location = new System.Drawing.Point(10, 154);
            this.ContactButton.Margin = new System.Windows.Forms.Padding(7);
            this.ContactButton.Name = "ContactButton";
            this.ContactButton.Size = new System.Drawing.Size(200, 35);
            this.ContactButton.TabIndex = 19;
            this.ContactButton.Text = "Επικοινωνήστε μαζί μας";
            this.ContactButton.UseVisualStyleBackColor = true;
            this.ContactButton.Click += new System.EventHandler(this.ContactButton_Click);
            // 
            // VoucherFaultyButton
            // 
            this.VoucherFaultyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoucherFaultyButton.Location = new System.Drawing.Point(264, 10);
            this.VoucherFaultyButton.Margin = new System.Windows.Forms.Padding(7);
            this.VoucherFaultyButton.Name = "VoucherFaultyButton";
            this.VoucherFaultyButton.Size = new System.Drawing.Size(200, 35);
            this.VoucherFaultyButton.TabIndex = 20;
            this.VoucherFaultyButton.Text = "Πίστωση Ελαττωματικού";
            this.VoucherFaultyButton.UseVisualStyleBackColor = true;
            this.VoucherFaultyButton.Click += new System.EventHandler(this.VoucherFaultyButton_Click);
            // 
            // VoucherButton
            // 
            this.VoucherButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoucherButton.Location = new System.Drawing.Point(264, 55);
            this.VoucherButton.Margin = new System.Windows.Forms.Padding(7);
            this.VoucherButton.Name = "VoucherButton";
            this.VoucherButton.Size = new System.Drawing.Size(200, 35);
            this.VoucherButton.TabIndex = 21;
            this.VoucherButton.Text = "Πίστωση";
            this.VoucherButton.UseVisualStyleBackColor = true;
            this.VoucherButton.Click += new System.EventHandler(this.VoucherButton_Click);
            // 
            // ManufacturerButton
            // 
            this.ManufacturerButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManufacturerButton.Location = new System.Drawing.Point(264, 103);
            this.ManufacturerButton.Margin = new System.Windows.Forms.Padding(7);
            this.ManufacturerButton.Name = "ManufacturerButton";
            this.ManufacturerButton.Size = new System.Drawing.Size(200, 35);
            this.ManufacturerButton.TabIndex = 22;
            this.ManufacturerButton.Text = "Αποστολή στην Αντιπροσωπεία";
            this.ManufacturerButton.UseVisualStyleBackColor = true;
            this.ManufacturerButton.Click += new System.EventHandler(this.ManufacturerButton_Click);
            // 
            // VoucherSMSButton
            // 
            this.VoucherSMSButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoucherSMSButton.Location = new System.Drawing.Point(3, 35);
            this.VoucherSMSButton.Name = "VoucherSMSButton";
            this.VoucherSMSButton.Size = new System.Drawing.Size(98, 35);
            this.VoucherSMSButton.TabIndex = 35;
            this.VoucherSMSButton.Text = "Πίστωση";
            this.VoucherSMSButton.UseVisualStyleBackColor = true;
            this.VoucherSMSButton.Click += new System.EventHandler(this.VoucherSMSButton_Click);
            // 
            // ReturnMoneySMSButton
            // 
            this.ReturnMoneySMSButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnMoneySMSButton.Location = new System.Drawing.Point(118, 35);
            this.ReturnMoneySMSButton.Name = "ReturnMoneySMSButton";
            this.ReturnMoneySMSButton.Size = new System.Drawing.Size(98, 35);
            this.ReturnMoneySMSButton.TabIndex = 36;
            this.ReturnMoneySMSButton.Text = "Επιστροφή";
            this.ReturnMoneySMSButton.UseVisualStyleBackColor = true;
            this.ReturnMoneySMSButton.Click += new System.EventHandler(this.ReturnMoneySMSButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CalendarTabPage);
            this.TabControl.Controls.Add(this.NotesPage);
            this.TabControl.Controls.Add(this.SMSTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(484, 287);
            this.TabControl.TabIndex = 40;
            // 
            // CalendarTabPage
            // 
            this.CalendarTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.CalendarTabPage.Controls.Add(this.ReturnLabel);
            this.CalendarTabPage.Controls.Add(this.DOALabel);
            this.CalendarTabPage.Controls.Add(this.NextHolidayLabel);
            this.CalendarTabPage.Controls.Add(this.HolidayLabel);
            this.CalendarTabPage.Controls.Add(this.WarrantyComboBox);
            this.CalendarTabPage.Controls.Add(this.ResetCalendar);
            this.CalendarTabPage.Controls.Add(this.WarrantyDays);
            this.CalendarTabPage.Controls.Add(this.WarrantyLabel);
            this.CalendarTabPage.Controls.Add(this.DaysPassedLabel);
            this.CalendarTabPage.Controls.Add(this.CurrentDateLabel);
            this.CalendarTabPage.Controls.Add(this.DateTimePicker);
            this.CalendarTabPage.Controls.Add(this.DaysLabel);
            this.CalendarTabPage.Controls.Add(this.OrderDateLabel);
            this.CalendarTabPage.Controls.Add(this.TodayLabel);
            this.CalendarTabPage.Location = new System.Drawing.Point(4, 24);
            this.CalendarTabPage.Name = "CalendarTabPage";
            this.CalendarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CalendarTabPage.Size = new System.Drawing.Size(476, 259);
            this.CalendarTabPage.TabIndex = 0;
            this.CalendarTabPage.Text = "Ημερολόγιο";
            // 
            // ReturnLabel
            // 
            this.ReturnLabel.AutoSize = true;
            this.ReturnLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnLabel.Location = new System.Drawing.Point(367, 87);
            this.ReturnLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.ReturnLabel.Name = "ReturnLabel";
            this.ReturnLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ReturnLabel.Size = new System.Drawing.Size(42, 23);
            this.ReturnLabel.TabIndex = 40;
            this.ReturnLabel.Text = "Return";
            // 
            // DOALabel
            // 
            this.DOALabel.AutoSize = true;
            this.DOALabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOALabel.Location = new System.Drawing.Point(291, 87);
            this.DOALabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.DOALabel.Name = "DOALabel";
            this.DOALabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.DOALabel.Size = new System.Drawing.Size(31, 23);
            this.DOALabel.TabIndex = 39;
            this.DOALabel.Text = "DOA";
            // 
            // NextHolidayLabel
            // 
            this.NextHolidayLabel.AutoSize = true;
            this.NextHolidayLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextHolidayLabel.Location = new System.Drawing.Point(45, 190);
            this.NextHolidayLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.NextHolidayLabel.Name = "NextHolidayLabel";
            this.NextHolidayLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.NextHolidayLabel.Size = new System.Drawing.Size(91, 23);
            this.NextHolidayLabel.TabIndex = 37;
            this.NextHolidayLabel.Text = "Επόμενη Αργία :";
            // 
            // HolidayLabel
            // 
            this.HolidayLabel.AutoSize = true;
            this.HolidayLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HolidayLabel.Location = new System.Drawing.Point(149, 190);
            this.HolidayLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.HolidayLabel.Name = "HolidayLabel";
            this.HolidayLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.HolidayLabel.Size = new System.Drawing.Size(85, 23);
            this.HolidayLabel.TabIndex = 36;
            this.HolidayLabel.Text = "Επόμενη Αργία";
            // 
            // WarrantyComboBox
            // 
            this.WarrantyComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WarrantyComboBox.FormattingEnabled = true;
            this.WarrantyComboBox.Location = new System.Drawing.Point(95, 125);
            this.WarrantyComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WarrantyComboBox.Name = "WarrantyComboBox";
            this.WarrantyComboBox.Size = new System.Drawing.Size(41, 21);
            this.WarrantyComboBox.TabIndex = 35;
            this.WarrantyComboBox.SelectedIndexChanged += new System.EventHandler(this.WarrantyComboBox_SelectedIndexChanged);
            // 
            // ResetCalendar
            // 
            this.ResetCalendar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetCalendar.Location = new System.Drawing.Point(7, 155);
            this.ResetCalendar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResetCalendar.Name = "ResetCalendar";
            this.ResetCalendar.Size = new System.Drawing.Size(460, 30);
            this.ResetCalendar.TabIndex = 34;
            this.ResetCalendar.Text = "Επαναφορά";
            this.ResetCalendar.UseVisualStyleBackColor = true;
            this.ResetCalendar.Click += new System.EventHandler(this.ResetCalendar_Click);
            // 
            // WarrantyDays
            // 
            this.WarrantyDays.AutoSize = true;
            this.WarrantyDays.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WarrantyDays.Location = new System.Drawing.Point(149, 124);
            this.WarrantyDays.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.WarrantyDays.Name = "WarrantyDays";
            this.WarrantyDays.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.WarrantyDays.Size = new System.Drawing.Size(149, 23);
            this.WarrantyDays.TabIndex = 33;
            this.WarrantyDays.Text = "Επέλεξε ημερομηνία πρώτα";
            // 
            // WarrantyLabel
            // 
            this.WarrantyLabel.AutoSize = true;
            this.WarrantyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WarrantyLabel.Location = new System.Drawing.Point(28, 124);
            this.WarrantyLabel.Margin = new System.Windows.Forms.Padding(5, 5, 4, 5);
            this.WarrantyLabel.Name = "WarrantyLabel";
            this.WarrantyLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.WarrantyLabel.Size = new System.Drawing.Size(59, 23);
            this.WarrantyLabel.TabIndex = 32;
            this.WarrantyLabel.Text = "Εγγύηση :";
            // 
            // DaysPassedLabel
            // 
            this.DaysPassedLabel.AutoSize = true;
            this.DaysPassedLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DaysPassedLabel.Location = new System.Drawing.Point(149, 87);
            this.DaysPassedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DaysPassedLabel.Name = "DaysPassedLabel";
            this.DaysPassedLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.DaysPassedLabel.Size = new System.Drawing.Size(117, 23);
            this.DaysPassedLabel.TabIndex = 31;
            this.DaysPassedLabel.Text = "Ημέρες που πέρασαν";
            // 
            // CurrentDateLabel
            // 
            this.CurrentDateLabel.AutoSize = true;
            this.CurrentDateLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentDateLabel.Location = new System.Drawing.Point(149, 11);
            this.CurrentDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentDateLabel.Name = "CurrentDateLabel";
            this.CurrentDateLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.CurrentDateLabel.Size = new System.Drawing.Size(122, 23);
            this.CurrentDateLabel.TabIndex = 30;
            this.CurrentDateLabel.Text = "Σημερινή Ημερομηνία";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "dd/MM/yy";
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePicker.Location = new System.Drawing.Point(149, 49);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DateTimePicker.MinDate = new System.DateTime(1997, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(240, 22);
            this.DateTimePicker.TabIndex = 29;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DaysLabel.Location = new System.Drawing.Point(47, 87);
            this.DaysLabel.Margin = new System.Windows.Forms.Padding(5, 5, 4, 5);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.DaysLabel.Size = new System.Drawing.Size(89, 23);
            this.DaysLabel.TabIndex = 28;
            this.DaysLabel.Text = "Έχουν περάσει :";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderDateLabel.Location = new System.Drawing.Point(19, 49);
            this.OrderDateLabel.Margin = new System.Windows.Forms.Padding(5, 5, 4, 5);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.OrderDateLabel.Size = new System.Drawing.Size(117, 23);
            this.OrderDateLabel.TabIndex = 27;
            this.OrderDateLabel.Text = "Ημ/νία Παραγγελίας :";
            // 
            // TodayLabel
            // 
            this.TodayLabel.AutoSize = true;
            this.TodayLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TodayLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TodayLabel.Location = new System.Drawing.Point(57, 11);
            this.TodayLabel.Margin = new System.Windows.Forms.Padding(5, 5, 4, 5);
            this.TodayLabel.Name = "TodayLabel";
            this.TodayLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.TodayLabel.Size = new System.Drawing.Size(79, 23);
            this.TodayLabel.TabIndex = 26;
            this.TodayLabel.Text = "Σήμερα είναι :";
            // 
            // NotesPage
            // 
            this.NotesPage.BackColor = System.Drawing.SystemColors.Control;
            this.NotesPage.Controls.Add(this.CancelComboBox);
            this.NotesPage.Controls.Add(this.CancelLabel);
            this.NotesPage.Controls.Add(this.InformComboBox);
            this.NotesPage.Controls.Add(this.ClearButton);
            this.NotesPage.Controls.Add(this.CopyButton);
            this.NotesPage.Controls.Add(this.NotesRichTextBox);
            this.NotesPage.Controls.Add(this.InformLabel);
            this.NotesPage.Location = new System.Drawing.Point(4, 24);
            this.NotesPage.Name = "NotesPage";
            this.NotesPage.Padding = new System.Windows.Forms.Padding(3);
            this.NotesPage.Size = new System.Drawing.Size(476, 259);
            this.NotesPage.TabIndex = 1;
            this.NotesPage.Text = "Σημειώσεις";
            // 
            // CancelComboBox
            // 
            this.CancelComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelComboBox.FormattingEnabled = true;
            this.CancelComboBox.Items.AddRange(new object[] {
            "Πρόβλημα διαθεσιμότητας προϊόντος",
            "Καθυστέρηση απάντησης από πελάτη",
            "Καθυστέρηση παραλαβής από προμηθευτή",
            "Καθυστέρηση παραλαβής από πελάτη",
            "Ζήτησε ακύρωση παραγγελίας χωρίς αιτιολογία (e-mail)",
            "Ζήτησε ακύρωση παραγγελίας χωρίς αιτιολογία (τηλέφωνο)",
            "Ζήτησε ακύρωση παραγγελίας χωρίς αιτιολογία (κατάστημα)",
            "Διπλή παραγγελία",
            "Λάθος παραγγελία από πωλητή",
            "Λάθος παραγγελία από πελάτη",
            "Μεταφορά σε άλλη παραγγελία",
            "Αδυναμία επικοινωνίας με τον πελάτη"});
            this.CancelComboBox.Location = new System.Drawing.Point(76, 69);
            this.CancelComboBox.Name = "CancelComboBox";
            this.CancelComboBox.Size = new System.Drawing.Size(338, 21);
            this.CancelComboBox.TabIndex = 46;
            this.CancelComboBox.SelectedIndexChanged += new System.EventHandler(this.CancelComboBox_SelectedIndexChanged);
            // 
            // CancelLabel
            // 
            this.CancelLabel.AutoSize = true;
            this.CancelLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelLabel.Location = new System.Drawing.Point(199, 53);
            this.CancelLabel.Name = "CancelLabel";
            this.CancelLabel.Size = new System.Drawing.Size(93, 13);
            this.CancelLabel.TabIndex = 45;
            this.CancelLabel.Text = "Αιτία ακύρωσης:";
            // 
            // InformComboBox
            // 
            this.InformComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InformComboBox.FormattingEnabled = true;
            this.InformComboBox.Items.AddRange(new object[] {
            "3-4 εργάσιμες μέρες",
            "10-15 εργάσιμες μέρες",
            "ημ/νία παραλαβής"});
            this.InformComboBox.Location = new System.Drawing.Point(76, 29);
            this.InformComboBox.Name = "InformComboBox";
            this.InformComboBox.Size = new System.Drawing.Size(338, 21);
            this.InformComboBox.TabIndex = 44;
            this.InformComboBox.SelectedIndexChanged += new System.EventHandler(this.InformComboBox_SelectedIndexChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(6, 171);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 35);
            this.ClearButton.TabIndex = 43;
            this.ClearButton.Text = "Διαγραφή Όλων";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CopyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopyButton.Location = new System.Drawing.Point(318, 171);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(150, 35);
            this.CopyButton.TabIndex = 42;
            this.CopyButton.Text = "Αντιγραφή";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // NotesRichTextBox
            // 
            this.NotesRichTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotesRichTextBox.Location = new System.Drawing.Point(6, 100);
            this.NotesRichTextBox.Name = "NotesRichTextBox";
            this.NotesRichTextBox.Size = new System.Drawing.Size(462, 65);
            this.NotesRichTextBox.TabIndex = 41;
            this.NotesRichTextBox.Text = "";
            // 
            // InformLabel
            // 
            this.InformLabel.AutoSize = true;
            this.InformLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InformLabel.Location = new System.Drawing.Point(166, 13);
            this.InformLabel.Name = "InformLabel";
            this.InformLabel.Size = new System.Drawing.Size(159, 13);
            this.InformLabel.TabIndex = 40;
            this.InformLabel.Text = "Ο πελάτης ενημερώθηκε για :";
            // 
            // SMSTabPage
            // 
            this.SMSTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.SMSTabPage.Controls.Add(this.panel1);
            this.SMSTabPage.Controls.Add(this.ManufacturerButton);
            this.SMSTabPage.Controls.Add(this.ReplacedButton);
            this.SMSTabPage.Controls.Add(this.ContactButton);
            this.SMSTabPage.Controls.Add(this.CompleteButton);
            this.SMSTabPage.Controls.Add(this.RepairButton);
            this.SMSTabPage.Controls.Add(this.VoucherFaultyButton);
            this.SMSTabPage.Controls.Add(this.VoucherButton);
            this.SMSTabPage.Location = new System.Drawing.Point(4, 24);
            this.SMSTabPage.Name = "SMSTabPage";
            this.SMSTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SMSTabPage.Size = new System.Drawing.Size(476, 259);
            this.SMSTabPage.TabIndex = 2;
            this.SMSTabPage.Text = "SMS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ReturnMoneySMSButton);
            this.panel1.Controls.Add(this.VoucherSMSButton);
            this.panel1.Location = new System.Drawing.Point(247, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 75);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Σημειώσεις";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.Location = new System.Drawing.Point(19, 260);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(62, 15);
            this.UserLabel.TabIndex = 42;
            this.UserLabel.Text = "Χρήστης :";
            // 
            // DeveloperLabel
            // 
            this.DeveloperLabel.AutoSize = true;
            this.DeveloperLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeveloperLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeveloperLabel.Location = new System.Drawing.Point(349, 260);
            this.DeveloperLabel.Name = "DeveloperLabel";
            this.DeveloperLabel.Size = new System.Drawing.Size(105, 15);
            this.DeveloperLabel.TabIndex = 44;
            this.DeveloperLabel.Text = "Developed by A.I.";
            // 
            // UserComboBox
            // 
            this.UserComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Items.AddRange(new object[] {
            "ΠΑΥΛΟΣ",
            "ΑΧΙΛΛΕΑΣ",
            "ΜΑΡΙΟΣ",
            "ΒΛΑΔΙΜΗΡΟΣ",
            "ΠΑΡΑΣΚΕΥΑΣ"});
            this.UserComboBox.Location = new System.Drawing.Point(85, 257);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(145, 23);
            this.UserComboBox.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 287);
            this.Controls.Add(this.UserComboBox);
            this.Controls.Add(this.DeveloperLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(500, 326);
            this.MinimumSize = new System.Drawing.Size(500, 326);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Shop v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.CalendarTabPage.ResumeLayout(false);
            this.CalendarTabPage.PerformLayout();
            this.NotesPage.ResumeLayout(false);
            this.NotesPage.PerformLayout();
            this.SMSTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker DateTimePicker;
        private Button CompleteButton;
        private Button RepairButton;
        private Button ReplacedButton;
        private Button ContactButton;
        private Button VoucherFaultyButton;
        private Button VoucherButton;
        private Button ManufacturerButton;
        private Button VoucherSMSButton;
        private Button ReturnMoneySMSButton;
        private Button ResetCalendar;
        private Button ClearButton;
        private Button CopyButton;
        private ComboBox CancelComboBox;
        private ComboBox WarrantyComboBox;
        private ComboBox InformComboBox;
        private TabControl TabControl;
        private TabPage CalendarTabPage;
        private TabPage NotesPage;
        private TabPage SMSTabPage;
        private Label CancelLabel;
        private Label InformLabel;
        private Label ReturnLabel;
        private Label DOALabel;
        private Label NextHolidayLabel;
        private Label HolidayLabel;
        private Label WarrantyDays;
        private Label WarrantyLabel;
        private Label DaysPassedLabel;
        private Label CurrentDateLabel;
        private Label DaysLabel;
        private Label OrderDateLabel;
        private Label TodayLabel;
        private Label UserLabel;
        private RichTextBox NotesRichTextBox;
        private Label DeveloperLabel;
        private ComboBox UserComboBox;
        private Panel panel1;
        private Label label1;
    }
}