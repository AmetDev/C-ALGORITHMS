﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewApplication
{
    public partial class Form2 : Form
    {
            Form3 frm3;
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Загружена Вторая форма";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = DataBank.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBank.Text = textBox1.Text;
            frm3 = new Form3();
            frm3.Show();
        }
    }
}