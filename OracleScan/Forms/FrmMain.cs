﻿using OracleScan.Models;
using OracleScan.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace OracleScan.Forms
{
    public partial class FrmMain : Form
    {
        private ProxyType _proxyType = ProxyType.None;
        private int _totalThreads = 30;
        private int _delay = 1;
        private string _lastFileName = string.Empty;

        private CancellationTokenSource _cancelSource = new();
        private Queue<Account> _accounts = new();
        private List<MyProxy> _proxies = new();
        private readonly ItemsCount _itemCount = new();
        private int _proxyIndex = 0;

        public FrmMain()
        {
            InitializeComponent();
            TopMost = true;

            TotalAccountsTextBox.DataBindings.Add("Text", _itemCount, "Total");
            SuccessAccountsTextBox.DataBindings.Add("Text", _itemCount, "Success");
            FailedAccountsTextBox.DataBindings.Add("Text", _itemCount, "Failed");
            CheckedAccountsTextBox.DataBindings.Add("Text", _itemCount, "Scanned");

            ActiveControl = kryptonLabel1;
        }

        private async void LoadDataBtn_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Invoke(() => ActiveControl = kryptonLabel1);
                var openFileDialog = new OpenFileDialog
                {
                    Filter = "All Files (*.*)|*.*",
                    Multiselect = false
                };
                var dialogRs = Invoke(() => openFileDialog.ShowDialog(this));
                if (dialogRs == DialogResult.OK)
                {
                    _accounts = DataHandler.LoadAccounts(openFileDialog.FileName);
                    _lastFileName = Path.GetFileName(openFileDialog.FileName);
                    Invoke(() =>
                    {
                        _itemCount.Total = _accounts.Count;
                        _itemCount.Success = 0;
                        _itemCount.Failed = 0;
                        _itemCount.Scanned = 0;
                    });
                }
            });
        }

        private async void LoadProxyBtn_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Invoke(() => ActiveControl = kryptonLabel1);
                var openFileDialog = new OpenFileDialog
                {
                    Filter = "All Files (*.*)|*.*",
                    Multiselect = false
                };
                var dialogRs = Invoke(() => openFileDialog.ShowDialog(this));
                if (dialogRs == DialogResult.OK)
                {
                    _proxies = DataHandler.LoadProxies(openFileDialog.FileName);
                    Invoke(() => ProxyCountTextBox.Text = _proxies.Count.ToString());
                }
            });
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            DisableButton(true);
            var skipped = (int)SkipUpDown.Value;
            try
            {
                await Task.Run(async () =>
                {
                    Invoke(() =>
                    {
                        ActiveControl = kryptonLabel1;
                        StatusTextBox.Text = "Đang chạy";
                        StatusTextBox.StateCommon.Back.Color1 = Color.Lime;
                        MessageBox.Show(this, "Chương trình bắt đầu", "Thông báo");
                    });
                    for (int i = 0; i < skipped; i++)
                    {
                        if (_accounts.Count == 0) break;
                        _accounts.Dequeue();
                    }
                    Invoke(() => _itemCount.Scanned += skipped);

                    var tasks = new List<Task>();
                    for (int i = 0; i < _totalThreads; i++)
                    {
                        var token = _cancelSource.Token;
                        tasks.Add(Check(token));
                    }
                    await Task.WhenAll(tasks);
                });
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog($"[StartBtn_Click] Got exception when running. Error: {ex}");
            }
            finally
            {
                DisableButton(false);
                DataHandler.WriteLastRun(_lastFileName, _itemCount.Scanned);
                Invoke(() =>
                {
                    SkipUpDown.Value = 0;
                    StatusTextBox.Text = "Đã dừng";
                    StatusTextBox.StateCommon.Back.Color1 = Color.Firebrick;
                    MessageBox.Show(this, "Chương trình đã dừng lại", "Thông báo");
                });
            }
        }

        private async Task Check(CancellationToken token)
        {
            try
            {
                MyProxy? myProxy = null;
                Account? account = null;
                while (true)
                {
                    if (token.IsCancellationRequested) return;
                    try
                    {
                        if (_proxyType != ProxyType.None)
                        {
                            if (_proxies.Count == 0) return;
                            lock (_proxies)
                            {
                                if (_proxyIndex == _proxies.Count) _proxyIndex = 0;
                                myProxy = _proxies[_proxyIndex];
                                _proxyIndex++;
                            }
                        }
                        lock (_accounts)
                        {
                            if (_accounts.Count == 0) return;
                            account = _accounts.Dequeue();
                        }
                        if (account == null) return;

                        using var client = OracleService.CreateClient(myProxy, _proxyType);
                        var result = await OracleService.CheckTenant(client, account.Tenant, token);
                        if (result == null)
                        {
                            DataHandler.WriteError(account);
                            Invoke(() =>
                            {
                                _itemCount.Failed++;
                                _itemCount.Scanned++;
                            });
                            continue;
                        }
                        if (result.Contains("homeRegionConsoleUrl"))
                        {
                            DataHandler.WriteSuccess(account);
                            Invoke(() =>
                            {
                                _itemCount.Success++;
                                _itemCount.Scanned++;
                            });
                            continue;
                        }
                        else
                        {
                            DataHandler.WriteFailed(account);
                            Invoke(() =>
                            {
                                _itemCount.Failed++;
                                _itemCount.Scanned++;
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        DataHandler.WriteLog($"[Check] Got exception when checking account {account?.Email} {account?.Password}. Error: {ex}");
                        if (account != null)
                        {
                            DataHandler.WriteError(account);
                            Invoke(() =>
                            {
                                _itemCount.Failed++;
                                _itemCount.Scanned++;
                            });
                        }
                    }
                    finally
                    {
                        if (!token.IsCancellationRequested) await Task.Delay(TimeSpan.FromSeconds(_delay), token);
                    }
                }
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog($"[Check] Got exception when checking accounts. Error: {ex}");
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            ActiveControl = kryptonLabel1;
            _cancelSource.Cancel();
        }

        private void DisableButton(bool running)
        {
            Invoke(() =>
            {
                StartBtn.Enabled = !running;
                DelayUpDown.Enabled = !running;
                ThreadsUpDown.Enabled = !running;
                NoProxyRadioButton.Enabled = !running;
                HTTPProxyRadioButton.Enabled = !running;
                Socks5RadioButton.Enabled = !running;
                LoadDataBtn.Enabled = !running;
                LoadProxyBtn.Enabled = !running;
                SkipUpDown.Enabled = !running;

                StopBtn.Enabled = running;
            });
        }

        private void DelayUpDown_ValueChanged(object sender, EventArgs e)
        {
            _delay = (int)DelayUpDown.Value;
        }

        private void ThreadsUpDown_ValueChanged(object sender, EventArgs e)
        {
            _totalThreads = (int)ThreadsUpDown.Value;
        }

        private void ProxyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NoProxyRadioButton.Checked) _proxyType = ProxyType.None;
            else if (HTTPProxyRadioButton.Checked) _proxyType = ProxyType.Http;
            else if (Socks5RadioButton.Checked) _proxyType = ProxyType.Socks5;
        }

        private void ActiveTopMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = ActiveTopMostCheckBox.Checked;
        }
    }
}