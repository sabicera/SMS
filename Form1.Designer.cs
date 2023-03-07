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
            CompleteButton = new Button();
            RepairButton = new Button();
            ReplacedButton = new Button();
            ContactButton = new Button();
            VoucherFaultyButton = new Button();
            VoucherButton = new Button();
            MoneybackButton = new Button();
            TabControl = new TabControl();
            CalendarTabPage = new TabPage();
            UserComboBox = new ComboBox();
            UserLabel = new Label();
            ReturnLabel = new Label();
            DOALabel = new Label();
            NextHolidayLabel = new Label();
            HolidayLabel = new Label();
            WarrantyComboBox = new ComboBox();
            ResetCalendar = new Button();
            WarrantyDays = new Label();
            WarrantyLabel = new Label();
            DaysPassedLabel = new Label();
            CurrentDateLabel = new Label();
            DateTimePicker = new DateTimePicker();
            DaysLabel = new Label();
            OrderDateLabel = new Label();
            TodayLabel = new Label();
            NotesPage = new TabPage();
            SameFromGRButton = new Button();
            SentToRepairΒutton = new Button();
            ReturnMoneyServiceButton = new Button();
            VoucherServiceButton = new Button();
            CancelComboBox = new ComboBox();
            CancelLabel = new Label();
            InformComboBox = new ComboBox();
            ClearButton = new Button();
            CopyButton = new Button();
            NotesRichTextBox = new RichTextBox();
            InformLabel = new Label();
            SMSTabPage = new TabPage();
            ManufacturerButton = new Button();
            LanguageLabel = new Label();
            LanguageComboBox = new ComboBox();
            TabControl.SuspendLayout();
            CalendarTabPage.SuspendLayout();
            NotesPage.SuspendLayout();
            SMSTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // CompleteButton
            // 
            CompleteButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CompleteButton.Location = new Point(7, 52);
            CompleteButton.Margin = new Padding(7);
            CompleteButton.Name = "CompleteButton";
            CompleteButton.Size = new Size(200, 35);
            CompleteButton.TabIndex = 16;
            CompleteButton.Text = "Ολοκλήρωση Ελεγχου";
            CompleteButton.UseVisualStyleBackColor = true;
            CompleteButton.Click += CompleteButton_Click;
            // 
            // RepairButton
            // 
            RepairButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            RepairButton.Location = new Point(7, 100);
            RepairButton.Margin = new Padding(7);
            RepairButton.Name = "RepairButton";
            RepairButton.Size = new Size(200, 35);
            RepairButton.TabIndex = 2;
            RepairButton.Text = "Ολοκλήρωση Επισκευής";
            RepairButton.UseVisualStyleBackColor = true;
            RepairButton.Click += RepairButton_Click;
            // 
            // ReplacedButton
            // 
            ReplacedButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReplacedButton.Location = new Point(7, 148);
            ReplacedButton.Margin = new Padding(7);
            ReplacedButton.Name = "ReplacedButton";
            ReplacedButton.Size = new Size(200, 35);
            ReplacedButton.TabIndex = 3;
            ReplacedButton.Text = "Αντικατάσταση";
            ReplacedButton.UseVisualStyleBackColor = true;
            ReplacedButton.Click += ReplacedButton_Click;
            // 
            // ContactButton
            // 
            ContactButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ContactButton.Location = new Point(7, 196);
            ContactButton.Margin = new Padding(7);
            ContactButton.Name = "ContactButton";
            ContactButton.Size = new Size(200, 35);
            ContactButton.TabIndex = 4;
            ContactButton.Text = "Επικοινωνήστε μαζί μας";
            ContactButton.UseVisualStyleBackColor = true;
            ContactButton.Click += ContactButton_Click;
            // 
            // VoucherFaultyButton
            // 
            VoucherFaultyButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            VoucherFaultyButton.Location = new Point(269, 52);
            VoucherFaultyButton.Margin = new Padding(7);
            VoucherFaultyButton.Name = "VoucherFaultyButton";
            VoucherFaultyButton.Size = new Size(200, 35);
            VoucherFaultyButton.TabIndex = 5;
            VoucherFaultyButton.Text = "Πίστωση Ελαττωματικού";
            VoucherFaultyButton.UseVisualStyleBackColor = true;
            VoucherFaultyButton.Click += VoucherFaultyButton_Click;
            // 
            // VoucherButton
            // 
            VoucherButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            VoucherButton.Location = new Point(269, 100);
            VoucherButton.Margin = new Padding(7);
            VoucherButton.Name = "VoucherButton";
            VoucherButton.Size = new Size(200, 35);
            VoucherButton.TabIndex = 6;
            VoucherButton.Text = "Πίστωση";
            VoucherButton.UseVisualStyleBackColor = true;
            VoucherButton.Click += VoucherButton_Click;
            // 
            // MoneybackButton
            // 
            MoneybackButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MoneybackButton.Location = new Point(269, 148);
            MoneybackButton.Margin = new Padding(7);
            MoneybackButton.Name = "MoneybackButton";
            MoneybackButton.Size = new Size(200, 35);
            MoneybackButton.TabIndex = 7;
            MoneybackButton.Text = "Επιστροφή Χρημάτων";
            MoneybackButton.UseVisualStyleBackColor = true;
            MoneybackButton.Click += MoneybackButton_Click;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(CalendarTabPage);
            TabControl.Controls.Add(NotesPage);
            TabControl.Controls.Add(SMSTabPage);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(484, 287);
            TabControl.TabIndex = 1;
            // 
            // CalendarTabPage
            // 
            CalendarTabPage.BackColor = SystemColors.Control;
            CalendarTabPage.Controls.Add(UserComboBox);
            CalendarTabPage.Controls.Add(UserLabel);
            CalendarTabPage.Controls.Add(ReturnLabel);
            CalendarTabPage.Controls.Add(DOALabel);
            CalendarTabPage.Controls.Add(NextHolidayLabel);
            CalendarTabPage.Controls.Add(HolidayLabel);
            CalendarTabPage.Controls.Add(WarrantyComboBox);
            CalendarTabPage.Controls.Add(ResetCalendar);
            CalendarTabPage.Controls.Add(WarrantyDays);
            CalendarTabPage.Controls.Add(WarrantyLabel);
            CalendarTabPage.Controls.Add(DaysPassedLabel);
            CalendarTabPage.Controls.Add(CurrentDateLabel);
            CalendarTabPage.Controls.Add(DateTimePicker);
            CalendarTabPage.Controls.Add(DaysLabel);
            CalendarTabPage.Controls.Add(OrderDateLabel);
            CalendarTabPage.Controls.Add(TodayLabel);
            CalendarTabPage.Location = new Point(4, 24);
            CalendarTabPage.Name = "CalendarTabPage";
            CalendarTabPage.Padding = new Padding(3);
            CalendarTabPage.Size = new Size(476, 259);
            CalendarTabPage.TabIndex = 0;
            CalendarTabPage.Text = "Ημερολόγιο";
            // 
            // UserComboBox
            // 
            UserComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserComboBox.FormattingEnabled = true;
            UserComboBox.Items.AddRange(new object[] { "ΠΑΥΛΟΣ", "ΑΧΙΛΛΕΑΣ", "ΜΑΡΙΟΣ", "ΒΛΑΔΙΜΗΡΟΣ", "ΠΑΡΑΣΚΕΥΑΣ" });
            UserComboBox.Location = new Point(81, 230);
            UserComboBox.Name = "UserComboBox";
            UserComboBox.Size = new Size(129, 23);
            UserComboBox.TabIndex = 900;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserLabel.Location = new Point(15, 233);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(62, 15);
            UserLabel.TabIndex = 46;
            UserLabel.Text = "Χρήστης :";
            // 
            // ReturnLabel
            // 
            ReturnLabel.AutoSize = true;
            ReturnLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnLabel.Location = new Point(367, 87);
            ReturnLabel.Margin = new Padding(9, 0, 9, 0);
            ReturnLabel.Name = "ReturnLabel";
            ReturnLabel.Padding = new Padding(0, 5, 0, 5);
            ReturnLabel.Size = new Size(42, 23);
            ReturnLabel.TabIndex = 40;
            ReturnLabel.Text = "Return";
            // 
            // DOALabel
            // 
            DOALabel.AutoSize = true;
            DOALabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            DOALabel.Location = new Point(291, 87);
            DOALabel.Margin = new Padding(9, 0, 9, 0);
            DOALabel.Name = "DOALabel";
            DOALabel.Padding = new Padding(0, 5, 0, 5);
            DOALabel.Size = new Size(31, 23);
            DOALabel.TabIndex = 39;
            DOALabel.Text = "DOA";
            // 
            // NextHolidayLabel
            // 
            NextHolidayLabel.AutoSize = true;
            NextHolidayLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            NextHolidayLabel.Location = new Point(45, 190);
            NextHolidayLabel.Margin = new Padding(9, 0, 9, 0);
            NextHolidayLabel.Name = "NextHolidayLabel";
            NextHolidayLabel.Padding = new Padding(0, 5, 0, 5);
            NextHolidayLabel.Size = new Size(91, 23);
            NextHolidayLabel.TabIndex = 37;
            NextHolidayLabel.Text = "Επόμενη Αργία :";
            // 
            // HolidayLabel
            // 
            HolidayLabel.AutoSize = true;
            HolidayLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            HolidayLabel.Location = new Point(149, 190);
            HolidayLabel.Margin = new Padding(9, 0, 9, 0);
            HolidayLabel.Name = "HolidayLabel";
            HolidayLabel.Padding = new Padding(0, 5, 0, 5);
            HolidayLabel.Size = new Size(85, 23);
            HolidayLabel.TabIndex = 36;
            HolidayLabel.Text = "Επόμενη Αργία";
            // 
            // WarrantyComboBox
            // 
            WarrantyComboBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            WarrantyComboBox.FormattingEnabled = true;
            WarrantyComboBox.Location = new Point(95, 124);
            WarrantyComboBox.Margin = new Padding(4, 3, 4, 3);
            WarrantyComboBox.Name = "WarrantyComboBox";
            WarrantyComboBox.Size = new Size(41, 21);
            WarrantyComboBox.TabIndex = 2;
            WarrantyComboBox.SelectedIndexChanged += WarrantyComboBox_SelectedIndexChanged;
            // 
            // ResetCalendar
            // 
            ResetCalendar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ResetCalendar.Location = new Point(7, 155);
            ResetCalendar.Margin = new Padding(4, 3, 4, 3);
            ResetCalendar.Name = "ResetCalendar";
            ResetCalendar.Size = new Size(460, 30);
            ResetCalendar.TabIndex = 3;
            ResetCalendar.Text = "Επαναφορά";
            ResetCalendar.UseVisualStyleBackColor = true;
            ResetCalendar.Click += ResetCalendar_Click;
            // 
            // WarrantyDays
            // 
            WarrantyDays.AutoSize = true;
            WarrantyDays.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            WarrantyDays.Location = new Point(149, 123);
            WarrantyDays.Margin = new Padding(9, 0, 9, 0);
            WarrantyDays.Name = "WarrantyDays";
            WarrantyDays.Padding = new Padding(0, 5, 0, 5);
            WarrantyDays.Size = new Size(149, 23);
            WarrantyDays.TabIndex = 33;
            WarrantyDays.Text = "Επέλεξε ημερομηνία πρώτα";
            // 
            // WarrantyLabel
            // 
            WarrantyLabel.AutoSize = true;
            WarrantyLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            WarrantyLabel.Location = new Point(28, 123);
            WarrantyLabel.Margin = new Padding(5, 5, 4, 5);
            WarrantyLabel.Name = "WarrantyLabel";
            WarrantyLabel.Padding = new Padding(0, 5, 0, 5);
            WarrantyLabel.Size = new Size(59, 23);
            WarrantyLabel.TabIndex = 32;
            WarrantyLabel.Text = "Εγγύηση :";
            // 
            // DaysPassedLabel
            // 
            DaysPassedLabel.AutoSize = true;
            DaysPassedLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            DaysPassedLabel.Location = new Point(149, 87);
            DaysPassedLabel.Margin = new Padding(4, 0, 4, 0);
            DaysPassedLabel.Name = "DaysPassedLabel";
            DaysPassedLabel.Padding = new Padding(0, 5, 0, 5);
            DaysPassedLabel.Size = new Size(117, 23);
            DaysPassedLabel.TabIndex = 31;
            DaysPassedLabel.Text = "Ημέρες που πέρασαν";
            // 
            // CurrentDateLabel
            // 
            CurrentDateLabel.AutoSize = true;
            CurrentDateLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentDateLabel.Location = new Point(149, 11);
            CurrentDateLabel.Margin = new Padding(4, 0, 4, 0);
            CurrentDateLabel.Name = "CurrentDateLabel";
            CurrentDateLabel.Padding = new Padding(0, 5, 0, 5);
            CurrentDateLabel.Size = new Size(122, 23);
            CurrentDateLabel.TabIndex = 30;
            CurrentDateLabel.Text = "Σημερινή Ημερομηνία";
            // 
            // DateTimePicker
            // 
            DateTimePicker.CustomFormat = "dd/MM/yy";
            DateTimePicker.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimePicker.Location = new Point(149, 49);
            DateTimePicker.Margin = new Padding(4, 3, 4, 3);
            DateTimePicker.MinDate = new DateTime(1997, 1, 1, 0, 0, 0, 0);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(240, 22);
            DateTimePicker.TabIndex = 1;
            DateTimePicker.ValueChanged += DateTimePicker1_ValueChanged;
            // 
            // DaysLabel
            // 
            DaysLabel.AutoSize = true;
            DaysLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            DaysLabel.Location = new Point(47, 87);
            DaysLabel.Margin = new Padding(5, 5, 4, 5);
            DaysLabel.Name = "DaysLabel";
            DaysLabel.Padding = new Padding(0, 5, 0, 5);
            DaysLabel.Size = new Size(89, 23);
            DaysLabel.TabIndex = 28;
            DaysLabel.Text = "Έχουν περάσει :";
            // 
            // OrderDateLabel
            // 
            OrderDateLabel.AutoSize = true;
            OrderDateLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            OrderDateLabel.Location = new Point(19, 49);
            OrderDateLabel.Margin = new Padding(5, 5, 4, 5);
            OrderDateLabel.Name = "OrderDateLabel";
            OrderDateLabel.Padding = new Padding(0, 5, 0, 5);
            OrderDateLabel.Size = new Size(117, 23);
            OrderDateLabel.TabIndex = 27;
            OrderDateLabel.Text = "Ημ/νία Παραγγελίας :";
            // 
            // TodayLabel
            // 
            TodayLabel.AutoSize = true;
            TodayLabel.BackColor = SystemColors.Control;
            TodayLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TodayLabel.Location = new Point(57, 11);
            TodayLabel.Margin = new Padding(5, 5, 4, 5);
            TodayLabel.Name = "TodayLabel";
            TodayLabel.Padding = new Padding(0, 5, 0, 5);
            TodayLabel.Size = new Size(79, 23);
            TodayLabel.TabIndex = 26;
            TodayLabel.Text = "Σήμερα είναι :";
            // 
            // NotesPage
            // 
            NotesPage.BackColor = SystemColors.Control;
            NotesPage.Controls.Add(SameFromGRButton);
            NotesPage.Controls.Add(SentToRepairΒutton);
            NotesPage.Controls.Add(ReturnMoneyServiceButton);
            NotesPage.Controls.Add(VoucherServiceButton);
            NotesPage.Controls.Add(CancelComboBox);
            NotesPage.Controls.Add(CancelLabel);
            NotesPage.Controls.Add(InformComboBox);
            NotesPage.Controls.Add(ClearButton);
            NotesPage.Controls.Add(CopyButton);
            NotesPage.Controls.Add(NotesRichTextBox);
            NotesPage.Controls.Add(InformLabel);
            NotesPage.Location = new Point(4, 24);
            NotesPage.Name = "NotesPage";
            NotesPage.Padding = new Padding(3);
            NotesPage.Size = new Size(476, 259);
            NotesPage.TabIndex = 1;
            NotesPage.Text = "Σημειώσεις";
            // 
            // SameFromGRButton
            // 
            SameFromGRButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            SameFromGRButton.Location = new Point(318, 105);
            SameFromGRButton.Name = "SameFromGRButton";
            SameFromGRButton.Size = new Size(150, 30);
            SameFromGRButton.TabIndex = 6;
            SameFromGRButton.Text = "Τροφοδοσία το ίδιο";
            SameFromGRButton.UseVisualStyleBackColor = true;
            SameFromGRButton.Click += SameFromGRButton_Click;
            // 
            // SentToRepairΒutton
            // 
            SentToRepairΒutton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            SentToRepairΒutton.Location = new Point(318, 69);
            SentToRepairΒutton.Name = "SentToRepairΒutton";
            SentToRepairΒutton.Size = new Size(150, 30);
            SentToRepairΒutton.TabIndex = 5;
            SentToRepairΒutton.Text = "Εστάλει Αντιπροσωπεία";
            SentToRepairΒutton.UseVisualStyleBackColor = true;
            SentToRepairΒutton.Click += SentToRepairΒutton_Click;
            // 
            // ReturnMoneyServiceButton
            // 
            ReturnMoneyServiceButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnMoneyServiceButton.Location = new Point(8, 105);
            ReturnMoneyServiceButton.Name = "ReturnMoneyServiceButton";
            ReturnMoneyServiceButton.Size = new Size(150, 30);
            ReturnMoneyServiceButton.TabIndex = 4;
            ReturnMoneyServiceButton.Text = "Επιστροφή Χρημάτων";
            ReturnMoneyServiceButton.UseVisualStyleBackColor = true;
            ReturnMoneyServiceButton.Click += ReturnMoneyServiceButton_Click;
            // 
            // VoucherServiceButton
            // 
            VoucherServiceButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            VoucherServiceButton.Location = new Point(8, 69);
            VoucherServiceButton.Name = "VoucherServiceButton";
            VoucherServiceButton.Size = new Size(150, 30);
            VoucherServiceButton.TabIndex = 3;
            VoucherServiceButton.Text = "Πίστωση";
            VoucherServiceButton.UseVisualStyleBackColor = true;
            VoucherServiceButton.Click += VoucherServiceButton_Click;
            // 
            // CancelComboBox
            // 
            CancelComboBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelComboBox.FormattingEnabled = true;
            CancelComboBox.Items.AddRange(new object[] { "Αδυναμία επικοινωνίας με τον πελάτη", "Διπλή παραγγελία", "Ζήτησε ακύρωση παραγγελίας χωρίς αιτιολογία (e-mail)", "Ζήτησε ακύρωση παραγγελίας χωρίς αιτιολογία (κατάστημα)", "Ζήτησε ακύρωση παραγγελίας χωρίς αιτιολογία (τηλέφωνο)", "Καθυστέρηση απάντησης από πελάτη", "Καθυστέρηση παραλαβής από πελάτη", "Καθυστέρηση παραλαβής από προμηθευτή", "Λάθος παραγγελία από πελάτη", "Λάθος παραγγελία από πωλητή", "Μεταφορά σε άλλη παραγγελία", "Πρόβλημα διαθεσιμότητας προϊόντος" });
            CancelComboBox.Location = new Point(124, 37);
            CancelComboBox.Name = "CancelComboBox";
            CancelComboBox.Size = new Size(344, 21);
            CancelComboBox.TabIndex = 2;
            CancelComboBox.SelectedIndexChanged += CancelComboBox_SelectedIndexChanged;
            // 
            // CancelLabel
            // 
            CancelLabel.AutoSize = true;
            CancelLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelLabel.Location = new Point(22, 41);
            CancelLabel.Name = "CancelLabel";
            CancelLabel.Size = new Size(96, 13);
            CancelLabel.TabIndex = 45;
            CancelLabel.Text = "Αιτία ακύρωσης :";
            // 
            // InformComboBox
            // 
            InformComboBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            InformComboBox.FormattingEnabled = true;
            InformComboBox.Items.AddRange(new object[] { "3-4 εργάσιμες μέρες", "10-15 εργάσιμες μέρες", "ημ/νία παραλαβής" });
            InformComboBox.Location = new Point(173, 10);
            InformComboBox.Name = "InformComboBox";
            InformComboBox.Size = new Size(295, 21);
            InformComboBox.TabIndex = 1;
            InformComboBox.SelectedIndexChanged += InformComboBox_SelectedIndexChanged;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.FromArgb(255, 128, 128);
            ClearButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.Location = new Point(6, 216);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(150, 35);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Διαγραφή Όλων";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.BackColor = Color.FromArgb(192, 255, 192);
            CopyButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CopyButton.Location = new Point(318, 216);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(150, 35);
            CopyButton.TabIndex = 5;
            CopyButton.Text = "Αντιγραφή";
            CopyButton.UseVisualStyleBackColor = false;
            CopyButton.Click += CopyButton_Click;
            // 
            // NotesRichTextBox
            // 
            NotesRichTextBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            NotesRichTextBox.Location = new Point(6, 145);
            NotesRichTextBox.Name = "NotesRichTextBox";
            NotesRichTextBox.Size = new Size(462, 65);
            NotesRichTextBox.TabIndex = 50;
            NotesRichTextBox.Text = "";
            // 
            // InformLabel
            // 
            InformLabel.AutoSize = true;
            InformLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            InformLabel.Location = new Point(8, 14);
            InformLabel.Name = "InformLabel";
            InformLabel.Size = new Size(159, 13);
            InformLabel.TabIndex = 40;
            InformLabel.Text = "Ο πελάτης ενημερώθηκε για :";
            // 
            // SMSTabPage
            // 
            SMSTabPage.BackColor = SystemColors.Control;
            SMSTabPage.Controls.Add(ManufacturerButton);
            SMSTabPage.Controls.Add(LanguageLabel);
            SMSTabPage.Controls.Add(LanguageComboBox);
            SMSTabPage.Controls.Add(MoneybackButton);
            SMSTabPage.Controls.Add(ReplacedButton);
            SMSTabPage.Controls.Add(ContactButton);
            SMSTabPage.Controls.Add(CompleteButton);
            SMSTabPage.Controls.Add(RepairButton);
            SMSTabPage.Controls.Add(VoucherFaultyButton);
            SMSTabPage.Controls.Add(VoucherButton);
            SMSTabPage.Location = new Point(4, 24);
            SMSTabPage.Name = "SMSTabPage";
            SMSTabPage.Padding = new Padding(3);
            SMSTabPage.Size = new Size(476, 259);
            SMSTabPage.TabIndex = 2;
            SMSTabPage.Text = "SMS";
            // 
            // ManufacturerButton
            // 
            ManufacturerButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ManufacturerButton.Location = new Point(269, 196);
            ManufacturerButton.Margin = new Padding(7);
            ManufacturerButton.Name = "ManufacturerButton";
            ManufacturerButton.Size = new Size(200, 35);
            ManufacturerButton.TabIndex = 8;
            ManufacturerButton.Text = "Αποστολή στην Αντιπροσωπεία";
            ManufacturerButton.UseVisualStyleBackColor = true;
            ManufacturerButton.Click += ManufacturerButton_Click;
            // 
            // LanguageLabel
            // 
            LanguageLabel.AutoSize = true;
            LanguageLabel.Location = new Point(12, 23);
            LanguageLabel.Name = "LanguageLabel";
            LanguageLabel.Size = new Size(103, 15);
            LanguageLabel.TabIndex = 39;
            LanguageLabel.Text = "Επιλογή γλώσσας";
            // 
            // LanguageComboBox
            // 
            LanguageComboBox.FormattingEnabled = true;
            LanguageComboBox.Items.AddRange(new object[] { "Ελληνικά", "English" });
            LanguageComboBox.Location = new Point(120, 19);
            LanguageComboBox.Name = "LanguageComboBox";
            LanguageComboBox.Size = new Size(87, 23);
            LanguageComboBox.TabIndex = 900;
            LanguageComboBox.Text = "Ελληνικά";
            LanguageComboBox.SelectedIndexChanged += LanguageComboBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(484, 287);
            Controls.Add(TabControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(500, 326);
            MinimumSize = new Size(500, 326);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Shop v2.1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            TabControl.ResumeLayout(false);
            CalendarTabPage.ResumeLayout(false);
            CalendarTabPage.PerformLayout();
            NotesPage.ResumeLayout(false);
            NotesPage.PerformLayout();
            SMSTabPage.ResumeLayout(false);
            SMSTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker DateTimePicker;
        private Button CompleteButton;
        private Button RepairButton;
        private Button ReplacedButton;
        private Button ContactButton;
        private Button VoucherFaultyButton;
        private Button VoucherButton;
        private Button MoneybackButton;
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
        private RichTextBox NotesRichTextBox;
        private ComboBox LanguageComboBox;
        private Label LanguageLabel;
        private Button ManufacturerButton;
        private ComboBox UserComboBox;
        private Label UserLabel;
        private Button SameFromGRButton;
        private Button SentToRepairΒutton;
        private Button ReturnMoneyServiceButton;
        private Button VoucherServiceButton;
    }
}