using System.ComponentModel;

namespace 宝塔管理工具
{
    partial class SavaPropertiesForm
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
            this.serverName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(38, 50);
            this.serverName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(196, 23);
            this.serverName.TabIndex = 0;
            this.serverName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(86, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器名称";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(89, 99);
            this.save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 35);
            this.save.TabIndex = 2;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // SavaPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 143);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SavaPropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "保存配置";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverName;
    }
}