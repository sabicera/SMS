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
            VoucherNotesButton = new Button();
            ReturnMoneyNotesButton = new Button();
            TabControl = new TabControl();
            CalendarTabPage = new TabPage();
            VersionLabel = new Label();
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
            NotesPanel = new Panel();
            NotesLabel = new Label();
            CalculatorTabPage = new TabPage();
            ResetCalcButton = new Button();
            CalculateButton = new Button();
            HistoryRichTextBox = new RichTextBox();
            VATSelectorComboBox = new ComboBox();
            PriceVATLabel = new Label();
            PriceInputTextBox = new TextBox();
            UserLabel = new Label();
            UserComboBox = new ComboBox();
            TabControl.SuspendLayout();
            CalendarTabPage.SuspendLayout();
            NotesPage.SuspendLayout();
            SMSTabPage.SuspendLayout();
            NotesPanel.SuspendLayout();
            CalculatorTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // CompleteButton
            // 
            CompleteButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CompleteButton.Location = new Point(10, 10);
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
            RepairButton.Location = new Point(10, 58);
            RepairButton.Margin = new Padding(7);
            RepairButton.Name = "RepairButton";
            RepairButton.Size = new Size(200, 35);
            RepairButton.TabIndex = 17;
            RepairButton.Text = "Ολοκλήρωση Επισκευής";
            RepairButton.UseVisualStyleBackColor = true;
            RepairButton.Click += RepairButton_Click;
            // 
            // ReplacedButton
            // 
            ReplacedButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReplacedButton.Location = new Point(10, 106);
            ReplacedButton.Margin = new Padding(7);
            ReplacedButton.Name = "ReplacedButton";
            ReplacedButton.Size = new Size(200, 35);
            ReplacedButton.TabIndex = 18;
            ReplacedButton.Text = "Αντικατάσταση";
            ReplacedButton.UseVisualStyleBackColor = true;
            ReplacedButton.Click += ReplacedButton_Click;
            // 
            // ContactButton
            // 
            ContactButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ContactButton.Location = new Point(10, 154);
            ContactButton.Margin = new Padding(7);
            ContactButton.Name = "ContactButton";
            ContactButton.Size = new Size(200, 35);
            ContactButton.TabIndex = 19;
            ContactButton.Text = "Επικοινωνήστε μαζί μας";
            ContactButton.UseVisualStyleBackColor = true;
            ContactButton.Click += ContactButton_Click;
            // 
            // VoucherFaultyButton
            // 
            VoucherFaultyButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            VoucherFaultyButton.Location = new Point(264, 10);
            VoucherFaultyButton.Margin = new Padding(7);
            VoucherFaultyButton.Name = "VoucherFaultyButton";
            VoucherFaultyButton.Size = new Size(200, 35);
            VoucherFaultyButton.TabIndex = 20;
            VoucherFaultyButton.Text = "Πίστωση Ελαττωματικού";
            VoucherFaultyButton.UseVisualStyleBackColor = true;
            VoucherFaultyButton.Click += VoucherFaultyButton_Click;
            // 
            // VoucherButton
            // 
            VoucherButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            VoucherButton.Location = new Point(264, 58);
            VoucherButton.Margin = new Padding(7);
            VoucherButton.Name = "VoucherButton";
            VoucherButton.Size = new Size(200, 35);
            VoucherButton.TabIndex = 21;
            VoucherButton.Text = "Πίστωση";
            VoucherButton.UseVisualStyleBackColor = true;
            VoucherButton.Click += VoucherButton_Click;
            // 
            // MoneybackButton
            // 
            MoneybackButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MoneybackButton.Location = new Point(264, 106);
            MoneybackButton.Margin = new Padding(7);
            MoneybackButton.Name = "MoneybackButton";
            MoneybackButton.Size = new Size(200, 35);
            MoneybackButton.TabIndex = 22;
            MoneybackButton.Text = "Επιστροφή Χρημάτων";
            MoneybackButton.UseVisualStyleBackColor = true;
            MoneybackButton.Click += MoneybackButton_Click;
            // 
            // VoucherNotesButton
            // 
            VoucherNotesButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            VoucherNotesButton.Location = new Point(3, 24);
            VoucherNotesButton.Name = "VoucherNotesButton";
            VoucherNotesButton.Size = new Size(98, 23);
            VoucherNotesButton.TabIndex = 35;
            VoucherNotesButton.Text = "Πίστωση";
            VoucherNotesButton.UseVisualStyleBackColor = true;
            VoucherNotesButton.Click += VoucherNotesButton_Click;
            // 
            // ReturnMoneyNotesButton
            // 
            ReturnMoneyNotesButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnMoneyNotesButton.Location = new Point(118, 24);
            ReturnMoneyNotesButton.Name = "ReturnMoneyNotesButton";
            ReturnMoneyNotesButton.Size = new Size(98, 23);
            ReturnMoneyNotesButton.TabIndex = 36;
            ReturnMoneyNotesButton.Text = "Επιστροφή";
            ReturnMoneyNotesButton.UseVisualStyleBackColor = true;
            ReturnMoneyNotesButton.Click += ReturnMoneyNotesButton_Click;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(CalendarTabPage);
            TabControl.Controls.Add(NotesPage);
            TabControl.Controls.Add(SMSTabPage);
            TabControl.Controls.Add(CalculatorTabPage);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(484, 287);
            TabControl.TabIndex = 40;
            // 
            // CalendarTabPage
            // 
            CalendarTabPage.BackColor = SystemColors.Control;
            CalendarTabPage.Controls.Add(VersionLabel);
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
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.BackColor = Color.Transparent;
            VersionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            VersionLabel.Location = new Point(369, 236);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(0, 15);
            VersionLabel.TabIndex = 44;
            VersionLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            WarrantyComboBox.Location = new Point(95, 125);
            WarrantyComboBox.Margin = new Padding(4, 3, 4, 3);
            WarrantyComboBox.Name = "WarrantyComboBox";
            WarrantyComboBox.Size = new Size(41, 21);
            WarrantyComboBox.TabIndex = 35;
            WarrantyComboBox.SelectedIndexChanged += WarrantyComboBox_SelectedIndexChanged;
            // 
            // ResetCalendar
            // 
            ResetCalendar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ResetCalendar.Location = new Point(7, 155);
            ResetCalendar.Margin = new Padding(4, 3, 4, 3);
            ResetCalendar.Name = "ResetCalendar";
            ResetCalendar.Size = new Size(460, 30);
            ResetCalendar.TabIndex = 34;
            ResetCalendar.Text = "Επαναφορά";
            ResetCalendar.UseVisualStyleBackColor = true;
            ResetCalendar.Click += ResetCalendar_Click;
            // 
            // WarrantyDays
            // 
            WarrantyDays.AutoSize = true;
            WarrantyDays.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            WarrantyDays.Location = new Point(149, 124);
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
            WarrantyLabel.Location = new Point(28, 124);
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
            DateTimePicker.TabIndex = 29;
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
            // CancelComboBox
            // 
            CancelComboBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelComboBox.FormattingEnabled = true;
            CancelComboBox.Items.AddRange(new object[] { "Πρόβλημα διαθεσιμότητας προϊόντος", "Καθυστέρηση απάντησης από πελάτη", "Καθυστέρηση παραλαβής από προμηθευτή", "Καθυστέρηση παραλαβής από πελάτη", "Ζήτησε ακύρωση παραγγελίας χωρίς αιτιολογία (e-mail)", "Ζήτησε ακύρωση παραγγελίας χωρίς αιτιολογία (τηλέφωνο)", "Ζήτησε ακύρωση παραγγελίας χωρίς αιτιολογία (κατάστημα)", "Διπλή παραγγελία", "Λάθος παραγγελία από πωλητή", "Λάθος παραγγελία από πελάτη", "Μεταφορά σε άλλη παραγγελία", "Αδυναμία επικοινωνίας με τον πελάτη" });
            CancelComboBox.Location = new Point(76, 69);
            CancelComboBox.Name = "CancelComboBox";
            CancelComboBox.Size = new Size(338, 21);
            CancelComboBox.TabIndex = 46;
            CancelComboBox.SelectedIndexChanged += CancelComboBox_SelectedIndexChanged;
            // 
            // CancelLabel
            // 
            CancelLabel.AutoSize = true;
            CancelLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelLabel.Location = new Point(199, 53);
            CancelLabel.Name = "CancelLabel";
            CancelLabel.Size = new Size(93, 13);
            CancelLabel.TabIndex = 45;
            CancelLabel.Text = "Αιτία ακύρωσης:";
            // 
            // InformComboBox
            // 
            InformComboBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            InformComboBox.FormattingEnabled = true;
            InformComboBox.Items.AddRange(new object[] { "3-4 εργάσιμες μέρες", "10-15 εργάσιμες μέρες", "ημ/νία παραλαβής" });
            InformComboBox.Location = new Point(76, 29);
            InformComboBox.Name = "InformComboBox";
            InformComboBox.Size = new Size(338, 21);
            InformComboBox.TabIndex = 44;
            InformComboBox.SelectedIndexChanged += InformComboBox_SelectedIndexChanged;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.FromArgb(255, 128, 128);
            ClearButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.Location = new Point(6, 171);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(150, 35);
            ClearButton.TabIndex = 43;
            ClearButton.Text = "Διαγραφή Όλων";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.BackColor = Color.FromArgb(192, 255, 192);
            CopyButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CopyButton.Location = new Point(318, 171);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(150, 35);
            CopyButton.TabIndex = 42;
            CopyButton.Text = "Αντιγραφή";
            CopyButton.UseVisualStyleBackColor = false;
            CopyButton.Click += CopyButton_Click;
            // 
            // NotesRichTextBox
            // 
            NotesRichTextBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            NotesRichTextBox.Location = new Point(6, 100);
            NotesRichTextBox.Name = "NotesRichTextBox";
            NotesRichTextBox.Size = new Size(462, 65);
            NotesRichTextBox.TabIndex = 41;
            NotesRichTextBox.Text = "";
            // 
            // InformLabel
            // 
            InformLabel.AutoSize = true;
            InformLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            InformLabel.Location = new Point(166, 13);
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
            SMSTabPage.Controls.Add(NotesPanel);
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
            ManufacturerButton.Location = new Point(264, 154);
            ManufacturerButton.Margin = new Padding(7);
            ManufacturerButton.Name = "ManufacturerButton";
            ManufacturerButton.Size = new Size(200, 35);
            ManufacturerButton.TabIndex = 40;
            ManufacturerButton.Text = "Αποστολή στην Αντιπροσωπεία";
            ManufacturerButton.UseVisualStyleBackColor = true;
            ManufacturerButton.Click += ManufacturerButton_Click;
            // 
            // LanguageLabel
            // 
            LanguageLabel.AutoSize = true;
            LanguageLabel.Location = new Point(15, 204);
            LanguageLabel.Name = "LanguageLabel";
            LanguageLabel.Size = new Size(103, 15);
            LanguageLabel.TabIndex = 39;
            LanguageLabel.Text = "Επιλογή γλώσσας";
            // 
            // LanguageComboBox
            // 
            LanguageComboBox.FormattingEnabled = true;
            LanguageComboBox.Items.AddRange(new object[] { "Ελληνικά", "English" });
            LanguageComboBox.Location = new Point(123, 200);
            LanguageComboBox.Name = "LanguageComboBox";
            LanguageComboBox.Size = new Size(87, 23);
            LanguageComboBox.TabIndex = 38;
            LanguageComboBox.Text = "Ελληνικά";
            LanguageComboBox.SelectedIndexChanged += LanguageComboBox_SelectedIndexChanged;
            // 
            // NotesPanel
            // 
            NotesPanel.BackColor = Color.FromArgb(192, 255, 192);
            NotesPanel.BorderStyle = BorderStyle.FixedSingle;
            NotesPanel.Controls.Add(NotesLabel);
            NotesPanel.Controls.Add(ReturnMoneyNotesButton);
            NotesPanel.Controls.Add(VoucherNotesButton);
            NotesPanel.Location = new Point(252, 200);
            NotesPanel.Name = "NotesPanel";
            NotesPanel.Size = new Size(221, 56);
            NotesPanel.TabIndex = 37;
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Location = new Point(77, 3);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(67, 15);
            NotesLabel.TabIndex = 37;
            NotesLabel.Text = "Σημειώσεις";
            // 
            // CalculatorTabPage
            // 
            CalculatorTabPage.BackColor = SystemColors.Control;
            CalculatorTabPage.Controls.Add(ResetCalcButton);
            CalculatorTabPage.Controls.Add(CalculateButton);
            CalculatorTabPage.Controls.Add(HistoryRichTextBox);
            CalculatorTabPage.Controls.Add(VATSelectorComboBox);
            CalculatorTabPage.Controls.Add(PriceVATLabel);
            CalculatorTabPage.Controls.Add(PriceInputTextBox);
            CalculatorTabPage.Location = new Point(4, 24);
            CalculatorTabPage.Name = "CalculatorTabPage";
            CalculatorTabPage.Padding = new Padding(3);
            CalculatorTabPage.Size = new Size(476, 259);
            CalculatorTabPage.TabIndex = 3;
            CalculatorTabPage.Text = "Calculator";
            // 
            // ResetCalcButton
            // 
            ResetCalcButton.BackColor = Color.Red;
            ResetCalcButton.Location = new Point(393, 233);
            ResetCalcButton.Name = "ResetCalcButton";
            ResetCalcButton.Size = new Size(75, 23);
            ResetCalcButton.TabIndex = 11;
            ResetCalcButton.Text = "Reset";
            ResetCalcButton.UseVisualStyleBackColor = false;
            ResetCalcButton.Click += ResetCalcButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.Lime;
            CalculateButton.Location = new Point(188, 31);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(75, 23);
            CalculateButton.TabIndex = 10;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // HistoryRichTextBox
            // 
            HistoryRichTextBox.Location = new Point(276, 13);
            HistoryRichTextBox.Name = "HistoryRichTextBox";
            HistoryRichTextBox.Size = new Size(192, 214);
            HistoryRichTextBox.TabIndex = 9;
            HistoryRichTextBox.Text = "";
            // 
            // VATSelectorComboBox
            // 
            VATSelectorComboBox.FormattingEnabled = true;
            VATSelectorComboBox.Items.AddRange(new object[] { "19%", "5%" });
            VATSelectorComboBox.Location = new Point(123, 31);
            VATSelectorComboBox.Name = "VATSelectorComboBox";
            VATSelectorComboBox.Size = new Size(59, 23);
            VATSelectorComboBox.TabIndex = 8;
            VATSelectorComboBox.Text = "19%";
            // 
            // PriceVATLabel
            // 
            PriceVATLabel.AutoSize = true;
            PriceVATLabel.Location = new Point(25, 13);
            PriceVATLabel.Name = "PriceVATLabel";
            PriceVATLabel.Size = new Size(81, 15);
            PriceVATLabel.TabIndex = 7;
            PriceVATLabel.Text = "Price with VAT";
            // 
            // PriceInputTextBox
            // 
            PriceInputTextBox.Location = new Point(15, 31);
            PriceInputTextBox.Name = "PriceInputTextBox";
            PriceInputTextBox.Size = new Size(100, 23);
            PriceInputTextBox.TabIndex = 6;
            PriceInputTextBox.TextChanged += PriceInputTextBox_TextChanged;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserLabel.Location = new Point(19, 260);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(62, 15);
            UserLabel.TabIndex = 42;
            UserLabel.Text = "Χρήστης :";
            // 
            // UserComboBox
            // 
            UserComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserComboBox.FormattingEnabled = true;
            UserComboBox.Items.AddRange(new object[] { "ΠΑΥΛΟΣ", "ΑΧΙΛΛΕΑΣ", "ΜΑΡΙΟΣ", "ΒΛΑΔΙΜΗΡΟΣ", "ΠΑΡΑΣΚΕΥΑΣ" });
            UserComboBox.Location = new Point(85, 257);
            UserComboBox.Name = "UserComboBox";
            UserComboBox.Size = new Size(129, 23);
            UserComboBox.TabIndex = 45;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(484, 287);
            Controls.Add(UserComboBox);
            Controls.Add(UserLabel);
            Controls.Add(TabControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(500, 326);
            MinimumSize = new Size(500, 326);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Shop v2.0";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            TabControl.ResumeLayout(false);
            CalendarTabPage.ResumeLayout(false);
            CalendarTabPage.PerformLayout();
            NotesPage.ResumeLayout(false);
            NotesPage.PerformLayout();
            SMSTabPage.ResumeLayout(false);
            SMSTabPage.PerformLayout();
            NotesPanel.ResumeLayout(false);
            NotesPanel.PerformLayout();
            CalculatorTabPage.ResumeLayout(false);
            CalculatorTabPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button VoucherNotesButton;
        private Button ReturnMoneyNotesButton;
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
        private Label VersionLabel;
        private ComboBox UserComboBox;
        private Panel NotesPanel;
        private Label NotesLabel;
        private ComboBox LanguageComboBox;
        private Label LanguageLabel;
        private Button ManufacturerButton;
        private TabPage CalculatorTabPage;
        private Button ResetCalcButton;
        private Button CalculateButton;
        private RichTextBox HistoryRichTextBox;
        private ComboBox VATSelectorComboBox;
        private Label PriceVATLabel;
        private TextBox PriceInputTextBox;
    }
}