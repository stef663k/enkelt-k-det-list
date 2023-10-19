using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace enkelt_kædet_liste
{
    public class Element
    {
        public int data { get; set; }
        public Element? next { get; set; }

        public Element(int data, Element? next)
        {
            this.data = data;
            this.next = next;
        }
    }
}