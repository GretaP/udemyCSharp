/*A Stack is a data structure for storing a list of elements in a LIFO(last in, first out) fashion.
Design a class called Stack with three methods.
void Push(object obj)
object Pop()
void Clear()

We should be able to use this stack class as follows:
var stack = new Stack();
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
The output of this program will be
3
2
1
Note: The downside of using the object class here is that if we store value types(eg int, char,
bool, DateTime) in our Stack, boxing and unboxing occurs, which comes with a small
performance penalty.In my C# Advanced course, I’ll teach you how to resolve this by using
generics, but for now don’t worry about it.*/

using System;

namespace SetB
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
