using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DelegateAndEvent
{
    public partial class Form1 : Form
    {
        CatAndMouse.Cat _Cat = null;

        CatAndMouse.Mouse _Mouse1 = null;
        CatAndMouse.Mouse _Mouse2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _Cat = new CatAndMouse.Cat("Tom", this);
            _Mouse1 = new CatAndMouse.Mouse("Jerry", this);
            _Mouse2 = new CatAndMouse.Mouse("Jack", this);
            _Cat.CatShout += new CatAndMouse.Cat.CatShoutEventHandler(_Mouse1.Run);
            _Cat.CatShout += new CatAndMouse.Cat.CatShoutEventHandler(_Mouse2.Run);
            _Cat.Shout();

            /*
            _Mouse1 = new CatAndMouse.Mouse("Jerry", this);
            _Mouse2 = new CatAndMouse.Mouse("Jack", this);
            _Mouse1.Run();
            _Mouse2.Run();
            */
          
        }
    }
}
