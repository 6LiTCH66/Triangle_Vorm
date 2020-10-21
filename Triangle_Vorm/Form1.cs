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
        public Form1()
        {
            InitializeComponent();
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

                double a, b;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);

                Triangle triangle = new Triangle(a, b);

                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Сторона b");

                listView1.Items.Add("Высота");

                listView1.Items.Add("Площадь");

                listView1.Items.Add("Существует?");

                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());

                listView1.Items[2].SubItems.Add(Convert.ToString(triangle.HeightH()));
                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.AreaS()));

                if (triangle.ExistTriangle) { listView1.Items[4].SubItems.Add("Существует"); }
                else listView1.Items[4].SubItems.Add("Не существует");



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
            else if (txtA.Text.Length > 0 && txtB.Text.Length == 0 && txtC.Text.Length == 0 && txtCorner.Text.Length > 0)
            {
                double a;
                double corner;

                a = Convert.ToDouble(txtA.Text);
                corner = Convert.ToDouble(txtCorner.Text);

                Triangle3 triangle3 = new Triangle3(a, corner);


                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Угол треугольника α");
                listView1.Items.Add("Высота");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Существует?");



                listView1.Items[0].SubItems.Add(triangle3.outputA());
                listView1.Items[1].SubItems.Add(triangle3.outputCorner());
                listView1.Items[2].SubItems.Add(Convert.ToString(triangle3.Height()));
                listView1.Items[3].SubItems.Add(Convert.ToString(triangle3.Area()));
                if (triangle3.ExistTriangle) { listView1.Items[4].SubItems.Add("Существует"); }
                else listView1.Items[4].SubItems.Add("Не существует");
            }
            else
            {
                MessageBox.Show("Не все поля были заполнены");
            }
            


        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

    }
}
