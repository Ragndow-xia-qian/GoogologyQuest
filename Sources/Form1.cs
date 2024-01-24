using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogologyQuest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            Rectangle workingArea = Screen.GetWorkingArea(this); // 获取工作区大小

            // 设置窗口的大小为窗口的 1/4 大小
            this.Width = workingArea.Width / 2;
            this.Height = workingArea.Height / 2;

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing); // 设置关闭事件

            // 计算窗口应该显示的位置
            int x = (workingArea.Width - this.Width) / 2;
            int y = (workingArea.Height - this.Height) / 2;

            this.Location = new Point(x, y); // 设置窗口的位置

            // 设置背景图片
            this.BackgroundImage = Image.FromFile("D:\\Code\\csharp\\WinForm Projects\\GoogologyQuest\\GoogologyQuest\\Sources\\Resources\\images\\background.jpg");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确定要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true; // 取消关闭操作
            }
        }
    }
}
