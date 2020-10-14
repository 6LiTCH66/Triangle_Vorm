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

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.Run_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Info;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Location = new System.Drawing.Point(11, 9);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(515, 199);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Поле";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Значение";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(423, 240);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(102, 20);
            this.txtA.TabIndex = 1;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(423, 274);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(102, 20);
            this.txtH.TabIndex = 2;
            // 
            // Run_button
            // 
            this.Run_button.BackColor = System.Drawing.SystemColors.Info;
            this.Run_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Run_button.Location = new System.Drawing.Point(569, 36);
            this.Run_button.Name = "Run_button";
            this.Run_button.Size = new System.Drawing.Size(157, 85);
            this.Run_button.TabIndex = 0;
            this.Run_button.Text = "Запустить";
            this.Run_button.UseVisualStyleBackColor = false;
            this.Run_button.Click += new System.EventHandler(this.Run_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(341, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сторона A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(341, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Высота H";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Run_button);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.listView2);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            if(listView2.Items.Count > 0)
            {
                listView2.Items.Clear();
            };
            if(txtA.Text.Length > 0 && txtH.Text.Length > 0)
            {
                double a, h;
                a = Convert.ToDouble(txtA.Text);
                h = Convert.ToDouble(txtH.Text);
                Triangle2 triangle2 = new Triangle2(a, h);
                listView2.Items.Add("Основание треугольника");
                listView2.Items.Add("Высота треугольника");
                listView2.Items.Add("Площадь");

                listView2.Items[0].SubItems.Add(triangle2.outputA2());
                listView2.Items[1].SubItems.Add(triangle2.outputH2());
                listView2.Items[2].SubItems.Add(Convert.ToString(triangle2.areaOfTriangle()));
            }
            else
            {
                MessageBox.Show("Не все поля были заполнены");
            }
        }
    }
}
