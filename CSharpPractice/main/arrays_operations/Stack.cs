using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.arrays_operations
{
    public  class Stack
    {
        private object[] _stackArray;
        private int _top;


        public Stack()
        {
            _stackArray = new object[100];
            _top = -1; //initialize that stack is empty
        }


        public void Push(object value)
        {
            if (_top == _stackArray.Length - 1)
            {
                throw new InvalidOperationException("Stack is full");
            }
            else if (value == null)
            {
                throw new InvalidOperationException("Attempt to pass null");
            }
            else
            {
                _top++;
                _stackArray[_top] = value;
            }
        }
        public object Pop()
        {
            if (_top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            var result = _stackArray[_top];
            _top--;
                return result;
            
        }

        public void Clear()
        {
            _top = -1;
        }
    }
}
