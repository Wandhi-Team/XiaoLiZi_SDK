using MsTool.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTool.Extensions
{
    public class Config
    {
        public SettingConfig settingConfig;

        public void Save(SettingConfig settingConfig)
        {
            this.settingConfig = settingConfig;

            SaveGroup();
            SaveRobot();
        }

        public string InitPath(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        private string Path
        {
            get
            {
                var root = $"{Directory.GetCurrentDirectory()}\\main\\data\\大猫娱乐";

                return InitPath(root);
            }
        }
        /// <summary>
        /// 获取群配置路径
        /// </summary>
        /// <param name="Group"></param>
        /// <returns></returns>

        private string GroupPath(string Group)
        {
            var groupPath = $"{Path}\\{Group}";
            return InitPath(groupPath);
        }

        public SettingConfig GetConfig()
        {
            settingConfig = new SettingConfig();
            var files = Directory.GetFiles(Path, "*.json");
            //加载机器人配置
            foreach (var item in files)
            {
                var robot = JsonConvert.DeserializeObject<RobotSetting>(File.ReadAllText(item));
                if (!settingConfig.RobotSettings.ContainsKey(robot.RobotQQ))
                {
                    settingConfig.RobotSettings.Add(robot.RobotQQ, robot);
                }
            }

            //加载群配置
            var groupsFile = Directory.GetDirectories(Path);
            foreach (var item in groupsFile)
            {
                var file = Directory.GetFiles(item).FirstOrDefault();
                if (!string.IsNullOrEmpty(file))
                {
                    var group = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(file));
                    if (!settingConfig.GroupSettings.ContainsKey(group.Group))
                    {
                        settingConfig.GroupSettings.Add(group.Group, group);
                    }
                }
            }
            return settingConfig;
        }


        /// <summary>
        /// 保存群配置信息
        /// </summary>
        private void SaveGroup()
        {
            foreach (var item in settingConfig.GroupSettings)
            {
                SaveFile(JsonConvert.SerializeObject(item.Value), $"{GroupPath(item.Key.ToString())}\\{item.Key}.json");
            }
        }
        /// <summary>
        /// 保存机器人配置信息
        /// </summary>
        private void SaveRobot()
        {
            foreach (var item in settingConfig.RobotSettings)
            {
                SaveFile(JsonConvert.SerializeObject(item.Value), $"{Path}\\{item.Key}.json");
            }
        }

        private void SaveFile(string Content, string FilePath)
        {
            File.WriteAllText(FilePath, Content, Encoding.UTF8);
        }
    }
}
