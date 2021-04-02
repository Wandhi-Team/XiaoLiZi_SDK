using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MsTool.Model;
using Newtonsoft.Json;
using SDK;
using Sunny.UI;

namespace MsTool
{
    public partial class MainSetting : UIForm
    {

        private long CurrentQ = 0;
        private List<Group> Groups = new List<Group>();
        private Dictionary<string, QInfo> Robots = new Dictionary<string, QInfo>();

        public MainSetting()
        {
            InitializeComponent();
            txt_Log.ReadOnly = true;
            LoadList();
            FormInit();
        }



        private void FormInit()
        {
            #region 批量退群
            dgv_BatchQuit.AddCheckBoxColumn("", "Checked", 50, false);
            dgv_BatchQuit.AddColumn("群号", "GroupID");
            dgv_BatchQuit.AddColumn("群名", "GroupName", 150);


            #endregion
        }

        public async void LoadList()
        {
            await Task.Run(() =>
             {
                 Info("载入机器人列表");
                 var qqs = JsonConvert.DeserializeObject<QInfoRoot>(Common.xlzAPI.GetThisQQ());
                 foreach (var item in qqs.QQlist)
                 {
                     var k = $"{item.Key}({item.Value.昵称})";
                     item.Value.QQ = long.Parse(item.Key);
                     Robots.Add(k, item.Value);
                 }
                 lb_QList.DataSource = Robots.Select(a => a.Key).ToList();
             });
        }

        internal void SaveConfig(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_BatchAdd_Click(object sender, EventArgs e)
        {
            btn_BatchAdd.Enabled = false;
            Task.Run(() =>
            {
                if (!GetCurrentQQ(out var qq))
                {
                    return;
                }
                var groups = txt_Groups.Lines;
                foreach (var item in groups)
                {
                    var res = Common.xlzAPI.AddGroupEvent(qq, long.Parse(item), "");
                    Info($"加群[{item}]:{res}");
                }

            }).ContinueWith((a) =>
            {
                btn_BatchAdd.Enabled = true;
            });
        }

        private void Info(string msg)
        {
            txt_Log.Text = $"{DateTime.Now.ToString()}:{msg}\r\n{txt_Log.Text}";
        }

        private bool GetCurrentQQ(out long _qq)
        {
            var qq = lb_QList.SelectedValue;
            _qq = 0;
            if (qq == null)
            {
                Info("请先选择机器人");
                return false;
            }
            if (Robots.ContainsKey(qq.ToString()))
            {
                _qq = Robots[qq.ToString()].QQ;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_ReferGroups_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
              {
                  btn_ReferGroups.Enabled = false;
                  if (!GetCurrentQQ(out var qq))
                  {
                      return;
                  }

                  var groups = Common.xlzAPI.Getgrouplist(qq);
                  Groups = new List<Group>();
                  foreach (var item in groups)
                  {
                      if (item.GroupID == 0)
                      {
                          continue;
                      }
                      var gp = new Group
                      {
                          GroupID = item.GroupID,
                          GroupName = item.GroupName,
                          QQ = qq
                      };

                      Groups.Add(gp);
                  }

                  dgv_BatchQuit.DataSource = Groups;

              }).ContinueWith((a) =>
              {
                  if (a.IsCompleted)
                  {
                      btn_ReferGroups.Enabled = true;
                  }
              });
        }

        private void lb_QList_Click(object sender, EventArgs e)
        {

        }

        private void btn_BatchQuit_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                btn_BatchQuit.Enabled = false;
                if (!GetCurrentQQ(out var qq))
                {
                    return;
                }

                foreach (var item in Groups.Where(a => a.Checked))
                {
                    var res = Common.xlzAPI.QuitGroupEvent(item.QQ, item.GroupID);
                    Info($"退群[{item.GroupID}]:{res}");
                }

            }).ContinueWith((a) =>
            {
                if (a.IsCompleted)
                {
                    btn_BatchQuit.Enabled = true;
                }
            });
        }
    }
}