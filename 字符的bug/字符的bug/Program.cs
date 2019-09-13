using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符的bug
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建Person类的对象
            Person zhangsan = new Person();  //类的实例化
            zhangsan.Name = "张三";
            zhangsan.Age = -23;
            zhangsan.Gender = '春';
            zhangsan.CHLSS();
            Console.ReadKey();
        }
    }
}
