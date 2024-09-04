using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public interface IView
    {
        string Sq { get; set; }
        double InputA { get; set; }
        double InputB { get; set; }
        event EventHandler<EventArgs> SetA;
        event EventHandler<EventArgs> SetB;
    }

    class Presenter
    {
        private Model model = new Model();
        private IView view;
        public Presenter(IView view)
        {
            this.view = view;
            this.view.SetA += new EventHandler<EventArgs>(OnSetA);
            this.view.SetB += new EventHandler<EventArgs>(OnSetB);
            RefreshView();
        }
        public void OnSetA(object sender, EventArgs e)
        {
            model.A = view.InputA;
            RefreshView();
        }
        public void OnSetB(object sender, EventArgs e)
        {
            model.B = view.InputB;
            RefreshView();
        }
        public void RefreshView()
        {
            view.Sq = model.square().ToString();
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
