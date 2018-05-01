using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWithPatterns.Models;

namespace WebWithPatterns.CompositeCommands
{
    public class WidgetGetter : ModelGetter<IList<President>>
    {
        public WidgetGetter(RefWrapper<IList<President>> receiver): base(receiver)
        {
            _Components = new List<Component>
            {
                new BasicWidgets(_receiver)
            };

        }

        //protected RefWrapper<List<Widget>> _WidgetsRef = new RefWrapper<List<Widget>> { Value = new List<Widget>() };

        //public override IEnumerable<Widget> GetModel()
        //{
        //    return _WidgetsRef.Value;
        //}
    }
}
