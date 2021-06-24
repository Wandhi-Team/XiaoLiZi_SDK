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
    public partial class LspSetting : UIPage
    {
        public LspConfig lspConfig;
        public LspSetting()
        {
            InitializeComponent();
        }


        public void InitInfo(LspConfig lspConfig)
        {
            this.lspConfig = lspConfig;
            InitInfo();
        }
        public void InitInfo()
        {
            txt_Token.Text = lspConfig?.Token;
            txt_Pre.Text = lspConfig?.Pre;
            txt_Code.Text = lspConfig?.Code;
            sw_Lsp.Active = lspConfig != null && lspConfig.Switch;
        }

    }
}
