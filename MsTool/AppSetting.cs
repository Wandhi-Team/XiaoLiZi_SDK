using SDK.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTool
{
    public class Setting : IAppSetting
    {
        private static MainSetting fm;
        public void AppSetting()
        {
            if (Setting.fm == null)
            {
                fm = new MainSetting();
                fm.FormClosed += fm.SaveConfig;
                //fm.FormClosed += (a, b) =>
                //{
                //    fm.Dispose();
                //    fm = null;
                //};
            }

            fm.ShowDialog();
        }
    }
}
