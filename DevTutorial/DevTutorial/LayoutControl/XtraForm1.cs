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

namespace LayoutControl
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        // object sender - 해당 이벤트 "XtraForm1_Load" 보내는 객체 의미 (헤당 이벤트 메서드가 누가 이벤트를 부르고 있는지 확인 가능)
        // EventArgs e - 이벤트 핸들러가 사용하는 파라미터 (이벤트 발생과 관련된 정보 포함)
        // 참고할 URL 주소 - https://itstalker.tistory.com/11
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            // Application.StartupPath - D:\bhjeon\Dynamo\DevTutorial\DevTutorial\LayoutControl\bin\Debug
            // this.Name - XtraForm1 (DevExpress 폼화면 이름)
            string fileName = string.Format("{0}/{1}.xml", Application.StartupPath, this.Name);
            // 해당 xml 파일(XtraForm1.xml)이 존재할 경우 
            // RestoreLayoutFromXml 메서드는 LayoutControl.SaveLayoutToXml 메서드를 사용하여 XML 형식의 파일(XtraForm1.xml)에 저장된 레이아웃(DevExpress 폼화면- XtraForm1.cs) 복원(로드)
            // Restore a previously saved layout.
            if (File.Exists(fileName)) layoutControl1.RestoreLayoutFromXml(fileName);
        }

        // object sender - 해당 이벤트 "btnSaveLayout_Click" 보내는 객체 의미 (헤당 이벤트 메서드가 누가 이벤트를 부르고 있는지 확인 가능)
        // EventArgs e - 이벤트 핸들러가 사용하는 파라미터 (이벤트 발생과 관련된 정보 포함)
        // 참고할 URL 주소 - https://itstalker.tistory.com/11
        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            try
            {
                // Save the layout to an XML file.
                // Application.StartupPath - D:\bhjeon\Dynamo\DevTutorial\DevTutorial\LayoutControl\bin\Debug
                // this.Name - XtraForm1 (DevExpress 폼화면 이름)
                // 런타임 시 SaveLayoutToXml 메서드를 사용하여 현재 레이아웃(DevExpress 폼화면- XtraForm1.cs)을 XML 형식의 파일에 저장
                // 그런 다음 LayoutControl.RestoreLayoutFromXml 메서드를 사용하여 저장된 설정 및 레이아웃(DevExpress 폼화면- XtraForm1.cs)을 복원(로드)
                layoutControl1.SaveLayoutToXml(string.Format("{0}/{1}.xml", Application.StartupPath, this.Name));
            }
            catch (Exception ex)
            {
                // 에러 메시지 출력
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}