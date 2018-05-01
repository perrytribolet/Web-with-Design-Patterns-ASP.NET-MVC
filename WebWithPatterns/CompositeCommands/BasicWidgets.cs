using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWithPatterns.Models;

namespace WebWithPatterns.CompositeCommands
{
    public class BasicWidgets : Component
    {
        private RefWrapper<List<Widget>> _WidgetsRef;

        public BasicWidgets(RefWrapper<List<Widget>> widgetsRef)
        {
            _WidgetsRef = widgetsRef;
        }
        public override void Execute()
        {
            _WidgetsRef.Value = new List<Widget>
            {
                new Widget{Id=42,Name="Clinton"},
                new Widget{Id=43,Name="Bush"},
                new Widget{Id=44, Name="Obama"}
            };
        }

        private void Reassign(ref List<Widget> widgets)
        {
            widgets = new List<Widget>
            {
                new Widget{Id=42,Name="Clinton"},
                new Widget{Id=43,Name="Bush"},
                new Widget{Id=44, Name="Obama"}
            };
        }
    }
}
