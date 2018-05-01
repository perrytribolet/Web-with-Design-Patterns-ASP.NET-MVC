using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWithPatterns.Models;

namespace WebWithPatterns.CompositeCommands
{
    public class WidgetGetter : ModelGetter<IEnumerable<Widget>>
    {
        public WidgetGetter()
        {
            _Components = new List<Component>
            {
                new BasicWidgets(_WidgetsRef)
            };

        }

        protected RefWrapper<List<Widget>> _WidgetsRef = new RefWrapper<List<Widget>> { Value = new List<Widget>() };

        public override IEnumerable<Widget> GetModel()
        {
            return _WidgetsRef.Value;
        }
    }
}
