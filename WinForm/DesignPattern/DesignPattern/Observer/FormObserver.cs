using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern.Observer
{
    public partial class FormObserver : Form
    {
        public FormObserver()
        {
            InitializeComponent();
        }

        private void FormObserver_Load(object sender, EventArgs e)
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
        }
    }
}
