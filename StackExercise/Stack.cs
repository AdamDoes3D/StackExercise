using System;
using System.Collections.Generic;
using System.Text;

namespace StackExercise
{
    class Stack
    {
        private readonly List<object> _stackOfObjects;

        public Stack()
        {
            _stackOfObjects = new List<object>();
            //Console.WriteLine("New stack has been created.");
        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException();
            }
            _stackOfObjects.Add(obj);
            //Console.WriteLine($"{obj} has been added to the stack.");
        }

        public object Pop()
        {
            int numberOfItems = _stackOfObjects.Count;

            if (numberOfItems == 0)
            {
                throw new InvalidOperationException();
            }
            var popThisObject = _stackOfObjects[numberOfItems - 1];
            _stackOfObjects.RemoveAt(numberOfItems - 1);
            return popThisObject;
        }

        public void Clear()
        {
            if (_stackOfObjects.Count == 0)
            {
                Console.WriteLine("Cannot clear an empty stack.");
            }
            else
            {
                _stackOfObjects.Clear();
                //Console.WriteLine("Stack has been cleared");
            }
        }
    }
}
