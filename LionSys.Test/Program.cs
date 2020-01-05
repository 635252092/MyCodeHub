using LionSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LionSys.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();

            Console.ReadKey();
        }

        private static void Test1()
        {
            string txt = "刘备张飞关羽";
            string str1 = "*张*";
            string str2 = "*张";
            string str3 = "张*";
            string str4 = "张*飞";
            string str5 = "*张*飞*";
            string str6 = "备*飞";
            string str13 = "备**飞";
            string str7 = "备*飞*羽";
            string str8 = "备*飞*羽";
            string str9 = "备***羽";
            string str16 = "备****羽";
            string str10 = "备*羽";
            string str11 = "备**羽";
            string str14 = "备***** *********羽";
            string str12 = "备**羽*备**羽";
            string str15 = "刘备*飞*";
            string str19 = "刘备*飞*羽";
            string str18 = "刘备*飞**羽";
            string str17 = "*备*关*";
            Console.WriteLine("txt:{0}", txt);
            Console.WriteLine("input:{0}   结果:{1}", str1, Check(txt, str1));
            Console.WriteLine("input:{0}   结果:{1}", str2, Check(txt, str2));
            Console.WriteLine("input:{0}   结果:{1}", str3, Check(txt, str3));
            Console.WriteLine("input:{0}   结果:{1}", str4, Check(txt, str4));
            Console.WriteLine("input:{0}   结果:{1}", str5, Check(txt, str5));
            Console.WriteLine("input:{0}   结果:{1}", str6, Check(txt, str6));
            Console.WriteLine("input:{0}   结果:{1}", str7, Check(txt, str7));
            Console.WriteLine("input:{0}   结果:{1}", str8, Check(txt, str8));
            Console.WriteLine("input:{0}   结果:{1}", str9, Check(txt, str9));
            Console.WriteLine("input:{0}   结果:{1}", txt, Check(txt, txt));
            Console.WriteLine("input:{0}   结果:{1}", str10, Check(txt, str10));
            Console.WriteLine("input:{0}   结果:{1}", str11, Check(txt, str11));
            Console.WriteLine("input:{0}   结果:{1}", str12, Check(txt, str12));
            Console.WriteLine("input:{0}   结果:{1}", str13, Check(txt, str13));
            Console.WriteLine("input:{0}   结果:{1}", str14, Check(txt, str14));
            Console.WriteLine("input:{0}   结果:{1}", str15, Check(txt, str15));
            Console.WriteLine("input:{0}   结果:{1}", str16, Check(txt, str16));
            Console.WriteLine("input:{0}   结果:{1}", str17, Check(txt, str17));
            Console.WriteLine("input:{0}   结果:{1}", str18, Check(txt, str18));
            Console.WriteLine("input:{0}   结果:{1}", str19, Check(txt, str19));
        }

        public static bool Check(string txt, string key)
        {
            bool isRight = false;
            //含有通配符
            if (key.Contains("*"))
            {
                //从*张，张* 都通过可得出，前后通配符没有用，去掉即可
                key= key.Trim('*');
                if (key.Contains('*'))
                {
                    //中间含有通配符
                    //关键词按 通配符 拆成数组
                    string[] strArr = key.Split('*');

                    //Console.WriteLine("strArr:" +string.Join("|", strArr));
                    /**
                     * 1.每次对比取 关键词数组的 前两个字符串。如果第二个为空字符串，就再取下一个
                     * 2.中间a**b;a***b。其中*代表一个或者多个，如果*数量大于匹配数量，就认为false。对应的判断是
                     *  (txt.IndexOf(strArr[j]) - txt.IndexOf(strArr[i])) >= key.IndexOf(strArr[j]) - key.IndexOf(strArr[i]))
                     * 3.判断方法true的思路是：第一个关键词匹配到txt了，第二个关键词也匹配到了，此时的顺序第二个必须在第一个后面。然后把txt截断。对应的判断是
                     * (txt.IndexOf(strArr[j]) - txt.IndexOf(strArr[i]) > 1
                     */
                    for (int i = 0; i < strArr.Length - 1; i++)
                    {
                       int j = i + 1;
                        while (string.IsNullOrEmpty(strArr[j])&&j< strArr.Length - 1)
                        {
                            //这一步是要取到非空的字符
                            j++;
                        }
                        if (txt.IndexOf(strArr[j]) < 0 || txt.IndexOf(strArr[i]) < 0)
                        {
                            //如果字符串不含关键词
                            isRight = false;
                            break;
                        }
                        else if (txt.IndexOf(strArr[j]) - txt.IndexOf(strArr[i]) > 1
                            &&((txt.IndexOf(strArr[j]) - txt.IndexOf(strArr[i])) >= key.IndexOf(strArr[j]) - key.IndexOf(strArr[i])))
                        {
                            isRight = true;
                            txt = txt.Substring(txt.IndexOf(strArr[j]));
                            key = key.Substring(key.IndexOf(strArr[j]));
                            i = j - 1;
                            Console.WriteLine("截断后：{0}",txt);
                        }
                        else
                        {
                            isRight = false;
                            break;
                        }
                    }
                }
                else
                {
                    //中间不含通配符，需要包含关键词就是匹配
                    isRight = txt.Contains(key);
                }
            }
            else
            {
                //不含通配符，必须全部一致
                isRight = txt.Equals(key);
            }
            return isRight;
        }
    }
}
