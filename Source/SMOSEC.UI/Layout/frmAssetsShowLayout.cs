using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ������Զ���ؼ��������䣬true���ӣ�false������
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssetsShowLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsShowLayout_Load(object sender, EventArgs e)
        {
            if (Form.ToString() == "SMOSEC.UI.AssetsManager.frmRepairDetail")
                lblNumber.DisplayFormat = "��ά������: {0}";
            else if (Form.ToString() == "SMOSEC.UI.AssetsManager.frmScrapDetail")
                lblNumber.DisplayFormat = "��������: {0}";
            else if ((Form.ToString() == "SMOSEC.UI.AssetsManager.frmTransferDetail"))
                lblNumber.DisplayFormat = "��ȷ������: {0}";
        }
    }
}