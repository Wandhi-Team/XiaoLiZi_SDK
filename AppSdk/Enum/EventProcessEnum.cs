using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Enum
{
    /// <summary>
    /// 启动事件处理
    /// </summary>
    public enum EventProcessEnum
    {
        // 阻止其他插件继续处理此事件
        /// <summary>
        /// 阻止其他插件继续处理此事件
        /// </summary>
        Block = 8,
        // 允许其他插件继续处理此事件
        /// <summary>
        /// 允许其他插件继续处理此事件
        /// </summary>
        Ignore = 0
    }
}
