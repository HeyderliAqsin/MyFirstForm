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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pass = txtPass.Text;
            string ConfirmPass = txtConfirm.Text;
            if(!string.IsNullOrWhiteSpace(email) && 
                !string.IsNullOrWhiteSpace(pass) 
                && !string.IsNullOrWhiteSpace(ConfirmPass))
            {
                if (pass == ConfirmPass)
                {
                    lblError.Visible = false;
                    if (AllMyList.UserList.Count == 0)
                    {
                        User user = new User();
                        user.Email = email;
                        user.Password = pass;
                        AllMyList.UserList.Add(user);
                        MessageBox.Show("User registred successfully!");
                        txtEmail.Text = "";
                        txtPass.Text = "";
                        txtConfirm.Text = "";
                        this.Close();
                        LoginForm lg = new LoginForm();
                        lg.ShowDialog();

                    }
                    else
                    {
                        bool isCorrect = true;
                        foreach (var us in AllMyList.UserList)
                        {
                            if (us.Email == email)
                            {
                                isCorrect = false;
                                break;
                            }
                          
                        }
                        if (isCorrect)
                        {
                            User user = new User();
                            user.Email = email;
                            user.Password = pass;
                            AllMyList.UserList.Add(user);
                            MessageBox.Show("User registred successfully!");
                            txtEmail.Text = "";
                            txtPass.Text = "";
                            txtConfirm.Text = "";
                            this.Close();
                            LoginForm lg = new LoginForm();
                            lg.ShowDialog();

                        }
                        else
                        {
                            lblError.Visible = true;
                            lblError.Text = "This email is already exist!";
                        }
                    }        
                }

                else
                {
                    lblError.Visible = true;
                    lblError.Text = "password isn`t same!";
                }

            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "please fill required fields!";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
