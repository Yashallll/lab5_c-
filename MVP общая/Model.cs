using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Model
    {
        private double a;
        private double b;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double square()
        {
            return a * b;
        }
    }
}
