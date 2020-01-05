using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U9Sys.Models.ScmBE.EntrustedRepairDocBE
{
    /// <summary>
    /// 可扩展枚举: 当前节点枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class CurrentNodeEnum
    {
        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("SV.Scm.ScmBE.EntrustedRepairDocBE.CurrentNodeEnum");
        #region ctor & cctor 
        static CurrentNodeEnum()
        {
            InitData();
        }
        private CurrentNodeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private CurrentNodeEnum(int eValue, string name)
        {
            this.currentValue = eValue;
            this.name = name;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32, CurrentNodeEnum>();
            notCommissioned = new CurrentNodeEnum(0, "NotCommissioned");
            innerEnums.Add(0, notCommissioned);
            entrustedExecution = new CurrentNodeEnum(1, "EntrustedExecution");
            innerEnums.Add(1, entrustedExecution);
            pendingPayment = new CurrentNodeEnum(2, "PendingPayment");
            innerEnums.Add(2, pendingPayment);
            alreadyPaid = new CurrentNodeEnum(3, "AlreadyPaid");
            innerEnums.Add(3, alreadyPaid);
            refunded = new CurrentNodeEnum(4, "Refunded");
            innerEnums.Add(4, refunded);
            terminationEntrustment = new CurrentNodeEnum(5, "TerminationEntrustment");
            innerEnums.Add(5, terminationEntrustment);
            empty = new CurrentNodeEnum(-1, "");
            innerEnums.Add(-1, empty);
        }
        #endregion

        #region  Empty Value
        private static CurrentNodeEnum empty;
        public static CurrentNodeEnum Empty
        {
            get
            {
                return empty;
            }
        }
        #endregion

        #region Intstance Propertites 
        private int currentValue;
        public System.Int32 Value
        {
            get
            {
                return currentValue;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        #endregion

        #region public static enum member
        private static CurrentNodeEnum notCommissioned;
        /// <summary>
        /// 枚举值: 未发起委托  Value:0  
        /// 当前节点枚举.Misc.未发起委托
        /// </summary>
        public static CurrentNodeEnum NotCommissioned
        {
            get
            {
                return notCommissioned;
            }
        }
        private static CurrentNodeEnum entrustedExecution;
        /// <summary>
        /// 枚举值: 委托执行中  Value:1  
        /// 当前节点枚举.Misc.委托执行中
        /// </summary>
        public static CurrentNodeEnum EntrustedExecution
        {
            get
            {
                return entrustedExecution;
            }
        }
        private static CurrentNodeEnum pendingPayment;
        /// <summary>
        /// 枚举值: 待付款  Value:2  
        /// 当前节点枚举.Misc.待付款
        /// </summary>
        public static CurrentNodeEnum PendingPayment
        {
            get
            {
                return pendingPayment;
            }
        }
        private static CurrentNodeEnum alreadyPaid;
        /// <summary>
        /// 枚举值: 已付款  Value:3  
        /// 当前节点枚举.Misc.已付款
        /// </summary>
        public static CurrentNodeEnum AlreadyPaid
        {
            get
            {
                return alreadyPaid;
            }
        }
        private static CurrentNodeEnum refunded;
        /// <summary>
        /// 枚举值: 已退款  Value:4  
        /// 当前节点枚举.Misc.已退款
        /// </summary>
        public static CurrentNodeEnum Refunded
        {
            get
            {
                return refunded;
            }
        }
        private static CurrentNodeEnum terminationEntrustment;
        /// <summary>
        /// 枚举值: 终止委托  Value:5  
        /// 当前节点枚举.Misc.终止委托
        /// </summary>
        public static CurrentNodeEnum TerminationEntrustment
        {
            get
            {
                return terminationEntrustment;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, CurrentNodeEnum> innerEnums;
        /// <summary>
        /// Get CurrentNodeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<CurrentNodeEnum> Values
        {
            get
            {
                return innerEnums.Values;
            }
        }

        private static object lockobj = new object();
        /// <summary>
        /// Get CurrentNodeEnum By Value 
        /// </summary>
        public static CurrentNodeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
                        CurrentNodeEnum newValue = new CurrentNodeEnum(value, "");
                        innerEnums.Add(value, newValue);
                        return newValue;
                    }
                }
            }
            return innerEnums[value];
        }
        /// <summary>
        /// Get CurrentNodeEnum By Value 
        /// </summary>
        public static CurrentNodeEnum GetFromValue(object value)
        {
            if (value == null)
                return CurrentNodeEnum.Empty;
            System.Int32 resultValue = 0;
            if (!System.Int32.TryParse(value.ToString(), out resultValue))
                throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据", value));
            return GetFromValue(resultValue);
        }
        /// <summary>
        /// Get CurrentNodeEnum By Name 
        /// </summary>
        public static CurrentNodeEnum GetFromName(string name)
        {
            foreach (CurrentNodeEnum obj in innerEnums.Values)
            {
                if (obj.Name == name)
                    return obj;
            }
            //don't need modify to return a Default Value .
            return null;
        }
        #endregion
    }

}

