using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

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
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private double length;
        public double Length
        {
            get { return length; }
            set { length = value;
                OnPropertyChanged("Sq");}
        }
        private double width;
        public double Width
        {
            get { return width; }
            set { width = value;
                OnPropertyChanged("Sq");
            }
        }
        public double Sq
        {
            get { return width * length; }
        }
    }
}
