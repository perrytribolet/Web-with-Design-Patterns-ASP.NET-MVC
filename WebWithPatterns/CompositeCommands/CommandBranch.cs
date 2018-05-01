using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWithPatterns.CompositeCommands
{
    public abstract class CommandBranch: Component
    {
        protected IEnumerable<Component> _Components;

        public override void Execute()
        {
            foreach (var c in _Components) c.Execute();
        }
    }
}
