﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class successForm : Form
    {
        public successForm()
        {
            InitializeComponent();

            successText.SelectAll();
            successText.SelectionAlignment = HorizontalAlignment.Center;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
