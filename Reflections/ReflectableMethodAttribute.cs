using System;
using System.Collections.Generic;
using System.Text;

namespace Reflections
{
    [AttributeUsage(AttributeTargets.Method)]
    class ReflectableMethodAttribute : Attribute
    {
    }
}
