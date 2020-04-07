using ConsoleTest.Model.Configuration.att;
using ConsoleTest.Model.Configuration.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ConsoleTest.AttributeTest;
using ConsoleTest.Expand;
using ConsoleTest.AttributeTest.Model;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //示例：根据特性验证
            UserInfo user = new UserInfo();
            user.name = "aaa";
            user.QQ = "12345ss";
            string errorMsg = string.Empty;
            bool verify = user.Verity(out errorMsg);
            Console.WriteLine(verify+":"+errorMsg);
            Console.WriteLine("____________________________________");
            //示例：根据特性获取枚举自定义属性
            EnumManager.TypeEnmu typeEnum= EnumManager.TypeEnmu.ToPay;
            Console.WriteLine(typeEnum.getTypeName());
            Console.WriteLine("____________________________________");
            RedisConfig redisConfig = new RedisConfig();
            redisConfig.MasterHostAndPort = "10.24.38.224:6379";
            redisConfig.Password = "redis@8d756";
            redisConfig.SlaveHostsAndPorts = "10.24.38.224:6380,";
            redisConfig.StringSeperator = ",";

            //ConsoleTest.Model.Configuration.Redis.RedisConfig
            string type = redisConfig.GetType().ToString();
            //Console.WriteLine(redisConfig.GetType().ToString());
            redisConfig.GetType().GetProperties().ToList().ForEach(delegate (PropertyInfo property) {
                ZzhKeyAttribute key1 = property.GetCustomAttribute(typeof(ZzhKeyAttribute)) as ZzhKeyAttribute;
                string value = property.GetValue(redisConfig).ToString();
                Console.WriteLine(key1.Key + "：" + value);
                Console.WriteLine(key1.Key2);
            });
            Console.ReadKey();
        }
    }
}
