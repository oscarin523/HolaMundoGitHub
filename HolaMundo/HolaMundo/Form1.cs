﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
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

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string nombre = txtname.Text;
            MessageBox.Show("Hola " + nombre + " Bienvenido al mundo real");

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //string nombre = txtname.Text;
            //MessageBox.Show("Hola " + nombre + " que guapo");
        }
    }
}
