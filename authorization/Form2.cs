using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace authorization
{
    public partial class FinalForm : Form
    {
        private string Login;
        private string Password;
        public FinalForm(string Login, string Password)
        {
            InitializeComponent();
            this.Login = Login;
            this.Password = Password;
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            labelLog.Text = Login;
            labelPass.Text = Password;



        }

        private void labelPass_Click(object sender, EventArgs e)
        {

        }
    }
}
