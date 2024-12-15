using ClosedXML.Excel;
using EasyScada.Core;
using EasyScada.Winforms.Controls;
using EnvDTE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunAutomation.Controls
{
    public partial class MonitorPanel : UserControl
    {
        DateTime _fromDate, _toDate;
        Email _email;
        string _fileName = string.Empty;
        string _code = string.Empty;

        public MonitorPanel()
        {
            InitializeComponent();

            Load += MonitorPanel_Load;
        }

        private void MonitorPanel_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                _btnQuery.Click += _btnQuery_Click;
                _btnSendMail.Click += _btnSendMail_Click;

                _dtFrom.ValueChanged += (s, o) => { _fromDate = _dtFrom.Value; };
                _dtTo.ValueChanged += (s, o) => { _toDate = _dtTo.Value; };
                _cbCode.SelectedValueChanged += (s, o) => { _code = _cbCode.Text; };

                _dtFrom.Value = DateTime.Now;
                _dtTo.Value = DateTime.Now;

                using (var dbContext = new ApplicationDbContext())
                {
                    var d = dbContext.DataLogs.ToList();

                    if (d != null && d.Count > 0)
                    {
                        _cbCode.Items.Add("All");
                        foreach (var item in d)
                        {
                            _cbCode.Items.Add(item.Code);
                        }
                        _cbCode.SelectedItem = "All";
                    }
                }
            }
            catch { }
        }

        private void _btnSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVariable.EmailCenter.Body = $"Dữ liệu cân từ ngày {_fromDate} đến ngày {_toDate}.  Mã hàng: {_code}";

                var result = GlobalVariable.EmailCenter.SendEmail();
                var mess = result == true ? "thành công" : "không thành công";
                //Debug.WriteLine($"Send email result: {result}");
                MessageBox.Show($"Gửi email {mess}", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void _btnQuery_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        void RefreshData()
        {
            try
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    var fromDate = _fromDate.ToString("yyyy-MM-dd 00:00:00");
                    var todateDate = _fromDate.ToString("yyyy-MM-dd 23:59:59");

                    _fromDate = Convert.ToDateTime(fromDate);
                    _toDate = Convert.ToDateTime(todateDate);

                    List<DataLog> data = new List<DataLog>();
                    if (_code != "All")
                    {
                        data = dbContext.DataLogs.Where(x => x.Code == _code && x.CreatedDate >= _fromDate && x.CreatedDate <= _toDate)
                            .OrderByDescending(_ => _.CreatedDate).ToList();
                    }
                    else data = dbContext.DataLogs.Where(x => x.CreatedDate >= _fromDate && x.CreatedDate <= _toDate)
                            .OrderByDescending(_ => _.CreatedDate).ToList();

                    //var data = dbContext.DataLogs.Where(x => x.Code == _code && x.CreatedDate >= _fromDate && x.CreatedDate <= _toDate)
                    //        .OrderByDescending(_ => _.CreatedDate).ToList();

                    if (data != null && data.Count > 0)
                    {
                        if (_grData.InvokeRequired)
                        {
                            this.Invoke(new Action(() =>
                            {
                                _grData.DataSource = data;
                            }));
                        }
                        else _grData.DataSource = data;

                        CreateExcel(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đọc dữ liệu báo cáo lỗi: {ex.Message}.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CreateExcel(List<DataLog> model)
        {
            try
            {
                // Tạo workbook Excel
                using (var workbook = new XLWorkbook())
                {
                    // Tạo một sheet
                    var worksheet = workbook.Worksheets.Add("Data");

                    worksheet.Range(1, 1, 1, 5).Merge().Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                   .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
                   .Font.SetFontSize(15).Font.SetBold(true);
                    worksheet.Range(2, 1, 2, 5).Merge().Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                  .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
                   .Font.SetFontSize(12).Font.SetBold(true);
                    worksheet.Range(3, 1, 3, 5).Merge().Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                 .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
                  .Font.SetFontSize(12).Font.SetBold(true); ;

                    worksheet.Cell(1, 1).Value = "BÁO CÁO";
                    worksheet.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.Orange;
                    worksheet.Cell(2, 1).Value = $"Thời gian: {_fromDate} - {_toDate}";
                    worksheet.Cell(3, 1).Value = $"Mã hàng: {_code}";

                    // Thêm tiêu đề cột
                    worksheet.Cell(5, 1).Value = "Ngày giờ cân";
                    worksheet.Cell(5, 2).Value = "Mã Hàng";
                    worksheet.Cell(5, 3).Value = "Bộ đếm";
                    worksheet.Cell(5, 4).Value = "Khối lượng (kg)";
                    worksheet.Cell(5, 5).Value = "Tổng khối lượng (kg)";
                    //tieu de columns
                    worksheet.Range(5, 1, 5, 5).SetAutoFilter(true);
                    worksheet.Range(5, 1, 5, 5).Style.Fill.BackgroundColor = XLColor.LightCyan;
                    // Định dạng bảng (nếu cần)
                    worksheet.Range($"A5:E{model.Count + 5}").Style.Border.SetInsideBorder(XLBorderStyleValues.Thin)
                                          .Border.SetOutsideBorder(XLBorderStyleValues.Thin);


                    // Thêm dữ liệu từ model
                    for (int i = 0; i < model.Count; i++)
                    {
                        var data = model[i];
                        worksheet.Cell(i + 6, 1).Value = data.CreatedDate;
                        worksheet.Cell(i + 6, 2).Value = data.Code;
                        worksheet.Cell(i + 6, 3).Value = data.Count;
                        worksheet.Cell(i + 6, 4).Value = data.Weight;
                        worksheet.Cell(i + 6, 5).Value = data.TotalWeight;
                    }

                    //worksheet.Column(1).Width = 40;  // Set cột 1 có độ rộng 15
                    worksheet.Columns().AdjustToContents();//Adjust Row Height and Column Width to Contents

                    //column name
                    worksheet.Range($"A5:E5").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                   .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
                    .Font.SetFontSize(12).Font.SetBold(true); ;

                    //Data row.
                    worksheet.Range($"A6:A{model.Count + 5}").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left)
                 .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
                 .DateFormat.Format = "yyyy-MM-dd HH:mm:ss";

                    worksheet.Range($"B6:B{model.Count + 5}").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left)
                 .Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                    worksheet.Range($"C6:E{model.Count + 5}").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right)
                .Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                    // Lưu file Excel
                    _fileName = $"{DateTime.Now.ToString("yyyyMMdd_HHmmss")}_Data.xlsx";
                    string filePath = Path.Combine(GlobalVariable.SettingConfig.AttachmentPath, _fileName);

                    //set cho attachmentEmail
                    GlobalVariable.EmailCenter.AttachmentPath = filePath;

                    workbook.SaveAs(filePath);

                    // Mở file Excel sau khi lưu
                    OpenExcelFile(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xuất excel lỗi: {ex.Message}.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Hàm mở file Excel
        private static void OpenExcelFile(string filePath)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = filePath; // Đường dẫn file Excel
                process.StartInfo.UseShellExecute = true; // Sử dụng ứng dụng mặc định để mở
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mở file lỗi: {ex.Message}.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}