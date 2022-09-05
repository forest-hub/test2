namespace forest.bao.com
{
    partial class FrmClassSetiScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClassSetiScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClassSetInfo = new System.Windows.Forms.Label();
            this.AddClassInfobutton = new System.Windows.Forms.Button();
            this.ModificationClassbutton = new System.Windows.Forms.Button();
            this.DeleteClassbutton = new System.Windows.Forms.Button();
            this.CloseWindonbutton = new System.Windows.Forms.Button();
            this.FrmClassSetScreenTop = new System.Windows.Forms.Panel();
            this.CourseClassificationComboBox = new System.Windows.Forms.ComboBox();
            this.CourseClassificationComboBoxLabel = new System.Windows.Forms.Label();
            this.ClassNamelabel = new System.Windows.Forms.Label();
            this.ClassNameTextBox = new System.Windows.Forms.TextBox();
            this.InquireClassInfoButton = new System.Windows.Forms.Button();
            this.ClassInfoCountLabel = new System.Windows.Forms.Label();
            this.ClassInfoCountLabel_NUM = new System.Windows.Forms.Label();
            this.ClassDataListView = new System.Windows.Forms.DataGridView();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyClassInfo_Screen = new System.Windows.Forms.Panel();
            this.ModifyScreenNumLable = new System.Windows.Forms.Label();
            this.ModifyScreenClassNumberLbel = new System.Windows.Forms.Label();
            this.ModifyClassInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.FrmClassSetScreenTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDataListView)).BeginInit();
            this.ModifyClassInfo_Screen.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassSetInfo
            // 
            this.ClassSetInfo.AutoSize = true;
            this.ClassSetInfo.Location = new System.Drawing.Point(24, 20);
            this.ClassSetInfo.Name = "ClassSetInfo";
            this.ClassSetInfo.Size = new System.Drawing.Size(119, 12);
            this.ClassSetInfo.TabIndex = 0;
            this.ClassSetInfo.Text = "当前位置 : 课程管理";
            // 
            // AddClassInfobutton
            // 
            this.AddClassInfobutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddClassInfobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddClassInfobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClassInfobutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddClassInfobutton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddClassInfobutton.Image = ((System.Drawing.Image)(resources.GetObject("AddClassInfobutton.Image")));
            this.AddClassInfobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddClassInfobutton.Location = new System.Drawing.Point(310, 12);
            this.AddClassInfobutton.Name = "AddClassInfobutton";
            this.AddClassInfobutton.Size = new System.Drawing.Size(85, 25);
            this.AddClassInfobutton.TabIndex = 1;
            this.AddClassInfobutton.Text = "添加课程";
            this.AddClassInfobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddClassInfobutton.UseVisualStyleBackColor = false;
            // 
            // ModificationClassbutton
            // 
            this.ModificationClassbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ModificationClassbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ModificationClassbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificationClassbutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ModificationClassbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.ModificationClassbutton.Image = ((System.Drawing.Image)(resources.GetObject("ModificationClassbutton.Image")));
            this.ModificationClassbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificationClassbutton.Location = new System.Drawing.Point(415, 12);
            this.ModificationClassbutton.Name = "ModificationClassbutton";
            this.ModificationClassbutton.Size = new System.Drawing.Size(85, 25);
            this.ModificationClassbutton.TabIndex = 2;
            this.ModificationClassbutton.Text = "修改课程";
            this.ModificationClassbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificationClassbutton.UseVisualStyleBackColor = false;
            // 
            // DeleteClassbutton
            // 
            this.DeleteClassbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteClassbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteClassbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteClassbutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteClassbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteClassbutton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteClassbutton.Image")));
            this.DeleteClassbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteClassbutton.Location = new System.Drawing.Point(516, 12);
            this.DeleteClassbutton.Name = "DeleteClassbutton";
            this.DeleteClassbutton.Size = new System.Drawing.Size(85, 25);
            this.DeleteClassbutton.TabIndex = 3;
            this.DeleteClassbutton.Text = "删除课程";
            this.DeleteClassbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteClassbutton.UseVisualStyleBackColor = false;
            // 
            // CloseWindonbutton
            // 
            this.CloseWindonbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CloseWindonbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseWindonbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindonbutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseWindonbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseWindonbutton.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindonbutton.Image")));
            this.CloseWindonbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseWindonbutton.Location = new System.Drawing.Point(617, 12);
            this.CloseWindonbutton.Name = "CloseWindonbutton";
            this.CloseWindonbutton.Size = new System.Drawing.Size(85, 25);
            this.CloseWindonbutton.TabIndex = 4;
            this.CloseWindonbutton.Text = "关闭窗口";
            this.CloseWindonbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseWindonbutton.UseVisualStyleBackColor = false;
            // 
            // FrmClassSetScreenTop
            // 
            this.FrmClassSetScreenTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FrmClassSetScreenTop.Controls.Add(this.CloseWindonbutton);
            this.FrmClassSetScreenTop.Controls.Add(this.DeleteClassbutton);
            this.FrmClassSetScreenTop.Controls.Add(this.ModificationClassbutton);
            this.FrmClassSetScreenTop.Controls.Add(this.AddClassInfobutton);
            this.FrmClassSetScreenTop.Controls.Add(this.ClassSetInfo);
            this.FrmClassSetScreenTop.Cursor = System.Windows.Forms.Cursors.No;
            this.FrmClassSetScreenTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.FrmClassSetScreenTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FrmClassSetScreenTop.Location = new System.Drawing.Point(0, 0);
            this.FrmClassSetScreenTop.Name = "FrmClassSetScreenTop";
            this.FrmClassSetScreenTop.Size = new System.Drawing.Size(714, 45);
            this.FrmClassSetScreenTop.TabIndex = 0;
            // 
            // CourseClassificationComboBox
            // 
            this.CourseClassificationComboBox.FormattingEnabled = true;
            this.CourseClassificationComboBox.Location = new System.Drawing.Point(95, 64);
            this.CourseClassificationComboBox.Name = "CourseClassificationComboBox";
            this.CourseClassificationComboBox.Size = new System.Drawing.Size(114, 20);
            this.CourseClassificationComboBox.TabIndex = 1;
            this.CourseClassificationComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseClassificationComboBox_SelectedIndexChanged);
            // 
            // CourseClassificationComboBoxLabel
            // 
            this.CourseClassificationComboBoxLabel.AutoSize = true;
            this.CourseClassificationComboBoxLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CourseClassificationComboBoxLabel.Location = new System.Drawing.Point(16, 67);
            this.CourseClassificationComboBoxLabel.Name = "CourseClassificationComboBoxLabel";
            this.CourseClassificationComboBoxLabel.Size = new System.Drawing.Size(77, 14);
            this.CourseClassificationComboBoxLabel.TabIndex = 2;
            this.CourseClassificationComboBoxLabel.Text = "课程分类：";
            // 
            // ClassNamelabel
            // 
            this.ClassNamelabel.AutoSize = true;
            this.ClassNamelabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClassNamelabel.Location = new System.Drawing.Point(217, 67);
            this.ClassNamelabel.Name = "ClassNamelabel";
            this.ClassNamelabel.Size = new System.Drawing.Size(77, 14);
            this.ClassNamelabel.TabIndex = 3;
            this.ClassNamelabel.Text = "课程名称：";
            // 
            // ClassNameTextBox
            // 
            this.ClassNameTextBox.Location = new System.Drawing.Point(291, 63);
            this.ClassNameTextBox.Name = "ClassNameTextBox";
            this.ClassNameTextBox.Size = new System.Drawing.Size(108, 21);
            this.ClassNameTextBox.TabIndex = 4;
            // 
            // InquireClassInfoButton
            // 
            this.InquireClassInfoButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InquireClassInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InquireClassInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InquireClassInfoButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InquireClassInfoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.InquireClassInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("InquireClassInfoButton.Image")));
            this.InquireClassInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InquireClassInfoButton.Location = new System.Drawing.Point(416, 59);
            this.InquireClassInfoButton.Name = "InquireClassInfoButton";
            this.InquireClassInfoButton.Size = new System.Drawing.Size(85, 25);
            this.InquireClassInfoButton.TabIndex = 5;
            this.InquireClassInfoButton.Text = "提交查询";
            this.InquireClassInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InquireClassInfoButton.UseVisualStyleBackColor = false;
            // 
            // ClassInfoCountLabel
            // 
            this.ClassInfoCountLabel.AutoSize = true;
            this.ClassInfoCountLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClassInfoCountLabel.Location = new System.Drawing.Point(521, 66);
            this.ClassInfoCountLabel.Name = "ClassInfoCountLabel";
            this.ClassInfoCountLabel.Size = new System.Drawing.Size(77, 14);
            this.ClassInfoCountLabel.TabIndex = 6;
            this.ClassInfoCountLabel.Text = "查询总数：";
            // 
            // ClassInfoCountLabel_NUM
            // 
            this.ClassInfoCountLabel_NUM.AutoSize = true;
            this.ClassInfoCountLabel_NUM.Location = new System.Drawing.Point(595, 69);
            this.ClassInfoCountLabel_NUM.Name = "ClassInfoCountLabel_NUM";
            this.ClassInfoCountLabel_NUM.Size = new System.Drawing.Size(11, 12);
            this.ClassInfoCountLabel_NUM.TabIndex = 7;
            this.ClassInfoCountLabel_NUM.Text = "0";
            // 
            // ClassDataListView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClassDataListView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassDataListView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClassDataListView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassDataListView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClassDataListView.ColumnHeadersHeight = 30;
            this.ClassDataListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassName,
            this.ClassTime,
            this.Score,
            this.Content,
            this.teacher});
            this.ClassDataListView.EnableHeadersVisualStyles = false;
            this.ClassDataListView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.ClassDataListView.Location = new System.Drawing.Point(12, 90);
            this.ClassDataListView.Name = "ClassDataListView";
            this.ClassDataListView.RowTemplate.Height = 23;
            this.ClassDataListView.ShowEditingIcon = false;
            this.ClassDataListView.Size = new System.Drawing.Size(690, 332);
            this.ClassDataListView.TabIndex = 8;
            this.ClassDataListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassDataListView_CellContentClick);
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "课程名称";
            this.ClassName.MinimumWidth = 8;
            this.ClassName.Name = "ClassName";
            this.ClassName.Width = 130;
            // 
            // ClassTime
            // 
            this.ClassTime.HeaderText = "课时";
            this.ClassTime.Name = "ClassTime";
            this.ClassTime.Width = 80;
            // 
            // Score
            // 
            this.Score.HeaderText = "分数";
            this.Score.Name = "Score";
            this.Score.Width = 80;
            // 
            // Content
            // 
            this.Content.HeaderText = "内容概述";
            this.Content.Name = "Content";
            this.Content.Width = 250;
            // 
            // teacher
            // 
            this.teacher.HeaderText = "讲师";
            this.teacher.Name = "teacher";
            // 
            // ModifyClassInfo_Screen
            // 
            this.ModifyClassInfo_Screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModifyClassInfo_Screen.Controls.Add(this.ModifyClassInfoGroupBox);
            this.ModifyClassInfo_Screen.Controls.Add(this.ModifyScreenNumLable);
            this.ModifyClassInfo_Screen.Controls.Add(this.ModifyScreenClassNumberLbel);
            this.ModifyClassInfo_Screen.Location = new System.Drawing.Point(5, 267);
            this.ModifyClassInfo_Screen.Name = "ModifyClassInfo_Screen";
            this.ModifyClassInfo_Screen.Size = new System.Drawing.Size(702, 167);
            this.ModifyClassInfo_Screen.TabIndex = 9;
            // 
            // ModifyScreenNumLable
            // 
            this.ModifyScreenNumLable.AutoSize = true;
            this.ModifyScreenNumLable.Location = new System.Drawing.Point(78, 17);
            this.ModifyScreenNumLable.Name = "ModifyScreenNumLable";
            this.ModifyScreenNumLable.Size = new System.Drawing.Size(11, 12);
            this.ModifyScreenNumLable.TabIndex = 9;
            this.ModifyScreenNumLable.Text = "0";
            // 
            // ModifyScreenClassNumberLbel
            // 
            this.ModifyScreenClassNumberLbel.AutoSize = true;
            this.ModifyScreenClassNumberLbel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ModifyScreenClassNumberLbel.Location = new System.Drawing.Point(2, 15);
            this.ModifyScreenClassNumberLbel.Name = "ModifyScreenClassNumberLbel";
            this.ModifyScreenClassNumberLbel.Size = new System.Drawing.Size(77, 14);
            this.ModifyScreenClassNumberLbel.TabIndex = 8;
            this.ModifyScreenClassNumberLbel.Text = "课程编号：";
            this.ModifyScreenClassNumberLbel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ModifyClassInfoGroupBox
            // 
            this.ModifyClassInfoGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModifyClassInfoGroupBox.Location = new System.Drawing.Point(13, 39);
            this.ModifyClassInfoGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyClassInfoGroupBox.Name = "ModifyClassInfoGroupBox";
            this.ModifyClassInfoGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ModifyClassInfoGroupBox.Size = new System.Drawing.Size(673, 114);
            this.ModifyClassInfoGroupBox.TabIndex = 10;
            this.ModifyClassInfoGroupBox.TabStop = false;
            this.ModifyClassInfoGroupBox.Text = "[课程信息]";
            // 
            // FrmClassSetiScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 434);
            this.Controls.Add(this.ModifyClassInfo_Screen);
            this.Controls.Add(this.ClassDataListView);
            this.Controls.Add(this.ClassInfoCountLabel_NUM);
            this.Controls.Add(this.ClassInfoCountLabel);
            this.Controls.Add(this.InquireClassInfoButton);
            this.Controls.Add(this.ClassNameTextBox);
            this.Controls.Add(this.ClassNamelabel);
            this.Controls.Add(this.CourseClassificationComboBoxLabel);
            this.Controls.Add(this.CourseClassificationComboBox);
            this.Controls.Add(this.FrmClassSetScreenTop);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClassSetiScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程设置页面";
            this.FrmClassSetScreenTop.ResumeLayout(false);
            this.FrmClassSetScreenTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDataListView)).EndInit();
            this.ModifyClassInfo_Screen.ResumeLayout(false);
            this.ModifyClassInfo_Screen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClassSetInfo;
        private System.Windows.Forms.Button AddClassInfobutton;
        private System.Windows.Forms.Button ModificationClassbutton;
        private System.Windows.Forms.Button DeleteClassbutton;
        private System.Windows.Forms.Button CloseWindonbutton;
        private System.Windows.Forms.Panel FrmClassSetScreenTop;
        private System.Windows.Forms.ComboBox CourseClassificationComboBox;
        private System.Windows.Forms.Label CourseClassificationComboBoxLabel;
        private System.Windows.Forms.Label ClassNamelabel;
        private System.Windows.Forms.TextBox ClassNameTextBox;
        private System.Windows.Forms.Button InquireClassInfoButton;
        private System.Windows.Forms.Label ClassInfoCountLabel;
        private System.Windows.Forms.Label ClassInfoCountLabel_NUM;
        private System.Windows.Forms.DataGridView ClassDataListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
        private System.Windows.Forms.Panel ModifyClassInfo_Screen;
        private System.Windows.Forms.Label ModifyScreenNumLable;
        private System.Windows.Forms.Label ModifyScreenClassNumberLbel;
        private System.Windows.Forms.GroupBox ModifyClassInfoGroupBox;
    }
}