using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
   public class CatAndMouse
    {
        public class Cat
        {
            private string name;
            private Form1 _form;

            public Cat(string name, Form1 _form)
            {
                this.name = name;
                this._form = _form;
            }

            public delegate void CatShoutEventHandler();

            public event CatShoutEventHandler CatShout;

            public void Shout()
            {
                // Console.WriteLine("喵,我是{0}", name);
                // return string.Format("喵,我是{0}", name);    
                _form.textBox1.Text  +=string.Format("喵,我是{0}", name)+"\r\n";
                if (CatShout != null)
                {
                    // CatShout(); //這樣也可以
                    CatShout();

                }



            }
        }

        public class Mouse
        {
            private string name;
            private Form1 _form;

            public Mouse(string name ,Form1 _form)
            {
                this.name = name;
                this._form = _form;

            }

            public void Run()
            {

                _form.textBox1.Text += string.Format("老貓,{0}快跑", name) + "\r\n";

            }
        }
    
    }
}
