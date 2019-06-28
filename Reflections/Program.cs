using System;
using System.Linq;
using System.Reflection;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectableClass reflectableClass = new ReflectableClass();
            var properties = typeof(ReflectableClass).GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"Property:{Environment.NewLine}" +
                    $"\tName: {property.Name}{Environment.NewLine}" +
                    $"\tType: {property.PropertyType}{Environment.NewLine}" +
                    $"\tValue: {property.GetValue(reflectableClass)}");
            }


            var methods = typeof(ReflectableClass).GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine($"Method:{Environment.NewLine}" +
                    $"\tName: {method.Name}{Environment.NewLine}" +
                    $"\tParameters: {method.GetParameters()}{Environment.NewLine}" +
                    $"\tReturn type: {method.ReturnType}");
            }


            var classesReflectedByAttribute =
                Assembly.GetExecutingAssembly().GetTypes().Where(type =>
                    type.CustomAttributes.Any(attr =>
                        attr.AttributeType == typeof(ReflectableClassAttribute)));
            Console.WriteLine($"Number of reflected classes with custom attributes: {classesReflectedByAttribute?.Count() ?? 0}");
            foreach (var type in classesReflectedByAttribute)
            {
                Console.WriteLine($"Type:{Environment.NewLine}" +
                    $"\tName: {type.Name}");
            }


            var methodsReflectedByAttribute = 
                Assembly.GetExecutingAssembly().GetTypes().SelectMany(type => 
                    type.GetMethods().Where(method => method.GetCustomAttributes().Any(attr =>
                        attr.GetType() == typeof(ReflectableMethodAttribute))));
            Console.WriteLine($"Number of reflected methods with custom attributes: {methodsReflectedByAttribute?.Count() ?? 0}");
            foreach (var type in methodsReflectedByAttribute)
            {
                Console.WriteLine($"Type:{Environment.NewLine}" +
                    $"\tName: {type.Name}");
            }

            Console.WriteLine("And finally invoke the reflected method with a parameter...");
            methodsReflectedByAttribute.FirstOrDefault()?.Invoke(reflectableClass, new[] { "nothing" });
        }
    }
}
