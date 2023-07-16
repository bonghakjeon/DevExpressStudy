using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FluentDesignOffice
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // object sender - 해당 이벤트 "frmMain_Load" 보내는 객체 의미 (헤당 이벤트 메서드가 누가 이벤트를 부르고 있는지 확인 가능)
        // EventArgs e - 이벤트 핸들러가 사용하는 파라미터 (이벤트 발생과 관련된 정보 포함)
        // 참고할 URL 주소 - https://itstalker.tistory.com/11
        private void frmMain_Load(object sender, EventArgs e)
        {
            // 컨테이너(fluentDesignFormContainer1)에 DevExpress사용자 정의 컨트롤(UserControl - ucCustomer) 추가(Add)
            // 컨테이너(fluentDesignFormContainer1)에 Controls 속성을 사용하여 새로운 컨트롤을 추가, 삭제 가능하며,
            // 몇 개의 컨트롤들을 가지고 있는지 알 수 있다.
            // 참고할 자료 URL 주소 - https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=congfa&logNo=130047425767
            fluentDesignFormContainer1.Controls.Add(new ucCustomer() { Dock=DockStyle.Fill });  // 컨트롤(UserControl - ucCustomer)이 컨테이너(fluentDesignFormContainer1)에 Docking할 때, 컨테이너의 정 가운데로 Dokcing 설정(Dock=DockStyle.Fill)  
        }
    }
}
