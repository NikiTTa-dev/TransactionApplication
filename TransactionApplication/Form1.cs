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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private bool isClicked = false;
        private void UsernameBox_MouseEnter_1(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (!isClicked)
                textBox.Text = "";
        }

        private void UsernameBox_MouseLeave_1(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (!isClicked)
                textBox.Text = "Username";
        }

        private void UsernameBox_Click_1(object sender, EventArgs e)
        {
            isClicked = true;
        }

        private void Background_Click(object sender, EventArgs e)
        {
        }

        private void Background_MouseLeave(object sender, EventArgs e)
        {
            UsernameBox.Text = "Fasfas";
        }
    }
}
