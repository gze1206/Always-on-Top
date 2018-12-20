using AlwaysOnTop.Properties;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AlwaysOnTop
{
	public class TopMost : IDisposable
	{
		public TopMost()
		{
			Program.hookCallback += KeyHook;
		}

		public void Dispose()
		{
			Program.hookCallback -= KeyHook;
		}

		private void KeyHook(KeyHookData data)
		{
			if (MainContext.Get.IsBlockingKeyInput) return;

			KeyHookData on = KeyHookData.Parse(Settings.Default.TopMost_ON);
			KeyHookData off = KeyHookData.Parse(Settings.Default.TopMost_OFF);

			if (on.ctrlDown == data.ctrlDown && on.shiftDown == data.shiftDown && on.key == data.key)
			{
				SetWindowPos(GetForegroundWindow(), HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
				MainContext.Get.ShowMessage("TopMost ON!\r\n(Always on Top을 종료해도 TopMost는 유지됩니다.)");
			} else if (off.ctrlDown == data.ctrlDown && off.shiftDown == data.shiftDown && off.key == data.key)
			{
				SetWindowPos(GetForegroundWindow(), HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
				MainContext.Get.ShowMessage("TopMost OFF!");
			}
		}

		[DllImport("user32.dll")]
		static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
		[DllImport("user32.dll")]
		static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

		static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
		static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
		const UInt32 SWP_NOSIZE = 0x0001;
		const UInt32 SWP_NOMOVE = 0x0002;
		const UInt32 SWP_SHOWWINDOW = 0x0040;
	}
}
