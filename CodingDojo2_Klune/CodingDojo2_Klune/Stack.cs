using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo2_Klune.Stack
{
    class Stack<T>
    {
        private StackElement<T> currentElement; //stores the latest entry of the stack

        /// <summary>
        /// Adds new Elements to the stack 
        /// </summary>
        /// <param name="item">item which should be added to the stack</param>
        public void Push(T item)
        {
            if (currentElement == null)
            {
                currentElement = new StackElement<T>() { ValueOfElement = item, Successor = null };
            }
            else
            {
                StackElement<T> temp = new StackElement<T>() { ValueOfElement = item, Successor = currentElement };
                currentElement = temp;
            }

        }

        /// <summary>
        /// Removes the last entry from the Stack
        /// If the stack is empty pop will return a default value
        /// </summary>
        /// <returns>deleted stack entry</returns>
        public T Pop()
        {
            if (currentElement != null)
            {
                T temp = currentElement.ValueOfElement;
                currentElement = currentElement.Successor;
                return temp;
            }
            else
            {
                throw new NullReferenceException(); //throw an exception becasue stack is entry
            }
        }

        /// <summary>
        /// Returns the value of the last entry (on top of the stack)
        /// If the stack is empty pop will return a default value
        /// </summary>
        /// <returns>value of current stack entry</returns>
        public T Peek()
        {
            if (currentElement != null)
            {
                return currentElement.ValueOfElement;
            }
            else
            {
                return default(T);
            }
        }

    }
}
