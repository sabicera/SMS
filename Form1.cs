namespace SMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string text1 = "��������� �������. ������� �����. � ������� ��� ��������� ������������. �������� �� �������� �� �� ����������.";
        string text2 = "��������� �������. ������� �����. � �������� ��� ��������� ������������. �������� �� �������� �� �� ����������.";
        string text3 = "��������� �������. ������� �����. � ������������� ��� ��������� ������������. �������� �� �������� �� �� ����������.";
        string text4 = "��������� �������. ������� �����. �������� ������������� ����� ���� ���.";
        string text5 = "��������� �������. ������� �����. �� ������ ��� ����� �����HMA����. ����� ������� �. ��� �� ������ ���� ����.";
        string text6 = "��������� �������. ������� �����. ����� ������� �. ��� �� ������ ���� ����.";
        string text7 = "��������� �������. ������� �����. �� ������ ��� ���������� ���� ������������� ��� ������.";

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text1);
            Clipboard.SetDataObject(data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text2);
            Clipboard.SetDataObject(data);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text3);
            Clipboard.SetDataObject(data);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text4);
            Clipboard.SetDataObject(data);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text5);
            Clipboard.SetDataObject(data);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text6);
            Clipboard.SetDataObject(data);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new DataObject();
            data.SetData(DataFormats.StringFormat, text7);
            Clipboard.SetDataObject(data);
        }
    }
}