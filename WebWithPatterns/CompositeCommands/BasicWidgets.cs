using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWithPatterns.Models;

namespace WebWithPatterns.CompositeCommands
{
    public class BasicWidgets : Component
    {
        private RefWrapper<IList<President>> _WidgetsRef;

        public BasicWidgets(RefWrapper<IList<President>> widgetsRef)
        {
            _WidgetsRef = widgetsRef;
        }
        public override void Execute()
        {
            _WidgetsRef.Value = new List<President>
            {
                new President{Id=42,Name="Clinton"},
                new President{Id=43,Name="Bush"},
                new President{Id=44, Name="Obama"}
            };
        }

        private void Reassign(ref List<President> widgets)
        {
            widgets = new List<President>
            {
                new President{Id=42,Name="Clinton"},
                new President{Id=43,Name="Bush"},
                new President{Id=44, Name="Obama"}
            };
        }
    }
}
