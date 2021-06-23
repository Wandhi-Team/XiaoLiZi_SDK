using MsTool.Form.Pages;
using MsTool.Model;
using Newtonsoft.Json;
using SDK;
using SDK.Model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsTool.Form
{
    public partial class CatSetting : UIAsideHeaderMainFooterFrame
    {
        public Dictionary<string, QInfo> Robots = new Dictionary<string, QInfo>();
        

        public CatSetting()
        {
            InitializeComponent();
            LoadRobot();
        }


        public void SettingInit()
        {
            Aside.TabControl = MainTabControl;
            AddPage(new RobotInfo(), 0);

            Aside.SelectFirst();
        }

        /// <summary>
        /// 载入机器人列表
        /// </summary>
        public async void LoadRobot()
        {
            await Task.Run(() =>
            {
                var qqs = JsonConvert.DeserializeObject<QInfoRoot>(Common.api.GetThisQQ());
                var robots = new List<QInfoList>();
                foreach (var item in qqs.QQlist)
                {
                    item.Value.QQ = long.Parse(item.Key);
                    Robots.Add(item.Key, item.Value);
                    robots.Add(new QInfoList
                    {
                        QQ = item.Value.QQ,
                        NickName = $"{item.Value.昵称}({item.Value.QQ})"
                    });
                }



                cmb_Robot.DisplayMember = "NickName";
                cmb_Robot.ValueMember = "QQ";
                cmb_Robot.DataSource = robots;

                if (robots.Count > 0)
                {
                    cmb_Robot.Select(0, 1);
                }
            });
        }

        public async void LoadGroup(long QQ)
        {
            await Task.Run(() =>
            {
                var groups = Common.api.Getgrouplist(QQ).Select(a => new GroupInfoList { Group = a.GroupID, GroupName = $"{a.GroupName}({a.GroupID})" }).ToList();

                cmb_Groups.DisplayMember = "GroupName";
                cmb_Groups.ValueMember = "Group";
                cmb_Groups.DataSource = groups;

                if (groups.Count() > 0)
                {
                    cmb_Groups.Select(0, 1);
                }
            });
        }

        private void cmb_Robot_SelectedIndexChanged(object sender, EventArgs e)
        {
            var robot = (QInfoList)cmb_Robot.SelectedItem;
            LoadGroup(robot.QQ);
        }
    }
}
