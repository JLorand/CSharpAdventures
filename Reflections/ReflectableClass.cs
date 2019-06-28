using System;
using System.Collections.Generic;
using System.Text;

namespace Reflections
{
    [ReflectableClass]
    public class ReflectableClass
    {
        public string FirstProperty { get; set; } = "First Porperty Value";
        public int SecondProperty { get; set; } = 123;
        public bool ThirdProperty { get; set; } = true;

        [ReflectableMethod]
        public void FirstMethod(string thing)
        {
            Console.WriteLine($"I do {thing}");
        }
    }
}
