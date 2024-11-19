using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayoutControlDemo
{
    // TODO : DevExpress Tutorial - Layout Control | FoxLearn 유튜브 영상 보면서 구현 (2024.01.09 jbh)
    // 참고 URL - https://youtu.be/iQ-vh1TMSCA?si=sBw8gBioIsEMlrGD
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}/{1}.xml", Application.StartupPath, this.Name);
            if (File.Exists(fileName))
                layoutControl1.RestoreLayoutFromXml(fileName);
        }

        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            try
            {
                layoutControl1.SaveLayoutToXml(string.Format("{0}/{1}.xml", Application.StartupPath, this.Name));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}