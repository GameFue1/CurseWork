using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class TranBackTextBox : TextBox
{
    private const int WM_ERASEBKGND = 0x0014;

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x20;  // WS_EX_TRANSPARENT
            return cp;
        }
    }

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == WM_ERASEBKGND)
        {
            using (Graphics g = Graphics.FromHdc(m.WParam))
            {
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    g.FillRectangle(brush, ClientRectangle);
                }
            }
            m.Result = IntPtr.Zero;
        }
        else
        {
            base.WndProc(ref m);
        }
    }
}