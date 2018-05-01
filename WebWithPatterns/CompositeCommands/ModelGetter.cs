using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWithPatterns.CompositeCommands
{
    public abstract class ModelGetter<T> : CommandBranch
    {
        protected RefWrapper<T> _receiver;

        public ModelGetter(RefWrapper<T> receiver)
        {
            _receiver = receiver;
        }

        public virtual RefWrapper<T> GetModel() {
            base.Execute();
            return _receiver;
        }
    }
}
