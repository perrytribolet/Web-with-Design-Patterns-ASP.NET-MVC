using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWithPatterns.CompositeCommands
{
    public abstract class ModelGetter<T> : CommandBranch
    {
        public abstract T GetModel();
    }
}
