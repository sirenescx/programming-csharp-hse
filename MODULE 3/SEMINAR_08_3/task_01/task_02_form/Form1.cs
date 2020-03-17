using System.Windows.Forms;
using task_02_class_library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace task_02_form
{
    public partial class Form1 : Form
    {
        public ElectronicQueue<Person> eq;
       // public ElectronicQueue eq;
        public Form1()
        {
            InitializeComponent();
            //  eq = new ElectronicQueue();
            eq = new ElectronicQueue<Person>();
            eq.AddToElectronicQueue(new Person("Jabba", "Hutt", 604));
            eq.AddToElectronicQueue(new Person("Wedge", "Antille", 25));
            eq.AddToElectronicQueue(new Person("Han", "Solo", 33));
            eq.AddToElectronicQueue(new Person("Leia", "Organa", 23));
            eq.AddToElectronicQueue(new Person("Lando", "Calrissian", 35));
            eq.AddToElectronicQueue(new Person("Anakin", "Skywalker", 46));
            timer1.Enabled = true;
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            timer1.Enabled = true;
            try
            {
                eq.AddToElectronicQueue(new Person(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text)));
                if (int.Parse(textBox3.Text) < 0) throw new FormatException();
            }
            catch (FormatException) { MessageBox.Show("Incorrect input. Age should be integer number > 0."); }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (eq.CallFromElectronicQueue() == null) timer1.Enabled = false;

            else
            {
                label4.Text = eq.CallFromElectronicQueue();
                System.Media.SystemSounds.Exclamation.Play();
                eq.DeleteFromElectronicQueue();
            }
        }
    }
}
