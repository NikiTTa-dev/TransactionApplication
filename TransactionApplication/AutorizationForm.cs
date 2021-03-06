using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransactionApplication
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
            this.PasswordTextBox.AutoSize = false;
            this.PasswordTextBox.Size = new Size(UsernameBox.Size.Width, UsernameBox.Size.Height);
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private bool isLoginClicked = false;
        private void UsernameBox_MouseEnter(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (!isLoginClicked)
                textBox.Text = "";
        }

        private void UsernameBox_MouseLeave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (!isLoginClicked)
                textBox.Text = "Username";
        }

        private void UsernameBox_Click(object sender, EventArgs e)
        {
            isLoginClicked = true;
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "********";
                isPasswordClicked = false;
            }
        }

        private void BackgroundPanel_Click(object sender, EventArgs e)
        {
            BackgroundPanel.Select();
            if (UsernameBox.Text == "")
            {
                UsernameBox.Text = "Username";
                isLoginClicked = false;
            }
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "********";
                isPasswordClicked = false;
            }
        }

        Point lastPoint;
        private void BackgroundPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void BackgroundPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private bool isPasswordClicked = false;
        private void PasswordTextBox_MouseEnter(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (!isPasswordClicked)
                textBox.Text = "";
        }

        private void PasswordTextBox_MouseLeave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (!isPasswordClicked)
                textBox.Text = "********";
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            isPasswordClicked = true;
            if (UsernameBox.Text == "")
            {
                UsernameBox.Text = "Username";
                isLoginClicked = false;
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string userLogin = UsernameBox.Text;
            string userPassword = PasswordTextBox.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Yes");
            else
                MessageBox.Show("No");
        }
    }
}
