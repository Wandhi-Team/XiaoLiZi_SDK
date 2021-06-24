
namespace MsTool.Form.Pages
{
    partial class LspSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.sw_Lsp = new Sunny.UI.UISwitch();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txt_Token = new Sunny.UI.UITextBox();
            this.txt_Pre = new Sunny.UI.UITextBox();
            this.txt_Code = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(42, 35);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(61, 21);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Token:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(42, 70);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(78, 21);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "触发前缀:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(42, 105);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(62, 21);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "触发词:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sw_Lsp
            // 
            this.sw_Lsp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.sw_Lsp.Location = new System.Drawing.Point(127, 138);
            this.sw_Lsp.MinimumSize = new System.Drawing.Size(1, 1);
            this.sw_Lsp.Name = "sw_Lsp";
            this.sw_Lsp.Size = new System.Drawing.Size(75, 29);
            this.sw_Lsp.TabIndex = 3;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(42, 140);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(62, 21);
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "当前群:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Token
            // 
            this.txt_Token.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Token.FillColor = System.Drawing.Color.White;
            this.txt_Token.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_Token.Location = new System.Drawing.Point(127, 30);
            this.txt_Token.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Token.Maximum = 2147483647D;
            this.txt_Token.Minimum = -2147483648D;
            this.txt_Token.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Token.Name = "txt_Token";
            this.txt_Token.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Token.Size = new System.Drawing.Size(150, 29);
            this.txt_Token.TabIndex = 5;
            // 
            // txt_Pre
            // 
            this.txt_Pre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pre.FillColor = System.Drawing.Color.White;
            this.txt_Pre.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_Pre.Location = new System.Drawing.Point(127, 67);
            this.txt_Pre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Pre.Maximum = 2147483647D;
            this.txt_Pre.Minimum = -2147483648D;
            this.txt_Pre.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Pre.Name = "txt_Pre";
            this.txt_Pre.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Pre.Size = new System.Drawing.Size(150, 29);
            this.txt_Pre.TabIndex = 6;
            // 
            // txt_Code
            // 
            this.txt_Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Code.FillColor = System.Drawing.Color.White;
            this.txt_Code.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_Code.Location = new System.Drawing.Point(127, 104);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Code.Maximum = 2147483647D;
            this.txt_Code.Minimum = -2147483648D;
            this.txt_Code.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Code.Size = new System.Drawing.Size(150, 29);
            this.txt_Code.TabIndex = 6;
            // 
            // LspSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Pre);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.txt_Token);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.sw_Lsp);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Name = "LspSetting";
            this.Text = "LspSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UISwitch sw_Lsp;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txt_Token;
        private Sunny.UI.UITextBox txt_Pre;
        private Sunny.UI.UITextBox txt_Code;
    }
}