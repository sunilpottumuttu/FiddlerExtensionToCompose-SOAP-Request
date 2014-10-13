using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fiddler;

namespace SOAPRequestComposer
{
    public class BootStrap : IHandleExecAction, IFiddlerExtension
    {


        public bool OnExecAction(string sCommand)
        {
            throw new NotImplementedException();
        }

        public void OnBeforeUnload()
        {
            throw new NotImplementedException();
        }

        public void OnLoad()
        {
            throw new NotImplementedException();
        }

     
    }
}
