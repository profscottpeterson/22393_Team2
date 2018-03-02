﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachConnect
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Show();

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachProfileForm coachForm = new CoachProfileForm();
            coachForm.Show();
        }

        private void addUpdateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAdminForm userForm = new UserAdminForm();
            userForm.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?",
                "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
