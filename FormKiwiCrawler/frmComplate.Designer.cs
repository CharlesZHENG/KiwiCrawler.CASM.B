﻿namespace FormKiwiCrawler
{
    partial class frmComplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComplate));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.txtTail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.ckbDetail = new System.Windows.Forms.CheckBox();
            this.cbNextPageType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "每页记录数";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(128, 24);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(111, 21);
            this.txtRow.TabIndex = 1;
            // 
            // txtTail
            // 
            this.txtTail.Location = new System.Drawing.Point(128, 75);
            this.txtTail.Name = "txtTail";
            this.txtTail.Size = new System.Drawing.Size(111, 21);
            this.txtTail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "末页记录数";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(164, 169);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "计算";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // ckbDetail
            // 
            this.ckbDetail.AutoSize = true;
            this.ckbDetail.Location = new System.Drawing.Point(33, 137);
            this.ckbDetail.Name = "ckbDetail";
            this.ckbDetail.Size = new System.Drawing.Size(84, 16);
            this.ckbDetail.TabIndex = 7;
            this.ckbDetail.Text = "没有详细页";
            this.ckbDetail.UseVisualStyleBackColor = true;
            // 
            // cbNextPageType
            // 
            this.cbNextPageType.FormattingEnabled = true;
            this.cbNextPageType.Items.AddRange(new object[] {
            "第一种翻页类型",
            "第二种翻页类型"});
            this.cbNextPageType.Location = new System.Drawing.Point(33, 172);
            this.cbNextPageType.Name = "cbNextPageType";
            this.cbNextPageType.Size = new System.Drawing.Size(114, 20);
            this.cbNextPageType.TabIndex = 8;
            this.cbNextPageType.Text = "第一种翻页类型";
            this.cbNextPageType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNextPageType_KeyPress);
            // 
            // frmComplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 213);
            this.Controls.Add(this.cbNextPageType);
            this.Controls.Add(this.ckbDetail);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtTail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmComplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmComplate";
            this.Load += new System.EventHandler(this.frmComplate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtTail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.CheckBox ckbDetail;
        private System.Windows.Forms.ComboBox cbNextPageType;
    }
}