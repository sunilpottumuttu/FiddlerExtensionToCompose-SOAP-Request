using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fiddler;
using System.Windows.Forms;


namespace SOAPRequestComposer
{
    public class BootStrap : IHandleExecAction, IFiddlerExtension
    {
        private TabPage __tab;
        private SOAPRequestComposer __view;
        
        public void OnLoad()
        {
            this.__tab = new TabPage("SOAP Request Composer");
            this.__view = new SOAPRequestComposer();
            this.__tab.Controls.Add(this.__view);
            FiddlerApplication.UI.tabsViews.TabPages.Add(this.__tab);
        }

        public bool OnExecAction(string sCommand)
        {
            return true;
        }

        public void OnBeforeUnload()
        {
            this.__tab.Controls.Remove(this.__view);
            FiddlerApplication.UI.pageBuilder.Controls.Remove(this.__tab);
        }

      
     
    }
}
