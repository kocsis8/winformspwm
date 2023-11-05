using Microsoft.EntityFrameworkCore;
using PasswordManager.Core.Data;
using PasswordManager.Core.Models;
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
    public partial class Registration : Form
    {
        private readonly PasswordManagerDbContext _context;
        private readonly BindingSource _bindingSource = new();

        public User User { get; private set; }

        public Registration()
        {
            _context = Program.GetDbContext();
            InitializeComponent();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var newUser = new User
            {
                Email = textBox_email.Text,
                Username = textBox_username.Text,
                FirstName = textBox_fn.Text,
                LastName = textBox_ln.Text,
            };

            // User hozzáadása az adatbázishoz a _context-en keresztül
            _context.User.Add(newUser);

            // Véglegesítés (mentés) az adatbázisban
            _context.SaveChanges();

        }
    }
}
