using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Model.Configuration.att
{
    public class ZzhKeyAttribute : Attribute
    {
        public string Key { get; set; }
        public string Key2 { get; set; }
        public ZzhKeyAttribute(string key)
        {
            Key = key;
        }
        public ZzhKeyAttribute(string key,string key2)
        {
            Key = key;
            Key2 = key2;
        }
    }
}
