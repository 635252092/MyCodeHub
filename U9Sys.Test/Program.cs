using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U9Sys.Models.ScmBE.EntrustedRepairDocBE;

namespace U9Sys.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            //Test2();
            //string s = "sfdsafds&&s!!";
            //Console.WriteLine(s.Trim('!'));
            Student[] s = new Student[0];
           

            Console.ReadKey();
        }
        private static void Test2()
        {
            Student s1 = new Student(20, "Tom");
            Student s2 = new Student(18, "Jack");
            Student s3 = s1 + s2;

            s3.sayPlus();
            (s1 - s2).sayMinus();
            Console.ReadKey();
        }
        public enum Expression
        {
            //
            // 摘要:
            //     加法运算，如 a + b，针对数值操作数，不进行溢出检查。
            Add = 0,
            //
            // 摘要:
            //     加法运算，如 (a + b)，针对数值操作数，进行溢出检查。
            AddChecked = 1,
            //
            // 摘要:
            //     按位或逻辑 AND 运算，如 C# 中的 (a & b) 和 Visual Basic 中的 (a And b)。
            And = 2,
            //
            // 摘要:
            //     条件 AND 运算，它仅在第一个操作数的计算结果为 true 时才计算第二个操作数。它与 C# 中的 (a && b) 和 Visual Basic 中的
            //     (a AndAlso b) 对应。
            AndAlso = 3,
            //
            // 摘要:
            //     获取一维数组长度的运算，如 array.Length。
            ArrayLength = 4,
            //
            // 摘要:
            //     一维数组中的索引运算，如 C# 中的 array[index] 或 Visual Basic 中的 array(index)。
            ArrayIndex = 5,
            //
            // 摘要:
            //     方法调用，如在 obj.sampleMethod() 表达式中。
            Call = 6,
            //
            // 摘要:
            //     表示 null 合并运算的节点，如 C# 中的 (a ?? b) 或 Visual Basic 中的 If(a, b)。
            Coalesce = 7,
            //
            // 摘要:
            //     条件运算，如 C# 中的 a > b ? a : b 或 Visual Basic 中的 If(a > b, a, b)。
            Conditional = 8,
            //
            // 摘要:
            //     一个常量值。
            Constant = 9,
        }
        private static void Test1()
        {
            Console.WriteLine(Models.ScmBE.EntrustedRepairDocBE.CurrentNodeEnum.Refunded.Value);

            switch (CurrentNodeEnum.Refunded.Value)
            {
                case 1:
                    break;
                default:
                    break;
            }
            Console.WriteLine(Models.ScmBE.EntrustedRepairDocBE.CurrentNodeEnum.GetFromValue(2).Name);
        }

        public class Student
        {
            public Student() { }
            public Student(int age, string name)
            {
                this.name = name;
                this.age = age;

            }
            private string name;
            private int age;

            public void sayPlus()
            {
                System.Console.WriteLine("{0} 年龄之和为：{1}", this.name, this.age);

            }
            public void sayMinus()
            {
                System.Console.WriteLine("{0} 年龄之差为：{1}", this.name, this.age);
            }
            //覆盖“+”操作符
            public static Student operator +(Student s1, Student s2)
            {
                return new Student(s1.age + s2.age, s1.name + " And " + s2.name);

            }
            //覆盖“-”操作符
            public static Student operator -(Student s1, Student s2)
            {
                return new Student(Math.Abs(s1.age - s2.age), s1.name + "And" + s2.name);
            }
        }
    }
}
