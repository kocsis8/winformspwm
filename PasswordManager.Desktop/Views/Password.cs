using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Desktop.Views
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void addPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPassword anpf = new AddNewPassword();
            anpf.ShowDialog();
        }
    }
}
