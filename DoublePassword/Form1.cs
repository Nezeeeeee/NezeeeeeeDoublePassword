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
            if(textBox1.Text == "123")
            {
                textBox2.Visible = true;
                button2.Visible = true;
                
                
            }
            else
            {
                MessageBox.Show("ошибка","введите верный пароль");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "321")
            {
                MessageBox.Show("Успешно!", "Вы в системе!");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("Введите верный пароль!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            textBox2.Visible = false;
            pictureBox1.Visible = false;
            textBox1.Text = "";
        }
    }
}
