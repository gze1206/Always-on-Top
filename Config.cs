using AlwaysOnTop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlwaysOnTop
{
	public partial class Config : Form
	{
		private static readonly string SettingStr = "설정 중";
		private static readonly string SettingIdleStr = "설정";

		private bool nowTopMost_ON_Setting = false;
		private bool nowTopMost_OFF_Setting = false;

		public Config()
		{
			InitializeComponent();

			topMost_ON_button.Click += TopMost_ON;
			topMost_OFF_button.Click += TopMost_OFF;

			Program.hookCallback += KeyHook;

			ReloadAll();
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			Program.hookCallback -= KeyHook;
			base.OnFormClosing(e);
		}

		private void ReloadAll()
		{
			topMost_ON_textBox.Text = Settings.Default.TopMost_ON;
			topMost_OFF_textBox.Text = Settings.Default.TopMost_OFF;
		}

		private void TopMost_ON(object sender, EventArgs e)
		{
			if (nowTopMost_OFF_Setting) return;

			if (nowTopMost_ON_Setting)
			{
				Settings.Default.TopMost_ON = string.IsNullOrEmpty(topMost_ON_textBox.Text) ? Settings.Default.TopMost_ON : topMost_ON_textBox.Text;
				nowTopMost_ON_Setting = false;
				MainContext.Get.IsBlockingKeyInput = false;
				topMost_ON_button.Text = SettingIdleStr;
				Settings.Default.Save();
			} else
			{
				Settings.Default.TopMost_ON = string.Empty;
				nowTopMost_ON_Setting = true;
				MainContext.Get.IsBlockingKeyInput = true;
				topMost_ON_button.Text = SettingStr;
			}
		}

		private void TopMost_OFF(object sender, EventArgs e)
		{
			if (nowTopMost_ON_Setting) return;

			if (nowTopMost_OFF_Setting)
			{
				Settings.Default.TopMost_OFF = string.IsNullOrEmpty(topMost_OFF_textBox.Text) ? Settings.Default.TopMost_OFF : topMost_OFF_textBox.Text;
				nowTopMost_OFF_Setting = false;
				MainContext.Get.IsBlockingKeyInput = false;
				topMost_OFF_button.Text = SettingIdleStr;
				Settings.Default.Save();
			} else
			{
				Settings.Default.TopMost_OFF = string.Empty;
				nowTopMost_OFF_Setting = true;
				MainContext.Get.IsBlockingKeyInput = true;
				topMost_OFF_button.Text = SettingStr;
			}
		}

		private void KeyHook(KeyHookData data)
		{
			if (nowTopMost_ON_Setting)
			{
				topMost_ON_textBox.Text = data.ToString();
			} else if (nowTopMost_OFF_Setting)
			{
				topMost_OFF_textBox.Text = data.ToString();
			}
		}
	}
}
