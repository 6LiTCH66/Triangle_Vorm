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
        CheckBox ch_box1, ch_box2, ch_box3, ch_box4, ch_box5, ch_box6;
        Label lbl;
        Button Run_Button1;
        public Form3()
        {
            this.Size = new Size(800, 400);
            ch_box1 = new CheckBox();
            ch_box1.Text = "Сторона A";
            ch_box1.Location = new Point(174, 62);
            ch_box1.Size = new Size(78, 17);

            ch_box2 = new CheckBox();
            ch_box2.Text = "Сторона B";
            ch_box2.Location = new Point(174, 96);
            ch_box2.Size = new Size(78, 17);

            ch_box3 = new CheckBox();
            ch_box3.Text = "Сторона C";
            ch_box3.Location = new Point(174, 132);
            ch_box3.Size = new Size(78, 17);

            ch_box4 = new CheckBox();
            ch_box4.Text = "Основание треугольника";
            ch_box4.Location = new Point(489, 62);
            ch_box4.Size = new Size(154, 17);

            ch_box5 = new CheckBox();
            ch_box5.Text = "Высота треугольника";
            ch_box5.Location = new Point(489, 96);
            ch_box5.Size = new Size(136, 17);

            ch_box6 = new CheckBox();
            ch_box6.Text = "Угол треугольника α";
            ch_box6.Location = new Point(174, 168);
            ch_box6.Size = new Size(136, 17);

            lbl = new Label();
            lbl.Text = "Какие данные у вас есть?";
            lbl.Location = new Point(265, 9);
            lbl.Size = new Size(341, 31);
            lbl.Font = new Font("Calibri", 20);

            Run_Button1 = new Button();
            Run_Button1.Text = "Запустить";
            Run_Button1.Location = new Point(270, 194);
            Run_Button1.Size = new Size(266, 113);
            Run_Button1.Click += Run_Button1_Click;

            Controls.Add(Run_Button1);
            Controls.Add(lbl);
            Controls.Add(ch_box6);
            Controls.Add(ch_box5);
            Controls.Add(ch_box4);
            Controls.Add(ch_box3);
            Controls.Add(ch_box2);
            Controls.Add(ch_box1);
        }


        private void Run_Button1_Click(object sender, EventArgs e)
        {
            if(ch_box1.Checked && ch_box2.Checked && ch_box3.Checked)
            {
                Form1 frm = new Form1();
                frm.Show();
                ch_box1.Checked = false;
                ch_box2.Checked = false;
                ch_box3.Checked = false;
            }
            else if(ch_box4.Checked && ch_box5.Checked)
            {
                Form2 frm = new Form2();
                frm.Show();
                ch_box4.Checked = false;
                ch_box5.Checked = false;
            }
            else if(ch_box1.Checked && ch_box2.Checked)
            {
                Form1 frm = new Form1();
                frm.Show();
                ch_box1.Checked = false;
                ch_box2.Checked = false;
            }
            else if (ch_box1.Checked)
            {
                Form1 frm = new Form1();
                frm.Show();
                ch_box1.Checked = false;
            }
            else if(ch_box1.Checked && ch_box6.Checked)
            {
                Form1 frm = new Form1();
                frm.Show();
                ch_box1.Checked = false;
                ch_box6.Checked = false;
            }
            else if (ch_box1.Checked && ch_box2.Checked && ch_box3.Checked && ch_box4.Checked && ch_box5.Checked)
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
