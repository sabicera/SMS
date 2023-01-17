namespace SMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string text1 = "йатастгла келесоу. тевмийо тлгла. о екецвос тоу пяоиомтос окойкгяыхгйе. лпояеите ма пеяасете ма то паяакабете.";
        string text2 = "йатастгла келесоу. тевмийо тлгла. г еписйеуг тоу пяоиомтос окойкгяыхгйе. лпояеите ма пеяасете ма то паяакабете.";
        string text3 = "йатастгла келесоу. тевмийо тлгла. г амтийатастасг тоу пяоиомтос окойкгяыхгйе. лпояеите ма пеяасете ма то паяакабете.";
        string text4 = "йатастгла келесоу. тевмийо тлгла. паяайакы епийоимымгсте алеса лафи лас.";
        string text5 = "йатастгла келесоу. тевмийо тлгла. то пяоиом сас еимаи пяобкHMAтийо. евете пистысг ─. циа ма паяете йати акко.";
        string text6 = "йатастгла келесоу. тевмийо тлгла. евете пистысг ─. циа ма паяете йати акко.";
        string text7 = "йатастгла келесоу. тевмийо тлгла. то пяоиом сас пяоыхеитаи стгм амтипяосыпеиа циа екецво.";

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