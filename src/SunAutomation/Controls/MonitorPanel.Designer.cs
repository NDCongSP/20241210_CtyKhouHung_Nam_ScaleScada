namespace SunAutomation.Controls
{
    partial class MonitorPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._grData = new System.Windows.Forms.DataGridView();
            this._dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._dtTo = new System.Windows.Forms.DateTimePicker();
            this._btnSendMail = new System.Windows.Forms.Button();
            this._btnQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._grData)).BeginInit();
            this.SuspendLayout();
            // 
            // _grData
            // 
            this._grData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grData.Location = new System.Drawing.Point(36, 105);
            this._grData.Name = "_grData";
            this._grData.Size = new System.Drawing.Size(776, 465);
            this._grData.TabIndex = 28;
            // 
            // _dtFrom
            // 
            this._dtFrom.CustomFormat = "yyyy-MM-dd";
            this._dtFrom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtFrom.Location = new System.Drawing.Point(161, 12);
            this._dtFrom.Name = "_dtFrom";
            this._dtFrom.Size = new System.Drawing.Size(248, 34);
            this._dtFrom.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 35);
            this.label1.TabIndex = 30;
            this.label1.Text = "TỪ NGÀY:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 35);
            this.label2.TabIndex = 32;
            this.label2.Text = "ĐẾN NGÀY:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dtTo
            // 
            this._dtTo.CustomFormat = "yyyy-MM-dd";
            this._dtTo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtTo.Location = new System.Drawing.Point(564, 12);
            this._dtTo.Name = "_dtTo";
            this._dtTo.Size = new System.Drawing.Size(248, 34);
            this._dtTo.TabIndex = 31;
            // 
            // _btnSendMail
            // 
            this._btnSendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._btnSendMail.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSendMail.Location = new System.Drawing.Point(651, 64);
            this._btnSendMail.Name = "_btnSendMail";
            this._btnSendMail.Size = new System.Drawing.Size(161, 35);
            this._btnSendMail.TabIndex = 34;
            this._btnSendMail.Text = "GỬI EMAIL";
            this._btnSendMail.UseVisualStyleBackColor = false;
            // 
            // _btnQuery
            // 
            this._btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._btnQuery.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnQuery.Location = new System.Drawing.Point(472, 64);
            this._btnQuery.Name = "_btnQuery";
            this._btnQuery.Size = new System.Drawing.Size(161, 35);
            this._btnQuery.TabIndex = 35;
            this._btnQuery.Text = "TRUY VẤN";
            this._btnQuery.UseVisualStyleBackColor = false;
            // 
            // MonitorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Controls.Add(this._btnQuery);
            this.Controls.Add(this._btnSendMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._dtTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._dtFrom);
            this.Controls.Add(this._grData);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MonitorPanel";
            this.Size = new System.Drawing.Size(857, 600);
            ((System.ComponentModel.ISupportInitialize)(this._grData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView _grData;
        private System.Windows.Forms.DateTimePicker _dtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker _dtTo;
        private System.Windows.Forms.Button _btnSendMail;
        private System.Windows.Forms.Button _btnQuery;
    }
}
