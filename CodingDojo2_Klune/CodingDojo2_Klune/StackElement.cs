using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo2_Klune.Stack
{
    class StackElement<T>
    {
        public T ValueOfElement { get; set; } //Stores the value of the staack entry
        public StackElement<T> Successor { get; set; } //points to the successor of this entry => the entry which was eded before this one
    }
}
