﻿namespace OracleScan.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            LoadProxyBtn = new Krypton.Toolkit.KryptonButton();
            LoadDataBtn = new Krypton.Toolkit.KryptonButton();
            StartBtn = new Krypton.Toolkit.KryptonButton();
            StopBtn = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            TotalAccountsTextBox = new Krypton.Toolkit.KryptonTextBox();
            SuccessAccountsTextBox = new Krypton.Toolkit.KryptonTextBox();
            FailedAccountsTextBox = new Krypton.Toolkit.KryptonTextBox();
            CheckedAccountsTextBox = new Krypton.Toolkit.KryptonTextBox();
            StatusTextBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            NoProxyRadioButton = new Krypton.Toolkit.KryptonRadioButton();
            HTTPProxyRadioButton = new Krypton.Toolkit.KryptonRadioButton();
            Socks5RadioButton = new Krypton.Toolkit.KryptonRadioButton();
            DelayUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            ThreadsUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            ActiveTopMostCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            label1 = new Krypton.Toolkit.KryptonLabel();
            TotalProxyTextBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            SkipUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            ErrorProxyTextBox = new Krypton.Toolkit.KryptonTextBox();
            BanProxyTextBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            ReloadErrProxyCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            SuspendLayout();
            // 
            // LoadProxyBtn
            // 
            LoadProxyBtn.CornerRoundingRadius = -1F;
            LoadProxyBtn.Location = new Point(287, 64);
            LoadProxyBtn.Name = "LoadProxyBtn";
            LoadProxyBtn.Size = new Size(112, 34);
            LoadProxyBtn.StateCommon.Back.Color1 = Color.Navy;
            LoadProxyBtn.StateCommon.Back.Color2 = Color.Navy;
            LoadProxyBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            LoadProxyBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoadProxyBtn.TabIndex = 0;
            LoadProxyBtn.Values.Text = "Load Proxy";
            LoadProxyBtn.Click += LoadProxyBtn_Click;
            // 
            // LoadDataBtn
            // 
            LoadDataBtn.CornerRoundingRadius = -1F;
            LoadDataBtn.Location = new Point(287, 10);
            LoadDataBtn.Name = "LoadDataBtn";
            LoadDataBtn.Size = new Size(112, 34);
            LoadDataBtn.StateCommon.Back.Color1 = Color.Navy;
            LoadDataBtn.StateCommon.Back.Color2 = Color.Navy;
            LoadDataBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            LoadDataBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoadDataBtn.TabIndex = 1;
            LoadDataBtn.Values.Text = "Load Data";
            LoadDataBtn.Click += LoadDataBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.CornerRoundingRadius = -1F;
            StartBtn.Location = new Point(287, 117);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(112, 34);
            StartBtn.StateCommon.Back.Color1 = Color.FromArgb(0, 80, 0);
            StartBtn.StateCommon.Back.Color2 = Color.FromArgb(0, 80, 0);
            StartBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            StartBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StartBtn.TabIndex = 2;
            StartBtn.Values.Text = "Start";
            StartBtn.Click += StartBtn_Click;
            // 
            // StopBtn
            // 
            StopBtn.CornerRoundingRadius = -1F;
            StopBtn.Enabled = false;
            StopBtn.Location = new Point(287, 172);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(112, 34);
            StopBtn.StateCommon.Back.Color1 = Color.Maroon;
            StopBtn.StateCommon.Back.Color2 = Color.Maroon;
            StopBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            StopBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StopBtn.TabIndex = 3;
            StopBtn.Values.Text = "Stop";
            StopBtn.Click += StopBtn_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(15, 13);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(98, 20);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 4;
            kryptonLabel1.Values.Text = "Tổng accounts:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(15, 50);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(82, 20);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 5;
            kryptonLabel2.Values.Text = "Thành công:";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(15, 87);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(61, 20);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 6;
            kryptonLabel3.Values.Text = "Thất bại:";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(15, 124);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(81, 20);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 7;
            kryptonLabel4.Values.Text = "Đã kiểm tra:";
            // 
            // TotalAccountsTextBox
            // 
            TotalAccountsTextBox.Location = new Point(123, 10);
            TotalAccountsTextBox.Name = "TotalAccountsTextBox";
            TotalAccountsTextBox.ReadOnly = true;
            TotalAccountsTextBox.Size = new Size(139, 23);
            TotalAccountsTextBox.StateCommon.Back.Color1 = Color.FromArgb(128, 255, 255);
            TotalAccountsTextBox.StateCommon.Content.Color1 = Color.Black;
            TotalAccountsTextBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalAccountsTextBox.TabIndex = 9;
            TotalAccountsTextBox.Text = "0";
            TotalAccountsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SuccessAccountsTextBox
            // 
            SuccessAccountsTextBox.Location = new Point(123, 47);
            SuccessAccountsTextBox.Name = "SuccessAccountsTextBox";
            SuccessAccountsTextBox.ReadOnly = true;
            SuccessAccountsTextBox.Size = new Size(139, 23);
            SuccessAccountsTextBox.StateCommon.Back.Color1 = Color.FromArgb(128, 255, 128);
            SuccessAccountsTextBox.StateCommon.Content.Color1 = Color.Black;
            SuccessAccountsTextBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SuccessAccountsTextBox.TabIndex = 10;
            SuccessAccountsTextBox.Text = "0";
            SuccessAccountsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // FailedAccountsTextBox
            // 
            FailedAccountsTextBox.Location = new Point(123, 84);
            FailedAccountsTextBox.Name = "FailedAccountsTextBox";
            FailedAccountsTextBox.ReadOnly = true;
            FailedAccountsTextBox.Size = new Size(139, 23);
            FailedAccountsTextBox.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 128);
            FailedAccountsTextBox.StateCommon.Content.Color1 = Color.Black;
            FailedAccountsTextBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FailedAccountsTextBox.TabIndex = 11;
            FailedAccountsTextBox.Text = "0";
            FailedAccountsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CheckedAccountsTextBox
            // 
            CheckedAccountsTextBox.Location = new Point(123, 121);
            CheckedAccountsTextBox.Name = "CheckedAccountsTextBox";
            CheckedAccountsTextBox.ReadOnly = true;
            CheckedAccountsTextBox.Size = new Size(139, 23);
            CheckedAccountsTextBox.StateCommon.Back.Color1 = Color.FromArgb(128, 255, 128);
            CheckedAccountsTextBox.StateCommon.Content.Color1 = Color.Black;
            CheckedAccountsTextBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CheckedAccountsTextBox.TabIndex = 12;
            CheckedAccountsTextBox.Text = "0";
            CheckedAccountsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(287, 227);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.ReadOnly = true;
            StatusTextBox.Size = new Size(112, 23);
            StatusTextBox.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 0);
            StatusTextBox.StateCommon.Content.Color1 = Color.Black;
            StatusTextBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StatusTextBox.TabIndex = 13;
            StatusTextBox.Text = "Chưa bắt đầu";
            StatusTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(287, 270);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(46, 20);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel6.TabIndex = 14;
            kryptonLabel6.Values.Text = "Delay:";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(15, 303);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(65, 20);
            kryptonLabel7.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel7.TabIndex = 15;
            kryptonLabel7.Values.Text = "Số luồng:";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(15, 335);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(47, 20);
            kryptonLabel8.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel8.TabIndex = 16;
            kryptonLabel8.Values.Text = "Proxy:";
            // 
            // NoProxyRadioButton
            // 
            NoProxyRadioButton.Checked = true;
            NoProxyRadioButton.Location = new Point(123, 335);
            NoProxyRadioButton.Name = "NoProxyRadioButton";
            NoProxyRadioButton.Size = new Size(77, 20);
            NoProxyRadioButton.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            NoProxyRadioButton.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NoProxyRadioButton.TabIndex = 17;
            NoProxyRadioButton.Values.Text = "Proxyless";
            NoProxyRadioButton.CheckedChanged += ProxyRadioButton_CheckedChanged;
            // 
            // HTTPProxyRadioButton
            // 
            HTTPProxyRadioButton.Location = new Point(208, 335);
            HTTPProxyRadioButton.Name = "HTTPProxyRadioButton";
            HTTPProxyRadioButton.Size = new Size(54, 20);
            HTTPProxyRadioButton.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            HTTPProxyRadioButton.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HTTPProxyRadioButton.TabIndex = 18;
            HTTPProxyRadioButton.Values.Text = "HTTP";
            HTTPProxyRadioButton.CheckedChanged += ProxyRadioButton_CheckedChanged;
            // 
            // Socks5RadioButton
            // 
            Socks5RadioButton.Location = new Point(271, 335);
            Socks5RadioButton.Name = "Socks5RadioButton";
            Socks5RadioButton.Size = new Size(62, 20);
            Socks5RadioButton.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            Socks5RadioButton.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Socks5RadioButton.TabIndex = 19;
            Socks5RadioButton.Values.Text = "Socks5";
            Socks5RadioButton.CheckedChanged += ProxyRadioButton_CheckedChanged;
            // 
            // DelayUpDown
            // 
            DelayUpDown.Location = new Point(339, 268);
            DelayUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            DelayUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DelayUpDown.Name = "DelayUpDown";
            DelayUpDown.Size = new Size(60, 22);
            DelayUpDown.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 128);
            DelayUpDown.StateCommon.Content.Color1 = Color.Black;
            DelayUpDown.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DelayUpDown.TabIndex = 20;
            DelayUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            DelayUpDown.ValueChanged += DelayUpDown_ValueChanged;
            // 
            // ThreadsUpDown
            // 
            ThreadsUpDown.Location = new Point(123, 301);
            ThreadsUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            ThreadsUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ThreadsUpDown.Name = "ThreadsUpDown";
            ThreadsUpDown.Size = new Size(139, 22);
            ThreadsUpDown.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 128);
            ThreadsUpDown.StateCommon.Content.Color1 = Color.Black;
            ThreadsUpDown.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ThreadsUpDown.TabIndex = 21;
            ThreadsUpDown.Value = new decimal(new int[] { 30, 0, 0, 0 });
            ThreadsUpDown.ValueChanged += ThreadsUpDown_ValueChanged;
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(15, 365);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(69, 20);
            kryptonLabel9.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel9.TabIndex = 22;
            kryptonLabel9.Values.Text = "Top most:";
            // 
            // ActiveTopMostCheckBox
            // 
            ActiveTopMostCheckBox.Checked = true;
            ActiveTopMostCheckBox.CheckState = CheckState.Checked;
            ActiveTopMostCheckBox.Location = new Point(123, 365);
            ActiveTopMostCheckBox.Name = "ActiveTopMostCheckBox";
            ActiveTopMostCheckBox.Size = new Size(60, 20);
            ActiveTopMostCheckBox.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ActiveTopMostCheckBox.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ActiveTopMostCheckBox.TabIndex = 23;
            ActiveTopMostCheckBox.Values.Text = "Active";
            ActiveTopMostCheckBox.CheckedChanged += ActiveTopMostCheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.Location = new Point(15, 160);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            label1.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.TabIndex = 24;
            label1.Values.Text = "Số proxy:";
            // 
            // TotalProxyTextBox
            // 
            TotalProxyTextBox.Location = new Point(123, 157);
            TotalProxyTextBox.Name = "TotalProxyTextBox";
            TotalProxyTextBox.ReadOnly = true;
            TotalProxyTextBox.Size = new Size(139, 23);
            TotalProxyTextBox.StateCommon.Back.Color1 = Color.FromArgb(128, 255, 255);
            TotalProxyTextBox.StateCommon.Content.Color1 = Color.Black;
            TotalProxyTextBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalProxyTextBox.TabIndex = 25;
            TotalProxyTextBox.Text = "0";
            TotalProxyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(15, 268);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(39, 20);
            kryptonLabel10.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel10.TabIndex = 26;
            kryptonLabel10.Values.Text = "Skip:";
            // 
            // SkipUpDown
            // 
            SkipUpDown.Location = new Point(123, 266);
            SkipUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            SkipUpDown.Name = "SkipUpDown";
            SkipUpDown.Size = new Size(139, 22);
            SkipUpDown.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 128);
            SkipUpDown.StateCommon.Content.Color1 = Color.Black;
            SkipUpDown.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SkipUpDown.TabIndex = 27;
            // 
            // ErrorProxyTextBox
            // 
            ErrorProxyTextBox.Location = new Point(123, 194);
            ErrorProxyTextBox.Name = "ErrorProxyTextBox";
            ErrorProxyTextBox.ReadOnly = true;
            ErrorProxyTextBox.Size = new Size(139, 23);
            ErrorProxyTextBox.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 128);
            ErrorProxyTextBox.StateCommon.Content.Color1 = Color.Black;
            ErrorProxyTextBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorProxyTextBox.TabIndex = 28;
            ErrorProxyTextBox.Text = "0";
            ErrorProxyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // BanProxyTextBox
            // 
            BanProxyTextBox.Location = new Point(123, 230);
            BanProxyTextBox.Name = "BanProxyTextBox";
            BanProxyTextBox.ReadOnly = true;
            BanProxyTextBox.Size = new Size(139, 23);
            BanProxyTextBox.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 128);
            BanProxyTextBox.StateCommon.Content.Color1 = Color.Black;
            BanProxyTextBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BanProxyTextBox.TabIndex = 29;
            BanProxyTextBox.Text = "0";
            BanProxyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(15, 197);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(65, 20);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel5.TabIndex = 30;
            kryptonLabel5.Values.Text = "Proxy lỗi:";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(15, 230);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(73, 20);
            kryptonLabel11.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel11.TabIndex = 31;
            kryptonLabel11.Values.Text = "Proxy ban:";
            // 
            // ReloadErrProxyCheckBox
            // 
            ReloadErrProxyCheckBox.Checked = true;
            ReloadErrProxyCheckBox.CheckState = CheckState.Checked;
            ReloadErrProxyCheckBox.Location = new Point(208, 365);
            ReloadErrProxyCheckBox.Name = "ReloadErrProxyCheckBox";
            ReloadErrProxyCheckBox.Size = new Size(165, 20);
            ReloadErrProxyCheckBox.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ReloadErrProxyCheckBox.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReloadErrProxyCheckBox.TabIndex = 32;
            ReloadErrProxyCheckBox.Values.Text = "Auto Reload Error Proxy";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(419, 396);
            Controls.Add(ReloadErrProxyCheckBox);
            Controls.Add(kryptonLabel11);
            Controls.Add(kryptonLabel5);
            Controls.Add(BanProxyTextBox);
            Controls.Add(ErrorProxyTextBox);
            Controls.Add(SkipUpDown);
            Controls.Add(kryptonLabel10);
            Controls.Add(TotalProxyTextBox);
            Controls.Add(label1);
            Controls.Add(ActiveTopMostCheckBox);
            Controls.Add(kryptonLabel9);
            Controls.Add(ThreadsUpDown);
            Controls.Add(DelayUpDown);
            Controls.Add(Socks5RadioButton);
            Controls.Add(HTTPProxyRadioButton);
            Controls.Add(NoProxyRadioButton);
            Controls.Add(kryptonLabel8);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel6);
            Controls.Add(StatusTextBox);
            Controls.Add(CheckedAccountsTextBox);
            Controls.Add(FailedAccountsTextBox);
            Controls.Add(SuccessAccountsTextBox);
            Controls.Add(TotalAccountsTextBox);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(StopBtn);
            Controls.Add(StartBtn);
            Controls.Add(LoadDataBtn);
            Controls.Add(LoadProxyBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(435, 435);
            MinimumSize = new Size(435, 435);
            Name = "FrmMain";
            Text = "Oracle Scan - Tele: @lukaxsx";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton LoadProxyBtn;
        private Krypton.Toolkit.KryptonButton LoadDataBtn;
        private Krypton.Toolkit.KryptonButton StartBtn;
        private Krypton.Toolkit.KryptonButton StopBtn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox TotalAccountsTextBox;
        private Krypton.Toolkit.KryptonTextBox SuccessAccountsTextBox;
        private Krypton.Toolkit.KryptonTextBox FailedAccountsTextBox;
        private Krypton.Toolkit.KryptonTextBox CheckedAccountsTextBox;
        private Krypton.Toolkit.KryptonTextBox StatusTextBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonRadioButton NoProxyRadioButton;
        private Krypton.Toolkit.KryptonRadioButton HTTPProxyRadioButton;
        private Krypton.Toolkit.KryptonRadioButton Socks5RadioButton;
        private Krypton.Toolkit.KryptonNumericUpDown DelayUpDown;
        private Krypton.Toolkit.KryptonNumericUpDown ThreadsUpDown;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonCheckBox ActiveTopMostCheckBox;
        private Krypton.Toolkit.KryptonLabel label1;
        private Krypton.Toolkit.KryptonTextBox TotalProxyTextBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonNumericUpDown SkipUpDown;
        private Krypton.Toolkit.KryptonTextBox ErrorProxyTextBox;
        private Krypton.Toolkit.KryptonTextBox BanProxyTextBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonCheckBox ReloadErrProxyCheckBox;
    }
}