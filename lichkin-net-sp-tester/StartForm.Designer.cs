namespace lichkin_net_sp_tester
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.buttonFT02RL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFT02RL
            // 
            this.buttonFT02RL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFT02RL.FlatAppearance.BorderSize = 0;
            this.buttonFT02RL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFT02RL.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFT02RL.ForeColor = System.Drawing.Color.White;
            this.buttonFT02RL.Image = global::lichkin_net_sp_tester.Properties.Resources.FT_02RL;
            this.buttonFT02RL.Location = new System.Drawing.Point(64, 64);
            this.buttonFT02RL.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFT02RL.Name = "buttonFT02RL";
            this.buttonFT02RL.Size = new System.Drawing.Size(256, 256);
            this.buttonFT02RL.TabIndex = 0;
            this.buttonFT02RL.Text = "FT-02RL";
            this.buttonFT02RL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFT02RL.UseVisualStyleBackColor = true;
            this.buttonFT02RL.Click += new System.EventHandler(this.buttonFT02RL_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonFT02RL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.Text = "串口通信调试工具";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFT02RL;
    }
}

