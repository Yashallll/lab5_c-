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
            Presenter presenter;
        }
        public event EventHandler<EventArgs> SetA;
        public event EventHandler<EventArgs> SetB;
        public string Sq
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public double InputA
        {
            get { return Convert.ToDouble(textBox1.Text); }
            set { textBox1.Text = value.ToString(); }
        }
        public double InputB
        {
            get { return Convert.ToDouble(textBox2.Text); }
            set { textBox2.Text = value.ToString(); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (SetA != null)
            {
                SetA(this, EventArgs.Empty);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (SetB != null)
            {
                SetB(this, EventArgs.Empty);
            }
        }
    }
}
