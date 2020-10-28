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
        Pen p = new Pen(Brushes.Black, 2);
        Panel panel = new Panel();
        public Form1()
        {
            InitializeComponent();
            gp = panel1.CreateGraphics();
        }

        public void DrawTriangle(double side_a, double side_b, double side_c)
        {

            int s1, s2, s3;

            int A_int = Convert.ToInt32(side_a);
            int B_int = Convert.ToInt32(side_b);
            int C_int = Convert.ToInt32(side_c);

            s1 = A_int * 10;
            s2 = B_int * 10;
            s3 = C_int * 10;

            Point Side_a = new Point(0, 0);
            Point Side_b = new Point(s1, 0);


            double x = (Math.Pow(s1, 2) + Math.Pow(s3, 2) - Math.Pow(s2, 2)) / (2 * s1);
            double y = Math.Sqrt((Math.Pow(s3, 2)) - (Math.Pow(x, 2)));

            Point Side_c = new Point((int)x, (int)y);

            gp.DrawLine(p, Side_a, Side_b);
            gp.DrawLine(p, Side_b, Side_c);
            gp.DrawLine(p, Side_c, Side_a);
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

                if(a > 0 || b > 0 || c > 0)
                {
                    DrawTriangle(a, b, c);
                }
                else
                {

                }

                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");

                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Полупериметр");

                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");

                listView1.Items.Add("Угол α");
                listView1.Items.Add("Угол β");
                listView1.Items.Add("Угол γ");


                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());

                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));

                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));

                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.SemiPerimeter()));

                listView1.Items[7].SubItems.Add(triangle.TypeOfTirangle);

                if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Существует"); }
                else listView1.Items[6].SubItems.Add("Не существует");

                listView1.Items[8].SubItems.Add(Convert.ToString(triangle.DegA()));
                listView1.Items[9].SubItems.Add(Convert.ToString(triangle.DegB()));
                listView1.Items[10].SubItems.Add(Convert.ToString(triangle.DegY()));

                
            }
            else if(txtA.Text.Length > 0 && txtB.Text.Length > 0 && txtC.Text.Length == 0)
            {

                double a, b, c;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);

                Triangle triangle = new Triangle(a, b);

                c = triangle.PifagorC();

                Triangle triangle1 = new Triangle(a, b, c);

                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона с");

                

                listView1.Items.Add("Высота");

                listView1.Items.Add("Площадь");

                listView1.Items.Add("Полупериметр");

                listView1.Items.Add("Существует?");

                listView1.Items.Add("Угол α");
                listView1.Items.Add("Угол β");
                listView1.Items.Add("Угол γ");

                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());

                listView1.Items[2].SubItems.Add(Convert.ToString(triangle.PifagorC()));

                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.HeightH()));
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.AreaS()));
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.SemiPerimeter()));

                if (triangle1.ExistTriangle) { listView1.Items[6].SubItems.Add("Существует"); }
                else listView1.Items[6].SubItems.Add("Не существует");

                listView1.Items[7].SubItems.Add(Convert.ToString(triangle1.DegA()));
                listView1.Items[8].SubItems.Add(Convert.ToString(triangle1.DegB()));
                listView1.Items[9].SubItems.Add(Convert.ToString(triangle1.DegY()));

                DrawTriangle(a, b, c);
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
            panel1.Refresh();
        }
    }
}
