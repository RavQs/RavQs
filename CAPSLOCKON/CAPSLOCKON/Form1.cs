﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPSLOCKON
{
    public partial class Form1 : Form
    {
        public PictureBox pictureBox1;
        public Form1()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
                pictureBox1.Visible = true;


            }
            else
            {
                MessageBox.Show("The Caps Lock key is OFF.");
                pictureBox1.Visible = false;
            }
            InitializeComponent();

        }

    }
}
