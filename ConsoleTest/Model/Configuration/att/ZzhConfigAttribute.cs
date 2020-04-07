using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Model.Configuration.att
{
   public class ZzhConfigAttribute:Attribute
    {
        string _moduleName, _functionName;
        public ZzhConfigAttribute(string module, string func)
        {
            _moduleName = module;
            _functionName = func;
        }
        public ZzhConfigAttribute(string module)
        {
            _moduleName = module;
        }
        public string Module
        {
            get { return _moduleName; }
            set { _moduleName = value; }
        }

        public string Function
        {
            get { return _functionName; }
            set { _functionName = value; }
        }
    }
}
