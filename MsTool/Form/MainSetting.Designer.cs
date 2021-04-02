using MsTool.Form;

namespace MsTool
{
    partial class MainSetting
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contail_Main = new System.Windows.Forms.SplitContainer();
            this.lb_QList = new Sunny.UI.UIListBox();
            this.contain_Right = new System.Windows.Forms.SplitContainer();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.btn_BatchQuit = new Sunny.UI.UIButton();
            this.btn_ReferGroups = new Sunny.UI.UIButton();
            this.dgv_BatchQuit = new Sunny.UI.UIDataGridView();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btn_BatchAdd = new Sunny.UI.UIButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_Log = new Sunny.UI.UITextBox();
            this.txt_Groups = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contail_Main)).BeginInit();
            this.contail_Main.Panel1.SuspendLayout();
            this.contail_Main.Panel2.SuspendLayout();
            this.contail_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contain_Right)).BeginInit();
            this.contain_Right.Panel1.SuspendLayout();
            this.contain_Right.Panel2.SuspendLayout();
            this.contain_Right.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BatchQuit)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.contail_Main);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 447);
            this.panel2.TabIndex = 3;
            // 
            // contail_Main
            // 
            this.contail_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contail_Main.Location = new System.Drawing.Point(0, 0);
            this.contail_Main.Name = "contail_Main";
            // 
            // contail_Main.Panel1
            // 
            this.contail_Main.Panel1.Controls.Add(this.lb_QList);
            // 
            // contail_Main.Panel2
            // 
            this.contail_Main.Panel2.Controls.Add(this.contain_Right);
            this.contail_Main.Size = new System.Drawing.Size(894, 447);
            this.contail_Main.SplitterDistance = 161;
            this.contail_Main.TabIndex = 0;
            // 
            // lb_QList
            // 
            this.lb_QList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_QList.FillColor = System.Drawing.Color.White;
            this.lb_QList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lb_QList.FormatString = "";
            this.lb_QList.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lb_QList.Location = new System.Drawing.Point(0, 0);
            this.lb_QList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_QList.MinimumSize = new System.Drawing.Size(1, 1);
            this.lb_QList.Name = "lb_QList";
            this.lb_QList.Padding = new System.Windows.Forms.Padding(2);
            this.lb_QList.Size = new System.Drawing.Size(161, 447);
            this.lb_QList.TabIndex = 0;
            this.lb_QList.Text = "uiListBox1";
            this.lb_QList.Click += new System.EventHandler(this.lb_QList_Click);
            // 
            // contain_Right
            // 
            this.contain_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contain_Right.Location = new System.Drawing.Point(0, 0);
            this.contain_Right.Name = "contain_Right";
            this.contain_Right.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // contain_Right.Panel1
            // 
            this.contain_Right.Panel1.Controls.Add(this.uiTabControl1);
            // 
            // contain_Right.Panel2
            // 
            this.contain_Right.Panel2.Controls.Add(this.txt_Log);
            this.contain_Right.Size = new System.Drawing.Size(729, 447);
            this.contain_Right.SplitterDistance = 343;
            this.contain_Right.TabIndex = 2;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Controls.Add(this.tabPage4);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(0, 0);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(729, 343);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.uiGroupBox2);
            this.tabPage3.Controls.Add(this.uiGroupBox1);
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(729, 303);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "加群/退群";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.btn_BatchQuit);
            this.uiGroupBox2.Controls.Add(this.btn_ReferGroups);
            this.uiGroupBox2.Controls.Add(this.dgv_BatchQuit);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(291, 5);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(434, 298);
            this.uiGroupBox2.TabIndex = 7;
            this.uiGroupBox2.Text = "批量退群";
            // 
            // btn_BatchQuit
            // 
            this.btn_BatchQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BatchQuit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_BatchQuit.Location = new System.Drawing.Point(323, 22);
            this.btn_BatchQuit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_BatchQuit.Name = "btn_BatchQuit";
            this.btn_BatchQuit.Size = new System.Drawing.Size(100, 35);
            this.btn_BatchQuit.TabIndex = 2;
            this.btn_BatchQuit.Text = "退出选中";
            this.btn_BatchQuit.Click += new System.EventHandler(this.btn_BatchQuit_Click);
            // 
            // btn_ReferGroups
            // 
            this.btn_ReferGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ReferGroups.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_ReferGroups.Location = new System.Drawing.Point(217, 22);
            this.btn_ReferGroups.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_ReferGroups.Name = "btn_ReferGroups";
            this.btn_ReferGroups.Size = new System.Drawing.Size(100, 35);
            this.btn_ReferGroups.TabIndex = 1;
            this.btn_ReferGroups.Text = "刷新群列表";
            this.btn_ReferGroups.Click += new System.EventHandler(this.btn_ReferGroups_Click);
            // 
            // dgv_BatchQuit
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_BatchQuit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BatchQuit.BackgroundColor = System.Drawing.Color.White;
            this.dgv_BatchQuit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BatchQuit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_BatchQuit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BatchQuit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_BatchQuit.EnableHeadersVisualStyles = false;
            this.dgv_BatchQuit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_BatchQuit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_BatchQuit.Location = new System.Drawing.Point(6, 62);
            this.dgv_BatchQuit.Name = "dgv_BatchQuit";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BatchQuit.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv_BatchQuit.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_BatchQuit.RowTemplate.Height = 29;
            this.dgv_BatchQuit.SelectedIndex = -1;
            this.dgv_BatchQuit.ShowGridLine = true;
            this.dgv_BatchQuit.Size = new System.Drawing.Size(417, 230);
            this.dgv_BatchQuit.TabIndex = 0;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.txt_Groups);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.btn_BatchAdd);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(4, 5);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(283, 298);
            this.uiGroupBox1.TabIndex = 6;
            this.uiGroupBox1.Text = "批量加群";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(3, 21);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(145, 36);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "每行一个群号：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_BatchAdd
            // 
            this.btn_BatchAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BatchAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_BatchAdd.Location = new System.Drawing.Point(179, 22);
            this.btn_BatchAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_BatchAdd.Name = "btn_BatchAdd";
            this.btn_BatchAdd.Size = new System.Drawing.Size(100, 35);
            this.btn_BatchAdd.TabIndex = 0;
            this.btn_BatchAdd.Text = "批量加群";
            this.btn_BatchAdd.Click += new System.EventHandler(this.btn_BatchAdd_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(0, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(729, 303);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_Log
            // 
            this.txt_Log.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Log.FillColor = System.Drawing.Color.White;
            this.txt_Log.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_Log.Location = new System.Drawing.Point(0, 0);
            this.txt_Log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Log.Maximum = 2147483647D;
            this.txt_Log.Minimum = -2147483648D;
            this.txt_Log.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Log.Size = new System.Drawing.Size(729, 100);
            this.txt_Log.TabIndex = 0;
            // 
            // txt_Groups
            // 
            this.txt_Groups.Location = new System.Drawing.Point(3, 62);
            this.txt_Groups.Multiline = true;
            this.txt_Groups.Name = "txt_Groups";
            this.txt_Groups.Size = new System.Drawing.Size(276, 230);
            this.txt_Groups.TabIndex = 3;
            // 
            // MainSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 482);
            this.Controls.Add(this.panel2);
            this.Name = "MainSetting";
            this.Text = "集市助手";
            this.panel2.ResumeLayout(false);
            this.contail_Main.Panel1.ResumeLayout(false);
            this.contail_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contail_Main)).EndInit();
            this.contail_Main.ResumeLayout(false);
            this.contain_Right.Panel1.ResumeLayout(false);
            this.contain_Right.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contain_Right)).EndInit();
            this.contain_Right.ResumeLayout(false);
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BatchQuit)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel2;

        #endregion
        private System.Windows.Forms.SplitContainer contail_Main;
        private System.Windows.Forms.SplitContainer contain_Right;
        private Sunny.UI.UIListBox lb_QList;
        private Sunny.UI.UITextBox txt_Log;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btn_BatchAdd;
        private System.Windows.Forms.TabPage tabPage4;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIButton btn_BatchQuit;
        private Sunny.UI.UIButton btn_ReferGroups;
        private Sunny.UI.UIDataGridView dgv_BatchQuit;
        private System.Windows.Forms.TextBox txt_Groups;
    }
}

