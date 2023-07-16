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

namespace FluentDesign.UI.Modules
{
    public partial class ucCategory : DevExpress.DXperience.Demos.TutorialControlBase // DevExpress.XtraEditors.XtraUserControl
    {
        public ucCategory()
        {
            InitializeComponent();
        }

        private void ucCategory_Load(object sender, EventArgs e)
        {
            NorthWindEntities db = new NorthWindEntities();     // 데이터모델 NorthWindEntities 클래스 객체 db 생성 
            // DbSet 클래스 객체(db.Categories) - 동일 타입의 데이터(Categories)을 여러 개 보관할 수 있는 컬렉션(Collection)을 의미 한다.
            // Collection 참고할 자료 URL 주소 - https://dhshin94.tistory.com/116
            gridControl1.DataSource = db.Categories.ToList();   // 그리드 뷰 컨트롤(gridControl1) 속성 DataSource에 데이터 바인딩(DBSet Categories를 리스트 객체로 변환(db.Categories.ToList();)후 데이터 바인딩 진행)
        }
    }
}
