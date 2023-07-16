using DevExpress.Skins;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skin
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
            SkinHelper.InitSkinPopupMenu(SkinsLink);    // 테마 메뉴가 있는 양식에서 SkinHelper 클래스 사용해서 BarLinkContainerItem 클래스 객체 SkinsLink(Appearance 탭 -> (Skins))에 로드
            // DevExpress 컨트롤의 스킨 관리하는 클래스 "SkinManager"에 속하는 기본 스킨 관리자 객체 "Default"에서 
            // 현재 DevExpress에서 사용하고 있는 Skin을 Collection(Hashtable로 구현되어 있음.)으로 가져옴.
            // 이 Collection에 속하는 SkinContainer 객체를 하나씩 방문
            foreach (SkinContainer cn in SkinManager.Default.Skins)
            {
                // ComboBoxEdit 클래스 객체 cboSkins에 속하는 프로퍼티(RepositoryItemComboBox 클래스 객체 Properties)에 속하는
                // ComboBoxItemCollection 클래스 객체 Items에 요소(SkinContainer 클래스 객체 cn의 프로퍼티 "SkinName") 추가
                cboSkins.Properties.Items.Add(cn.SkinName); 
            }
        }

        // object sender - 해당 이벤트 "cboSkins_SelectedIndexChanged" 보내는 객체 의미 (헤당 이벤트 메서드가 누가 이벤트를 부르고 있는지 확인 가능)
        // EventArgs e - 이벤트 핸들러가 사용하는 파라미터 (이벤트 발생과 관련된 정보 포함)
        // 참고할 URL 주소 - https://itstalker.tistory.com/11
        private void cboSkins_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SetSkinStyle - 사용자가 지정한 특정한 스킨(cboSkins.Text) UI 화면에 적용
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(cboSkins.Text);
        }
    }
}