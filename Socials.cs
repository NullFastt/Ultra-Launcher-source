using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Ultra_Launcher;

public class Socials : Form
{
	private IContainer components;

	private Label label6;

	private Panel panel3;

	private SiticoneCircleButton siticoneCircleButton8;

	private Label label1;

	private SiticoneCircleButton siticoneCircleButton7;

	private SiticoneCircleButton siticoneCircleButton6;

	private SiticoneCircleButton siticoneCircleButton5;

	private SiticoneCircleButton siticoneCircleButton4;

	private SiticoneCircleButton siticoneCircleButton3;

	private SiticoneCircleButton siticoneCircleButton2;

	private SiticoneCircleButton siticoneCircleButton1;

	private Panel panel1;

	private Panel panel2;

	private SiticoneCircleButton siticoneCircleButton9;

	private Panel panel4;

	private SiticoneDragControl siticoneDragControl1;

	public Socials()
	{
		InitializeComponent();
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
		Hide();
		new Launch().Show();
	}

	private void siticoneCircleButton3_Click(object sender, EventArgs e)
	{
		Process.Start("https://discord.gg/9ZtMCGtYpZ");
	}

	private void siticoneCircleButton4_Click(object sender, EventArgs e)
	{
		MessageBox.Show("You are already on Socials");
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
		Process.Start("https://linktr.ee/raxterfnyt");
	}

	private void siticoneCircleButton8_Click(object sender, EventArgs e)
	{
		Process.Start("https://linktr.ee/psychoidk");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ultra_Launcher.Socials));
		this.label6 = new System.Windows.Forms.Label();
		this.panel3 = new System.Windows.Forms.Panel();
		this.siticoneCircleButton8 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.label1 = new System.Windows.Forms.Label();
		this.siticoneCircleButton7 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton6 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton5 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton4 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton3 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton2 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.siticoneCircleButton1 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.panel1 = new System.Windows.Forms.Panel();
		this.panel2 = new System.Windows.Forms.Panel();
		this.siticoneCircleButton9 = new Siticone.UI.WinForms.SiticoneCircleButton();
		this.panel4 = new System.Windows.Forms.Panel();
		this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
		this.panel4.SuspendLayout();
		base.SuspendLayout();
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.ForeColor = System.Drawing.Color.White;
		this.label6.Location = new System.Drawing.Point(489, 243);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(225, 33);
		this.label6.TabIndex = 54;
		this.label6.Text = "Raxter's Socials";
		this.panel3.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel3.BackgroundImage");
		this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.panel3.Location = new System.Drawing.Point(483, 10);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(246, 227);
		this.panel3.TabIndex = 48;
		this.siticoneCircleButton8.CheckedState.Parent = this.siticoneCircleButton8;
		this.siticoneCircleButton8.CustomImages.Parent = this.siticoneCircleButton8;
		this.siticoneCircleButton8.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton8.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.siticoneCircleButton8.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton8.HoveredState.Parent = this.siticoneCircleButton8;
		this.siticoneCircleButton8.Location = new System.Drawing.Point(129, 281);
		this.siticoneCircleButton8.Name = "siticoneCircleButton8";
		this.siticoneCircleButton8.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton8.ShadowDecoration.Parent = this.siticoneCircleButton8;
		this.siticoneCircleButton8.Size = new System.Drawing.Size(219, 64);
		this.siticoneCircleButton8.TabIndex = 52;
		this.siticoneCircleButton8.Text = "Launch All Socials";
		this.siticoneCircleButton8.Click += new System.EventHandler(siticoneCircleButton8_Click);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.White;
		this.label1.Location = new System.Drawing.Point(123, 243);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(235, 33);
		this.label1.TabIndex = 49;
		this.label1.Text = "Psycho's Socials";
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
		this.siticoneCircleButton7.TabIndex = 46;
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
		this.siticoneCircleButton6.TabIndex = 45;
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
		this.siticoneCircleButton5.TabIndex = 44;
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
		this.siticoneCircleButton4.TabIndex = 43;
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
		this.siticoneCircleButton3.TabIndex = 42;
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
		this.siticoneCircleButton2.TabIndex = 41;
		this.siticoneCircleButton2.Text = "Launch";
		this.siticoneCircleButton2.Click += new System.EventHandler(siticoneCircleButton2_Click);
		this.siticoneCircleButton1.CheckedState.Parent = this.siticoneCircleButton1;
		this.siticoneCircleButton1.CustomImages.Parent = this.siticoneCircleButton1;
		this.siticoneCircleButton1.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.siticoneCircleButton1.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton1.HoveredState.Parent = this.siticoneCircleButton1;
		this.siticoneCircleButton1.Location = new System.Drawing.Point(1, 15);
		this.siticoneCircleButton1.Name = "siticoneCircleButton1";
		this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton1.ShadowDecoration.Parent = this.siticoneCircleButton1;
		this.siticoneCircleButton1.Size = new System.Drawing.Size(76, 39);
		this.siticoneCircleButton1.TabIndex = 40;
		this.siticoneCircleButton1.Text = "Home";
		this.siticoneCircleButton1.Click += new System.EventHandler(siticoneCircleButton1_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.Location = new System.Drawing.Point(91, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(10, 450);
		this.panel1.TabIndex = 39;
		this.panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
		this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.panel2.Location = new System.Drawing.Point(112, 10);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(246, 227);
		this.panel2.TabIndex = 47;
		this.siticoneCircleButton9.CheckedState.Parent = this.siticoneCircleButton9;
		this.siticoneCircleButton9.CustomImages.Parent = this.siticoneCircleButton9;
		this.siticoneCircleButton9.FillColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.siticoneCircleButton9.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.siticoneCircleButton9.ForeColor = System.Drawing.Color.White;
		this.siticoneCircleButton9.HoveredState.Parent = this.siticoneCircleButton9;
		this.siticoneCircleButton9.Location = new System.Drawing.Point(483, 281);
		this.siticoneCircleButton9.Name = "siticoneCircleButton9";
		this.siticoneCircleButton9.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
		this.siticoneCircleButton9.ShadowDecoration.Parent = this.siticoneCircleButton9;
		this.siticoneCircleButton9.Size = new System.Drawing.Size(219, 64);
		this.siticoneCircleButton9.TabIndex = 55;
		this.siticoneCircleButton9.Text = "Launch All Socials";
		this.siticoneCircleButton9.Click += new System.EventHandler(siticoneCircleButton9_Click);
		this.panel4.Controls.Add(this.siticoneCircleButton1);
		this.panel4.Location = new System.Drawing.Point(3, 0);
		this.panel4.Name = "panel4";
		this.panel4.Size = new System.Drawing.Size(807, 101);
		this.panel4.TabIndex = 56;
		this.siticoneDragControl1.TargetControl = this.panel4;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.Controls.Add(this.siticoneCircleButton9);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.panel3);
		base.Controls.Add(this.siticoneCircleButton8);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.panel2);
		base.Controls.Add(this.siticoneCircleButton7);
		base.Controls.Add(this.siticoneCircleButton6);
		base.Controls.Add(this.siticoneCircleButton5);
		base.Controls.Add(this.siticoneCircleButton4);
		base.Controls.Add(this.siticoneCircleButton3);
		base.Controls.Add(this.siticoneCircleButton2);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.panel4);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Socials";
		this.Text = "Ultra Socials";
		this.panel4.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
