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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtEmail.Text;
            string pas = txtPass.Text;
            bool isCorrect = false;
            foreach (var user in AllMyList.UserList)
            {
                if (user.Email==ad && user.Password == pas)
                {
                    isCorrect = true;
                    break;
                }
                
            }
            if (isCorrect)
            {
                UserForm us = new UserForm();
                us.ShowDialog();
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Email or password isn`t correct";
            }
        }
    }
}
