﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_WladimirCanar
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MainMenu addMainMenuForm = new MainMenu();
            addMainMenuForm.Tag = this;
            addMainMenuForm.Show(this);
            Hide();
        }

        private void textBoxSizeDesk_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                    e.Handled = true;
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
