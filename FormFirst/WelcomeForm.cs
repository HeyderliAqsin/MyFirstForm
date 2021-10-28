using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFirst
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm rg = new RegisterForm();
            rg.ShowDialog();
        }
    }
}
