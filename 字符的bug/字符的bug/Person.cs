using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符的bug
{
    class Person
    {
        //字段
        private string name;
        private int _age;
        private char _gender;

        //属性
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        public char Gender
        {
            get
            {
                if (_gender != '男' && _gender != '女')
                {
                    return _gender = '男';
                }
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        //当你给属性赋值的时候，首先会执行set方法
        //当你输出属性的值的时候，会执行get方法
        //public string Name { get => name; set => name = value; }


        //方法
        public void CHLSS()
        {
            Console.WriteLine("我叫{0},我今年{1}岁了, 我是{2}生,我可以吃喝拉撒睡哦", this.Name, this.Age, this.Gender);

        }
    }
}
