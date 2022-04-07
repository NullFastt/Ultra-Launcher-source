using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Ultra_Launcher;

public class Launch : Form
{
	private IContainer components;

	private SiticoneCircleButton siticoneCircleButton7;

	private SiticoneCircleButton siticoneCircleButton6;

	private SiticoneCircleButton siticoneCircleButton5;

	private SiticoneCircleButton siticoneCircleButton4;

	private SiticoneCircleButton siticoneCircleButton3;

	private SiticoneCircleButton siticoneCircleButton2;

	private SiticoneCircleButton siticoneCircleButton1;

	private Panel panel1;

	private Panel panel2;

	private Label label1;

	private Label label2;

	private Label label3;

	private SiticoneCircleButton siticoneCircleButton8;

	private SiticoneCircleButton siticoneCircleButton9;

	private Panel panel3;

	private Panel panel4;

	private SiticoneCircleButton siticoneCircleButton10;

	private SiticoneCircleButton siticoneCircleButton11;

	private Label label4;

	private Label label5;

	private Label label6;

	private Panel panel5;

	private SiticoneDragControl siticoneDragControl1;

	public Launch()
	{
		InitializeComponent();
	}

	private void siticoneCircleButton3_Click(object sender, EventArgs e)
	{
		Process.Start("https://discord.gg/9ZtMCGtYpZ");
	}

