/*
 * Created by SharpDevelop.
 * User: AJB
 * Date: 12/12/2013
 * Time: 12:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GreenCal
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.txtScreen = new System.Windows.Forms.TextBox();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btnHash = new System.Windows.Forms.Button();
			this.btnStar = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.timmor = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.editTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeKeyArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtScreen
			// 
			this.txtScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.txtScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtScreen.Location = new System.Drawing.Point(12, 12);
			this.txtScreen.Name = "txtScreen";
			this.txtScreen.Size = new System.Drawing.Size(435, 116);
			this.txtScreen.TabIndex = 0;
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.Color.Lime;
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.ForeColor = System.Drawing.Color.Crimson;
			this.btn1.Location = new System.Drawing.Point(12, 139);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(141, 115);
			this.btn1.TabIndex = 1;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.Color.Lime;
			this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.ForeColor = System.Drawing.Color.Crimson;
			this.btn2.Location = new System.Drawing.Point(159, 139);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(141, 115);
			this.btn2.TabIndex = 2;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = false;
			this.btn2.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn3
			// 
			this.btn3.BackColor = System.Drawing.Color.Lime;
			this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn3.ForeColor = System.Drawing.Color.Crimson;
			this.btn3.Location = new System.Drawing.Point(306, 139);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(141, 115);
			this.btn3.TabIndex = 3;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = false;
			this.btn3.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn4
			// 
			this.btn4.BackColor = System.Drawing.Color.Lime;
			this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn4.ForeColor = System.Drawing.Color.Crimson;
			this.btn4.Location = new System.Drawing.Point(12, 260);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(141, 115);
			this.btn4.TabIndex = 3;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = false;
			this.btn4.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn5
			// 
			this.btn5.BackColor = System.Drawing.Color.Lime;
			this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5.ForeColor = System.Drawing.Color.Crimson;
			this.btn5.Location = new System.Drawing.Point(159, 260);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(141, 115);
			this.btn5.TabIndex = 3;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = false;
			this.btn5.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn9
			// 
			this.btn9.BackColor = System.Drawing.Color.Lime;
			this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn9.ForeColor = System.Drawing.Color.Crimson;
			this.btn9.Location = new System.Drawing.Point(306, 381);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(141, 115);
			this.btn9.TabIndex = 3;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = false;
			this.btn9.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn8
			// 
			this.btn8.BackColor = System.Drawing.Color.Lime;
			this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn8.ForeColor = System.Drawing.Color.Crimson;
			this.btn8.Location = new System.Drawing.Point(159, 381);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(141, 115);
			this.btn8.TabIndex = 3;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = false;
			this.btn8.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn6
			// 
			this.btn6.BackColor = System.Drawing.Color.Lime;
			this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6.ForeColor = System.Drawing.Color.Crimson;
			this.btn6.Location = new System.Drawing.Point(306, 260);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(141, 115);
			this.btn6.TabIndex = 3;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = false;
			this.btn6.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btnHash
			// 
			this.btnHash.BackColor = System.Drawing.Color.Lime;
			this.btnHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHash.ForeColor = System.Drawing.Color.Crimson;
			this.btnHash.Location = new System.Drawing.Point(306, 502);
			this.btnHash.Name = "btnHash";
			this.btnHash.Size = new System.Drawing.Size(141, 115);
			this.btnHash.TabIndex = 3;
			this.btnHash.Text = "#";
			this.btnHash.UseVisualStyleBackColor = false;
			// 
			// btnStar
			// 
			this.btnStar.BackColor = System.Drawing.Color.Lime;
			this.btnStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStar.ForeColor = System.Drawing.Color.Crimson;
			this.btnStar.Location = new System.Drawing.Point(12, 502);
			this.btnStar.Name = "btnStar";
			this.btnStar.Size = new System.Drawing.Size(141, 115);
			this.btnStar.TabIndex = 3;
			this.btnStar.Text = "*";
			this.btnStar.UseVisualStyleBackColor = false;
			this.btnStar.Click += new System.EventHandler(this.BtnStarClick);
			// 
			// btn7
			// 
			this.btn7.BackColor = System.Drawing.Color.Lime;
			this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7.ForeColor = System.Drawing.Color.Crimson;
			this.btn7.Location = new System.Drawing.Point(12, 381);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(141, 115);
			this.btn7.TabIndex = 3;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = false;
			this.btn7.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn0
			// 
			this.btn0.BackColor = System.Drawing.Color.Lime;
			this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn0.ForeColor = System.Drawing.Color.Crimson;
			this.btn0.Location = new System.Drawing.Point(159, 502);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(141, 115);
			this.btn0.TabIndex = 3;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = false;
			this.btn0.Click += new System.EventHandler(this.Btn2Click);
			// 
			// timmor
			// 
			this.timmor.Tick += new System.EventHandler(this.TimmorTick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.editTimerToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(459, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// editTimerToolStripMenuItem
			// 
			this.editTimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.changeTimerToolStripMenuItem,
									this.changeKeyArrayToolStripMenuItem});
			this.editTimerToolStripMenuItem.Name = "editTimerToolStripMenuItem";
			this.editTimerToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
			this.editTimerToolStripMenuItem.Text = "Change Settings";
			// 
			// changeTimerToolStripMenuItem
			// 
			this.changeTimerToolStripMenuItem.Name = "changeTimerToolStripMenuItem";
			this.changeTimerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.changeTimerToolStripMenuItem.Text = "Change Timer";
			this.changeTimerToolStripMenuItem.Click += new System.EventHandler(this.ChangeTimerToolStripMenuItemClick);
			// 
			// changeKeyArrayToolStripMenuItem
			// 
			this.changeKeyArrayToolStripMenuItem.Name = "changeKeyArrayToolStripMenuItem";
			this.changeKeyArrayToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.changeKeyArrayToolStripMenuItem.Text = "Change Key Array";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(459, 625);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.btnHash);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btnStar);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.txtScreen);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.MaximumSize = new System.Drawing.Size(475, 663);
			this.MinimumSize = new System.Drawing.Size(475, 663);
			this.Name = "MainForm";
			this.Text = "GreenCal";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeKeyArrayToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeTimerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editTimerToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Timer timmor;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btnStar;
		private System.Windows.Forms.Button btnHash;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.TextBox txtScreen;
	}
}
