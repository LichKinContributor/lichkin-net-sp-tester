using System;

namespace LichKin.IO.Ports.Test
{
    partial class FT02RLForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FT02RLForm));
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.input02 = new System.Windows.Forms.CheckBox();
            this.input01 = new System.Windows.Forms.CheckBox();
            this.groupBoxLogAll = new System.Windows.Forms.GroupBox();
            this.richTextAllLog = new System.Windows.Forms.RichTextBox();
            this.groupBoxLogMain = new System.Windows.Forms.GroupBox();
            this.richTextMainLog = new System.Windows.Forms.RichTextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.output02 = new System.Windows.Forms.CheckBox();
            this.output01 = new System.Windows.Forms.CheckBox();
            this.buttonClearAllLog = new System.Windows.Forms.Button();
            this.buttonClearMainLog = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxLogAll.SuspendLayout();
            this.groupBoxLogMain.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.input02);
            this.groupBoxInput.Controls.Add(this.input01);
            this.groupBoxInput.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxInput.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxInput.Location = new System.Drawing.Point(570, 40);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(50, 345);
            this.groupBoxInput.TabIndex = 24;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "输入";
            // 
            // input02
            // 
            this.input02.AutoSize = true;
            this.input02.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.input02.Cursor = System.Windows.Forms.Cursors.No;
            this.input02.Enabled = false;
            this.input02.Location = new System.Drawing.Point(5, 40);
            this.input02.Name = "input02";
            this.input02.Size = new System.Drawing.Size(38, 16);
            this.input02.TabIndex = 14;
            this.input02.Text = "02";
            this.input02.UseVisualStyleBackColor = true;
            // 
            // input01
            // 
            this.input01.AutoSize = true;
            this.input01.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.input01.Cursor = System.Windows.Forms.Cursors.No;
            this.input01.Enabled = false;
            this.input01.Location = new System.Drawing.Point(5, 20);
            this.input01.Name = "input01";
            this.input01.Size = new System.Drawing.Size(38, 16);
            this.input01.TabIndex = 13;
            this.input01.Text = "01";
            this.input01.UseVisualStyleBackColor = true;
            // 
            // groupBoxLogAll
            // 
            this.groupBoxLogAll.Controls.Add(this.richTextAllLog);
            this.groupBoxLogAll.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxLogAll.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxLogAll.Location = new System.Drawing.Point(10, 40);
            this.groupBoxLogAll.Name = "groupBoxLogAll";
            this.groupBoxLogAll.Size = new System.Drawing.Size(500, 580);
            this.groupBoxLogAll.TabIndex = 21;
            this.groupBoxLogAll.TabStop = false;
            this.groupBoxLogAll.Text = "所有日志";
            // 
            // richTextAllLog
            // 
            this.richTextAllLog.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextAllLog.Location = new System.Drawing.Point(10, 20);
            this.richTextAllLog.Margin = new System.Windows.Forms.Padding(0);
            this.richTextAllLog.Name = "richTextAllLog";
            this.richTextAllLog.ReadOnly = true;
            this.richTextAllLog.Size = new System.Drawing.Size(480, 550);
            this.richTextAllLog.TabIndex = 1;
            this.richTextAllLog.Text = "";
            this.richTextAllLog.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // groupBoxLogMain
            // 
            this.groupBoxLogMain.Controls.Add(this.richTextMainLog);
            this.groupBoxLogMain.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxLogMain.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxLogMain.Location = new System.Drawing.Point(625, 40);
            this.groupBoxLogMain.Name = "groupBoxLogMain";
            this.groupBoxLogMain.Size = new System.Drawing.Size(365, 580);
            this.groupBoxLogMain.TabIndex = 22;
            this.groupBoxLogMain.TabStop = false;
            this.groupBoxLogMain.Text = "主要日志";
            // 
            // richTextMainLog
            // 
            this.richTextMainLog.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextMainLog.Location = new System.Drawing.Point(10, 20);
            this.richTextMainLog.Name = "richTextMainLog";
            this.richTextMainLog.Size = new System.Drawing.Size(345, 550);
            this.richTextMainLog.TabIndex = 0;
            this.richTextMainLog.Text = "";
            this.richTextMainLog.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.output02);
            this.groupBoxOutput.Controls.Add(this.output01);
            this.groupBoxOutput.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxOutput.Location = new System.Drawing.Point(515, 40);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(50, 345);
            this.groupBoxOutput.TabIndex = 23;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "输出";
            // 
            // output02
            // 
            this.output02.AutoSize = true;
            this.output02.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.output02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.output02.Location = new System.Drawing.Point(5, 40);
            this.output02.Name = "output02";
            this.output02.Size = new System.Drawing.Size(38, 16);
            this.output02.TabIndex = 1;
            this.output02.Text = "02";
            this.output02.UseVisualStyleBackColor = true;
            this.output02.CheckedChanged += new System.EventHandler(this.CheckBox_Click);
            // 
            // output01
            // 
            this.output01.AutoSize = true;
            this.output01.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.output01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.output01.Location = new System.Drawing.Point(5, 20);
            this.output01.Name = "output01";
            this.output01.Size = new System.Drawing.Size(38, 16);
            this.output01.TabIndex = 0;
            this.output01.Text = "01";
            this.output01.UseVisualStyleBackColor = true;
            this.output01.CheckedChanged += new System.EventHandler(this.CheckBox_Click);
            // 
            // buttonClearAllLog
            // 
            this.buttonClearAllLog.Location = new System.Drawing.Point(515, 400);
            this.buttonClearAllLog.Name = "buttonClearAllLog";
            this.buttonClearAllLog.Size = new System.Drawing.Size(105, 23);
            this.buttonClearAllLog.TabIndex = 17;
            this.buttonClearAllLog.Text = "<< 清空日志";
            this.buttonClearAllLog.UseVisualStyleBackColor = true;
            this.buttonClearAllLog.Click += new System.EventHandler(this.buttonClearAllLog_Click);
            // 
            // buttonClearMainLog
            // 
            this.buttonClearMainLog.Location = new System.Drawing.Point(515, 430);
            this.buttonClearMainLog.Name = "buttonClearMainLog";
            this.buttonClearMainLog.Size = new System.Drawing.Size(105, 23);
            this.buttonClearMainLog.TabIndex = 26;
            this.buttonClearMainLog.Text = "清空日志 >>";
            this.buttonClearMainLog.UseVisualStyleBackColor = true;
            this.buttonClearMainLog.Click += new System.EventHandler(this.buttonClearMainLog_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.PanelMain.Controls.Add(this.buttonClearMainLog);
            this.PanelMain.Controls.Add(this.buttonClearAllLog);
            this.PanelMain.Controls.Add(this.groupBoxOutput);
            this.PanelMain.Controls.Add(this.groupBoxLogMain);
            this.PanelMain.Controls.Add(this.groupBoxLogAll);
            this.PanelMain.Controls.Add(this.groupBoxInput);
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1000, 630);
            this.PanelMain.TabIndex = 0;
            // 
            // FT02RLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FT02RLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FT-02RL";
            this.Load += new System.EventHandler(this.FT02RLForm_Load);
            this.Disposed += new System.EventHandler(this.FT02RLForm_Disposed);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxLogAll.ResumeLayout(false);
            this.groupBoxLogMain.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.CheckBox input02;
        private System.Windows.Forms.CheckBox input01;
        private System.Windows.Forms.GroupBox groupBoxLogAll;
        private System.Windows.Forms.RichTextBox richTextAllLog;
        private System.Windows.Forms.GroupBox groupBoxLogMain;
        private System.Windows.Forms.RichTextBox richTextMainLog;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.CheckBox output02;
        private System.Windows.Forms.CheckBox output01;
        private System.Windows.Forms.Button buttonClearAllLog;
        private System.Windows.Forms.Button buttonClearMainLog;
        private System.Windows.Forms.Panel PanelMain;
    }
}

