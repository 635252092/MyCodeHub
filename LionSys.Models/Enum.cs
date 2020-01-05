using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionSys.Models
{
    public enum EnumCultureID
    {
        [Description("zh-TW")]
        zh_TW,
        [Description("zh-CN")]
        zh_CN,
        [Description("en-US")]
        en_US,
        [Description("th-TH")]
        th_TH,
        [Description("ja-JP")]
        ja_JP,
    }
}
