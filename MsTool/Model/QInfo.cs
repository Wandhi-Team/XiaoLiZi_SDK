﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTool.Model
{
    public class QInfo
    {
        public long QQ { set; get; }
        public string 昵称 { get; set; }
        public string 登录状态 { get; set; }
        public string 等级信息 { get; set; }
        public string 收发信息 { get; set; }
        public string 登录IP { get; set; }
        public string 登录协议 { get; set; }
        public string 腾讯服务器 { get; set; }
    }
    public class QInfoRoot
    {
        public Dictionary<string, QInfo> QQlist { get; set; }
    }

    /// <summary>
    /// 机器人列表
    /// </summary>
    public class QInfoList
    {
        public long QQ { set; get; }
        public string NickName { set; get; }
    }

    /// <summary>
    /// qq群列表
    /// </summary>
    public class GroupInfoList
    {
        public long Group { set; get; }
        public string GroupName { set; get; }
    }

}