/*We use the “object” type here so we can store any objects inside the stack.Remember the “object” class is the base of all classes
in the.NET Framework.So any types can be automatically upcast to the object. Make sure to
take into account the scenario that null is passed to this object. We should not store null
references in the stack. So if null is passed to this method, you should throw an
InvalidOperationException. Remember, when coding every method, you should think of all
possibilities and make sure the method behaves properly in all these edge cases. That’s what
distinguishes you from an “average” programmer.*/

/// <summary>
/// The Push() method stores the given object on top of the stack.
/// </summary>

using System;

namespace SetB
{
    class Push
    {
    }
}
