namespace SunAutomation
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this._panelBottom = new System.Windows.Forms.Panel();
            this._lbStatus = new System.Windows.Forms.Label();
            this._btnSetup = new EasyScada.Winforms.Controls.ThemedButton();
            this._btnReport = new EasyScada.Winforms.Controls.ThemedButton();
            this._btnMain = new EasyScada.Winforms.Controls.ThemedButton();
            this._panelBorderTop = new System.Windows.Forms.Panel();
            this._lineHighlight = new System.Windows.Forms.Panel();
            this._panelBorderBottom = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._panelMain = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this._lbCurrentTime = new System.Windows.Forms.Label();
            this._panelHeader = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this._lbCurrentDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this._labWeight = new System.Windows.Forms.Label();
            this._labCount = new System.Windows.Forms.Label();
            this._labTotalWeight = new System.Windows.Forms.Label();
            this._labCode = new System.Windows.Forms.Label();
            this._panelBottom.SuspendLayout();
            this._panelBorderTop.SuspendLayout();
            this._panelBorderBottom.SuspendLayout();
            this.panel15.SuspendLayout();
            this._panelMain.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this._panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelBottom
            // 
            this._panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(160)))));
            this._panelBottom.Controls.Add(this._lbStatus);
            this._panelBottom.Controls.Add(this._btnSetup);
            this._panelBottom.Controls.Add(this._btnReport);
            this._panelBottom.Controls.Add(this._btnMain);
            this._panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBottom.Location = new System.Drawing.Point(0, 663);
            this._panelBottom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._panelBottom.Name = "_panelBottom";
            this._panelBottom.Size = new System.Drawing.Size(1123, 115);
            this._panelBottom.TabIndex = 2;
            // 
            // _lbStatus
            // 
            this._lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lbStatus.BackColor = System.Drawing.Color.White;
            this._lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._lbStatus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbStatus.Location = new System.Drawing.Point(887, 25);
            this._lbStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._lbStatus.Name = "_lbStatus";
            this._lbStatus.Size = new System.Drawing.Size(219, 64);
            this._lbStatus.TabIndex = 4;
            this._lbStatus.Text = "??";
            this._lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnSetup
            // 
            this._btnSetup.Location = new System.Drawing.Point(481, 12);
            this._btnSetup.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._btnSetup.Name = "_btnSetup";
            this._btnSetup.PaletteMode = EasyScada.Winforms.Controls.PaletteMode.Office2007Blue;
            this._btnSetup.Size = new System.Drawing.Size(222, 90);
            this._btnSetup.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSetup.TabIndex = 11;
            this._btnSetup.Values.Image = global::SunAutomation.Properties.Resources.icons8_setup_36;
            this._btnSetup.Values.Text = "CÀI ĐẶT";
            // 
            // _btnReport
            // 
            this._btnReport.Location = new System.Drawing.Point(250, 12);
            this._btnReport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._btnReport.Name = "_btnReport";
            this._btnReport.PaletteMode = EasyScada.Winforms.Controls.PaletteMode.Office2007Blue;
            this._btnReport.Size = new System.Drawing.Size(222, 90);
            this._btnReport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnReport.TabIndex = 9;
            this._btnReport.Values.Image = global::SunAutomation.Properties.Resources.icons8_presentation_36;
            this._btnReport.Values.Text = "BÁO CÁO";
            // 
            // _btnMain
            // 
            this._btnMain.Location = new System.Drawing.Point(19, 12);
            this._btnMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._btnMain.Name = "_btnMain";
            this._btnMain.PaletteMode = EasyScada.Winforms.Controls.PaletteMode.Office2007Blue;
            this._btnMain.Size = new System.Drawing.Size(222, 90);
            this._btnMain.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMain.TabIndex = 7;
            this._btnMain.Values.Image = global::SunAutomation.Properties.Resources.icons8_home_36;
            this._btnMain.Values.Text = "Main";
            // 
            // _panelBorderTop
            // 
            this._panelBorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this._panelBorderTop.Controls.Add(this._lineHighlight);
            this._panelBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelBorderTop.Location = new System.Drawing.Point(0, 0);
            this._panelBorderTop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._panelBorderTop.Name = "_panelBorderTop";
            this._panelBorderTop.Size = new System.Drawing.Size(1123, 12);
            this._panelBorderTop.TabIndex = 0;
            // 
            // _lineHighlight
            // 
            this._lineHighlight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lineHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this._lineHighlight.Location = new System.Drawing.Point(0, 4);
            this._lineHighlight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._lineHighlight.Name = "_lineHighlight";
            this._lineHighlight.Size = new System.Drawing.Size(1339, 1);
            this._lineHighlight.TabIndex = 2;
            // 
            // _panelBorderBottom
            // 
            this._panelBorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this._panelBorderBottom.Controls.Add(this.panel11);
            this._panelBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBorderBottom.Location = new System.Drawing.Point(0, 563);
            this._panelBorderBottom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._panelBorderBottom.Name = "_panelBorderBottom";
            this._panelBorderBottom.Size = new System.Drawing.Size(1123, 12);
            this._panelBorderBottom.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.panel11.Location = new System.Drawing.Point(0, 4);
            this.panel11.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1339, 1);
            this.panel11.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this._labWeight);
            this.panel15.Controls.Add(this.label3);
            this.panel15.Controls.Add(this.label9);
            this.panel15.Location = new System.Drawing.Point(155, 44);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(775, 113);
            this.panel15.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "KHỐI LƯỢNG";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(710, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 45);
            this.label9.TabIndex = 4;
            this.label9.Text = "KG";
            // 
            // _panelMain
            // 
            this._panelMain.BackColor = System.Drawing.Color.White;
            this._panelMain.Controls.Add(this.panel6);
            this._panelMain.Controls.Add(this.panel5);
            this._panelMain.Controls.Add(this.panel4);
            this._panelMain.Controls.Add(this.panel15);
            this._panelMain.Controls.Add(this._panelBorderBottom);
            this._panelMain.Controls.Add(this._panelBorderTop);
            this._panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelMain.Location = new System.Drawing.Point(0, 88);
            this._panelMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._panelMain.Name = "_panelMain";
            this._panelMain.Size = new System.Drawing.Size(1123, 575);
            this._panelMain.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this._labCode);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(155, 401);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(775, 113);
            this.panel6.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 47);
            this.label7.TabIndex = 8;
            this.label7.Text = "HÓA";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 47);
            this.label11.TabIndex = 7;
            this.label11.Text = "MÃ HÀNG";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(710, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 45);
            this.label8.TabIndex = 4;
            this.label8.Text = "SP";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this._labTotalWeight);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(155, 282);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(775, 113);
            this.panel5.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 47);
            this.label10.TabIndex = 6;
            this.label10.Text = "LƯỢNG";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 47);
            this.label5.TabIndex = 2;
            this.label5.Text = "TỔNG KHỐI";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(710, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 45);
            this.label6.TabIndex = 4;
            this.label6.Text = "KG";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this._labCount);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(155, 163);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(775, 113);
            this.panel4.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "BỘ ĐẾM";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(710, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 45);
            this.label4.TabIndex = 4;
            this.label4.Text = "SP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 88);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this._lbCurrentTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(907, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 88);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 88);
            this.panel3.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 88);
            this.panel7.TabIndex = 3;
            // 
            // _lbCurrentTime
            // 
            this._lbCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lbCurrentTime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbCurrentTime.ForeColor = System.Drawing.Color.White;
            this._lbCurrentTime.Location = new System.Drawing.Point(23, 14);
            this._lbCurrentTime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this._lbCurrentTime.Name = "_lbCurrentTime";
            this._lbCurrentTime.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this._lbCurrentTime.Size = new System.Drawing.Size(176, 49);
            this._lbCurrentTime.TabIndex = 9;
            this._lbCurrentTime.Text = "16   :   21 :  00";
            this._lbCurrentTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _panelHeader
            // 
            this._panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(160)))));
            this._panelHeader.Controls.Add(this.panel8);
            this._panelHeader.Controls.Add(this._lbCurrentDate);
            this._panelHeader.Controls.Add(this.label1);
            this._panelHeader.Controls.Add(this.panel2);
            this._panelHeader.Controls.Add(this.panel1);
            this._panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelHeader.Location = new System.Drawing.Point(0, 0);
            this._panelHeader.Margin = new System.Windows.Forms.Padding(6);
            this._panelHeader.Name = "_panelHeader";
            this._panelHeader.Size = new System.Drawing.Size(1123, 88);
            this._panelHeader.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Location = new System.Drawing.Point(201, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 90);
            this.panel8.TabIndex = 10;
            // 
            // _lbCurrentDate
            // 
            this._lbCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lbCurrentDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbCurrentDate.ForeColor = System.Drawing.Color.White;
            this._lbCurrentDate.Location = new System.Drawing.Point(16, 14);
            this._lbCurrentDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this._lbCurrentDate.Name = "_lbCurrentDate";
            this._lbCurrentDate.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this._lbCurrentDate.Size = new System.Drawing.Size(196, 49);
            this._lbCurrentDate.TabIndex = 8;
            this._lbCurrentDate.Text = "2024-10-09";
            this._lbCurrentDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label1.Size = new System.Drawing.Size(636, 75);
            this.label1.TabIndex = 9;
            this.label1.Text = "HỆ THỐNG CÂN BĂNG TẢI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // _labWeight
            // 
            this._labWeight.BackColor = System.Drawing.Color.Black;
            this._labWeight.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labWeight.ForeColor = System.Drawing.Color.White;
            this._labWeight.Location = new System.Drawing.Point(258, 13);
            this._labWeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._labWeight.Name = "_labWeight";
            this._labWeight.Size = new System.Drawing.Size(442, 86);
            this._labWeight.TabIndex = 5;
            this._labWeight.Text = "0";
            this._labWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labCount
            // 
            this._labCount.BackColor = System.Drawing.Color.Black;
            this._labCount.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labCount.ForeColor = System.Drawing.Color.White;
            this._labCount.Location = new System.Drawing.Point(258, 14);
            this._labCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._labCount.Name = "_labCount";
            this._labCount.Size = new System.Drawing.Size(442, 86);
            this._labCount.TabIndex = 6;
            this._labCount.Text = "0";
            this._labCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labTotalWeight
            // 
            this._labTotalWeight.BackColor = System.Drawing.Color.Black;
            this._labTotalWeight.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labTotalWeight.ForeColor = System.Drawing.Color.White;
            this._labTotalWeight.Location = new System.Drawing.Point(258, 13);
            this._labTotalWeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._labTotalWeight.Name = "_labTotalWeight";
            this._labTotalWeight.Size = new System.Drawing.Size(442, 86);
            this._labTotalWeight.TabIndex = 7;
            this._labTotalWeight.Text = "0";
            this._labTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labCode
            // 
            this._labCode.BackColor = System.Drawing.Color.Black;
            this._labCode.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labCode.ForeColor = System.Drawing.Color.White;
            this._labCode.Location = new System.Drawing.Point(258, 13);
            this._labCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._labCode.Name = "_labCode";
            this._labCode.Size = new System.Drawing.Size(442, 86);
            this._labCode.TabIndex = 8;
            this._labCode.Text = "0";
            this._labCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 778);
            this.Controls.Add(this._panelMain);
            this.Controls.Add(this._panelBottom);
            this.Controls.Add(this._panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sun Automation";
            this._panelBottom.ResumeLayout(false);
            this._panelBorderTop.ResumeLayout(false);
            this._panelBorderBottom.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this._panelMain.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this._panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel _panelBottom;
        private EasyScada.Winforms.Controls.ThemedButton _btnMain;
        private EasyScada.Winforms.Controls.ThemedButton _btnReport;
        private EasyScada.Winforms.Controls.ThemedButton _btnSetup;
        private System.Windows.Forms.Panel _panelBorderTop;
        private System.Windows.Forms.Panel _lineHighlight;
        private System.Windows.Forms.Panel _panelBorderBottom;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel _panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel _panelHeader;
        private System.Windows.Forms.Label _lbCurrentTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label _lbCurrentDate;
        private System.Windows.Forms.Label _lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label _labWeight;
        private System.Windows.Forms.Label _labCode;
        private System.Windows.Forms.Label _labTotalWeight;
        private System.Windows.Forms.Label _labCount;
    }
}

