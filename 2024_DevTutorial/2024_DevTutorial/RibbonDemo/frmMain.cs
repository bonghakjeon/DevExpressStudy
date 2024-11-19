using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RibbonDemo
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();

            // TODO : 리본 버튼 단축키 구현 (2024.01.17 jbh)
            // 참고 URL - https://s-engineer.tistory.com/290
            KeyPreview = true;
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmModule1 frm = new frmModule1();
            frm.MdiParent  = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmModule2 frm = new frmModule2();
            frm.MdiParent  = this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmModule3 frm = new frmModule3();
            frm.MdiParent  = this;
            frm.Show();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) 
            { 
                
            }
        }
    }
}