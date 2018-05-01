using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWithPatterns.CompositeCommands
{
    public sealed class RefWrapper<T>
    {
        public T Value { get; set; }
    }
}
