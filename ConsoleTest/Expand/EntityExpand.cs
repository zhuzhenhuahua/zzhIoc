using ConsoleTest.AttributeTest.Attr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Expand
{
    public static class EntityExpand
    {
        public static bool Verity<T>(this T model,out string errorMsg) where T : class, new()
        {
            errorMsg = string.Empty;
            Type type = model.GetType();
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                //遍历属性，判断属性是否存在VerifyBaseAtttribute特性，true会去查看继承链是否存在
                //这个之所以使用Base特性就是抽象出验证特性共同的东西，所有验证都可以调用这个方法生效
                if (propertyInfo.IsDefined(typeof(VerifyAttributeBase), true))
                {
                    //然后获取属性上面的特性（注意一个属性上面可能会出现多个验证特性，所以这里我们需要获取一个数组）
                    var obj = propertyInfo.GetCustomAttributes(typeof(VerifyAttributeBase), true);
                    foreach (VerifyAttributeBase item in obj)
                    {
                        object value = propertyInfo.GetValue(model);
                        if (!item.verify(value,out errorMsg))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
