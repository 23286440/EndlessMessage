using System;
using System.Windows.Forms;

namespace 消息轰炸
{
    public partial class Main : Form
    {
        private int max;
        private int counts;
        private int wait;

        public Main()
        {
            InitializeComponent();
        }

        private void 打赏链接_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://afdian.net/a/Zhuluoji");
        }

        private void 源代码链接_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://github.com/23286440/EndlessMessage");
        }

        private void Bilibili链接_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://space.bilibili.com/1927497544");
        }

        private void 运行按钮_Click(object sender, EventArgs e)
        {
            if (计时器1.Enabled)
            {
                计时器1.Enabled = false;
                计时器2.Enabled = false;
                运行按钮.Text = "戳我运行 q(≧▽≦q)";
            }
            else
            {
                max = (int)Math.Round(发送次数.Value);
                wait = (int)Math.Round(间隔时间.Value);
                counts = 0;

                已发送次数.Text = "0";
                运行按钮.Text = "点我终止运行o(*￣︶￣*)o";
                运行倒计时.Text = Math.Round(启动等待.Value).ToString();

                计时器1.Interval = 1000;
                计时器1.Enabled = true;
            }
        }

        private void 计时器1_Tick(object sender, EventArgs e)
        {
            if (运行倒计时.Text == "0")
            {
                计时器2.Interval = wait;
                计时器2.Enabled = true;
                计时器1.Enabled = false;
            }
            else
            {
                运行倒计时.Text = (int.Parse(运行倒计时.Text) - 1).ToString();
            }
        }

        private void 计时器2_Tick(object sender, EventArgs e)
        {
            SendKeys.SendWait("^v"+ "{ENTER}");
            counts++;
            已发送次数.Text=counts.ToString();
            if (max != 0 && counts >= max)
            {
                计时器2.Enabled = false;
                运行按钮.Text = "戳我运行 q(≧▽≦q)";
            }
        }
    }
}