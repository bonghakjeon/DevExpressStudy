using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreenManagerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // object sender - 해당 이벤트 "simpleButton1_Click" 보내는 객체 의미 (헤당 이벤트 메서드가 누가 이벤트를 부르고 있는지 확인 가능)
        // EventArgs e - 이벤트 핸들러가 사용하는 파라미터 (이벤트 발생과 관련된 정보 포함)
        // 참고할 URL 주소 - https://itstalker.tistory.com/11
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Type 객체(typeof(frmWaitForm)) 를 통해 객체의 타입, 클래스의 타입등을 받아서 구분할 수 있다.
            // 여기서 말하는 "frmWaitForm"은 클래스의 타입을 의미한다.
            // Type(typeof()) 클래스, Reflection Namespace 참고할 자료 URL 주소 - https://blockdmask.tistory.com/599
            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, true, false);  // Splash 양식(대기처리 기능)의 화면(typeof(frmWaitForm)) 지정 및 해당 화면 출력 (Open frmWaitForm)
            SplashScreenManager.Default.SetWaitFormCaption("Processing data...");        // Splash 양식(대기처리 기능)의 화면(typeof(frmWaitForm)) 출력시 Caption 항목에 출력되는 텍스트 값 "Processing data..."


            // Splash 양식(대기처리 기능)의 화면(typeof(frmWaitForm))은 별도의 스레드에서 열린다.
            // SetWaitFormDescription - Splash 양식(대기처리 기능)의 화면(typeof(frmWaitForm)) 출력시 Description 항목에 출력되는 텍스트 "0%" 부터 "99%" 까지 차례로 출력
            for (int i = 0; i < 100; i++)
            {
                SplashScreenManager.Default.SetWaitFormDescription(i.ToString() + "%");
                Thread.Sleep(10); // 0.01초 대기
            }
            SplashScreenManager.CloseForm();  // 기존에 오픈된 Splash 양식(대기처리 기능)의 화면(typeof(frmWaitForm)) 닫기(CloseForm)
        }
    }
}
