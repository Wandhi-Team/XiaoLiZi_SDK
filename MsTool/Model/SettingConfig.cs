using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTool.Model
{


    /// <summary>
    /// 插件配置
    /// </summary>
    public class SettingConfig
    {
        public SettingConfig()
        {
            RobotSettings = new Dictionary<long, RobotSetting>();
            GroupSettings = new Dictionary<long, Settings>();
        }
        public Dictionary<long, RobotSetting> RobotSettings { set; get; }
        public Dictionary<long, Settings> GroupSettings { set; get; }
    }
    /// <summary>
    /// 机器人配置
    /// </summary>
    public class RobotSetting
    {
        public long RobotQQ { set; get; }
        public string MasterQQ { set; get; }
    }

    /// <summary>
    /// 分群配置
    /// </summary>
    public class Settings
    {
        public long Group { set; get; }
        public LspConfig LspGroupConfig { set; get; }
    }
    public class LspConfig
    {
        /// <summary>
        /// token
        /// </summary>
        public string Token { set; get; }
        /// <summary>
        /// 前缀
        /// </summary>
        public string Pre { set; get; }
        /// <summary>
        /// 触发词
        /// </summary>
        public string Code { set; get; }
        /// <summary>
        /// 开关
        /// </summary>
        public bool Switch { set; get; }
    }
}
