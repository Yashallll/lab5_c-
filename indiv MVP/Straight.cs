using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Straight
    {
        private double a, b;
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
        public string Intersection_points()
        {
            string result = $"y(0;{Math.Round(a * 0 + b, 2)})";
            if (a == 0)
            {
                result += "\nНет пересечения с x!!!";
            }
            else result += $" x({Math.Round((0 - b) / a, 2)};0)";
            return result;
        }
        public string Perpendicularity_Check(Straight straight)
        {
            if (a * straight.a == -1)
            {
                return "Две прямые перпендикулярны.";
            }
            else
            {
                return "Две прямые неперпендикулярны!";
            }
        }
        public string Finding_an_Angle(Straight straight)
        {
            if (a * straight.a == -1)
            { 
                return ""; 
            }
            else
            {
                double angle = Math.Atan((a - straight.a) / (1 + a * straight.a));
                if (angle < 0)
                {
                    angle += 2;
                }
                if (angle * 180 / Math.PI == 0)
                {
                    return "Прямые параллельные.";
                }
                else 
                { 
                    return $"Угол между прямыми равен {Math.Round(angle * 180 / Math.PI, 2)}"; 
                }
            }
        }
    }
}
