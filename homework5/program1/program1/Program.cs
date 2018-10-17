using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDetails B = new OrderDetails();
            B.num = "1";
            B.goodName = "苹果";
            B.cusName = "张三";
            B.price = 10;
            OrderDetails A = new OrderDetails();
            A.num = "2";
            A.goodName = "香蕉";
            A.cusName = "李四";
            A.price = 20;
            List<OrderDetails> list = new List<OrderDetails>();
            OrderService os = new OrderService();
            os.AddOrder(list, B);
            os.AddOrder(list, A);
            os.SearchOrder2(list, B.goodName);
            os.SearchOrder3(list, B.cusName);
            os.SearchOrder4(list);
        }
    }
}
