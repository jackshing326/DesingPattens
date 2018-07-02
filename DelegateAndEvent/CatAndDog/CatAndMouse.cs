using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAndMouse
{
   
       public class Cat
        {
            private string name;

            public Cat(string name)
            {
                this.name = name;
            }

            public delegate void CatShoutEventHandler( );

            public event CatShoutEventHandler CatShout;

            public void Shout(ref string result)
            {
                Console.WriteLine("喵,我是{0}", name);
               // return string.Format("喵,我是{0}", name);    
               // result = string.Format("喵,我是{0}", name);
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

            public Mouse(string name)
            {
                this.name = name;
            }

            public void Run()
            {
             
                Console.WriteLine("老貓,{0}快跑", name);

            }
        }
    
}
