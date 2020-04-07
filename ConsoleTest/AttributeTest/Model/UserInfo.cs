using ConsoleTest.AttributeTest.Attr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.AttributeTest.Model
{
   public class UserInfo
    {
        [Scope(5)]//验证不能操作5个字符
        public string name { get; set; }
        [Scope(4,6)]//验证最少5位，最多5位
        public string QQ { get; set; }
    }
}
