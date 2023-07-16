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

namespace RibbonControl
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // object sender - 해당 이벤트 "barButtonItem3_ItemClick" 보내는 객체 의미 (헤당 이벤트 메서드가 누가 이벤트를 부르고 있는지 확인 가능)
        // ItemClickEventArgs e - 이벤트 핸들러가 사용하는 파라미터 (이벤트 발생과 관련된 정보 포함)
        // 참고할 URL 주소 - https://itstalker.tistory.com/11
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmModule1 frm = new frmModule1(); // frmModule1 클래스 폼객체 "frm" 생성
            frm.MdiParent = this;              // frmModule1 클래스 폼객체 "frm"의 부모폼 객체(frmMain) 설정
            frm.Show();                        // 자식 폼"frm" 화면 출력
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmModule2 frm = new frmModule2(); // frmModule2 클래스 폼객체 "frm" 생성
            frm.MdiParent = this;              // frmModule2 클래스 폼객체 "frm"의 부모폼 객체(frmMain) 설정
            frm.Show();                        // 자식 폼"frm" 화면 출력
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmModule3 frm = new frmModule3(); // frmModule3 클래스 폼객체 "frm" 생성
            frm.MdiParent = this;              // frmModule3 클래스 폼객체 "frm"의 부모폼 객체(frmMain) 설정
            frm.Show();                        // 자식 폼"frm" 화면 출력
        }
    }
}