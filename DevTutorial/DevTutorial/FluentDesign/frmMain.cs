using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using FluentDesign.UI.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentDesign
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        async Task LoadModuleAsync(ModuleInfo module)
        {
            // StartNew()는 쓰레드 생성과 동시에 실행
            await Task.Factory.StartNew(() =>
            {
                // 컨테이너(fluentDesignFormContainer)에 Controls 속성 사용
                // -> 파라미터로 받은 module의 Name 프로퍼티와 동일한 module이 Controls 안에 존재하지 않는 경우 
                if (!fluentDesignFormContainer.Controls.ContainsKey(module.Name))
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;   // TutorialControlBase 클래스 객체 control 새로 생성
                    // 해당 TutorialControlBase 클래스 객체 control이 null 이 아닐 경우 
                    if (control != null)
                    {
                        control.Dock = DockStyle.Fill; // 해당 컨트롤 객체 control을 부모 컨테이너(fluentDesignFormContainer)에 도킹(모든 컨트롤의 가장자리는 포함 된 컨트롤의 모든 가장자리에 도킹)
                        control.CreateWaitDialog();
                        // fluentDesignFormContainer.Invoke 실행 - 컨트롤의 내부 창 핸들이 있는 스레드에서 지정된 대리자(delegate) 실행
                        // Invoke - 컨트롤(컨테이너)의 본인 스레드가 아닌 다른 스레드(또는 대리자 MethodInvoker)를 이용하여 해당 컨트롤 객체를 동기식으로 실행하는 방법
                        // 참고할 자료 URL 주소 - https://jeongkyun-it.tistory.com/90
                        fluentDesignFormContainer.Invoke(new MethodInvoker(delegate ()
                        {
                            fluentDesignFormContainer.Controls.Add(control);   //  컨테이너(fluentDesignFormContainer)에 Controls 속성을 사용 컨트롤(control) 추가
                            control.BringToFront();   // 컨트롤(control)을 맨 앞으로 가져온다.
                        }));
                    }
                }
                // 파라미터로 받은 module의 Name 프로퍼티와 동일한 module이 Controls 안에 존재하는 경우 
                else
                {
                    // 컨테이너(fluentDesignFormContainer)에 Controls 속성 사용 -> 파라미터로 받은 module의 Name 프로퍼티와 동일한 module 찾기(find)
                    // 동일한 module 찾아서 var control(배열)에 할당 
                    var control = fluentDesignFormContainer.Controls.Find(module.Name, true);
                    if (control.Length == 1)    // 해당 control(배열)의 길이가 1일 경우 
                        fluentDesignFormContainer.Invoke(new MethodInvoker(delegate () { control[0].BringToFront(); }));
                }
            });
        }

        // object sender - 해당 이벤트 "frmMain_Load" 보내는 객체 의미 (헤당 이벤트 메서드가 누가 이벤트를 부르고 있는지 확인 가능)
        // EventArgs e - 이벤트 핸들러가 사용하는 파라미터 (이벤트 발생과 관련된 정보 포함)
        // 참고할 URL 주소 - https://itstalker.tistory.com/11
        private void frmMain_Load(object sender, EventArgs e)
        {
            // 컨테이너(fluentDesignFormContainer)에 DevExpress사용자 정의 컨트롤(UserControl - ucNewInvoice) 추가(Add)
            // 컨테이너(fluentDesignFormContainer)에 Controls 속성을 사용하여 새로운 컨트롤을 추가, 삭제 가능하며,
            // 몇 개의 컨트롤들을 가지고 있는지 알 수 있다.
            // 참고할 자료 URL 주소 - https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=congfa&logNo=130047425767
            this.fluentDesignFormContainer.Controls.Add(new ucNewInvoice() { Dock = DockStyle.Fill });
            this.itemNav.Caption = $"{accordionControlElementNewInvoice.Text}";   // 화면 상단 컨트롤 itemNav Caption 텍스트 "New Invoice" 출력
        }

        private async void accordionControlElementNewInvoice_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementNewInvoice.Text}";   // 화면 상단 컨트롤 itemNav Caption 텍스트 "New Invoice" 출력
            // 모듈이란? - 모듈은 하나 이상의 클래스와 인터페이스로 구성된 type.dll 또는 application.exe 같은 이식 가능한 실행 파일 의미.
            // 단일 모듈에 여러 네임스페이스가 포함될 수 있고 네임스페이스는 여러 모듈에 걸쳐 있을 수 있음.
            // 참고할 자료 URL 주소 - https://learn.microsoft.com/ko-kr/dotnet/api/system.reflection.module?view=net-7.0
            if (ModulesInfo.GetItem("ucNewInvoice") == null)   // ModulesInfo - 여러 개의 동일한 타입의 모듈을 담아 놓은 컬렉션(Collection)과 비슷한 역할의 클래스 
                ModulesInfo.Add(new ModuleInfo("ucNewInvoice", "FluentDesign.UI.Modules.ucNewInvoice"));  // ModulesInfo에 모듈("ucNewInvoice")이 존재하지 않을 경우(null) ModulesInfo에 모듈("ucNewInvoice") 추가

            await LoadModuleAsync(ModulesInfo.GetItem("ucNewInvoice"));   // 비동기 메서드 "LoadModuleAsync" 호출
        }

        private async void accordionControlElementCustomer_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementCategories.Text}/{accordionControlElementCustomer.Text}";
            if (ModulesInfo.GetItem("ucCustomer") == null)
                ModulesInfo.Add(new ModuleInfo("ucCustomer", "FluentDesign.UI.Modules.ucCustomer"));

            await LoadModuleAsync(ModulesInfo.GetItem("ucCustomer"));    // 비동기 메서드 "LoadModuleAsync" 호출
        }


        private async void accordionControlElementCategory_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementCategories.Text}/{accordionControlElementCategory.Text}";
            if (ModulesInfo.GetItem("ucCategory") == null)
                ModulesInfo.Add(new ModuleInfo("ucCategory", "FluentDesign.UI.Modules.ucCategory"));

            await LoadModuleAsync(ModulesInfo.GetItem("ucCategory"));    // 비동기 메서드 "LoadModuleAsync" 호출
        }

        private async void accordionControlElementProduct_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementCategories.Text}/{accordionControlElementProduct.Text}";
            if (ModulesInfo.GetItem("ucProduct") == null)
                ModulesInfo.Add(new ModuleInfo("ucProduct", "FluentDesign.UI.Modules.ucProduct"));

            await LoadModuleAsync(ModulesInfo.GetItem("ucProduct"));    // 비동기 메서드 "LoadModuleAsync" 호출
        }
    }
}
