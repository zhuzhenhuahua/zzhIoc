using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.AttributeTest.Attr
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple =false,Inherited =true)]
   public class RemarkAttribute:Attribute
    {
        public string reMarks { get; set; }
        public RemarkAttribute(string remarks)
        {
            reMarks = remarks;
        }
    }
}
