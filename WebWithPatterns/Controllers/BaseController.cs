using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebWithPatterns.CompositeCommands;

namespace WebWithPatterns.Controllers
{
    public class BaseController: Controller
    {
        public object GetModel<T>(ModelGetter<T> modelGetter)
        {
            modelGetter.Execute();
            return modelGetter.GetModel();
        }
    }
}
