using ConsoleTest.AttributeTest.Attr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.AttributeTest
{
    public class EnumManager
    {
        public enum TypeEnmu
        {
            /// <summary>
            /// 待支付
            /// </summary>
            [Remark("待支付")]
            ToPay = 1,
            /// <summary>
            /// 支付成功
            /// </summary>
            [Remark("支付成功")]
            PaymentSuccess = 2,
            /// <summary>
            /// 支付失败
            /// </summary>
            [Remark("支付失败")]
            PaymentFailure = 3
        }
    }
}
