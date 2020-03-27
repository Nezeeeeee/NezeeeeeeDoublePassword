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

        //private void button1_Click(object sender, EventArgs e)
        ///{
        #region firtsVerion
        //var button = (Button)sender;

        //if (button.Focused && textBox1.Text == "123")
        //{
        //    //действия для второго клика
        //    label2.Visible = true;
        //    label2.Text = "Введите второй пароль!";
        //    textBox1.Text = "";
        //}
        //else
        //{

        //    if (textBox1.Text == "321")
        //    {
        //        MessageBox.Show("Успех", "Вы в системе!");
        //        pictureBox1.Visible = true;
        //        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //        label2.Text = "Нормасик!";
        //        textBox1.Text = "";
        //        button1.Visible = false;

        //    }
        //    //действия для первого клика
        //}
        #endregion
        #region SecondVersion
        //var button = (Button)sender;

        //if (button.Focused)
        //{
        //    if (textBox1.Text == "123")
        //    {
        //        //действия для второго клика
        //        label2.Visible = true;
        //        label2.Text = "Введите второй пароль!";
        //        textBox1.Text = "";
        //    }
        //    else if(textBox1.Text == "321")
        //    {
        //        MessageBox.Show("Успех", "Вы в системе!");
        //        pictureBox1.Visible = true;
        //        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //        label2.Text = "Нормасик!";
        //        textBox1.Text = "";
        //        button1.Visible = false;
        //        label1.Text = "";
        //        textBox1.Visible = false;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Введите верный пароль!");
        //    }

        //}
        #endregion
        //}
        bool state = false;
        private void firstAction(object sender, EventArgs e)
        {
            if (textBox1.Text == "123")
            {
                //действия для второго клика
                label2.Visible = true;
                label2.Text = "Введите второй пароль!";
                textBox1.Text = "";
                state = true;
            }
            else
            {
                textBox1.Text = "";
                state = false;
                MessageBox.Show("Введите верный пароль!");
            }
            //MessageBox.Show("Первое действие");
            this.button1.Click -= new EventHandler(firstAction);
            this.button1.Click += new EventHandler(secondAction);
            

        }

        private void secondAction(object sender, EventArgs e)
        {
            if (textBox1.Text == "321" && state == true)
            {
                MessageBox.Show("Успех", "Вы в системе!");
                pictureBox1.Visible = true;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                label2.Text = "Нормасик!";
                textBox1.Text = "";
                button1.Visible = false;
                label1.Text = "";
                textBox1.Visible = false;
                state = true;
            }
            else
            {
                textBox1.Text = "";
                state = false;
                MessageBox.Show("Введите верный пароль!");
            }
            //MessageBox.Show("Второе действие");
            this.button1.Click -= new EventHandler(secondAction);
            this.button1.Click += new EventHandler(firstAction);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            textBox1.Text = "";
            label2.Text = "";
            button1.Visible = true;
            label1.Text = "Password";
            textBox1.Visible = true;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия проги: 0.02","О программе");
        }
    }
}
