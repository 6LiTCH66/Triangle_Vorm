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
    public partial class Form1 : Form
    {
        Graphics gp;
        Pen p = new Pen(Brushes.Black, 1);
        Panel panel = new Panel();
        public Form1()
        {
            InitializeComponent();
            gp = panel1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
            }

            if (txtA.Text.Length > 0 && txtB.Text.Length > 0 && txtC.Text.Length > 0)
            {

                double a, b, c;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                    

                Triangle triangle = new Triangle(a, b, c);

                int A_int = Convert.ToInt32(a);
                int B_int = Convert.ToInt32(b);
                int C_int = Convert.ToInt32(c);

                Point p1 = new Point(A_int, A_int);
                Point p2 = new Point(B_int, B_int);
                Point p3 = new Point(C_int, C_int);

                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");

                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Полупериметр");

                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");

                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());

                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));

                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));

                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.SemiPerimeter()));

                listView1.Items[7].SubItems.Add(triangle.TypeOfTirangle);

                if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Существует"); }
                else listView1.Items[6].SubItems.Add("Не существует");
            }
            else if(txtA.Text.Length > 0 && txtB.Text.Length > 0 && txtC.Text.Length == 0)
            {

                double a, b, c;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);


                Triangle triangle = new Triangle(a, b);

                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона с");

                listView1.Items.Add("Высота");

                listView1.Items.Add("Площадь");

                listView1.Items.Add("Полупериметр");

                listView1.Items.Add("Существует?");

                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());

                listView1.Items[2].SubItems.Add(Convert.ToString(triangle.PifagorC()));

                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.HeightH()));
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.AreaS()));
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.SemiPerimeter()));

                if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Существует"); }
                else listView1.Items[6].SubItems.Add("Не существует");



            }
            else if(txtA.Text.Length > 0 && txtB.Text.Length == 0 && txtC.Text.Length == 0)
            {
                double a;
                a = Convert.ToDouble(txtA.Text);

                Triangle triangle = new Triangle(a);

                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Высота");
                listView1.Items.Add("Площадь");

                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(Convert.ToString(triangle.Height_H()));
                listView1.Items[2].SubItems.Add(Convert.ToString(triangle.Area_S()));

            }

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(10, 100);
            Point p2 = new Point(100, 50);
            Point p3 = new Point(10, 60);

            gp.DrawLine(p, p1, p2);
            gp.DrawLine(p, p2, p3);
            gp.DrawLine(p, p3, p1);

        }
    }
}
