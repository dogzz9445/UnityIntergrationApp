using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;

namespace Particle.Controls.UserContorls
{
    class IOTextBox : TextBox
    {
        private const UInt32 DLGC_WANTARROWS = 0x0001;
        private const UInt32 DLGC_WANTTAB = 0x0002;
        private const UInt32 DLGC_WANTALLKEYS = 0x0004;
        private const UInt32 DLGC_HASSETSEL = 0x0008;
        private const UInt32 DLGC_WANTCHARS = 0x0080;
        private const UInt32 WM_GETDLGCODE = 0x0087;

        public IOTextBox() : base()
        {
            Loaded += (sender, args) =>
            {
                HwndSource source = HwndSource.FromVisual(this) as HwndSource;
                if (source != null)
                {
                    source.AddHook(new HwndSourceHook(ChildHwndSource));
                }
            };
        }

        public IntPtr ChildHwndSource(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam, ref bool handled)
        {
            if (msg == WM_GETDLGCODE)
            {
                handled = true;
                return new IntPtr(DLGC_WANTCHARS | DLGC_WANTARROWS | DLGC_HASSETSEL);
            }
            return IntPtr.Zero;
        }
    }
}
