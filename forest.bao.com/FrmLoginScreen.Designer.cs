namespace forest.bao.com
{
    partial class FrmLoginScreen
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginScreen));
            this.LoginNameText = new System.Windows.Forms.Label();
            this.LoginPasswordText = new System.Windows.Forms.Label();
            this.LoginNameBox = new System.Windows.Forms.TextBox();
            this.LoginPassWordBox = new System.Windows.Forms.TextBox();
            this.RemberPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginSystemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginNameText
            // 
            this.LoginNameText.AutoSize = true;
            this.LoginNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.LoginNameText.Location = new System.Drawing.Point(69, 126);
            this.LoginNameText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginNameText.Name = "LoginNameText";
            this.LoginNameText.Size = new System.Drawing.Size(65, 12);
            this.LoginNameText.TabIndex = 0;
            this.LoginNameText.Text = "登录账户：";
            this.LoginNameText.Click += new System.EventHandler(this.LoginNameText_Click);
            // 
            // LoginPasswordText
            // 
            this.LoginPasswordText.AutoSize = true;
            this.LoginPasswordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.LoginPasswordText.Location = new System.Drawing.Point(69, 151);
            this.LoginPasswordText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginPasswordText.Name = "LoginPasswordText";
            this.LoginPasswordText.Size = new System.Drawing.Size(65, 12);
            this.LoginPasswordText.TabIndex = 1;
            this.LoginPasswordText.Text = "账户密码：";
            this.LoginPasswordText.Click += new System.EventHandler(this.LoginPasswordText_Click);
            // 
            // LoginNameBox
            // 
            this.LoginNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginNameBox.Location = new System.Drawing.Point(138, 124);
            this.LoginNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginNameBox.Name = "LoginNameBox";
            this.LoginNameBox.Size = new System.Drawing.Size(136, 21);
            this.LoginNameBox.TabIndex = 2;
            this.LoginNameBox.TextChanged += new System.EventHandler(this.LoginNameTextBox_TextChanged);
            // 
            // LoginPassWordBox
            // 
            this.LoginPassWordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPassWordBox.Location = new System.Drawing.Point(138, 149);
            this.LoginPassWordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginPassWordBox.Name = "LoginPassWordBox";
            this.LoginPassWordBox.Size = new System.Drawing.Size(136, 21);
            this.LoginPassWordBox.TabIndex = 3;
            this.LoginPassWordBox.UseSystemPasswordChar = true;
            this.LoginPassWordBox.TextChanged += new System.EventHandler(this.LoginPassWordTextBox_TextChanged);
            // 
            // RemberPasswordCheckBox
            // 
            this.RemberPasswordCheckBox.AutoSize = true;
            this.RemberPasswordCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.RemberPasswordCheckBox.Location = new System.Drawing.Point(71, 185);
            this.RemberPasswordCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemberPasswordCheckBox.Name = "RemberPasswordCheckBox";
            this.RemberPasswordCheckBox.Size = new System.Drawing.Size(72, 16);
            this.RemberPasswordCheckBox.TabIndex = 4;
            this.RemberPasswordCheckBox.Text = "记住密码";
            this.RemberPasswordCheckBox.UseVisualStyleBackColor = false;
            this.RemberPasswordCheckBox.CheckedChanged += new System.EventHandler(this.RemberPasswordCheckBox_CheckedChanged);
            // 
            // LoginSystemButton
            // 
            this.LoginSystemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.LoginSystemButton.Location = new System.Drawing.Point(147, 180);
            this.LoginSystemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginSystemButton.Name = "LoginSystemButton";
            this.LoginSystemButton.Size = new System.Drawing.Size(117, 24);
            this.LoginSystemButton.TabIndex = 5;
            this.LoginSystemButton.Text = "登录";
            this.LoginSystemButton.UseVisualStyleBackColor = false;
            this.LoginSystemButton.Click += new System.EventHandler(this.LoginSystemButton_Click);
            // 
            // FrmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::forest.bao.com.Properties.Resources.AdminLoginbg;
            this.ClientSize = new System.Drawing.Size(396, 260);
            this.Controls.Add(this.LoginSystemButton);
            this.Controls.Add(this.RemberPasswordCheckBox);
            this.Controls.Add(this.LoginPassWordBox);
            this.Controls.Add(this.LoginNameBox);
            this.Controls.Add(this.LoginPasswordText);
            this.Controls.Add(this.LoginNameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FrmLoginadminScreen);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginNameText;
        private System.Windows.Forms.Label LoginPasswordText;
        private System.Windows.Forms.TextBox LoginNameBox;
        private System.Windows.Forms.TextBox LoginPassWordBox;
        private System.Windows.Forms.CheckBox RemberPasswordCheckBox;
        private System.Windows.Forms.Button LoginSystemButton;
    }
}

