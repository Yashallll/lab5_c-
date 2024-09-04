using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WpfApp1
{
    class ViewModel
    {
        public Model model { get; set; }
        public ViewModel()
        {
            model = new Model();
        }
    }
    public class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName1, string propertyName2, string propertyName3, string propertyName4)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName1));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName2));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName3));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName4));
        }
        private double a1, b1, a2, b2;
        public double A1
        {
            get { return a1; }
            set { a1 = value;
                OnPropertyChanged("Intersection_points1", "Intersection_points2", "Perpendicularity_Check", "Finding_an_Angle");
            }
        }
        public double B1
        {
            get { return b1; }
            set { b1 = value;
                OnPropertyChanged("Intersection_points1", "Intersection_points2", "Perpendicularity_Check", "Finding_an_Angle");
            }
        }
        public double A2
        {
            get { return a2; }
            set
            {
                a2 = value;
                OnPropertyChanged("Intersection_points1", "Intersection_points2", "Perpendicularity_Check", "Finding_an_Angle");
            }
        }
        public double B2
        {
            get { return b2; }
            set
            {
                b2 = value;
                OnPropertyChanged("Intersection_points1", "Intersection_points2", "Perpendicularity_Check", "Finding_an_Angle");
            }
        }
        public string Intersection_points1
        {
            get
            {
                string result = $"y(0;{Math.Round(a1 * 0 + b1, 2)})";
                if (a1 == 0)
                {
                    result += "\nНет пересечения с x!!!";
                }
                else result += $" x({Math.Round((0 - b1) / a1, 2)};0)";
                return result;
            }
        }
        public string Intersection_points2
        {
            get
            {
                string result = $"y(0;{Math.Round(a2 * 0 + b2, 2)})";
                if (a1 == 0)
                {
                    result += "\nНет пересечения с x!!!";
                }
                else result += $" x({Math.Round((0 - b2) / a2, 2)};0)";
                return result;
            }
        }
        public string Perpendicularity_Check
        {
            get
            {
                if (a1 * a2 == -1)
                {
                    return "Две прямые перпендикулярны.";
                }
                else
                {
                    return "Две прямые неперпендикулярны!";
                }
            }
        }
        public string Finding_an_Angle
        {
            get
            {
                if (a1 * a2 == -1)
                {
                    return "";
                }
                else
                {
                    double angle = Math.Atan((a1 - a2) / (1 + a1 * a2));
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
}
