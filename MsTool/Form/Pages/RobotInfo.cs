using MsTool.Model;
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

namespace MsTool.Form.Pages
{
    public partial class RobotInfo : UIPage
    {
        public QInfo robot;
        public RobotInfo(ref QInfo qInfo)
        {
            InitializeComponent();
            robot = qInfo;
        }

        public void InitInfo()
        {
            //lab_Avatar.Image=robot.

            lab_QQ.Text = robot?.QQ.ToString();
            lab_NickName.Text = robot?.昵称;
            lab_Level.Text = robot?.等级信息;
        }

        public void InitInfo(ref QInfo qInfo)
        {
            robot = qInfo;

            InitInfo();
        }
    }
}
