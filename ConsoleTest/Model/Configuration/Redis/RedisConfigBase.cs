using ConsoleTest.Model.Configuration.att;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Model.Configuration.Redis
{
   public class RedisConfigBase
    {
        [ZzhKey("自定义Key1:MasterHostAndPort", "自定义Key2:MasterHostAndPort2")]
        public string MasterHostAndPort { get; set; }

        [ZzhKey("自定义SlaveHostsAndPorts", "自定义Key2:SlaveHostsAndPorts")]
        public string SlaveHostsAndPorts { get; set; }

        [ZzhKey("自定义Password", "自定义Key2:Password2")]
        public string Password { get; set; }

        [ZzhKey("自定义StringSeperator", "自定义Key2:StringSeperator2")]
        public string StringSeperator { get; set; }
    }
}
