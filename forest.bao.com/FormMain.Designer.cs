namespace forest.bao.com
{
	
	
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.FrmMainImageTop = new System.Windows.Forms.Panel();
            this.LeftPanl = new System.Windows.Forms.Panel();
            this.ChangeUserPassWordButton = new System.Windows.Forms.Button();
            this.MangeTeacherInfoButton = new System.Windows.Forms.Button();
            this.MangeClassInfoButton = new System.Windows.Forms.Button();
            this.AddClassInfoButton = new System.Windows.Forms.Button();
            this.Right_MainScreenPanel = new System.Windows.Forms.Panel();
            this.LeftPanl.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrmMainImageTop
            // 
            this.FrmMainImageTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FrmMainImageTop.BackgroundImage")));
            this.FrmMainImageTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.FrmMainImageTop.Location = new System.Drawing.Point(0, 0);
            this.FrmMainImageTop.Name = "FrmMainImageTop";
            this.FrmMainImageTop.Size = new System.Drawing.Size(884, 66);
            this.FrmMainImageTop.TabIndex = 0;
            // 
            // LeftPanl
            // 
            this.LeftPanl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftPanl.Controls.Add(this.ChangeUserPassWordButton);
            this.LeftPanl.Controls.Add(this.MangeTeacherInfoButton);
            this.LeftPanl.Controls.Add(this.MangeClassInfoButton);
            this.LeftPanl.Controls.Add(this.AddClassInfoButton);
            this.LeftPanl.Location = new System.Drawing.Point(0, 72);
            this.LeftPanl.Name = "LeftPanl";
            this.LeftPanl.Size = new System.Drawing.Size(152, 434);
            this.LeftPanl.TabIndex = 1;
            this.LeftPanl.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftPanl_Paint);
            // 
            // ChangeUserPassWordButton
            // 
            this.ChangeUserPassWordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(105)))));
            this.ChangeUserPassWordButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChangeUserPassWordButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ChangeUserPassWordButton.Image = ((System.Drawing.Image)(resources.GetObject("ChangeUserPassWordButton.Image")));
            this.ChangeUserPassWordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeUserPassWordButton.Location = new System.Drawing.Point(11, 391);
            this.ChangeUserPassWordButton.Name = "ChangeUserPassWordButton";
            this.ChangeUserPassWordButton.Size = new System.Drawing.Size(123, 35);
            this.ChangeUserPassWordButton.TabIndex = 3;
            this.ChangeUserPassWordButton.Text = "修改登录密码";
            this.ChangeUserPassWordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeUserPassWordButton.UseVisualStyleBackColor = false;
            this.ChangeUserPassWordButton.Click += new System.EventHandler(this.ChangeUserPassWordButton_Click);
            // 
            // MangeTeacherInfoButton
            // 
            this.MangeTeacherInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(105)))));
            this.MangeTeacherInfoButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MangeTeacherInfoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MangeTeacherInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("MangeTeacherInfoButton.Image")));
            this.MangeTeacherInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MangeTeacherInfoButton.Location = new System.Drawing.Point(11, 291);
            this.MangeTeacherInfoButton.Name = "MangeTeacherInfoButton";
            this.MangeTeacherInfoButton.Size = new System.Drawing.Size(123, 35);
            this.MangeTeacherInfoButton.TabIndex = 2;
            this.MangeTeacherInfoButton.Text = "讲师信息管理";
            this.MangeTeacherInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MangeTeacherInfoButton.UseVisualStyleBackColor = false;
            this.MangeTeacherInfoButton.Click += new System.EventHandler(this.MangeTeacherInfoButton_Click);
            // 
            // MangeClassInfoButton
            // 
            this.MangeClassInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(105)))));
            this.MangeClassInfoButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MangeClassInfoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MangeClassInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("MangeClassInfoButton.Image")));
            this.MangeClassInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MangeClassInfoButton.Location = new System.Drawing.Point(11, 250);
            this.MangeClassInfoButton.Name = "MangeClassInfoButton";
            this.MangeClassInfoButton.Size = new System.Drawing.Size(123, 35);
            this.MangeClassInfoButton.TabIndex = 1;
            this.MangeClassInfoButton.Text = "课程信息管理";
            this.MangeClassInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MangeClassInfoButton.UseVisualStyleBackColor = false;
            this.MangeClassInfoButton.Click += new System.EventHandler(this.MangeClassInfoButton_Click);
            // 
            // AddClassInfoButton
            // 
            this.AddClassInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(105)))));
            this.AddClassInfoButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddClassInfoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddClassInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("AddClassInfoButton.Image")));
            this.AddClassInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddClassInfoButton.Location = new System.Drawing.Point(11, 209);
            this.AddClassInfoButton.Name = "AddClassInfoButton";
            this.AddClassInfoButton.Size = new System.Drawing.Size(123, 35);
            this.AddClassInfoButton.TabIndex = 0;
            this.AddClassInfoButton.Text = "添加课程信息";
            this.AddClassInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddClassInfoButton.UseVisualStyleBackColor = false;
            this.AddClassInfoButton.Click += new System.EventHandler(this.AddClassInfoButton_Click);
            // 
            // Right_MainScreenPanel
            // 
            this.Right_MainScreenPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Right_MainScreenPanel.BackgroundImage")));
            this.Right_MainScreenPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Right_MainScreenPanel.Location = new System.Drawing.Point(170, 72);
            this.Right_MainScreenPanel.Name = "Right_MainScreenPanel";
            this.Right_MainScreenPanel.Size = new System.Drawing.Size(714, 434);
            this.Right_MainScreenPanel.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.Right_MainScreenPanel);
            this.Controls.Add(this.LeftPanl);
            this.Controls.Add(this.FrmMainImageTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "主窗口";
            this.LeftPanl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FrmMainImageTop;
        private System.Windows.Forms.Panel LeftPanl;
        private System.Windows.Forms.Panel Right_MainScreenPanel;
        private System.Windows.Forms.Button AddClassInfoButton;
        private System.Windows.Forms.Button ChangeUserPassWordButton;
        private System.Windows.Forms.Button MangeTeacherInfoButton;
        private System.Windows.Forms.Button MangeClassInfoButton;
    }
}