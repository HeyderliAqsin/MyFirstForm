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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnAddgroup_Click(object sender, EventArgs e)
        {
            string groupName = txtgroup.Text;
            if (!cmbgroup.Items.Contains(groupName))
            {
                cmbgroup.Items.Add(groupName);
                txtgroup.Text = "";

            }
            else
            {
                MessageBox.Show("Qrup adı artıq mövcuddur!");
            }
           
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            cmbgroup.Items.Add("--Select group--");
            cmbgroup.SelectedIndex = 0;

        }
    }
}
