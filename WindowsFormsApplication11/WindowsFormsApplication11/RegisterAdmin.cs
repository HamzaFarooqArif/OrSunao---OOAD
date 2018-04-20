﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class RegisterAdmin : Form
    {
        public RegisterAdmin()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            bool isregister;
            bool ispassed;
            server.SRegisterAdmin(Txt_FirstName.Text, txt_LastName.Text, Txt_Password.Text, txt_Email.Text, txt_CNIC.Text, txt_Contact.Text, out isregister, out ispassed);
            if (ispassed)
            {
                if(isregister)
                {
                    MessageBox.Show("yayyyyy! u r registered");
                }
                else
                {
                    MessageBox.Show("mr jao");
                }
            }
        }

        private void lnklbl_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginAdmin n1 = new LoginAdmin();
            n1.Show();
            this.Close();
        }

        private void lnklbl_GoToMainPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrSunao o = new OrSunao();
            o.Show();
            this.Close();
        }
    }
}