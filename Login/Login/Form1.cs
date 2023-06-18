using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Lparam);


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text== "Email") {
                textUser.Text = "";
                textUser.ForeColor = Color.LightGray;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text =="") {
                textUser.Text = "Email";
                textUser.ForeColor = Color.DimGray;
            }
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_Enter_1(object sender, EventArgs e)
        {
            if (textPassword.Text == "Password")
            {
                textPassword.Text = "";
                textPassword.ForeColor = Color.LightGray;
                textPassword.UseSystemPasswordChar = true;
            }
        }
        private void textPassword_Leave_1(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.Text = "Password";
                textPassword.ForeColor = Color.DimGray;
                textPassword.UseSystemPasswordChar = false;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
} 
