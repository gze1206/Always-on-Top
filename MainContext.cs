using AlwaysOnTop.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlwaysOnTop
{
	public class MainContext : ApplicationContext
	{
		private static readonly string BalloonTipTitle = "Always on Top";

		private NotifyIcon trayIcon;
		private TopMost topMost;

		public static MainContext Get { get; private set; } = null;
		public bool IsBlockingKeyInput = false;

		public MainContext()
		{
			Get = this;

			trayIcon = new NotifyIcon()
			{
				Icon = Resources.AppIcon,
				ContextMenu = new ContextMenu(new MenuItem[]
				{
					new MenuItem("Help", Help),
					new MenuItem("Config", Config),
					new MenuItem("Quit", Exit)
				}),
				Visible = true
			};

			topMost = new TopMost();

			ShowMessage("프로그램이 실행되었습니다.\r\n우클릭 - Help로 사용법을 확인할 수 있습니다.");
		}

		public void ShowMessage(string msg, ToolTipIcon icon = ToolTipIcon.None) => trayIcon.ShowBalloonTip(1000, BalloonTipTitle, msg, icon);


		private void Help(object sender, EventArgs e)
		{
			string msg = $"현재 창 항상 위에 고정 : {Settings.Default.TopMost_ON} / 해제 : {Settings.Default.TopMost_OFF}";
			MessageBox.Show(msg, "도움말", MessageBoxButtons.OK);
		}

		private void Config(object sender, EventArgs e)
		{
			new Config().Show(MainForm);
		}

		private void Exit(object sender, EventArgs e)
		{
			topMost.Dispose();
			Program.Unhook();
			trayIcon.Visible = false;
			Application.Exit();
		}
	}
}
