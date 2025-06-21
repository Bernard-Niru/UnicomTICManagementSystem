using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Username_lbl.Text =Login.CurrentUserName;
            Name_lbl.Text = Login.CurrentName;
            Role_lbl.Text = Login.CurrentRole;
            Pswd_lbl.Text = Login.CurrentPassword;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void Username_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
