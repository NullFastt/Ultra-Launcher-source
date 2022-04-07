using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Ultra_Launcher;

public class Home : Form
{
	private IContainer components;

	private Panel panel1;

	private Panel panel2;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private SiticoneCircleButton siticoneCircleButton1;

	private SiticoneCircleButton siticoneCircleButton2;

	private SiticoneCircleButton siticoneCircleButton3;

	private SiticoneCircleButton siticoneCircleButton4;

	private SiticoneCircleButton siticoneCircleButton5;

	private SiticoneCircleButton siticoneCircleButton6;

	private SiticoneCircleButton siticoneCircleButton7;

	private Panel panel3;

	private SiticoneDragControl siticoneDragControl1;

	public Home()
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
		MessageBox.Show("You are already on Home");
	}

	private void siticoneCircleButton2_Click(object sender, EventArgs e)
	{
		Hide();
		new Launch().Show();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ultra_Launcher.Home));
		this.panel1 = new System.Windows.Forms.Panel();
		this.panel2 = new System.Windows.Forms.Panel();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.siticoneCircleButton1 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton2 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton3 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton4 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton5 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton6 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton7 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.panel3 = new System.Windows.Forms.Panel();
		this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
		this.panel3.SuspendLayout();
		base.SuspendLayout();
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.Location = new System.Drawing.Point(92, -1);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(10, 450);
		this.panel1.TabIndex = 0;
		this.panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
		this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.panel2.Location = new System.Drawing.Point(108, 12);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(190, 176);
		this.panel2.TabIndex = 1;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Impact", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.White;
		this.label1.Location = new System.Drawing.Point(302, 12);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(426, 45);
		this.label1.TabIndex = 2;
		this.label1.Text = "Welcome to Ultra Launcher";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Impact", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.Color.White;
		this.label2.Location = new System.Drawing.Point(108, 191);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(522, 45);
		this.label2.TabIndex = 3;
		this.label2.Text = "The home of XpsyFN and RaiderFN";
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Impact", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.White;
		this.label3.Location = new System.Drawing.Point(108, 236);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(524, 29);
		this.label3.TabIndex = 4;
		this.label3.Text = "If it does not launch please consult the *Not Working*\r\n";
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Impact", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.ForeColor = System.Drawing.Color.White;
		this.label4.Location = new System.Drawing.Point(231, 265);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(284, 29);
		this.label4.TabIndex = 5;
		this.label4.Text = "channel in Xpsy Community";
		this.siticoneCircleButton1.CheckedState.Parent = this.siticoneCircleButton1;
		this.siticoneCircleButton1.CustomImages.Parent = this.siticoneCircleButton1;
		this.siticoneCircleButton1.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton1.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton1.HoveredState.Parent = this.siticoneCircleButton1;
		this.siticoneCircleButton1.Location = new System.Drawing.Point(2, 17);
		this.siticoneCircleButton1.Name = "siticoneCircleButton1";
		this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton1.ShadowDecoration.Parent = this.siticoneCircleButton1;
		this.siticoneCircleButton1.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton1.TabIndex = 7;
		this.siticoneCircleButton1.Text = "Home";
		this.siticoneCircleButton1.Click += new System.EventHandler(siticoneCircleButton1_Click);
		this.siticoneCircleButton2.CheckedState.Parent = this.siticoneCircleButton2;
		this.siticoneCircleButton2.CustomImages.Parent = this.siticoneCircleButton2;
		this.siticoneCircleButton2.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton2.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton2.HoveredState.Parent = this.siticoneCircleButton2;
		this.siticoneCircleButton2.Location = new System.Drawing.Point(4, 62);
		this.siticoneCircleButton2.Name = "siticoneCircleButton2";
		this.siticoneCircleButton2.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton2.ShadowDecoration.Parent = this.siticoneCircleButton2;
		this.siticoneCircleButton2.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton2.TabIndex = 8;
		this.siticoneCircleButton2.Text = "Launch";
		this.siticoneCircleButton2.Click += new System.EventHandler(siticoneCircleButton2_Click);
		this.siticoneCircleButton3.CheckedState.Parent = this.siticoneCircleButton3;
		this.siticoneCircleButton3.CustomImages.Parent = this.siticoneCircleButton3;
		this.siticoneCircleButton3.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton3.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton3.HoveredState.Parent = this.siticoneCircleButton3;
		this.siticoneCircleButton3.Location = new System.Drawing.Point(4, 107);
		this.siticoneCircleButton3.Name = "siticoneCircleButton3";
		this.siticoneCircleButton3.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton3.ShadowDecoration.Parent = this.siticoneCircleButton3;
		this.siticoneCircleButton3.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton3.TabIndex = 9;
		this.siticoneCircleButton3.Text = "Discord";
		this.siticoneCircleButton3.Click += new System.EventHandler(siticoneCircleButton3_Click);
		this.siticoneCircleButton4.CheckedState.Parent = this.siticoneCircleButton4;
		this.siticoneCircleButton4.CustomImages.Parent = this.siticoneCircleButton4;
		this.siticoneCircleButton4.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton4.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton4.HoveredState.Parent = this.siticoneCircleButton4;
		this.siticoneCircleButton4.Location = new System.Drawing.Point(4, 152);
		this.siticoneCircleButton4.Name = "siticoneCircleButton4";
		this.siticoneCircleButton4.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton4.ShadowDecoration.Parent = this.siticoneCircleButton4;
		this.siticoneCircleButton4.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton4.TabIndex = 10;
		this.siticoneCircleButton4.Text = "Socials";
		this.siticoneCircleButton4.Click += new System.EventHandler(siticoneCircleButton4_Click);
		this.siticoneCircleButton5.CheckedState.Parent = this.siticoneCircleButton5;
		this.siticoneCircleButton5.CustomImages.Parent = this.siticoneCircleButton5;
		this.siticoneCircleButton5.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton5.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton5.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton5.HoveredState.Parent = this.siticoneCircleButton5;
		this.siticoneCircleButton5.Location = new System.Drawing.Point(4, 197);
		this.siticoneCircleButton5.Name = "siticoneCircleButton5";
		this.siticoneCircleButton5.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton5.ShadowDecoration.Parent = this.siticoneCircleButton5;
		this.siticoneCircleButton5.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton5.TabIndex = 11;
		this.siticoneCircleButton5.Text = "Contact Us";
		this.siticoneCircleButton5.Click += new System.EventHandler(siticoneCircleButton5_Click);
		this.siticoneCircleButton6.CheckedState.Parent = this.siticoneCircleButton6;
		this.siticoneCircleButton6.CustomImages.Parent = this.siticoneCircleButton6;
		this.siticoneCircleButton6.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton6.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton6.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton6.HoveredState.Parent = this.siticoneCircleButton6;
		this.siticoneCircleButton6.Location = new System.Drawing.Point(4, 242);
		this.siticoneCircleButton6.Name = "siticoneCircleButton6";
		this.siticoneCircleButton6.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton6.ShadowDecoration.Parent = this.siticoneCircleButton6;
		this.siticoneCircleButton6.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton6.TabIndex = 12;
		this.siticoneCircleButton6.Text = "Settings";
		this.siticoneCircleButton6.Click += new System.EventHandler(siticoneCircleButton6_Click);
		this.siticoneCircleButton7.CheckedState.Parent = this.siticoneCircleButton7;
		this.siticoneCircleButton7.CustomImages.Parent = this.siticoneCircleButton7;
		this.siticoneCircleButton7.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton7.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton7.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton7.HoveredState.Parent = this.siticoneCircleButton7;
		this.siticoneCircleButton7.Location = new System.Drawing.Point(751, -1);
		this.siticoneCircleButton7.Name = "siticoneCircleButton7";
		this.siticoneCircleButton7.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton7.ShadowDecoration.Parent = this.siticoneCircleButton7;
		this.siticoneCircleButton7.Size = new System.Drawing.Size(48, 42);
		this.siticoneCircleButton7.TabIndex = 13;
		this.siticoneCircleButton7.Text = "X";
		this.siticoneCircleButton7.Click += new System.EventHandler(siticoneCircleButton7_Click);
		this.panel3.Controls.Add(this.siticoneCircleButton1);
		this.panel3.Controls.Add(this.label1);
		this.panel3.Location = new System.Drawing.Point(2, 0);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(796, 100);
		this.panel3.TabIndex = 14;
		this.siticoneDragControl1.TargetControl = this.panel3;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.Controls.Add(this.siticoneCircleButton7);
		base.Controls.Add(this.siticoneCircleButton6);
		base.Controls.Add(this.siticoneCircleButton5);
		base.Controls.Add(this.siticoneCircleButton4);
		base.Controls.Add(this.siticoneCircleButton3);
		base.Controls.Add(this.siticoneCircleButton2);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.panel2);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.panel3);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Home";
		base.Opacity = 0.9;
		this.Text = "Ultra Home";
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
