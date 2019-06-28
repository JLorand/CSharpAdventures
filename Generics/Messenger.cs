using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Messenger<T>
    {
        private readonly T _message;

        public Messenger(T message)
        {
            _message = message;
        }

        public GenericResult<T> GetBaseResponse()
        {
            return new GenericResult<T>()
            {
                Success = true,
                Data = _message,
                Type = _message.GetType()
            };
        }

        public GenericResult<T> GetNewMessage(T message)
        {
            return new GenericResult<T>()
            {
                Success = true,
                Data = message,
                Type = message.GetType()
            };
        }
    }
}
