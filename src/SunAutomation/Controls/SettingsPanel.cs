using Newtonsoft.Json;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace SunAutomation.Controls
{
    public partial class SettingsPanel : UserControl
    {
        public SettingsPanel()
        {
            InitializeComponent();

            Load += MonitorPanel_Load;
        }

        private void MonitorPanel_Load(object sender, EventArgs e)
        {
            try
            {
                _btnSave.Click += _btnSave_Click;

                using (var dbContext = new ApplicationDbContext())
                {
                    _txtInterval.Text = GlobalVariable.SettingConfig.CheckConnectInterval.ToString();
                    _txtEmailReceipt.Text = GlobalVariable.SettingConfig.RecipientEmail;
                    _txtEmailTo.Text = GlobalVariable.SettingConfig.SenderEmail;
                    _txtPassEmailTo.Text = GlobalVariable.SettingConfig.SenderPassword;
                    _txtEmailSubject.Text = GlobalVariable.SettingConfig.EmailSubject;
                    _txtAttachmentPath.Text = GlobalVariable.SettingConfig.AttachmentPath;
                }
            }
            catch { }
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    GlobalVariable.SettingConfig.CheckConnectInterval = int.TryParse(_txtInterval.Text, out int value) ? value : 5;
                    GlobalVariable.SettingConfig.RecipientEmail = _txtEmailReceipt.Text;
                    GlobalVariable.SettingConfig.SenderEmail = _txtEmailTo.Text;
                    GlobalVariable.SettingConfig.SenderPassword = _txtPassEmailTo.Text;
                    GlobalVariable.SettingConfig.EmailSubject = _txtEmailSubject.Text;
                    GlobalVariable.SettingConfig.AttachmentPath = _txtAttachmentPath.Text;

                    GlobalVariable.MyConfig.ConfingModel = JsonConvert.SerializeObject(GlobalVariable.SettingConfig);

                    dbContext.ConfigSettings.AddOrUpdate(GlobalVariable.MyConfig);
                    dbContext.SaveChanges();

                    MessageBox.Show("Lưu thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lưu thông tin cài đặt lỗi: {ex.Message}.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
