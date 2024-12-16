using EasyScada.Core;
using EasyScada.Winforms.Controls;
using EnvDTE80;
using Newtonsoft.Json;
using SunAutomation.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunAutomation
{
    public partial class MainForm : Form
    {
        EasyDriverConnector _easyDriverConnector;
        SettingsPanel _setingsPanel = new SettingsPanel();
        MonitorPanel _monitorPanel = new MonitorPanel();

        Control _activePanel;

        DateTime _startTime, _endTime;
        int _countConnect = 0;

        bool _trigger = false;
        DataLog _dataLog = new DataLog();

        public MainForm()
        {
            InitializeComponent();
            Text = "Khoi Hung Tech";

            _easyDriverConnector = new EasyDriverConnector();
            _easyDriverConnector.ConnectionStatusChaged += _easyDriverConnector_ConnectionStatusChaged;
            _easyDriverConnector.BeginInit();
            _easyDriverConnector.EndInit();
            _lbStatus.Text = _easyDriverConnector.ConnectionStatus.ToString();

            Load += MainForm_Load;

            _btnMain.Click += _btnMain_Click;
            _btnReport.Click += _btnMonitor_Click;
            _btnSetup.Click += _btnSetup_Click;

            if (GlobalVariable.SettingConfig.IsServer == true)
            {
                _easyDriverConnector.Started += _easyDriverConnector_Started;
                if (_easyDriverConnector.IsStarted)
                {
                    _easyDriverConnector_Started(null, null);
                }
            }

            _startTime = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                RefreshDateTime();

                if (GlobalVariable.SettingConfig.IsServer)
                {
                    var totalTime = (DateTime.Now - _startTime).TotalSeconds;
                    if (totalTime > GlobalVariable.SettingConfig.CheckConnectInterval)
                    {
                        _countConnect = _countConnect <= 1000 ? _countConnect += 1 : 1;
                        _easyDriverConnector.GetTag("Local Station/Channel1/Device1/CHECK_CONNECT").WriteAsync(_countConnect.ToString(), WritePiority.High);
                        _startTime = DateTime.Now;
                    }
                }
            }
            catch { }
            finally
            {
                if (!this.FindForm().IsDisposed)
                {
                    timer1.Start();
                }
            }
        }

        private void RefreshDateTime()
        {
            var now = DateTime.Now;
            _lbCurrentDate.Text = $"{now:yyyy-MM-dd}";
            _lbCurrentTime.Text = $"{now:HH}  :  {now:mm}  :  {now:ss}";
        }

        private void _easyDriverConnector_Started(object sender, EventArgs e)
        {
            _easyDriverConnector.GetTag($"Local Station/Channel1/Device1/WEIGHT").ValueChanged += WEIGHT_ValueChanged;
            _easyDriverConnector.GetTag($"Local Station/Channel1/Device1/COUNT").ValueChanged += COUNT_ValueChanged;
            _easyDriverConnector.GetTag($"Local Station/Channel1/Device1/TOTAL_WEIGHT").ValueChanged += TOTAL_WEIGHT_ValueChanged;
            _easyDriverConnector.GetTag($"Local Station/Channel1/Device1/TRIGGER").ValueChanged += TRIGGER_ValueChanged;
            _easyDriverConnector.GetTag($"Local Station/Channel1/Device1/CODE").ValueChanged += CODE_ValueChanged;

            CODE_ValueChanged(_easyDriverConnector.GetTag($"Local Station/Channel1/Device1/CODE")
                    , new TagValueChangedEventArgs(_easyDriverConnector.GetTag($"Local Station/Channel1/Device1/CODE")
                    , "", _easyDriverConnector.GetTag($"Local Station/Channel1/Device1/CODE").Value));
            WEIGHT_ValueChanged(_easyDriverConnector.GetTag($"Local Station/Channel1/Device1/WEIGHT")
                   , new TagValueChangedEventArgs(_easyDriverConnector.GetTag($"Local Station/Channel1/Device1/WEIGHT")
                   , "", _easyDriverConnector.GetTag($"Local Station/Channel1/Device1/WEIGHT").Value));
            COUNT_ValueChanged(_easyDriverConnector.GetTag($"Local Station/Channel1/Device1/COUNT")
                    , new TagValueChangedEventArgs(_easyDriverConnector.GetTag($"Local Station/Channel1/Device1/COUNT")
                    , "", _easyDriverConnector.GetTag($"Local Station/Channel1/Device1/COUNT").Value));
            TOTAL_WEIGHT_ValueChanged(_easyDriverConnector.GetTag($"Local Station/Channel1/Device1/TOTAL_WEIGHT")
                   , new TagValueChangedEventArgs(_easyDriverConnector.GetTag($"Local Station/Channel1/Device1/TOTAL_WEIGHT")
                   , "", _easyDriverConnector.GetTag($"Local Station/Channel1/Device1/TOTAL_WEIGHT").Value));
        }

        private void TOTAL_WEIGHT_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            try
            {
                _dataLog.TotalWeight = double.TryParse(e.NewValue, out double value) ? Math.Round(value / 100, 2) : 0;

                if (_labTotalWeight.InvokeRequired)
                {
                    _labTotalWeight.Invoke(new Action(() =>
                    {
                        _labTotalWeight.Text = _dataLog.TotalWeight.ToString();
                    }));
                }
                else _labTotalWeight.Text = _dataLog.TotalWeight.ToString();
            }
            catch { }
        }

        private void COUNT_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            try
            {
                _dataLog.Count = int.TryParse(e.NewValue, out int value) ? value : 0;

                if (_labCount.InvokeRequired)
                {
                    _labCount.Invoke(new Action(() =>
                    {
                        _labCount.Text = _dataLog.Count.ToString();
                    }));
                }
                else _labCount.Text = _dataLog.Count.ToString();
            }
            catch { }
        }

        private void WEIGHT_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            try
            {
                _dataLog.Weight = double.TryParse(e.NewValue, out double value) ? Math.Round(value / 100, 2) : 0;

                if (_labWeight.InvokeRequired)
                {
                    _labWeight.Invoke(new Action(() =>
                    {
                        _labWeight.Text = _dataLog.Weight.ToString();
                    }));
                }
                else _labWeight.Text = _dataLog.Weight.ToString();
            }
            catch { }
        }

        private void TRIGGER_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            try
            {
                //nếu app được mở ở máy client thì không thực hiện log data.
                if (!GlobalVariable.SettingConfig.IsServer) return;

                _trigger = e.NewValue == "1" ? true : false;

                if (_trigger)
                {
                    using (var dbContext = new ApplicationDbContext())
                    {
                        _dataLog.Id = Guid.NewGuid();
                        _dataLog.CreatedDate = DateTime.Now;

                        dbContext.DataLogs.Add(_dataLog);
                        dbContext.SaveChanges();
                    }
                    _easyDriverConnector.GetTag("Local Station/Channel1/Device1/SAVE_DONE").WriteAsync("1", WritePiority.High);
                }
            }
            catch { }
        }

        private void CODE_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            try
            {
                _dataLog.Code = e.NewValue;

                if (_labCode.InvokeRequired)
                {
                    _labCode.Invoke(new Action(() =>
                    {
                        _labCode.Text = _dataLog.Code.ToString();
                    }));
                }
                else _labCode.Text = _dataLog.Code.ToString();
            }
            catch { }
        }

        private void _easyDriverConnector_ConnectionStatusChaged(object sender, ConnectionStatusChangedEventArgs e)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    _lbStatus.Text = e.NewStatus.ToString();
                    _lbStatus.ForeColor = GetConnectionStatusColor(e.NewStatus);
                    _lbStatus.Text = _easyDriverConnector.ConnectionStatus.ToString();
                }));
            }
            else
            {
                _lbStatus.Text = e.NewStatus.ToString();
                _lbStatus.ForeColor = GetConnectionStatusColor(e.NewStatus);
                _lbStatus.Text = _easyDriverConnector.ConnectionStatus.ToString();

            }
        }

        private Color GetConnectionStatusColor(ConnectionStatus status)
        {
            switch (status)
            {
                case ConnectionStatus.Connected:
                    return Color.Lime;
                case ConnectionStatus.Connecting:
                case ConnectionStatus.Reconnecting:
                    return Color.Orange;
                case ConnectionStatus.Disconnected:
                    return Color.Red;
                default:
                    return Color.White;
            }
        }

        private void _btnMonitor_Click(object sender, EventArgs e)
        {
            _monitorPanel = new MonitorPanel();
            ShowPanel(_monitorPanel);
        }

        private void _btnMain_Click(object sender, EventArgs e)
        {
            if (_activePanel != null)
            {
                _activePanel.Visible = false;
                _activePanel.SendToBack();
            }
        }

        private void _btnSetup_Click(object sender, EventArgs e)
        {
            _setingsPanel = new SettingsPanel();
            ShowPanel(_setingsPanel);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var data = dbContext.ConfigSettings.ToList();

                if (data != null && data.Count > 0)
                {
                    GlobalVariable.MyConfig = data.FirstOrDefault();

                    GlobalVariable.SettingConfig = JsonConvert.DeserializeObject<SettingsModel>(GlobalVariable.MyConfig.ConfingModel);
                }
                else
                {
                    GlobalVariable.MyConfig.Id = Guid.NewGuid();
                }

                GlobalVariable.EmailCenter.SenderEmail = GlobalVariable.SettingConfig.SenderEmail;
                GlobalVariable.EmailCenter.SenderPassword = GlobalVariable.SettingConfig.SenderPassword;
                GlobalVariable.EmailCenter.RecipientEmail = GlobalVariable.SettingConfig.RecipientEmail;
                //GlobalVariable.EmailCenter.Port = 587;
                GlobalVariable.EmailCenter.Subject = GlobalVariable.SettingConfig.EmailSubject;
            }

            if (GlobalVariable.SettingConfig.IsServer)
            {
                var serverAddress = _easyDriverConnector.ServerAddress;
            }
            else
            {
                _monitorPanel = new MonitorPanel();
                ShowPanel(_monitorPanel);

                _btnMain.Visible=false;
            }

            RefreshDateTime();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private bool ContainsControl(Control control)
        {
            foreach (Control item in _panelMain.Controls)
            {
                if (item == control)
                    return true;
            }
            return false;
        }

        private void ShowPanel(Control panel)
        {
            if (_activePanel != null)
            {
                _activePanel.Visible = false;
                _activePanel.SendToBack();
            }

            if (!ContainsControl(panel))
            {
                _panelMain.Controls.Add(panel);
            }

            panel.Dock = DockStyle.Fill; ;
            panel.Visible = true;
            _activePanel = panel;
            panel.BringToFront();
        }
    }
}
