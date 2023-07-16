using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageComboBoxEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // object sender - 해당 이벤트 "imageComboBoxEdit_SelectedIndexChanged" 보내는 객체 의미 (헤당 이벤트 메서드가 누가 이벤트를 부르고 있는지 확인 가능)
        // EventArgs e - 이벤트 핸들러가 사용하는 파라미터 (이벤트 발생과 관련된 정보 포함)
        // 참고할 URL 주소 - https://itstalker.tistory.com/11
        private void imageComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DevExpress.XtraEditors.XtraMessageBox.Show() - DevExpress 전용 메시지 박스 출력 메서드

            // imageComboBoxEdit에서 "male" 선택시 메시지 "male" 출력 / "female" 선택시 메시지 "female" 출력 
            //DevExpress.XtraEditors.XtraMessageBox.Show(imageComboBoxEdit.SelectedItem.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // imageComboBoxEdit에서 "male" 선택시 메시지 value "1" 출력 / "female" 선택시 메시지 value "0" 출력 
            DevExpress.XtraEditors.XtraMessageBox.Show(imageComboBoxEdit.EditValue.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
