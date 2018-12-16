using System;
using System.Windows.Forms;

namespace LichKin.IO.Ports.Test
{
    public partial class FT02RLForm : Form
    {
        /**
         * 构造方法
         **/
        public FT02RLForm()
        {
            InitializeComponent();// 初始化控件
        }

        /**
         * 窗口加载后事件
         **/
        private void FT02RLForm_Load(object sender, EventArgs e)
        {
            FT02RLConfigLoader.instance.Load(
                 (sid, portName, readedHexString) =>
                 {
                     Log(false, "串口【" + portName + "】读取到数据：" + (readedHexString.Length > 18 ? "\n" : "") + "【" + readedHexString + "】");
                 },
                 (sid, portName) =>
                 {
                     Log(null, "尝试打开串口【" + portName + "】");
                 },
                 (sid, portName) =>
                 {
                     Log(null, "尝试打开串口【" + portName + "】 -> 成功");
                 },
                 (sid, portName) =>
                 {
                     Log(null, "尝试打开串口【" + portName + "】 -> 失败");
                 },
                 (sid, portName) =>
                 {
                     Log(false, "串口【" + portName + "】仍处于打开状态");
                 },
                 (sid, portName) =>
                 {
                     Log(null, "串口【" + portName + "】已经断开");
                 },
                 (sid, portName) =>
                 {
                     Log(null, "尝试重新打开串口【" + portName + "】");
                 },
                 (sid, portName) =>
                 {
                     Log(null, "尝试重新打开串口【" + portName + "】 -> 成功");
                 },
                 (sid, portName) =>
                 {
                     Log(null, "尝试重新打开串口【" + portName + "】 -> 失败");
                 },
                 (sid, portName) =>
                 {
                     SerialPortX serialPortX = FT02RLConfigLoader.instance.Get(sid);
                     if (serialPortX == null)
                     {
                         return;
                     }
                     serialPortX.EnqueueModbus(true,

                         new FT02RLReadCMDEventHandler((SID, PortName, result) =>
                         {
                             switch (result)
                             {
                                 case 0:
                                     // 所有路均未接通
                                     {
                                         Log(false, "串口【" + portName + "】，所有路均未接通。");
                                         Checkbox_Checked(input01, false);
                                         Checkbox_Checked(input02, false);
                                     };
                                     break;
                                 case 1:
                                     // 01路接通
                                     {
                                         Log(null, "串口【" + portName + "】，01路接通。");
                                         Checkbox_Checked(input01, true);
                                         Checkbox_Checked(input02, false);
                                     };
                                     break;
                                 case 2:
                                     // 02路接通
                                     {
                                         Log(null, "串口【" + portName + "】，02路接通。");
                                         Checkbox_Checked(input01, false);
                                         Checkbox_Checked(input02, true);
                                     };
                                     break;
                                 case 3:
                                     // 01路接通
                                     // 02路接通
                                     {
                                         Log(null, "串口【" + portName + "】，01路接通。");
                                         Log(null, "串口【" + portName + "】，02路接通。");
                                         Checkbox_Checked(input01, true);
                                         Checkbox_Checked(input02, true);
                                     };
                                     break;
                             }
                         }),

                         "01", "02", "00 00 00 02");
                 }
             );
        }

        /**
         * 窗口销毁后事件
         **/
        private void FT02RLForm_Disposed(object sender, EventArgs e)
        {
            FT02RLConfigLoader.instance.Release();
        }

        /**
         * 记录日志
         * @param main null:都记录;true:只记录主要日志;false:只记录所有日志;
         * @param text 日志内容
         **/
        private void Log(bool? main, String text)
        {
            switch (main)
            {
                case null:
                    RichTextBox_AppendText(richTextMainLog, text);
                    RichTextBox_AppendText(richTextAllLog, text);
                    break;
                case true:
                    RichTextBox_AppendText(richTextMainLog, text);
                    break;
                case false:
                    RichTextBox_AppendText(richTextAllLog, text);
                    break;
            }
        }

        // 多线程操作主线程创建的控件使用委托代理模式实现
        delegate void RichTextBox_AppendText_Deletgate(RichTextBox richTextBox, String text);
        private void RichTextBox_AppendText(RichTextBox richTextBox, String text)
        {
            if (!richTextBox.IsDisposed)
            {
                if (richTextBox.InvokeRequired)
                {
                    if (!this.IsDisposed)
                    {
                        this.Invoke(new RichTextBox_AppendText_Deletgate(RichTextBox_AppendText), new object[] { richTextBox, text });
                    }
                }
                else
                {
                    richTextBox.AppendText(DateTime.Now.ToString("[yyyy-MM-dd_HH:mm:ss.fff]") + " -> " + text + "\n");
                }
            }
        }

        /**
         * 富文本改变事件（通用）
         **/
        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;
            richTextBox.Select(richTextBox.TextLength, 0);
            richTextBox.ScrollToCaret();
        }

        /**
         * 清空所有日志按钮点击事件
         **/
        private void buttonClearAllLog_Click(object sender, EventArgs e)
        {
            richTextAllLog.Clear();
        }

        /**
         * 清空主要日志按钮点击事件
         **/
        private void buttonClearMainLog_Click(object sender, EventArgs e)
        {
            richTextMainLog.Clear();
        }

        // 多线程操作主线程创建的控件使用委托代理模式实现
        delegate void Checkbox_Checked_Delegate(CheckBox checkBox, Boolean @checked);
        private void Checkbox_Checked(CheckBox checkBox, Boolean @checked)
        {
            if (!checkBox.IsDisposed)
            {
                if (checkBox.InvokeRequired)
                {
                    if (!this.IsDisposed)
                    {
                        this.Invoke(new Checkbox_Checked_Delegate(Checkbox_Checked), new object[] { checkBox, @checked });
                    }
                }
                else
                {
                    checkBox.Checked = @checked;
                }
            }
        }

        /**
         * 复选框点击事件（通用）
         **/
        private void CheckBox_Click(object sender, EventArgs e)
        {
            String cmd = "00" + " " + ((CheckBox)sender).TabIndex.ToString("X2") + " " + (((CheckBox)sender).Checked ? "FF" : "00") + " " + "00";
            SerialPortX serialPortX = FT02RLConfigLoader.instance.Get("1234567890");
            if (serialPortX == null)
            {
                return;
            }
            serialPortX.EnqueueModbus(false, new FT02RLWriteCMDEventHandler(), "01", "05", cmd);
        }
    }
}
