using System;

namespace simpleapp
{
    partial class Form2
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
            this.btnread = new System.Windows.Forms.Button();
            this.btnwrite = new System.Windows.Forms.Button();
            this.txtLen = new System.Windows.Forms.TextBox();
            this.txtReaderType = new System.Windows.Forms.TextBox();
            this.labelReaderTypr = new System.Windows.Forms.Label();
            this.txtHardwareVersion = new System.Windows.Forms.TextBox();
            this.txtFirmwareVersion = new System.Windows.Forms.TextBox();
            this.labelHardwareVer = new System.Windows.Forms.Label();
            this.labelFirmwareVer = new System.Windows.Forms.Label();
            this.txtEpc = new System.Windows.Forms.TextBox();
            this.txtRssi = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtTagInfo = new System.Windows.Forms.TextBox();
            this.epc = new System.Windows.Forms.Label();
            this.len = new System.Windows.Forms.Label();
            this.rssi = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnread
            // 
            this.btnread.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnread.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnread.Location = new System.Drawing.Point(39, 250);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(150, 59);
            this.btnread.TabIndex = 0;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = false;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnwrite
            // 
            this.btnwrite.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnwrite.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwrite.Location = new System.Drawing.Point(309, 250);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(150, 59);
            this.btnwrite.TabIndex = 1;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = false;
            this.btnwrite.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtLen
            // 
            this.txtLen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLen.Location = new System.Drawing.Point(64, 28);
            this.txtLen.Multiline = true;
            this.txtLen.Name = "txtLen";
            this.txtLen.Size = new System.Drawing.Size(46, 18);
            this.txtLen.TabIndex = 2;
            // 
            // txtReaderType
            // 
            this.txtReaderType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtReaderType.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtReaderType.Location = new System.Drawing.Point(309, 44);
            this.txtReaderType.Multiline = true;
            this.txtReaderType.Name = "txtReaderType";
            this.txtReaderType.Size = new System.Drawing.Size(178, 25);
            this.txtReaderType.TabIndex = 3;
            // 
            // labelReaderTypr
            // 
            this.labelReaderTypr.AutoSize = true;
            this.labelReaderTypr.Location = new System.Drawing.Point(306, 28);
            this.labelReaderTypr.Name = "labelReaderTypr";
            this.labelReaderTypr.Size = new System.Drawing.Size(69, 13);
            this.labelReaderTypr.TabIndex = 4;
            this.labelReaderTypr.Text = "Reader Type";
            this.labelReaderTypr.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHardwareVersion
            // 
            this.txtHardwareVersion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtHardwareVersion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtHardwareVersion.Location = new System.Drawing.Point(309, 96);
            this.txtHardwareVersion.Multiline = true;
            this.txtHardwareVersion.Name = "txtHardwareVersion";
            this.txtHardwareVersion.Size = new System.Drawing.Size(178, 25);
            this.txtHardwareVersion.TabIndex = 5;
            // 
            // txtFirmwareVersion
            // 
            this.txtFirmwareVersion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFirmwareVersion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFirmwareVersion.Location = new System.Drawing.Point(309, 152);
            this.txtFirmwareVersion.Multiline = true;
            this.txtFirmwareVersion.Name = "txtFirmwareVersion";
            this.txtFirmwareVersion.Size = new System.Drawing.Size(178, 25);
            this.txtFirmwareVersion.TabIndex = 6;
            // 
            // labelHardwareVer
            // 
            this.labelHardwareVer.AutoSize = true;
            this.labelHardwareVer.Location = new System.Drawing.Point(306, 80);
            this.labelHardwareVer.Name = "labelHardwareVer";
            this.labelHardwareVer.Size = new System.Drawing.Size(91, 13);
            this.labelHardwareVer.TabIndex = 7;
            this.labelHardwareVer.Text = "Hardware Version";
            // 
            // labelFirmwareVer
            // 
            this.labelFirmwareVer.AutoSize = true;
            this.labelFirmwareVer.Location = new System.Drawing.Point(306, 136);
            this.labelFirmwareVer.Name = "labelFirmwareVer";
            this.labelFirmwareVer.Size = new System.Drawing.Size(87, 13);
            this.labelFirmwareVer.TabIndex = 8;
            this.labelFirmwareVer.Text = "Firmware Version";
            // 
            // txtEpc
            // 
            this.txtEpc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEpc.Location = new System.Drawing.Point(12, 28);
            this.txtEpc.Multiline = true;
            this.txtEpc.Name = "txtEpc";
            this.txtEpc.Size = new System.Drawing.Size(46, 18);
            this.txtEpc.TabIndex = 12;
            // 
            // txtRssi
            // 
            this.txtRssi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRssi.Location = new System.Drawing.Point(116, 28);
            this.txtRssi.Multiline = true;
            this.txtRssi.Name = "txtRssi";
            this.txtRssi.Size = new System.Drawing.Size(46, 18);
            this.txtRssi.TabIndex = 13;
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCount.Location = new System.Drawing.Point(168, 28);
            this.txtCount.Multiline = true;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(46, 18);
            this.txtCount.TabIndex = 14;
            // 
            // txtTagInfo
            // 
            this.txtTagInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTagInfo.Location = new System.Drawing.Point(12, 80);
            this.txtTagInfo.Multiline = true;
            this.txtTagInfo.Name = "txtTagInfo";
            this.txtTagInfo.Size = new System.Drawing.Size(202, 78);
            this.txtTagInfo.TabIndex = 15;
            // 
            // epc
            // 
            this.epc.AutoSize = true;
            this.epc.Location = new System.Drawing.Point(21, 12);
            this.epc.Name = "epc";
            this.epc.Size = new System.Drawing.Size(28, 13);
            this.epc.TabIndex = 16;
            this.epc.Text = "EPC";
            // 
            // len
            // 
            this.len.AutoSize = true;
            this.len.Location = new System.Drawing.Point(73, 12);
            this.len.Name = "len";
            this.len.Size = new System.Drawing.Size(25, 13);
            this.len.TabIndex = 17;
            this.len.Text = "Len";
            // 
            // rssi
            // 
            this.rssi.AutoSize = true;
            this.rssi.Location = new System.Drawing.Point(124, 12);
            this.rssi.Name = "rssi";
            this.rssi.Size = new System.Drawing.Size(32, 13);
            this.rssi.TabIndex = 18;
            this.rssi.Text = "RSSI";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(169, 12);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(45, 13);
            this.count.TabIndex = 19;
            this.count.Text = "COUNT";
            //this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 350);
            this.Controls.Add(this.count);
            this.Controls.Add(this.rssi);
            this.Controls.Add(this.len);
            this.Controls.Add(this.epc);
            this.Controls.Add(this.txtTagInfo);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtRssi);
            this.Controls.Add(this.txtEpc);
            this.Controls.Add(this.labelFirmwareVer);
            this.Controls.Add(this.labelHardwareVer);
            this.Controls.Add(this.txtFirmwareVersion);
            this.Controls.Add(this.txtHardwareVersion);
            this.Controls.Add(this.labelReaderTypr);
            this.Controls.Add(this.txtReaderType);
            this.Controls.Add(this.txtLen);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.btnread);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /*
       internal void Show()
       {
           throw new NotImplementedException();
       }
*/
        #endregion

        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.TextBox txtLen;
        private System.Windows.Forms.TextBox txtReaderType;
        private System.Windows.Forms.Label labelReaderTypr;
        private System.Windows.Forms.TextBox txtHardwareVersion;
        private System.Windows.Forms.TextBox txtFirmwareVersion;
        private System.Windows.Forms.Label labelHardwareVer;
        private System.Windows.Forms.Label labelFirmwareVer;
        private System.Windows.Forms.TextBox txtEpc;
        private System.Windows.Forms.TextBox txtRssi;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtTagInfo;
        private System.Windows.Forms.Label epc;
        private System.Windows.Forms.Label len;
        private System.Windows.Forms.Label rssi;
        private System.Windows.Forms.Label count;
    }
}
