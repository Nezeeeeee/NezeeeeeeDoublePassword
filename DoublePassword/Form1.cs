using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoublePassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region firtsVerion
            var button = (Button)sender;
            if (button.Focused && textBox1.Text == "123")
            {
                //действия для второго клика
                label2.Visible = true;
                label2.Text = "Введите второй пароль!";
                textBox1.Text = "";
            }
            else
            {

                if (textBox1.Text == "321")
                {
                    MessageBox.Show("Успех", "Вы в системе!");
                    pictureBox1.Visible = true;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label2.Text = "Нормасик!";

                }
                //действия для первого клика
            }
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            textBox1.Text = "";
            label2.Text = "";
        }




        
    }
}
