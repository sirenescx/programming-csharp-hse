﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_05_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            string info = "Mouse clicked at Form2 at " + DateTime.Now.ToString();
            Form1.log.WriteToLog(info);
        }
    }
}
