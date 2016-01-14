﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormKiwiCrawler
{
    public partial class frmAdd : Form
    {
        public KiwiCrawler.Model.Urlconfigs_k urlFrmMode_k { get; set; }//这个属性好像没用到，记不得了20151208
        public frmAdd()
        {
            InitializeComponent();
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            KiwiCrawler.Model.Urlconfigs_k urlFrmMode = new KiwiCrawler.Model.Urlconfigs_k();

            urlFrmMode.kAddressBusinessType = txtBusinessType.Text.Trim();
            urlFrmMode.kCaptureType = cbCaptureType.Text.Trim();
            urlFrmMode.kComplateDegree = 0;
            urlFrmMode.kDetailPattern = txtDetailPattern.Text.Trim();
            urlFrmMode.kDetailPatternType = cbDetailPatternType.Text.Trim();
            urlFrmMode.kKeyWords = txtKeyWords.Text.Trim();
            urlFrmMode.kNextPagePattern = txtNextPagePattern.Text.Trim();
            urlFrmMode.kNextPagePatternType = cbNextPagePatternType.Text.Trim();
            urlFrmMode.kPageTotal = String.IsNullOrEmpty(txtPageNum.Text.Trim()) ? -1 : Int32.Parse(txtPageNum.Text.Trim());
            urlFrmMode.kUrl = txtUrl.Text.Trim();
            string msg = "";
            //保存到数据库
            KiwiCrawler.BLL.Urlconfigs_kBll bll = new KiwiCrawler.BLL.Urlconfigs_kBll();

            if (bll.Add(urlFrmMode))
            {
                msg += "添加种子链接成功。\r\n";
                //添加到抽取配置表
                KiwiCrawler.BLL.Extractionconfig_kBll extractionconfigBll = new KiwiCrawler.BLL.Extractionconfig_kBll();
                KiwiCrawler.Model.Extractionconfig_k extractionconfigModel = new KiwiCrawler.Model.Extractionconfig_k();
                //extractionconfigModel.KId = bll.GetMaxId()-1;//查询出来的比实际加了1
                extractionconfigModel.kId = bll.GetModelList("kUrl='" + urlFrmMode.kUrl + "'").FirstOrDefault().kId;
                extractionconfigModel.kUrl = urlFrmMode.kUrl;
                extractionconfigModel.kKeywords = urlFrmMode.kKeyWords;
                extractionconfigModel.kPercent = 0;
                if (extractionconfigBll.Add(extractionconfigModel))
                {
                    msg += "同步抽取信息成功。\r\n";
                }
                else
                {
                    msg += "同步抽取信息失败。";
                }
            }
            else
            {
                msg += "添加种子链接失败。\r\n";
            }

            MessageBox.Show(msg);
            urlFrmMode_k = urlFrmMode;
            this.Close();
        }
    }
}
