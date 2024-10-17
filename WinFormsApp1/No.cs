using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class No
    {
        public string elemento;
        public No next;

        public No(string elemento, No next)
        {
            this.elemento = elemento;
            this.next = next;
        }

        public string getElemento()
        {
            return elemento;
        }

        public void setElemento(string elemento)
        {
            this.elemento = elemento;
        }

        public No getNo()
        {
            return next;
        }

        public void setNo(No next)
        {
            this.next = next;
        }
    }
}
