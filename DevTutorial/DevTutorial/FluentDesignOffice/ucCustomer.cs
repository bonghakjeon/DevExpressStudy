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

namespace FluentDesignOffice
{
    public partial class ucCustomer : DevExpress.XtraEditors.XtraUserControl
    {
        public ucCustomer()
        {
            InitializeComponent();
        }

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            NorthWindEntities db = new NorthWindEntities();   // 데이터모델 NorthWindEntities 클래스 객체 db 생성 
            // DbSet 클래스 객체(db.Customers) - 동일 타입의 데이터(Customers)을 여러 개 보관할 수 있는 컬렉션(Collection)을 의미 한다.
            // Collection 참고할 자료 URL 주소 - https://dhshin94.tistory.com/116
            customerBindingSource.DataSource = db.Customers.ToList();   // 그리드 뷰 컨트롤(gridControl1) 속성 DataSource에 데이터 바인딩(DBSet Customers 리스트 객체로 변환(db.Customers.ToList();)후 데이터 바인딩 진행)
        }
    }
}
