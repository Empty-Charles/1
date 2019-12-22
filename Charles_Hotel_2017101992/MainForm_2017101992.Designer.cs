namespace Charles_Hotel_2017101992
{
    partial class MainForm_2017101992
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_2017101992));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.miUserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.tool = new System.Windows.Forms.ToolStrip();
            this.入住Btn = new System.Windows.Forms.ToolStripButton();
            this.退房Btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.旅客Btn = new System.Windows.Forms.ToolStripButton();
            this.客房Btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.添加Btn = new System.Windows.Forms.ToolStripButton();
            this.删除修改Btn = new System.Windows.Forms.ToolStripButton();
            this.menu.SuspendLayout();
            this.tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.miEditUser,
            this.toolStripMenuItem10});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 24);
            this.toolStripMenuItem1.Text = "客房管理（M）";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem2.Text = "入住登记";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem3.Text = "退房登记";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(120, 24);
            this.toolStripMenuItem4.Text = "查询管理（S）";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(174, 26);
            this.toolStripMenuItem5.Text = "旅客信息查询";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(174, 26);
            this.toolStripMenuItem6.Text = "客房信息查询";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // miEditUser
            // 
            this.miEditUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewUser,
            this.miUserManage});
            this.miEditUser.Name = "miEditUser";
            this.miEditUser.Size = new System.Drawing.Size(122, 24);
            this.miEditUser.Text = "用户管理（U）";
            // 
            // miNewUser
            // 
            this.miNewUser.Name = "miNewUser";
            this.miNewUser.Size = new System.Drawing.Size(159, 26);
            this.miNewUser.Text = "添加新用户";
            this.miNewUser.Click += new System.EventHandler(this.miNewUser_Click);
            // 
            // miUserManage
            // 
            this.miUserManage.Name = "miUserManage";
            this.miUserManage.Size = new System.Drawing.Size(159, 26);
            this.miUserManage.Text = "删除修改";
            this.miUserManage.Click += new System.EventHandler(this.miUserManage_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11});
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(93, 24);
            this.toolStripMenuItem10.Text = "帮助（H）";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem11.Text = "关于";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // tool
            // 
            this.tool.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入住Btn,
            this.退房Btn,
            this.toolStripButton3,
            this.旅客Btn,
            this.客房Btn,
            this.toolStripButton6,
            this.添加Btn,
            this.删除修改Btn});
            this.tool.Location = new System.Drawing.Point(0, 28);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(800, 27);
            this.tool.TabIndex = 4;
            this.tool.Text = "toolStrip2";
            // 
            // 入住Btn
            // 
            this.入住Btn.Image = ((System.Drawing.Image)(resources.GetObject("入住Btn.Image")));
            this.入住Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.入住Btn.Name = "入住Btn";
            this.入住Btn.Size = new System.Drawing.Size(93, 24);
            this.入住Btn.Text = "入住登记";
            this.入住Btn.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 退房Btn
            // 
            this.退房Btn.Image = ((System.Drawing.Image)(resources.GetObject("退房Btn.Image")));
            this.退房Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.退房Btn.Name = "退房Btn";
            this.退房Btn.Size = new System.Drawing.Size(93, 24);
            this.退房Btn.Text = "退房登记";
            this.退房Btn.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // 旅客Btn
            // 
            this.旅客Btn.Image = ((System.Drawing.Image)(resources.GetObject("旅客Btn.Image")));
            this.旅客Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.旅客Btn.Name = "旅客Btn";
            this.旅客Btn.Size = new System.Drawing.Size(93, 24);
            this.旅客Btn.Text = "旅客信息";
            this.旅客Btn.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // 客房Btn
            // 
            this.客房Btn.Image = ((System.Drawing.Image)(resources.GetObject("客房Btn.Image")));
            this.客房Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.客房Btn.Name = "客房Btn";
            this.客房Btn.Size = new System.Drawing.Size(93, 24);
            this.客房Btn.Text = "客房信息";
            this.客房Btn.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // 添加Btn
            // 
            this.添加Btn.Image = ((System.Drawing.Image)(resources.GetObject("添加Btn.Image")));
            this.添加Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.添加Btn.Name = "添加Btn";
            this.添加Btn.Size = new System.Drawing.Size(108, 24);
            this.添加Btn.Text = "添加新用户";
            this.添加Btn.Click += new System.EventHandler(this.miNewUser_Click);
            // 
            // 删除修改Btn
            // 
            this.删除修改Btn.Image = ((System.Drawing.Image)(resources.GetObject("删除修改Btn.Image")));
            this.删除修改Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.删除修改Btn.Name = "删除修改Btn";
            this.删除修改Btn.Size = new System.Drawing.Size(99, 24);
            this.删除修改Btn.Text = "删除/修改";
            this.删除修改Btn.Click += new System.EventHandler(this.miUserManage_Click);
            // 
            // MainForm_2017101992
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tool);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm_2017101992";
            this.Text = "酒店管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_2017101992_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem miEditUser;
        private System.Windows.Forms.ToolStripMenuItem miNewUser;
        private System.Windows.Forms.ToolStripMenuItem miUserManage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripButton 入住Btn;
        private System.Windows.Forms.ToolStripButton 退房Btn;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton 旅客Btn;
        private System.Windows.Forms.ToolStripButton 客房Btn;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton 添加Btn;
        private System.Windows.Forms.ToolStripButton 删除修改Btn;
    }
}