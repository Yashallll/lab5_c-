using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public interface IView
    {
        string Perpendicularity { get; set; }
        string Angle { get; set; }
        double InputA1 { get; set; }
        double InputB1 { get; set; }
        event EventHandler<EventArgs> SetA1;
        event EventHandler<EventArgs> SetB1;
        double InputA2 { get; set; }
        double InputB2 { get; set; }
        event EventHandler<EventArgs> SetA2;
        event EventHandler<EventArgs> SetB2;
        string Intersection_points1 { get; set; }
        string Intersection_points2 { get; set; }
    }

    class Presenter
    {
        private Straight straight1 = new Straight();
        private Straight straight2 = new Straight();
        private IView view;
        public Presenter(IView view)
        {
            this.view = view;
            this.view.SetA1 += new EventHandler<EventArgs>(OnSetA1);
            this.view.SetB1 += new EventHandler<EventArgs>(OnSetB1);
            this.view.SetA2 += new EventHandler<EventArgs>(OnSetA2);
            this.view.SetB2 += new EventHandler<EventArgs>(OnSetB2);
            RefreshView();
        }
        public void OnSetA1(object sender, EventArgs e)
        {
            straight1.A = view.InputA1;
            RefreshView();
        }
        public void OnSetB1(object sender, EventArgs e)
        {
            straight1.B = view.InputB1;
            RefreshView();
        }
        public void OnSetA2(object sender, EventArgs e)
        {
            straight2.A = view.InputA2;
            RefreshView();
        }
        public void OnSetB2(object sender, EventArgs e)
        {
            straight2.B = view.InputB2;
            RefreshView();
        }
        public void RefreshView()
        {
            view.Perpendicularity = straight1.Perpendicularity_Check(straight2);
            view.Angle = straight1.Finding_an_Angle(straight2);
            view.Intersection_points1 = straight1.Intersection_points();
            view.Intersection_points2 = straight2.Intersection_points();
        }
    }

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 view = new Form1();
            Presenter presenter = new Presenter(view);
            Application.Run(view);
        }
    }
}
