namespace SimpleClock
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelAlert = new System.Windows.Forms.Button();
            this.btnSetAlert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeekDay = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cmbMin = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timerClcok = new System.Windows.Forms.Timer(this.components);
            this.timerAlert = new System.Windows.Forms.Timer(this.components);
            this.txtStopWatch = new System.Windows.Forms.TextBox();
            this.listStopWatchLog = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.cmbCountHour = new System.Windows.Forms.ComboBox();
            this.cmbCountMin = new System.Windows.Forms.ComboBox();
            this.cmbCountSecond = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCountStart = new System.Windows.Forms.Button();
            this.btnCountPause = new System.Windows.Forms.Button();
            this.btnCountStop = new System.Windows.Forms.Button();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancelAlert);
            this.tabPage1.Controls.Add(this.btnSetAlert);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtWeekDay);
            this.tabPage1.Controls.Add(this.txtDate);
            this.tabPage1.Controls.Add(this.cmbMin);
            this.tabPage1.Controls.Add(this.cmbHour);
            this.tabPage1.Controls.Add(this.txtTime);
            this.tabPage1.Font = new System.Drawing.Font("細明體-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "時鐘";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancelAlert
            // 
            this.btnCancelAlert.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancelAlert.Location = new System.Drawing.Point(578, 203);
            this.btnCancelAlert.Name = "btnCancelAlert";
            this.btnCancelAlert.Size = new System.Drawing.Size(184, 40);
            this.btnCancelAlert.TabIndex = 7;
            this.btnCancelAlert.Text = "關閉鬧鐘";
            this.btnCancelAlert.UseVisualStyleBackColor = true;
            this.btnCancelAlert.Click += new System.EventHandler(this.btnCancelAlert_Click);
            // 
            // btnSetAlert
            // 
            this.btnSetAlert.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetAlert.Location = new System.Drawing.Point(388, 203);
            this.btnSetAlert.Name = "btnSetAlert";
            this.btnSetAlert.Size = new System.Drawing.Size(184, 40);
            this.btnSetAlert.TabIndex = 6;
            this.btnSetAlert.Text = "設定鬧鐘";
            this.btnSetAlert.UseVisualStyleBackColor = true;
            this.btnSetAlert.Click += new System.EventHandler(this.btnSetAlert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(157, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // txtWeekDay
            // 
            this.txtWeekDay.Enabled = false;
            this.txtWeekDay.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWeekDay.Location = new System.Drawing.Point(458, 115);
            this.txtWeekDay.Name = "txtWeekDay";
            this.txtWeekDay.Size = new System.Drawing.Size(304, 79);
            this.txtWeekDay.TabIndex = 4;
            this.txtWeekDay.Text = "星期";
            this.txtWeekDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDate.Location = new System.Drawing.Point(6, 115);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(446, 79);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "日期";
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbMin
            // 
            this.cmbMin.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbMin.FormattingEnabled = true;
            this.cmbMin.Location = new System.Drawing.Point(192, 205);
            this.cmbMin.Name = "cmbMin";
            this.cmbMin.Size = new System.Drawing.Size(144, 38);
            this.cmbMin.TabIndex = 2;
            // 
            // cmbHour
            // 
            this.cmbHour.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(6, 205);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(145, 38);
            this.cmbHour.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTime.Location = new System.Drawing.Point(6, 6);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(756, 103);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "00:00:00";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.btnStop);
            this.tabPage2.Controls.Add(this.btnLog);
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.btnPause);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.listStopWatchLog);
            this.tabPage2.Controls.Add(this.txtStopWatch);
            this.tabPage2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "碼表";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCountStop);
            this.tabPage3.Controls.Add(this.btnCountPause);
            this.tabPage3.Controls.Add(this.btnCountStart);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cmbCountSecond);
            this.tabPage3.Controls.Add(this.cmbCountMin);
            this.tabPage3.Controls.Add(this.cmbCountHour);
            this.tabPage3.Controls.Add(this.txtCountDown);
            this.tabPage3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "倒數";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // timerClcok
            // 
            this.timerClcok.Tick += new System.EventHandler(this.timerClcok_Tick);
            // 
            // timerAlert
            // 
            this.timerAlert.Tick += new System.EventHandler(this.timerAlert_Tick);
            // 
            // txtStopWatch
            // 
            this.txtStopWatch.Enabled = false;
            this.txtStopWatch.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStopWatch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStopWatch.Location = new System.Drawing.Point(6, 6);
            this.txtStopWatch.Name = "txtStopWatch";
            this.txtStopWatch.Size = new System.Drawing.Size(756, 103);
            this.txtStopWatch.TabIndex = 1;
            this.txtStopWatch.Text = "00:00:00.000";
            this.txtStopWatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listStopWatchLog
            // 
            this.listStopWatchLog.FormattingEnabled = true;
            this.listStopWatchLog.ItemHeight = 19;
            this.listStopWatchLog.Location = new System.Drawing.Point(6, 115);
            this.listStopWatchLog.Name = "listStopWatchLog";
            this.listStopWatchLog.Size = new System.Drawing.Size(250, 270);
            this.listStopWatchLog.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(262, 115);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(184, 40);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Yellow;
            this.btnPause.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPause.Location = new System.Drawing.Point(452, 115);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(184, 40);
            this.btnPause.TabIndex = 8;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(262, 161);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(184, 40);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "歸零";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Aqua;
            this.btnLog.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLog.Location = new System.Drawing.Point(452, 161);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(184, 40);
            this.btnLog.TabIndex = 10;
            this.btnLog.Text = "紀錄";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.Location = new System.Drawing.Point(262, 207);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(374, 40);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "停止並清空紀錄";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 1;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick);
            // 
            // txtCountDown
            // 
            this.txtCountDown.Enabled = false;
            this.txtCountDown.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCountDown.Location = new System.Drawing.Point(3, 3);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.Size = new System.Drawing.Size(762, 103);
            this.txtCountDown.TabIndex = 1;
            this.txtCountDown.Text = "00:00:00";
            this.txtCountDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbCountHour
            // 
            this.cmbCountHour.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCountHour.FormattingEnabled = true;
            this.cmbCountHour.Location = new System.Drawing.Point(3, 112);
            this.cmbCountHour.Name = "cmbCountHour";
            this.cmbCountHour.Size = new System.Drawing.Size(145, 38);
            this.cmbCountHour.TabIndex = 2;
            // 
            // cmbCountMin
            // 
            this.cmbCountMin.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCountMin.FormattingEnabled = true;
            this.cmbCountMin.Location = new System.Drawing.Point(189, 112);
            this.cmbCountMin.Name = "cmbCountMin";
            this.cmbCountMin.Size = new System.Drawing.Size(145, 38);
            this.cmbCountMin.TabIndex = 3;
            // 
            // cmbCountSecond
            // 
            this.cmbCountSecond.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCountSecond.FormattingEnabled = true;
            this.cmbCountSecond.Location = new System.Drawing.Point(375, 112);
            this.cmbCountSecond.Name = "cmbCountSecond";
            this.cmbCountSecond.Size = new System.Drawing.Size(145, 38);
            this.cmbCountSecond.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(154, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(340, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // btnCountStart
            // 
            this.btnCountStart.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCountStart.Location = new System.Drawing.Point(3, 156);
            this.btnCountStart.Name = "btnCountStart";
            this.btnCountStart.Size = new System.Drawing.Size(184, 40);
            this.btnCountStart.TabIndex = 8;
            this.btnCountStart.Text = "開始倒數";
            this.btnCountStart.UseVisualStyleBackColor = true;
            this.btnCountStart.Click += new System.EventHandler(this.btnCountStart_Click);
            // 
            // btnCountPause
            // 
            this.btnCountPause.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCountPause.Location = new System.Drawing.Point(3, 202);
            this.btnCountPause.Name = "btnCountPause";
            this.btnCountPause.Size = new System.Drawing.Size(184, 40);
            this.btnCountPause.TabIndex = 9;
            this.btnCountPause.Text = "暫停";
            this.btnCountPause.UseVisualStyleBackColor = true;
            this.btnCountPause.Click += new System.EventHandler(this.btnCountPause_Click);
            // 
            // btnCountStop
            // 
            this.btnCountStop.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCountStop.Location = new System.Drawing.Point(3, 248);
            this.btnCountStop.Name = "btnCountStop";
            this.btnCountStop.Size = new System.Drawing.Size(184, 40);
            this.btnCountStop.TabIndex = 10;
            this.btnCountStop.Text = "停止";
            this.btnCountStop.UseVisualStyleBackColor = true;
            this.btnCountStop.Click += new System.EventHandler(this.btnCountStop_Click);
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "簡單時鐘";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtWeekDay;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cmbMin;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnCancelAlert;
        private System.Windows.Forms.Button btnSetAlert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerClcok;
        private System.Windows.Forms.Timer timerAlert;
        private System.Windows.Forms.TextBox txtStopWatch;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listStopWatchLog;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCountSecond;
        private System.Windows.Forms.ComboBox cmbCountMin;
        private System.Windows.Forms.ComboBox cmbCountHour;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCountStart;
        private System.Windows.Forms.Button btnCountStop;
        private System.Windows.Forms.Button btnCountPause;
        private System.Windows.Forms.Timer timerCountDown;
    }
}

