using System.Xml;
namespace authorization
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {

            InitializeComponent();
            init();
            labelResult.Visible = false;
        }

        XmlDocument xmlDocument = new XmlDocument();

        XmlElement xRoot;

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void init()
        {
            try
            {
                xmlDocument.Load("logs.txt");
                xRoot = xmlDocument.DocumentElement;
            }
            catch
            {
                File.WriteAllText("logs.txt", "<users></users>");
                xmlDocument.Load("logs.txt");
                xRoot = xmlDocument.DocumentElement;

            }
        }
        RegForm regForm = new RegForm();

        private void button1_Click(object sender, EventArgs e)
        {
            regForm.ShowDialog();
        }

        FinalForm finalForm;

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (CheckUser())
            {
                finalForm = new FinalForm(textBoxLog.Text, textBoxPass.Text);
                finalForm.ShowDialog();
            }
            else { labelResult.Visible = true; labelResult.Text = "Error"; }
        }

        private bool CheckUser()
        {
            xmlDocument.Load("logs.txt");
            xRoot = xmlDocument.DocumentElement;

            foreach (XmlNode xUser in xRoot)
            {
                if (xUser.Attributes.GetNamedItem("login").Value == textBoxLog.Text) if (xUser.Attributes.GetNamedItem("password").Value == textBoxPass.Text) return true;
            }



            return false;
        }



    }
}