	private void siticoneCircleButton7_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Are you sure you want to close?", "Close Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
		{
			Application.Exit();
		}
	}

	private void siticoneCircleButton1_Click(object sender, EventArgs e)
	{
		Hide();
		new Home().Show();
	}

	private void siticoneCircleButton2_Click(object sender, EventArgs e)
	{
		MessageBox.Show("You are already on Launch");
	}

	private void siticoneCircleButton4_Click(object sender, EventArgs e)
	{
		Hide();
		new Socials().Show();
	}

	private void siticoneCircleButton5_Click(object sender, EventArgs e)
	{
		MessageBox.Show("Contact youtube raxterfn#6969 or psycho#0009");
	}

	private void siticoneCircleButton6_Click(object sender, EventArgs e)
	{
		Hide();
		new Settings().Show();
	}

	private void siticoneCircleButton9_Click(object sender, EventArgs e)
	{
		MessageBox.Show("XpsyFN Private coming soon!");
	}

	private void siticoneCircleButton10_Click(object sender, EventArgs e)
	{
		MessageBox.Show("RaiderFN Private coming soon!");
	}

	private async void siticoneCircleButton11_Click(object sender, EventArgs e)
	{
		string[] array = new string[3] { "FortniteClient-Win64-Shipping_EAC.exe", "FortniteClient-Win64-Shipping_BE.exe", "FortniteLauncher.exe" };
		for (int i = 0; i < array.Length; i++)
		{
			Process[] processesByName = Process.GetProcessesByName(array[i]);
			for (int j = 0; j < processesByName.Length; j++)
			{
				processesByName[j].Kill();
			}
		}
		string TempPath = Path.GetTempPath();
		string Path1 = "";
		dynamic val = JsonConvert.DeserializeObject(File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat")));
		foreach (dynamic item in val.InstallationList)
		{
			if (item.AppName == "Fortnite")
			{
				Path1 = item.InstallLocation.ToString() + "\\FortniteGame\\Binaries\\Win64";
				_ = (string)item.AppVersion.ToString().Split('-')[1];
			}
		}
		if (File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_EAC.old"))
		{
			File.Move(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe.old");
		}
		if (File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_BE.old"))
		{
			File.Move(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe.old");
		}
		WebClient webClient = new WebClient();
		await webClient.DownloadFileTaskAsync("https://cdn.discordapp.com/attachments/899550196420186112/959775434537570354/FortniteClient-Win64-Shipping_EAC.exe", TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe");
		await webClient.DownloadFileTaskAsync("https://cdn.discordapp.com/attachments/899550196420186112/959775434130739250/FortniteClient-Win64-Shipping_BE.exe", TempPath + "\\FortniteClient-Win64-Shipping_BE.exe");
		if (!File.Exists(TempPath + "\\Raider.dll"))
		{
			await webClient.DownloadFileTaskAsync("https://cdn.discordapp.com/attachments/899550196420186112/959700693973876786/Raider.dll", TempPath + "\\Raider.dll");
		}
		if (!File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe"))
		{
			File.Move(TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
		}
		else
		{
			File.Delete(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
			File.Move(TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
		}
		if (!File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe"))
		{
			File.Move(TempPath + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
		}
		else
		{
			File.Delete(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
			File.Move(TempPath + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
		}
		if (!File.Exists(Path1 + "\\Raider.dll"))
		{
			File.Move(TempPath + "\\Raider.dll", Path1 + "\\Raider.dll");
		}
		else
		{
			File.Delete(Path1 + "\\Raider.dll");
			File.Move(TempPath + "\\Raider.dll", Path1 + "\\Raider.dll");
		}
		Process.Start(new ProcessStartInfo
		{
			CreateNoWindow = true,
			FileName = "cmd.exe",
			Arguments = "/C start com.epicgames.launcher://apps/Fortnite?action=launch"
		});
	}

	private async void siticoneCircleButton8_Click(object sender, EventArgs e)
	{
		string[] array = new string[3] { "FortniteClient-Win64-Shipping_EAC.exe", "FortniteClient-Win64-Shipping_BE.exe", "FortniteLauncher.exe" };
		for (int i = 0; i < array.Length; i++)
		{
			Process[] processesByName = Process.GetProcessesByName(array[i]);
			for (int j = 0; j < processesByName.Length; j++)
			{
				processesByName[j].Kill();
			}
		}
		string TempPath = Path.GetTempPath();
		string Path1 = "";
		dynamic val = JsonConvert.DeserializeObject(File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat")));
		foreach (dynamic item in val.InstallationList)
		{
			if (item.AppName == "Fortnite")
			{
				Path1 = item.InstallLocation.ToString() + "\\FortniteGame\\Binaries\\Win64";
				_ = (string)item.AppVersion.ToString().Split('-')[1];
			}
		}
		if (File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_EAC.old"))
		{
			File.Move(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe.old");
		}
		if (File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_BE.old"))
		{
			File.Move(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe.old");
		}
		WebClient webClient = new WebClient();
		await webClient.DownloadFileTaskAsync("https://cdn.discordapp.com/attachments/899550196420186112/956457891949314109/FortniteClient-Win64-Shipping_EAC.exe", TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe");
		await webClient.DownloadFileTaskAsync("https://cdn.discordapp.com/attachments/899550196420186112/956457939273654282/FortniteClient-Win64-Shipping_BE.exe", TempPath + "\\FortniteClient-Win64-Shipping_BE.exe");
		if (!File.Exists(TempPath + "\\XPSY.dll"))
		{
			await webClient.DownloadFileTaskAsync("https://cdn.discordapp.com/attachments/899550196420186112/956457817416564746/XPSY.dll", TempPath + "\\XPSY.dll");
		}
		if (!File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe"))
		{
			File.Move(TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
		}
		else
		{
			File.Delete(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
			File.Move(TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
		}
		if (!File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe"))
		{
			File.Move(TempPath + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
		}
		else
		{
			File.Delete(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
			File.Move(TempPath + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
		}
		if (!File.Exists(Path1 + "\\XPSY.dll"))
		{
			File.Move(TempPath + "\\XPSY.dll", Path1 + "\\XPSY.dll");
		}
		else
		{
			File.Delete(Path1 + "\\XPSY.dll");
			File.Move(TempPath + "\\XPSY.dll", Path1 + "\\XPSY.dll");
		}
		Process.Start(new ProcessStartInfo
		{
			CreateNoWindow = true,
			FileName = "cmd.exe",
			Arguments = "/C start com.epicgames.launcher://apps/Fortnite?action=launch"
		});
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ultra_Launcher.Launch));
		this.siticoneCircleButton7 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton6 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton5 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton4 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton3 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton2 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton1 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.panel1 = new System.Windows.Forms.Panel();
		this.panel2 = new System.Windows.Forms.Panel();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.siticoneCircleButton8 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton9 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.panel3 = new System.Windows.Forms.Panel();
		this.panel4 = new System.Windows.Forms.Panel();
		this.siticoneCircleButton10 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton11 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.panel5 = new System.Windows.Forms.Panel();
		this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
		this.panel5.SuspendLayout();
		base.SuspendLayout();
		this.siticoneCircleButton7.CheckedState.Parent = this.siticoneCircleButton7;
		this.siticoneCircleButton7.CustomImages.Parent = this.siticoneCircleButton7;
		this.siticoneCircleButton7.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton7.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton7.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton7.HoveredState.Parent = this.siticoneCircleButton7;
		this.siticoneCircleButton7.Location = new System.Drawing.Point(750, 0);
		this.siticoneCircleButton7.Name = "siticoneCircleButton7";
		this.siticoneCircleButton7.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton7.ShadowDecoration.Parent = this.siticoneCircleButton7;
		this.siticoneCircleButton7.Size = new System.Drawing.Size(48, 42);
		this.siticoneCircleButton7.TabIndex = 26;
		this.siticoneCircleButton7.Text = "X";
		this.siticoneCircleButton7.Click += new System.EventHandler(siticoneCircleButton7_Click);
		this.siticoneCircleButton6.CheckedState.Parent = this.siticoneCircleButton6;
		this.siticoneCircleButton6.CustomImages.Parent = this.siticoneCircleButton6;
		this.siticoneCircleButton6.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton6.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton6.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton6.HoveredState.Parent = this.siticoneCircleButton6;
		this.siticoneCircleButton6.Location = new System.Drawing.Point(3, 243);
		this.siticoneCircleButton6.Name = "siticoneCircleButton6";
		this.siticoneCircleButton6.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton6.ShadowDecoration.Parent = this.siticoneCircleButton6;
		this.siticoneCircleButton6.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton6.TabIndex = 25;
		this.siticoneCircleButton6.Text = "Settings";
		this.siticoneCircleButton6.Click += new System.EventHandler(siticoneCircleButton6_Click);
		this.siticoneCircleButton5.CheckedState.Parent = this.siticoneCircleButton5;
		this.siticoneCircleButton5.CustomImages.Parent = this.siticoneCircleButton5;
		this.siticoneCircleButton5.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton5.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton5.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton5.HoveredState.Parent = this.siticoneCircleButton5;
		this.siticoneCircleButton5.Location = new System.Drawing.Point(3, 198);
		this.siticoneCircleButton5.Name = "siticoneCircleButton5";
		this.siticoneCircleButton5.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton5.ShadowDecoration.Parent = this.siticoneCircleButton5;
		this.siticoneCircleButton5.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton5.TabIndex = 24;
		this.siticoneCircleButton5.Text = "Contact Us";
		this.siticoneCircleButton5.Click += new System.EventHandler(siticoneCircleButton5_Click);
		this.siticoneCircleButton4.CheckedState.Parent = this.siticoneCircleButton4;
		this.siticoneCircleButton4.CustomImages.Parent = this.siticoneCircleButton4;
		this.siticoneCircleButton4.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton4.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton4.HoveredState.Parent = this.siticoneCircleButton4;
		this.siticoneCircleButton4.Location = new System.Drawing.Point(3, 153);
		this.siticoneCircleButton4.Name = "siticoneCircleButton4";
		this.siticoneCircleButton4.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton4.ShadowDecoration.Parent = this.siticoneCircleButton4;
		this.siticoneCircleButton4.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton4.TabIndex = 23;
		this.siticoneCircleButton4.Text = "Socials";
		this.siticoneCircleButton4.Click += new System.EventHandler(siticoneCircleButton4_Click);
		this.siticoneCircleButton3.CheckedState.Parent = this.siticoneCircleButton3;
		this.siticoneCircleButton3.CustomImages.Parent = this.siticoneCircleButton3;
		this.siticoneCircleButton3.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton3.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton3.HoveredState.Parent = this.siticoneCircleButton3;
		this.siticoneCircleButton3.Location = new System.Drawing.Point(3, 108);
		this.siticoneCircleButton3.Name = "siticoneCircleButton3";
		this.siticoneCircleButton3.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton3.ShadowDecoration.Parent = this.siticoneCircleButton3;
		this.siticoneCircleButton3.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton3.TabIndex = 22;
		this.siticoneCircleButton3.Text = "Discord";
		this.siticoneCircleButton3.Click += new System.EventHandler(siticoneCircleButton3_Click);
		this.siticoneCircleButton2.CheckedState.Parent = this.siticoneCircleButton2;
		this.siticoneCircleButton2.CustomImages.Parent = this.siticoneCircleButton2;
		this.siticoneCircleButton2.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton2.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton2.HoveredState.Parent = this.siticoneCircleButton2;
		this.siticoneCircleButton2.Location = new System.Drawing.Point(3, 63);
		this.siticoneCircleButton2.Name = "siticoneCircleButton2";
		this.siticoneCircleButton2.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton2.ShadowDecoration.Parent = this.siticoneCircleButton2;
		this.siticoneCircleButton2.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton2.TabIndex = 21;
		this.siticoneCircleButton2.Text = "Launch";
		this.siticoneCircleButton2.Click += new System.EventHandler(siticoneCircleButton2_Click);
		this.siticoneCircleButton1.CheckedState.Parent = this.siticoneCircleButton1;
		this.siticoneCircleButton1.CustomImages.Parent = this.siticoneCircleButton1;
		this.siticoneCircleButton1.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton1.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton1.HoveredState.Parent = this.siticoneCircleButton1;
		this.siticoneCircleButton1.Location = new System.Drawing.Point(1, 17);
		this.siticoneCircleButton1.Name = "siticoneCircleButton1";
		this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton1.ShadowDecoration.Parent = this.siticoneCircleButton1;
		this.siticoneCircleButton1.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton1.TabIndex = 20;
		this.siticoneCircleButton1.Text = "Home";
		this.siticoneCircleButton1.Click += new System.EventHandler(siticoneCircleButton1_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.Location = new System.Drawing.Point(91, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(10, 450);
		this.panel1.TabIndex = 14;
		this.panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
		this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.panel2.Location = new System.Drawing.Point(112, 10);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(246, 227);
		this.panel2.TabIndex = 27;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.White;
		this.label1.Location = new System.Drawing.Point(163, 243);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(137, 33);
		this.label1.TabIndex = 28;
		this.label1.Text = "XpsyFN -";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.Color.White;
		this.label2.Location = new System.Drawing.Point(148, 276);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(152, 33);
		this.label2.TabIndex = 29;
		this.label2.Text = "Auto Inject";
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.White;
		this.label3.Location = new System.Drawing.Point(107, 306);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(264, 33);
		this.label3.TabIndex = 30;
		this.label3.Text = "Created By Psycho";
		this.siticoneCircleButton8.CheckedState.Parent = this.siticoneCircleButton8;
		this.siticoneCircleButton8.CustomImages.Parent = this.siticoneCircleButton8;
		this.siticoneCircleButton8.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton8.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton8.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton8.HoveredState.Parent = this.siticoneCircleButton8;
		this.siticoneCircleButton8.Location = new System.Drawing.Point(113, 342);
		this.siticoneCircleButton8.Name = "siticoneCircleButton8";
		this.siticoneCircleButton8.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton8.ShadowDecoration.Parent = this.siticoneCircleButton8;
		this.siticoneCircleButton8.Size = new System.Drawing.Size(105, 64);
		this.siticoneCircleButton8.TabIndex = 31;
		this.siticoneCircleButton8.Text = "Launch Hybrid";
		this.siticoneCircleButton8.Click += new System.EventHandler(siticoneCircleButton8_Click);
		this.siticoneCircleButton9.CheckedState.Parent = this.siticoneCircleButton9;
		this.siticoneCircleButton9.CustomImages.Parent = this.siticoneCircleButton9;
		this.siticoneCircleButton9.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton9.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton9.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton9.HoveredState.Parent = this.siticoneCircleButton9;
		this.siticoneCircleButton9.Location = new System.Drawing.Point(266, 342);
		this.siticoneCircleButton9.Name = "siticoneCircleButton9";
		this.siticoneCircleButton9.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton9.ShadowDecoration.Parent = this.siticoneCircleButton9;
		this.siticoneCircleButton9.Size = new System.Drawing.Size(105, 64);
		this.siticoneCircleButton9.TabIndex = 32;
		this.siticoneCircleButton9.Text = "Launch Private";
		this.siticoneCircleButton9.Click += new System.EventHandler(siticoneCircleButton9_Click);
		this.panel3.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel3.BackgroundImage");
		this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.panel3.Location = new System.Drawing.Point(483, 10);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(246, 227);
		this.panel3.TabIndex = 28;
		this.panel4.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel4.BackgroundImage");
		this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.panel4.Location = new System.Drawing.Point(842, 16);
		this.panel4.Name = "panel4";
		this.panel4.Size = new System.Drawing.Size(246, 227);
		this.panel4.TabIndex = 33;
		this.siticoneCircleButton10.CheckedState.Parent = this.siticoneCircleButton10;
		this.siticoneCircleButton10.CustomImages.Parent = this.siticoneCircleButton10;
		this.siticoneCircleButton10.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton10.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton10.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton10.HoveredState.Parent = this.siticoneCircleButton10;
		this.siticoneCircleButton10.Location = new System.Drawing.Point(625, 348);
		this.siticoneCircleButton10.Name = "siticoneCircleButton10";
		this.siticoneCircleButton10.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton10.ShadowDecoration.Parent = this.siticoneCircleButton10;
		this.siticoneCircleButton10.Size = new System.Drawing.Size(105, 64);
		this.siticoneCircleButton10.TabIndex = 38;
		this.siticoneCircleButton10.Text = "Launch Private";
		this.siticoneCircleButton10.Click += new System.EventHandler(siticoneCircleButton10_Click);
		this.siticoneCircleButton11.CheckedState.Parent = this.siticoneCircleButton11;
		this.siticoneCircleButton11.CustomImages.Parent = this.siticoneCircleButton11;
		this.siticoneCircleButton11.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton11.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton11.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton11.HoveredState.Parent = this.siticoneCircleButton11;
		this.siticoneCircleButton11.Location = new System.Drawing.Point(472, 348);
		this.siticoneCircleButton11.Name = "siticoneCircleButton11";
		this.siticoneCircleButton11.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton11.ShadowDecoration.Parent = this.siticoneCircleButton11;
		this.siticoneCircleButton11.Size = new System.Drawing.Size(105, 64);
		this.siticoneCircleButton11.TabIndex = 37;
		this.siticoneCircleButton11.Text = "Launch Hybrid";
		this.siticoneCircleButton11.Click += new System.EventHandler(siticoneCircleButton11_Click);
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.ForeColor = System.Drawing.Color.White;
		this.label4.Location = new System.Drawing.Point(466, 312);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(254, 33);
		this.label4.TabIndex = 36;
		this.label4.Text = "Created By Raxter";
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.Color.White;
		this.label5.Location = new System.Drawing.Point(507, 279);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(152, 33);
		this.label5.TabIndex = 35;
		this.label5.Text = "Auto Inject";
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.ForeColor = System.Drawing.Color.White;
		this.label6.Location = new System.Drawing.Point(522, 240);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(158, 33);
		this.label6.TabIndex = 34;
		this.label6.Text = "RaiderFN -";
		this.panel5.Controls.Add(this.siticoneCircleButton1);
		this.panel5.Location = new System.Drawing.Point(2, 1);
		this.panel5.Name = "panel5";
		this.panel5.Size = new System.Drawing.Size(795, 81);
		this.panel5.TabIndex = 39;
		this.siticoneDragControl1.TargetControl = this.panel5;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.Controls.Add(this.panel4);
		base.Controls.Add(this.siticoneCircleButton10);
		base.Controls.Add(this.siticoneCircleButton11);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.panel3);
		base.Controls.Add(this.siticoneCircleButton9);
		base.Controls.Add(this.siticoneCircleButton8);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.panel2);
		base.Controls.Add(this.siticoneCircleButton7);
		base.Controls.Add(this.siticoneCircleButton6);
		base.Controls.Add(this.siticoneCircleButton5);
		base.Controls.Add(this.siticoneCircleButton4);
		base.Controls.Add(this.siticoneCircleButton3);
		base.Controls.Add(this.siticoneCircleButton2);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.panel5);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Launch";
		this.Text = "Ultra Launch";
		this.panel5.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
