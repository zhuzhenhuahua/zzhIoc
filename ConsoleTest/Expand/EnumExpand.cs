using ConsoleTest.AttributeTest.Attr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Expand
{
   public static class EnumExpand
    {
        /// <summary>
        /// 朱振华自定义获取remark特性
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string getTypeName(this Enum value)
        {
            Type type = value.GetType();
            string strValue = value.ToString();//原始值
            //获取该枚举值的特性
            FieldInfo fieldInfo = type.GetField(strValue);
            if (fieldInfo.IsDefined(typeof(RemarkAttribute), true))
            {
                var attr = fieldInfo.GetCustomAttribute(typeof(RemarkAttribute)) as RemarkAttribute;
                return attr.reMarks;
            }
            else {
                return strValue;
            }
        }
    }
}
