﻿using System;
 using System.Threading;
 using System.Windows.Forms;

namespace 宝塔管理工具
{
    public partial class SavaPropertiesForm : Form
    {
        private string _btAddress;
        private string _btToken;
        private ComboBox _comboBox;
        private string _search;
        private string _selectNum;

        public SavaPropertiesForm(string btAddress, string btToken, ComboBox comboBox, string search, string selectNum)
        {
            _btAddress = btAddress;
            _btToken = btToken;
            _comboBox = comboBox;
            _search = search;
            _selectNum = selectNum;
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(serverName.Text))
            {
                MessageBox.Show(@"服务器名不能为空！");
                return;
            }
            var thread = new Thread(new JsonProperties(_btAddress,_btToken,_comboBox,_search,_selectNum,serverName.Text).SaveProperties);
            thread.Start();
            this.Close();
        }
    }
}