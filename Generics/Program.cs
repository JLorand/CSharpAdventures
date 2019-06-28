using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Messenger<string> stringMessenger = new Messenger<string>("Base message");
            var result1 = stringMessenger.GetBaseResponse();
            Console.WriteLine($"First result:{Environment.NewLine}" +
                $"\tSuccess: {result1.Success}{Environment.NewLine}" +
                $"\tData: {result1.Data}{Environment.NewLine}" +
                $"\tData type: {result1.Type}");

            Messenger<int> intMessenger = new Messenger<int>(1);
            var result2 = intMessenger.GetBaseResponse();
            Console.WriteLine($"Second result:{Environment.NewLine}" +
                $"\tSuccess: {result2.Success}{Environment.NewLine}" +
                $"\tData: {result2.Data}{Environment.NewLine}" +
                $"\tData type: {result2.Type}");

            Messenger<bool> boolMessenger = new Messenger<bool>(true);
            var result3 = boolMessenger.GetBaseResponse();
            Console.WriteLine($"Third result:{Environment.NewLine}" +
                $"\tSuccess: {result3.Success}{Environment.NewLine}" +
                $"\tData: {result3.Data}{Environment.NewLine}" +
                $"\tData type: {result3.Type}");

            Messenger<string> newMessenger = new Messenger<string>("BaseMessage");
            var result4 = newMessenger.GetNewMessage("New message");
            Console.WriteLine($"Fourth result:{Environment.NewLine}" +
                $"\tSuccess: {result4.Success}{Environment.NewLine}" +
                $"\tData: {result4.Data}{Environment.NewLine}" +
                $"\tData type: {result4.Type}");
        }
    }
}
