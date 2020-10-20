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
    public partial class Form2 : Form
    {
        ListView listView;
        ColumnHeader columnHeader5, columnHeader6;
        TextBox _txtA, _txtH;
        Button Run_Button;
        Label lbl1, lbl2;


        public Form2()
        {
            this.Size = new Size(800, 400);
            Run_Button = new Button();
            Run_Button.Text = "Запустить";
            Run_Button.Location = new Point(569, 36);
            Run_Button.Size = new Size(157, 85);
            Run_Button.Click += Run_Button_Click;

            

            listView = new ListView();
            listView.Size = new Size(515, 199);

            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();

            columnHeader5.Text = "Поле";
            columnHeader5.TextAlign = HorizontalAlignment.Left;
            columnHeader6.Text = "Значение";
            columnHeader6.TextAlign = HorizontalAlignment.Left;

            listView.Columns.Add(columnHeader5);
            listView.Columns.Add(columnHeader6);
            listView.BackColor = Color.Gold;
            listView.View = View.Details;

            _txtA = new TextBox();
            _txtA.Size = new Size(102, 20);
            _txtA.Location = new Point(423, 240);
            _txtH = new TextBox();
            _txtH.Size = new Size(102, 20);
            _txtH.Location = new Point(423, 274);

            lbl1 = new Label();
            lbl1.Text = "Сторона A";
            lbl1.Location = new Point(341, 241);
            lbl1.Size = new Size(76, 16);

            lbl2 = new Label();
            lbl2.Text = "Высота H";
            lbl2.Location = new Point(341, 277);
            lbl2.Size = new Size(76, 16);


            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(listView);
            Controls.Add(Run_Button);
            Controls.Add(_txtH);
            Controls.Add(_txtA);
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                listView.Items.Clear();
            };
            if (_txtA.Text.Length > 0 && _txtH.Text.Length > 0)
            {
                double a, h;
                a = Convert.ToDouble(_txtA.Text);
                h = Convert.ToDouble(_txtH.Text);
                Triangle2 triangle2 = new Triangle2(a, h);
                listView.Items.Add("Основание треугольника");
                listView.Items.Add("Высота треугольника");
                listView.Items.Add("Площадь");

                listView.Items[0].SubItems.Add(triangle2.outputA2());
                listView.Items[1].SubItems.Add(triangle2.outputH2());
                listView.Items[2].SubItems.Add(Convert.ToString(triangle2.areaOfTriangle()));
            }
            else
            {
                MessageBox.Show("Не все поля были заполнены");
            }
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }
    }
}
