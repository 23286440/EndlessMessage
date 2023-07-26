namespace 消息轰炸
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.运行按钮 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.已发送次数 = new System.Windows.Forms.Label();
            this.启动等待 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.发送次数 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.间隔时间 = new System.Windows.Forms.NumericUpDown();
            this.Bilibili链接 = new System.Windows.Forms.LinkLabel();
            this.源代码链接 = new System.Windows.Forms.LinkLabel();
            this.打赏链接 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.协议 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.运行倒计时 = new System.Windows.Forms.Label();
            this.计时器1 = new System.Windows.Forms.Timer(this.components);
            this.计时器2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.启动等待)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.发送次数)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.间隔时间)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "将你要发送的消息复制到粘贴板，设置好等待秒数后运行，\r\n之后点击发送消息的输入框即可！\r\n";
            // 
            // 运行按钮
            // 
            this.运行按钮.BackColor = System.Drawing.Color.Transparent;
            this.运行按钮.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("运行按钮.BackgroundImage")));
            this.运行按钮.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.运行按钮.Cursor = System.Windows.Forms.Cursors.Hand;
            this.运行按钮.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.运行按钮.Location = new System.Drawing.Point(17, 122);
            this.运行按钮.Name = "运行按钮";
            this.运行按钮.Size = new System.Drawing.Size(159, 42);
            this.运行按钮.TabIndex = 1;
            this.运行按钮.Text = "戳我运行 q(≧▽≦q)";
            this.运行按钮.UseVisualStyleBackColor = false;
            this.运行按钮.Click += new System.EventHandler(this.运行按钮_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(180, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "已发送次数：";
            // 
            // 已发送次数
            // 
            this.已发送次数.AutoSize = true;
            this.已发送次数.Location = new System.Drawing.Point(246, 125);
            this.已发送次数.Name = "已发送次数";
            this.已发送次数.Size = new System.Drawing.Size(11, 12);
            this.已发送次数.TabIndex = 3;
            this.已发送次数.Text = "0";
            // 
            // 启动等待
            // 
            this.启动等待.Location = new System.Drawing.Point(86, 51);
            this.启动等待.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.启动等待.Name = "启动等待";
            this.启动等待.Size = new System.Drawing.Size(78, 21);
            this.启动等待.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "等待秒数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(170, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "次数限制（0为一直发）：";
            // 
            // 发送次数
            // 
            this.发送次数.Location = new System.Drawing.Point(319, 51);
            this.发送次数.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.发送次数.Name = "发送次数";
            this.发送次数.Size = new System.Drawing.Size(116, 21);
            this.发送次数.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(15, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "每条消息间隔时间（毫秒）：";
            // 
            // 间隔时间
            // 
            this.间隔时间.Location = new System.Drawing.Point(172, 76);
            this.间隔时间.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.间隔时间.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.间隔时间.Name = "间隔时间";
            this.间隔时间.Size = new System.Drawing.Size(71, 21);
            this.间隔时间.TabIndex = 9;
            this.间隔时间.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Bilibili链接
            // 
            this.Bilibili链接.AutoSize = true;
            this.Bilibili链接.BackColor = System.Drawing.Color.Transparent;
            this.Bilibili链接.Location = new System.Drawing.Point(382, 98);
            this.Bilibili链接.Name = "Bilibili链接";
            this.Bilibili链接.Size = new System.Drawing.Size(53, 12);
            this.Bilibili链接.TabIndex = 17;
            this.Bilibili链接.TabStop = true;
            this.Bilibili链接.Text = "Bilibili";
            this.Bilibili链接.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Bilibili链接_LinkClicked);
            // 
            // 源代码链接
            // 
            this.源代码链接.AutoSize = true;
            this.源代码链接.BackColor = System.Drawing.Color.Transparent;
            this.源代码链接.Location = new System.Drawing.Point(335, 98);
            this.源代码链接.Name = "源代码链接";
            this.源代码链接.Size = new System.Drawing.Size(41, 12);
            this.源代码链接.TabIndex = 16;
            this.源代码链接.TabStop = true;
            this.源代码链接.Text = "源代码";
            this.源代码链接.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.源代码链接_LinkClicked);
            // 
            // 打赏链接
            // 
            this.打赏链接.AutoSize = true;
            this.打赏链接.BackColor = System.Drawing.Color.Transparent;
            this.打赏链接.Location = new System.Drawing.Point(300, 98);
            this.打赏链接.Name = "打赏链接";
            this.打赏链接.Size = new System.Drawing.Size(29, 12);
            this.打赏链接.TabIndex = 15;
            this.打赏链接.TabStop = true;
            this.打赏链接.Text = "打赏";
            this.打赏链接.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.打赏链接_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(299, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "作者：侏罗纪";
            // 
            // 协议
            // 
            this.协议.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.协议.AutoSize = true;
            this.协议.BackColor = System.Drawing.Color.Transparent;
            this.协议.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.协议.Location = new System.Drawing.Point(295, 166);
            this.协议.Name = "协议";
            this.协议.Size = new System.Drawing.Size(154, 14);
            this.协议.TabIndex = 18;
            this.协议.Text = "本软件使用MIT许可协议";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(182, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "运行倒计时：";
            // 
            // 运行倒计时
            // 
            this.运行倒计时.AutoSize = true;
            this.运行倒计时.BackColor = System.Drawing.Color.White;
            this.运行倒计时.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.运行倒计时.ForeColor = System.Drawing.Color.Red;
            this.运行倒计时.Location = new System.Drawing.Point(265, 144);
            this.运行倒计时.Name = "运行倒计时";
            this.运行倒计时.Size = new System.Drawing.Size(22, 21);
            this.运行倒计时.TabIndex = 20;
            this.运行倒计时.Text = "0";
            // 
            // 计时器1
            // 
            this.计时器1.Interval = 1000;
            this.计时器1.Tick += new System.EventHandler(this.计时器1_Tick);
            // 
            // 计时器2
            // 
            this.计时器2.Tick += new System.EventHandler(this.计时器2_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Violet;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(463, 189);
            this.Controls.Add(this.运行倒计时);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.协议);
            this.Controls.Add(this.Bilibili链接);
            this.Controls.Add(this.源代码链接);
            this.Controls.Add(this.打赏链接);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.间隔时间);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.发送次数);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.启动等待);
            this.Controls.Add(this.已发送次数);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.运行按钮);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "消息轰炸";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.启动等待)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.发送次数)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.间隔时间)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 运行按钮;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 已发送次数;
        private System.Windows.Forms.NumericUpDown 启动等待;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown 发送次数;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown 间隔时间;
        private System.Windows.Forms.LinkLabel Bilibili链接;
        private System.Windows.Forms.LinkLabel 源代码链接;
        private System.Windows.Forms.LinkLabel 打赏链接;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label 协议;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label 运行倒计时;
        private System.Windows.Forms.Timer 计时器1;
        private System.Windows.Forms.Timer 计时器2;
    }
}

