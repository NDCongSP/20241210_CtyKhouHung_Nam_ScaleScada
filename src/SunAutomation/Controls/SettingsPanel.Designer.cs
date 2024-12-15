namespace SunAutomation.Controls
{
    partial class SettingsPanel
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
            this._btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._txtInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtEmailReceipt = new System.Windows.Forms.TextBox();
            this._txtEmailTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtPassEmailTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtEmailSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtAttachmentPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnSave
            // 
            this._btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._btnSave.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSave.Location = new System.Drawing.Point(755, 405);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(258, 69);
            this._btnSave.TabIndex = 36;
            this._btnSave.Text = "LƯU";
            this._btnSave.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 35);
            this.label2.TabIndex = 35;
            this.label2.Text = "THỜI GIAN GHI TAG CHECK_CONNECT (s)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtInterval
            // 
            this._txtInterval.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtInterval.Location = new System.Drawing.Point(46, 59);
            this._txtInterval.Name = "_txtInterval";
            this._txtInterval.Size = new System.Drawing.Size(397, 34);
            this._txtInterval.TabIndex = 37;
            this._txtInterval.Text = "0";
            this._txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 35);
            this.label1.TabIndex = 38;
            this.label1.Text = "EMAIl NHẬN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtEmailReceipt
            // 
            this._txtEmailReceipt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtEmailReceipt.Location = new System.Drawing.Point(46, 151);
            this._txtEmailReceipt.Name = "_txtEmailReceipt";
            this._txtEmailReceipt.Size = new System.Drawing.Size(967, 34);
            this._txtEmailReceipt.TabIndex = 39;
            // 
            // _txtEmailTo
            // 
            this._txtEmailTo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtEmailTo.Location = new System.Drawing.Point(491, 59);
            this._txtEmailTo.Name = "_txtEmailTo";
            this._txtEmailTo.Size = new System.Drawing.Size(334, 34);
            this._txtEmailTo.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 35);
            this.label3.TabIndex = 40;
            this.label3.Text = "EMAIl GỬI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtPassEmailTo
            // 
            this._txtPassEmailTo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPassEmailTo.Location = new System.Drawing.Point(850, 59);
            this._txtPassEmailTo.Name = "_txtPassEmailTo";
            this._txtPassEmailTo.PasswordChar = '*';
            this._txtPassEmailTo.Size = new System.Drawing.Size(163, 34);
            this._txtPassEmailTo.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(845, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 35);
            this.label4.TabIndex = 42;
            this.label4.Text = "PASS EMAIl GỬI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtEmailSubject
            // 
            this._txtEmailSubject.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtEmailSubject.Location = new System.Drawing.Point(46, 246);
            this._txtEmailSubject.Name = "_txtEmailSubject";
            this._txtEmailSubject.Size = new System.Drawing.Size(967, 34);
            this._txtEmailSubject.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 35);
            this.label5.TabIndex = 44;
            this.label5.Text = "TIÊU ĐỀ EMAIL GỬI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtAttachmentPath
            // 
            this._txtAttachmentPath.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtAttachmentPath.Location = new System.Drawing.Point(46, 344);
            this._txtAttachmentPath.Name = "_txtAttachmentPath";
            this._txtAttachmentPath.Size = new System.Drawing.Size(967, 34);
            this._txtAttachmentPath.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(609, 35);
            this.label6.TabIndex = 46;
            this.label6.Text = "ĐƯỜNG DẪN ĐẾN FILE EXCEL BÁO CÁO ĐÍNH KÈM GỬI EMAIL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Controls.Add(this._txtAttachmentPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._txtEmailSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtPassEmailTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtEmailTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtEmailReceipt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtInterval);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(1048, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtEmailReceipt;
        private System.Windows.Forms.TextBox _txtEmailTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtPassEmailTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtEmailSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtAttachmentPath;
        private System.Windows.Forms.Label label6;
    }
}
