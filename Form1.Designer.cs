namespace MsnService
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txbServerport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listboxStatus = new System.Windows.Forms.ListBox();
            this.lbUser = new System.Windows.Forms.ListBox();
            this.btnKick = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.Location = new System.Drawing.Point(628, 244);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(65, 26);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStart.Location = new System.Drawing.Point(557, 244);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(65, 26);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "啟動";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txbServerport
            // 
            this.txbServerport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbServerport.Location = new System.Drawing.Point(296, 243);
            this.txbServerport.Name = "txbServerport";
            this.txbServerport.Size = new System.Drawing.Size(64, 29);
            this.txbServerport.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(271, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "：";
            // 
            // txbServerIP
            // 
            this.txbServerIP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbServerIP.Location = new System.Drawing.Point(114, 243);
            this.txbServerIP.Name = "txbServerIP";
            this.txbServerIP.Size = new System.Drawing.Size(157, 29);
            this.txbServerIP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "服務器地址：";
            // 
            // listboxStatus
            // 
            this.listboxStatus.BackColor = System.Drawing.Color.Black;
            this.listboxStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listboxStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.listboxStatus.FormattingEnabled = true;
            this.listboxStatus.ItemHeight = 21;
            this.listboxStatus.Location = new System.Drawing.Point(4, 3);
            this.listboxStatus.Name = "listboxStatus";
            this.listboxStatus.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listboxStatus.Size = new System.Drawing.Size(498, 235);
            this.listboxStatus.TabIndex = 7;
            // 
            // lbUser
            // 
            this.lbUser.BackColor = System.Drawing.Color.Black;
            this.lbUser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbUser.ForeColor = System.Drawing.SystemColors.Window;
            this.lbUser.FormattingEnabled = true;
            this.lbUser.ItemHeight = 21;
            this.lbUser.Location = new System.Drawing.Point(508, 3);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(185, 235);
            this.lbUser.TabIndex = 14;
            // 
            // btnKick
            // 
            this.btnKick.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnKick.Location = new System.Drawing.Point(486, 244);
            this.btnKick.Name = "btnKick";
            this.btnKick.Size = new System.Drawing.Size(65, 26);
            this.btnKick.TabIndex = 15;
            this.btnKick.Text = "Kick";
            this.btnKick.UseVisualStyleBackColor = true;
            this.btnKick.Click += new System.EventHandler(this.btnKick_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "VUserList";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 276);
            this.Controls.Add(this.btnKick);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txbServerport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbServerIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MsnService";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txbServerport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbServerIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listboxStatus;
        private System.Windows.Forms.ListBox lbUser;
        private System.Windows.Forms.Button btnKick;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

