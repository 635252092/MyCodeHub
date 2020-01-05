using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Dto.PubEnum
{
    public enum EcdrpSite
    {
        Admin = 1,
        Channel = 2,
        Wms = 3
    }
    /// <summary>
    /// 
    /// </summary>
    public enum LoginEnum
    {
        [Description("空值")]
        Empty = -1,
        [Description("成功")]
        Success = 0,
        [Description("登陆失败")]
        Fail = 1,
        [Description("用户名不存在")]
        NoExist = 2,
        [Description("用户名或密码错误")]
        LoginNameOrPwdErr = 3,
        [Description("禁用")]
        Disable = 4,
        [Description("验证码错误")]
        CheckCodeErr = 5,
    }
}
