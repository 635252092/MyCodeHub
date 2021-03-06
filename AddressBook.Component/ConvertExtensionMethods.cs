﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Component
{
    public static class ConvertExtensionMethods
    {
        /// <summary>
        /// 对象转换为其字符串表现形式,Null 返回空字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Ustring(this object obj)
        {
            return obj == null ? string.Empty : obj.ToString();
        }

        /// <summary>
        /// Object 的值转换为Int32 数字; 空字串,DBNull.Value,Null,转换异常 返回defaultValue（默认为0）
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int Uint(this object obj)
        {
            if (obj.IsNullOrEmptyString()) return 0;

            try
            {
                return Convert.ToInt32(obj);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Object 的值转换为Uint64 数字; 空字串,DBNull.Value,Null 返回0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Int64 Uint64(this object obj)
        {
            if (obj.IsNullOrEmptyString()) return 0;

            return Convert.ToInt64(obj);
        }

        /// <summary>
        /// Object 的值转换为Decimal 数字; 空字串,DBNull.Value,Null 返回0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static decimal Udecimal(this object obj)
        {
            if (obj.IsNullOrEmptyString()) return 0;

            return Convert.ToDecimal(obj);

        }

        /// <summary>
        /// Object 的值转换为Decimal 数字; 空字串,DBNull.Value,Null 返回-1 (-1说明输入的参数格式有误)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static decimal Udecimal2(this object obj)
        {
            if (obj.IsNullOrEmptyString()) return -1;
            decimal result;
            if (decimal.TryParse(obj.ToString(), out result))
            {
                return result;
            }
            else
            {
                return -1;
            }

        }

        /// <summary>
        /// Object 的值转换为Double 数字; 空字串,DBNull.Value,Null 返回0.0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double Udouble(this object obj)
        {
            if (obj.IsNullOrEmptyString()) return 0.0;

            return Convert.ToDouble(obj.ToString());
        }

        /// <summary>
        /// Object 的值判断是否为null或者为空字符串（支持DBNull.Value的情况）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsNullOrEmptyString(this object obj)
        {
            return obj == null || (obj is string && (string)obj == "") || (obj is DBNull && (DBNull)obj == DBNull.Value);
        }

        /// <summary>
        /// 默认时间是1970-1-1
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DateTime UDateTime(this object obj)
        {
            try
            {
                return DateTime.Parse(obj.ToString());
            }
            catch
            {
                return DateTime.Parse("1970-01-01 00:00:00");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="obj"></param>
        /// <param name="ifNotNull"></param>
        /// <param name="ifNull"></param>
        /// <returns></returns>
        public static TResult TryGet<T, TResult>(this T obj, Func<T, TResult> ifNotNull, TResult def)
        {
            if (obj == null)
            {
                return def;
            }

            return ifNotNull == null ? default(TResult) : ifNotNull(obj);
        }

        #region string Convert Extension
        //与ZiXin.Web.Component里的StringHelp一致(出于所有项目公用ZiXin.ERP.Component的原因，暂不调整StringHelp里的)

        /// <summary>
        /// 尝试将当前包含日期时间信息的字符串类型转换成 <see cref="DateTime"/> 类型。转换失败返回 defaultValue( 默认NULL)。
        /// </summary>
        /// <param name="stringContainsDateInfo"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static DateTime? ToDateTime(this string stringContainsDateInfo, DateTime? defaultValue = null)
        {
            DateTime dateTime;
            if (DateTime.TryParse(stringContainsDateInfo, out dateTime)) return dateTime;

            return defaultValue;
        }

        /// <summary>
        /// 尝试将当前字符串类型转换成 <see cref="bool"/> 。等于 "true" 或等于 "y" 返回 true（忽略大小写）。
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool ToBool(this string source)
        {
            if (string.IsNullOrEmpty(source)) return false;

            return source.ToLower() == "true" || source.ToLower() == "y";
        }

        /// <summary>
        /// 尝试将当前包含数值信息的字符串类型转换成 <see cref="int"/> 类型，转换失败返回defaultValue(默认0)。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int ToInt(this string source, int defaultValue = 0)
        {
            int result;
            if (int.TryParse(source, out result)) return result;

            return defaultValue;
        }

        /// <summary>
        /// 尝试将当前包含数值信息的字符串类型转换成可为空的 <see cref="int"/> 类型，转换失败返回defaultValue(默认null)。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int? ToIntNullable(this string source, int? defaultValue = null)
        {
            int result;
            if (int.TryParse(source, out result)) return result;

            return defaultValue;
        }

        /// <summary>
        /// 尝试将当前包含数值信息的字符串类型转换成 <see cref="Decimal"/> 类型。转换失败返回 defaultValue( 默认0)。
        /// </summary>
        /// <param name="stringContainsDecimalInfo"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Decimal ToDecimal(this string stringContainsDecimalInfo, decimal defaultValue = 0)
        {
            Decimal result;
            if (Decimal.TryParse(stringContainsDecimalInfo, out result)) return result;

            return defaultValue;
        }

        /// <summary>
        /// 尝试将当前包含数值信息的字符串类型转换成可为空的 <see cref="Decimal"/> 类型。转换失败返回 defaultValue( 默认NULL)。
        /// </summary>
        /// <param name="stringContainsDecimalInfo"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Decimal? ToDecimalNullable(this string stringContainsDecimalInfo, decimal? defaultValue = null)
        {
            Decimal result;
            if (Decimal.TryParse(stringContainsDecimalInfo, out result)) return result;

            return defaultValue;
        }

        /// <summary>
        /// 把数字类型的string[]数组，转成int[]数组
        /// </summary>
        /// <param name="obj">必须为数字类型的string数组</param>
        /// <returns>int数组</returns>
        public static int[] UintArray(this string[] obj)
        {
            if (obj.IsNullOrEmptyString()) return new int[0];

            try
            {
                int[] ids = new int[obj.Length];
                for (int i = 0; i < obj.Length; i++)
                {
                    ids[i] = int.Parse(obj[i]);
                }
                return ids;
            }
            catch
            {
                return new int[0];
            }
        }

        /// <summary>
        /// 返回时间戳
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>时间戳</returns>
        public static int Utimestamp(this DateTime time)
        {
            try
            {
                return (int)(time - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))).TotalSeconds;
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// int数组 转成以","分隔的字符串
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string UArrayIntSplit(this int[] array)
        {
            try
            {
                string str = "";
                int lenght = array.Count();
                foreach (var s in array)
                {
                    lenght--;
                    if (lenght <= 0)
                    {
                        str += s.ToString();
                    }
                    else
                    {
                        str += s.ToString() + ",";
                    }
                    
                }
                return str;
            }
            catch
            {
                return "";
            }
        }
        /// <summary>
        /// string数组 转成以","分隔的字符串
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string UArrayStringSplit(this string[] array)
        {
            try
            {
                string str = "";
                int lenght = array.Count();
                foreach (var s in array)
                {
                    lenght--;
                    if (lenght <= 0)
                    {
                        str += s.Trim();
                    }
                    else
                    {
                        str += s.Trim() + ",";
                    }
                   
                }
                return str;
            }
            catch
            {
                return "";
            }
        }

        #endregion
    }
}
