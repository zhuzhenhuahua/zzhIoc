using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.AttributeTest.Attr
{
    /// <summary>
    /// 验证范围(Length)
    /// </summary>
    public class ScopeAttribute : VerifyAttributeBase
    {
        private int Min = 0;
        private int Max = 0;
        /// <summary>
        /// 从0开始
        /// </summary>
        /// <param name="max"></param>
        public ScopeAttribute(int max)
        {
            Max = max;
        }
        public ScopeAttribute(int min, int max) {
            Min = min;
            Max = max;
        }
        public override bool verify(object value,out string errorMsg)
        {
            errorMsg = "超出长度范围";
            if (value == null)
            {
                errorMsg = "字符为空";
                return false;
            }
            Type type = value.GetType();
            string str = value.ToString();
            if (string.IsNullOrWhiteSpace(str))
            {
                errorMsg = "字符串为空";
                return false;
            }
            int Length = str.Length;
            if (Min > 0 && Max > 0)
            {
                return Length > Min && Length < Max ? true : false;
            }
            else if (Min > 0)
            {
                return Length > Min ? true : false;
            }
            else if (Max > 0)
            {
                return Length < Max ? true : false;
            }
            return false;
        }
    }
}
