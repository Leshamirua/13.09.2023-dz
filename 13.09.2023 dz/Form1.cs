using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._09._2023_dz
{
    //недоделанное, заболел, не могу доделать :(
    public partial class Form1 : Form
    {
        Person person = new Person();
        Info info = new Info();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            if (textBox1.Text != "" && int.TryParse(textBox2.Text, out age))
            {
                info.AddInfo(new Person(textBox1.Text, age));
            }

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
