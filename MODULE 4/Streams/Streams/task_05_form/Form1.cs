using System;
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
    public partial class Form1 : Form
    {
        public static MyLog log; // reference to a MyLog-object
        public Form1()
        {
            InitializeComponent();
            log = new MyLog(); // creating MyLog object
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            string info = "Mouse clicked at Form1 at " + DateTime.Now.ToString();
            MessageBox.Show(info);
            // if mouse clicked - write a string to a log
            log.WriteToLog(info);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string info = "Button1 clicked at " + DateTime.Now.ToString();
            log.WriteToLog(info);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string info = "Button2 clicked at " + DateTime.Now.ToString();
            log.WriteToLog(info);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
