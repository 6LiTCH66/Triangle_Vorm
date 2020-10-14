using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Vorm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Run_button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                Form1 frm = new Form1();
                frm.Show();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else if(checkBox4.Checked && checkBox5.Checked)
            {
                Form2 frm = new Form2();
                frm.Show();
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
            {
                MessageBox.Show("Данные выбраны не правильно");
            }
            else
            {
                MessageBox.Show("Данные выбраны не правильно");
            }
        }
    }
}
