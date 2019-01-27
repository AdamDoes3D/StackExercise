using System;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            //stack.Push(null);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //stack.Clear();
            //stack.Clear();

            Console.ReadKey();
        }
    }
}
