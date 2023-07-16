
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentDesignOffice
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowsFormsSettings.ForceDirectXPaint();   // 프로세스 "FluentDesignOffice.exe" 시작될 때, DirectX 랜더링 사용(DirectX로 컨트롤 칠하기)
            // (DPI - Dots per inch) - 해상도 의미
            // 참고할 자료 URL 주소 - https://learn.microsoft.com/ko-kr/windows/win32/hidpi/high-dpi-desktop-application-development-on-windows?redirectedfrom=MSDN
            WindowsFormsSettings.SetDPIAware();         // 실행하는 현재 프로세스 "FluentDesignOffice.exe" 에 대한 시스템 DPI 인식 모드 활성화(단일 디스플레이 배율에서만 선명하게 렌더링되어 DPI가 변경 될 때마다 흐릿해짐.)
            WindowsFormsSettings.EnableFormSkins();     // DevExpress 폼(frmMain.cs) 타이틀바 스킨 기능 활성화 하기 
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("The Bezier");   // SetSkinStyle - 사용자가 지정한 특정한 스킨("The Bezier") UI 화면에 적용
            SetSkinPalette();
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", GetDefaultSize());
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch;
            WindowsFormsSettings.CustomizationFormSnapMode = DevExpress.Utils.Controls.SnapMode.OwnerControl;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        static float GetDefaultSize()
        {
            return 8.25F;
        }

        static void SetSkinPalette()
        {
            var skin = CommonSkins.GetSkin(WindowsFormsSettings.DefaultLookAndFeel);   // 사용자가 지정하여 활성화 된 특정한 스킨("The Bezier") Object 가져와서 var skin에 할당 
            DevExpress.Utils.Svg.SvgPalette palette = skin.CustomSvgPalettes["Office Colorful"];   // 스킨에 칠할 팔레트(Color) 색상 Dictionary 객체에서 Key "Office Colorful"에 맞는 값(Value) 가져와서 palette에 할당하기 
            skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(palette);               // 스킨에 칠할 팔레트(Color) 색상 설정
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();                                    // 스킨을 변경/설정할 때 메서드 "ForceDefaultLookAndFeelChanged" 호출 
        }
    }
}
