
namespace MsTool.Form
{
    partial class CatSetting
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("机器人信息");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("涩图配置");
            this.cmb_Robot = new Sunny.UI.UIComboBox();
            this.cmb_Groups = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(138, 419);
            this.Footer.Size = new System.Drawing.Size(662, 31);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.uiLabel2);
            this.Header.Controls.Add(this.uiLabel1);
            this.Header.Controls.Add(this.cmb_Groups);
            this.Header.Controls.Add(this.cmb_Robot);
            this.Header.Location = new System.Drawing.Point(138, 35);
            this.Header.Size = new System.Drawing.Size(662, 49);
            // 
            // Aside
            // 
            treeNode1.Name = "机器人信息";
            treeNode1.Text = "机器人信息";
            treeNode2.Name = "涩图配置";
            treeNode2.Text = "涩图配置";
            this.Aside.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.Aside.Size = new System.Drawing.Size(138, 415);
            // 
            // cmb_Robot
            // 
            this.cmb_Robot.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_Robot.FillColor = System.Drawing.Color.White;
            this.cmb_Robot.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_Robot.Location = new System.Drawing.Point(86, 13);
            this.cmb_Robot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Robot.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_Robot.Name = "cmb_Robot";
            this.cmb_Robot.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_Robot.Size = new System.Drawing.Size(213, 29);
            this.cmb_Robot.TabIndex = 0;
            this.cmb_Robot.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_Robot.SelectedIndexChanged += new System.EventHandler(this.cmb_Robot_SelectedIndexChanged);
            // 
            // cmb_Groups
            // 
            this.cmb_Groups.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_Groups.FillColor = System.Drawing.Color.White;
            this.cmb_Groups.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_Groups.Location = new System.Drawing.Point(438, 13);
            this.cmb_Groups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Groups.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_Groups.Name = "cmb_Groups";
            this.cmb_Groups.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_Groups.Size = new System.Drawing.Size(213, 29);
            this.cmb_Groups.TabIndex = 1;
            this.cmb_Groups.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_Groups.SelectedIndexChanged += new System.EventHandler(this.cmb_Groups_SelectedIndexChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(6, 17);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(74, 21);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "机器人：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(396, 17);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(42, 21);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "群：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CatSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CatSetting";
            this.Text = "CatSetting";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox cmb_Groups;
        private Sunny.UI.UIComboBox cmb_Robot;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
    }
}