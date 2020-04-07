using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.AttributeTest.Attr
{
   public abstract class VerifyAttributeBase:Attribute
    {
        public abstract bool verify(object value,out string errorMsg);
    }
}
