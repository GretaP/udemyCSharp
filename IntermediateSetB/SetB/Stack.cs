/*Design a class called Stack with three methods.
void Push(object obj)
object Pop()
void Clear()

The Push() method stores the given object on top of the stack. We use the “object” type here so
we can store any objects inside the stack.  Remember the “object” class is the base of all classes
in the.NET Framework.  So any types can be automatically upcast to the object. 

Make sure to take into account the scenario that null is passed to this object. We should not store null
references in the stack. So if null is passed to this method, you should throw an
InvalidOperationException. Remember, when coding every method, you should think of all
possibilities and make sure the method behaves properly in all these edge cases. That’s what
distinguishes you from an “average” programmer.

The Pop() method removes the object on top of the stack and returns it.Make sure to take into
account the scenario that we call the Pop() method on an empty stack. In this case, this method
should throw an InvalidOperationException. Remember, your classes should always be in a valid
state and used properly. When they are misused, they should throw exceptions.Again, thinking
of all these edge cases, separates you from an average programmer. The code written this way
will be more robust and with less bugs.

The Clear() method removes all objects from the stack. */


using System;

namespace SetB
{
    class Stack
    {
        private 
        void Push(object obj)
        {

        }

        object Pop()
        {

        }

        void Clear() { }
    }
}
