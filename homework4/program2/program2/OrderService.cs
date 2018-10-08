using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class OrderService : OrderDetails
    {

        public void AddOrder(List<OrderDetails> list, OrderDetails A)
        {
            list.Add(A);
        }

        public void DeleteOrder(List<OrderDetails> list, OrderDetails A)
        {
            int i = 0;
            while (i < list.Count && list[i] != A)
                i++;
            if (i >= list.Count)
                Console.WriteLine("订单不存在，删除失败");
            else
                list.Remove(list[i]);
        }

        public void ChangeOrder(List<OrderDetails> list, OrderDetails A, OrderDetails B)
        {
            int i = 0;
            while (i < list.Count && list[i] != A)
                i++;
            if (i >= list.Count)
                Console.WriteLine("订单不存在，修改失败");
            else
            {
                list[i].num = B.num;
                list[i].goodName = B.goodName;
                list[i].cusName = B.cusName;
            }
        }

        public void SearchOrder1(List<OrderDetails> list, string num1)
        {
            foreach (OrderDetails B in list)
            {
                if (B.num == num1)
                    Console.WriteLine(B.num + "\t" + B.goodName + "\t" + B.cusName);
            }
        }

        public void SearchOrder2(List<OrderDetails> list, string goodName1)
        {
            foreach (OrderDetails B in list)
            {
                if (B.goodName == goodName1)
                    Console.WriteLine(B.num + "\t" + B.goodName + "\t" + B.cusName);
            }
        }

        public void SearchOrder3(List<OrderDetails> list, string cusName1)
        {
            foreach (OrderDetails B in list)
            {
                if (B.cusName == cusName1)
                    Console.WriteLine(B.num + "\t" + B.goodName + "\t" + B.cusName);
            }
        }
    }
}