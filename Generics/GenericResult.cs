using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class GenericResult<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public Type Type { get; internal set; }
    }
}
