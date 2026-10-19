using System;

namespace VIZCore3DX.NET.ExportOptions
{
    public partial class FrmMain
    {
        // 모델 열기
        private void btnOpen_Click(object sender, EventArgs e)
        {
            vizcore3dx.Model.OpenFileDialog();
        }
    }
}
