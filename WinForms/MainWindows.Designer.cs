﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace 宝塔管理工具
{
    partial class MainWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MainWindows));
            this.loginBT = new System.Windows.Forms.Button();
            this.BT_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_token = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SitePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.root = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.types = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectNub = new System.Windows.Forms.TextBox();
            this.selectSite = new System.Windows.Forms.Button();
            this.DeleteSelected = new System.Windows.Forms.Button();
            this.DeleteSelected2 = new System.Windows.Forms.Button();
            this.BatchAddSite = new System.Windows.Forms.Button();
            this.loginProperties = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.savaProperties = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBT
            // 
            this.loginBT.Location = new System.Drawing.Point(919, 7);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(104, 34);
            this.loginBT.TabIndex = 0;
            this.loginBT.Text = "登录";
            this.loginBT.UseVisualStyleBackColor = true;
            this.loginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // BT_address
            // 
            this.BT_address.Location = new System.Drawing.Point(85, 11);
            this.BT_address.Name = "BT_address";
            this.BT_address.Size = new System.Drawing.Size(217, 23);
            this.BT_address.TabIndex = 1;
            this.BT_address.Text = "http://bt.ahyu.xyz";
            this.BT_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "宝塔地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "宝塔密钥：";
            // 
            // BT_token
            // 
            this.BT_token.Location = new System.Drawing.Point(399, 11);
            this.BT_token.Name = "BT_token";
            this.BT_token.Size = new System.Drawing.Size(217, 23);
            this.BT_token.TabIndex = 3;
            this.BT_token.Text = "i841pPgJnTkuNGlxdMnFrFCd97FByVjj";
            this.BT_token.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1031, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(65, 17);
            this.statusLabel.Text = "等待操作...";
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.serialNumber, this.SiteName, this.domain, this.SiteStatus, this.backCount, this.SitePath,
                this.root, this.ID, this.delete
            });
            this.dataView.GridColor = System.Drawing.SystemColors.Control;
            this.dataView.Location = new System.Drawing.Point(8, 246);
            this.dataView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Height = 23;
            this.dataView.Size = new System.Drawing.Size(1015, 404);
            this.dataView.TabIndex = 7;
            this.dataView.CellContentClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // serialNumber
            // 
            this.serialNumber.HeaderText = "序号";
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.ReadOnly = true;
            this.serialNumber.Width = 35;
            // 
            // SiteName
            // 
            this.SiteName.HeaderText = "网站名";
            this.SiteName.Name = "SiteName";
            this.SiteName.ReadOnly = true;
            this.SiteName.Width = 110;
            // 
            // domain
            // 
            this.domain.HeaderText = "域名数量";
            this.domain.Name = "domain";
            this.domain.ReadOnly = true;
            this.domain.Width = 80;
            // 
            // SiteStatus
            // 
            this.SiteStatus.HeaderText = "网站状态";
            this.SiteStatus.Name = "SiteStatus";
            this.SiteStatus.ReadOnly = true;
            this.SiteStatus.Width = 80;
            // 
            // backCount
            // 
            this.backCount.HeaderText = "备份数";
            this.backCount.Name = "backCount";
            this.backCount.ReadOnly = true;
            this.backCount.Width = 70;
            // 
            // SitePath
            // 
            this.SitePath.HeaderText = "网站路径";
            this.SitePath.Name = "SitePath";
            this.SitePath.ReadOnly = true;
            this.SitePath.Width = 250;
            // 
            // root
            // 
            this.root.HeaderText = "是否删除根目录";
            this.root.Name = "root";
            // 
            // ID
            // 
            this.ID.HeaderText = "网站ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // delete
            // 
            this.delete.HeaderText = "删除";
            this.delete.Name = "delete";
            this.delete.Text = "删除";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 102;
            // 
            // types
            // 
            this.types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.types.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.types.FormattingEnabled = true;
            this.types.ItemHeight = 17;
            this.types.Location = new System.Drawing.Point(85, 69);
            this.types.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.types.Name = "types";
            this.types.Size = new System.Drawing.Size(217, 25);
            this.types.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "网站分类：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "查询数量：";
            // 
            // selectNub
            // 
            this.selectNub.Location = new System.Drawing.Point(706, 69);
            this.selectNub.Name = "selectNub";
            this.selectNub.Size = new System.Drawing.Size(206, 23);
            this.selectNub.TabIndex = 11;
            this.selectNub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectNub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.selectNub_KeyPress_1);
            // 
            // selectSite
            // 
            this.selectSite.Enabled = false;
            this.selectSite.Location = new System.Drawing.Point(919, 69);
            this.selectSite.Name = "selectSite";
            this.selectSite.Size = new System.Drawing.Size(104, 34);
            this.selectSite.TabIndex = 13;
            this.selectSite.Text = "查询";
            this.selectSite.UseVisualStyleBackColor = true;
            this.selectSite.Click += new System.EventHandler(this.Select_Click);
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.Enabled = false;
            this.DeleteSelected.Location = new System.Drawing.Point(626, 191);
            this.DeleteSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteSelected.Name = "DeleteSelected";
            this.DeleteSelected.Size = new System.Drawing.Size(220, 47);
            this.DeleteSelected.TabIndex = 14;
            this.DeleteSelected.Text = "删除选中网站并删除其根目录";
            this.DeleteSelected.UseVisualStyleBackColor = true;
            this.DeleteSelected.Click += new System.EventHandler(this.DeleteSelect_Click);
            // 
            // DeleteSelected2
            // 
            this.DeleteSelected2.Enabled = false;
            this.DeleteSelected2.Location = new System.Drawing.Point(483, 191);
            this.DeleteSelected2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteSelected2.Name = "DeleteSelected2";
            this.DeleteSelected2.Size = new System.Drawing.Size(134, 47);
            this.DeleteSelected2.TabIndex = 15;
            this.DeleteSelected2.Text = "删除选中";
            this.DeleteSelected2.UseVisualStyleBackColor = true;
            this.DeleteSelected2.Click += new System.EventHandler(this.deleteSelected2_Click);
            // 
            // BatchAddSite
            // 
            this.BatchAddSite.Enabled = false;
            this.BatchAddSite.Location = new System.Drawing.Point(8, 191);
            this.BatchAddSite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BatchAddSite.Name = "BatchAddSite";
            this.BatchAddSite.Size = new System.Drawing.Size(115, 47);
            this.BatchAddSite.TabIndex = 16;
            this.BatchAddSite.Text = "批量添加网站";
            this.BatchAddSite.UseVisualStyleBackColor = true;
            this.BatchAddSite.Click += new System.EventHandler(this.BatchAddSite_Click);
            // 
            // loginProperties
            // 
            this.loginProperties.BackColor = System.Drawing.Color.White;
            this.loginProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loginProperties.FormattingEnabled = true;
            this.loginProperties.Location = new System.Drawing.Point(706, 11);
            this.loginProperties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginProperties.Name = "loginProperties";
            this.loginProperties.Size = new System.Drawing.Size(206, 25);
            this.loginProperties.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(624, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "登录配置：";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(317, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "搜索网站：";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(399, 69);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(217, 23);
            this.searchTxt.TabIndex = 20;
            // 
            // savaProperties
            // 
            this.savaProperties.Enabled = false;
            this.savaProperties.Location = new System.Drawing.Point(919, 191);
            this.savaProperties.Name = "savaProperties";
            this.savaProperties.Size = new System.Drawing.Size(104, 47);
            this.savaProperties.TabIndex = 21;
            this.savaProperties.Text = "保存该配置";
            this.savaProperties.UseVisualStyleBackColor = true;
            this.savaProperties.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 686);
            this.Controls.Add(this.savaProperties);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginProperties);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BatchAddSite);
            this.Controls.Add(this.DeleteSelected2);
            this.Controls.Add(this.DeleteSelected);
            this.Controls.Add(this.selectSite);
            this.Controls.Add(this.selectNub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.types);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_token);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_address);
            this.Controls.Add(this.loginBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宝塔管理工具";
            this.Load += new System.EventHandler(this.MainWindows_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SelectNub_KeyPress1(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BT_address;
        private System.Windows.Forms.TextBox BT_token;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.ComboBox types;
        private System.Windows.Forms.Button loginBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox selectNub;
        private System.Windows.Forms.Button selectSite;
        private System.Windows.Forms.Button DeleteSelected2;
        private System.Windows.Forms.Button DeleteSelected;
        private System.Windows.Forms.Button BatchAddSite;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn root;
        private System.Windows.Forms.DataGridViewTextBoxColumn SitePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn backCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn domain;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button savaProperties;
        private System.Windows.Forms.ComboBox loginProperties;
        private System.Windows.Forms.TextBox searchTxt;
    }
}