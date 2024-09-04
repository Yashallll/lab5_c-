using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }
        public event EventHandler<EventArgs> SetA1;
        public event EventHandler<EventArgs> SetB1;
        public event EventHandler<EventArgs> SetA2;
        public event EventHandler<EventArgs> SetB2;
        public string Angle
        {
            get { return label6.Text; }
            set { label6.Text = value; }
        }
        public string Perpendicularity
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }
        public string Intersection_points1
        {
            get { return label7.Text; }
            set { label7.Text = value; }
        }
        public string Intersection_points2
        {
            get { return label8.Text; }
            set { label8.Text = value; }
        }
        public double InputA1
        {
            get 
            {
                if (textBox1.Text.Length != 0)
                {
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        if (!Char.IsDigit((char)textBox1.Text[i]) && textBox1.Text[0] != '-')
                        {
                            MessageBox.Show("Неверный тип данных.");
                            return 0;
                        }
                    }
                    if (textBox1.Text[0] == '-' && textBox1.Text.Length == 1)
                    {
                        return 0;
                    }
                    else
                        return Convert.ToDouble(textBox1.Text);
                }
                return 0;
            }
            set { textBox1.Text = value.ToString(); }
        }
        public double InputB1
        {
            get {
                if (textBox2.Text.Length != 0)
                {
                    for (int i = 0; i < textBox2.Text.Length; i++)
                    {
                        if (!Char.IsDigit((char)textBox2.Text[i]) && textBox2.Text[0] != '-')
                        {
                            MessageBox.Show("Неверный тип данных.");
                            return 0;
                        }
                    }
                    if (textBox2.Text[0] == '-' && textBox2.Text.Length == 1)
                    {
                        return 0;
                    }
                    else
                        return Convert.ToDouble(textBox2.Text);
                }
                return 0;
            }
            set { textBox2.Text = value.ToString(); }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (SetA1 != null)
            {
                SetA1(this, EventArgs.Empty);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (SetB1 != null)
            {
                SetB1(this, EventArgs.Empty);
            }
        }
        public double InputA2
        {
            get {
                if (textBox3.Text.Length != 0)
                {
                    for (int i = 0; i < textBox3.Text.Length; i++)
                    {
                        if (!Char.IsDigit((char)textBox3.Text[i]) && textBox3.Text[0] != '-')
                        {
                            MessageBox.Show("Неверный тип данных.");
                            return 0;
                        }
                    }
                    if (textBox3.Text[0] == '-' && textBox3.Text.Length == 1)
                    {
                        return 0;
                    }
                    else
                        return Convert.ToDouble(textBox3.Text);
                }
                return 0;
            }
            set { textBox3.Text = value.ToString(); }
        }
        public double InputB2
        {
            get {
                if (textBox4.Text.Length != 0)
                {
                    for (int i = 0; i < textBox4.Text.Length; i++)
                    {
                        if (!Char.IsDigit((char)textBox4.Text[i]) && textBox4.Text[0] != '-')
                        {
                            MessageBox.Show("Неверный тип данных.");
                            return 0;
                        }
                    }
                    if (textBox4.Text[0] == '-' && textBox4.Text.Length == 1)
                    {
                        return 0;
                    }
                    else
                        return Convert.ToDouble(textBox4.Text);
                }
                return 0;
            }
            set { textBox4.Text = value.ToString(); }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (SetA2 != null)
            {
                SetA2(this, EventArgs.Empty);
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (SetB2 != null)
            {
                SetB2(this, EventArgs.Empty);
            }
        }
    }
}
