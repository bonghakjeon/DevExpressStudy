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

namespace RadialMenuApp
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Point p = this.Location;                   // this.Location - frmMain 폼화면 왼쪽 위 모퉁이 좌표(x, y) 값을 가져옴.
            // p.Offset 메서드 [실행 전] 좌표(556, 254) -> p.Offset 메서드 [실행 후] 좌표 (556 + 808(this.Width)/2, 254 + 532(this.Height)/2) 
            // offset 메서드 기능 - Point를 기존 좌표값(x, y)에서 지정된 크기(메서드 x, y 파라미터)만큼 변환
            p.Offset(this.Width / 2, this.Height / 2); // this.Width == frmMain 폼 화면 Width 값 / this.height == frmMain 폼 화면 Height 값 
            radialMenu1.ShowPopup(p); // p.Offset 메서드 실행 이후 좌표 값(556 + 808(this.Width)/2, 254 + 532(this.Height)/2)에 RadialMenu 화면 출력 
        }

        /// <summary>
        /// FILE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barLargeButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("FILE Test!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);   // 메시지 "FILE Test!" 출력
        }

        /// <summary>
        /// Folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barLargeButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Folder Test!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); // 메시지 "Folder Test!" 출력
        }

        /// <summary>
        /// Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barLargeButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Item Test!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);   // 메시지 "Item Test!" 출력
        }

        /// <summary>
        /// Card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barLargeButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Card Test!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);   // 메시지 "Card Test!" 출력
        }

        /// <summary>
        /// Album
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barLargeButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Album Test!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);  // 메시지 "Album Test!" 출력 
        }

        /// <summary>
        /// Movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barLargeButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Movie Test!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);  // 메시지 "Movie Test!" 출력
        }
    }
}