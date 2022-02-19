
namespace MyTool_SpriteSheetTool
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlLeft = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblPicSize = new System.Windows.Forms.Label();
			this.lblPicNumber = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.rbBMP = new System.Windows.Forms.RadioButton();
			this.rbTIFF = new System.Windows.Forms.RadioButton();
			this.rbPNG = new System.Windows.Forms.RadioButton();
			this.pbDraw = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbSplitH = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbSplitW = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbLayoutW = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
			this.panel1.Controls.Add(this.pnlLeft);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.lblPicSize);
			this.panel1.Controls.Add(this.lblPicNumber);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Controls.Add(this.rbBMP);
			this.panel1.Controls.Add(this.rbTIFF);
			this.panel1.Controls.Add(this.rbPNG);
			this.panel1.Controls.Add(this.pbDraw);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(581, 387);
			this.panel1.TabIndex = 18;
			// 
			// pnlLeft
			// 
			this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
			this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeft.Location = new System.Drawing.Point(0, 12);
			this.pnlLeft.Name = "pnlLeft";
			this.pnlLeft.Size = new System.Drawing.Size(8, 363);
			this.pnlLeft.TabIndex = 16;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 375);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(581, 12);
			this.panel3.TabIndex = 15;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Meiryo", 10F);
			this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label10.Location = new System.Drawing.Point(22, 19);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(262, 21);
			this.label10.TabIndex = 12;
			this.label10.Text = "画像をドラッグ＆ドロップしてください";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(581, 12);
			this.panel2.TabIndex = 0;
			// 
			// lblPicSize
			// 
			this.lblPicSize.AutoSize = true;
			this.lblPicSize.Font = new System.Drawing.Font("Meiryo", 9F);
			this.lblPicSize.Location = new System.Drawing.Point(205, 348);
			this.lblPicSize.Name = "lblPicSize";
			this.lblPicSize.Size = new System.Drawing.Size(79, 18);
			this.lblPicSize.TabIndex = 10;
			this.lblPicSize.Text = "1024 x 1024";
			// 
			// lblPicNumber
			// 
			this.lblPicNumber.AutoSize = true;
			this.lblPicNumber.Font = new System.Drawing.Font("Meiryo", 9F);
			this.lblPicNumber.Location = new System.Drawing.Point(85, 348);
			this.lblPicNumber.Name = "lblPicNumber";
			this.lblPicNumber.Size = new System.Drawing.Size(22, 18);
			this.lblPicNumber.TabIndex = 9;
			this.lblPicNumber.Text = "64";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Meiryo", 9F);
			this.label7.Location = new System.Drawing.Point(164, 348);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 18);
			this.label7.TabIndex = 0;
			this.label7.Text = "Size：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Meiryo", 9F);
			this.label6.Location = new System.Drawing.Point(22, 348);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 18);
			this.label6.TabIndex = 0;
			this.label6.Text = "Number：";
			// 
			// btnOK
			// 
			this.btnOK.Font = new System.Drawing.Font("Meiryo", 9.75F);
			this.btnOK.Location = new System.Drawing.Point(373, 313);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(159, 32);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "出力する";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// rbBMP
			// 
			this.rbBMP.AutoSize = true;
			this.rbBMP.Font = new System.Drawing.Font("Meiryo", 9.75F);
			this.rbBMP.Location = new System.Drawing.Point(491, 283);
			this.rbBMP.Name = "rbBMP";
			this.rbBMP.Size = new System.Drawing.Size(55, 24);
			this.rbBMP.TabIndex = 8;
			this.rbBMP.Text = "BMP";
			this.rbBMP.UseVisualStyleBackColor = true;
			// 
			// rbTIFF
			// 
			this.rbTIFF.AutoSize = true;
			this.rbTIFF.Font = new System.Drawing.Font("Meiryo", 9.75F);
			this.rbTIFF.Location = new System.Drawing.Point(425, 283);
			this.rbTIFF.Name = "rbTIFF";
			this.rbTIFF.Size = new System.Drawing.Size(54, 24);
			this.rbTIFF.TabIndex = 7;
			this.rbTIFF.Text = "TIFF";
			this.rbTIFF.UseVisualStyleBackColor = true;
			// 
			// rbPNG
			// 
			this.rbPNG.AutoSize = true;
			this.rbPNG.Checked = true;
			this.rbPNG.Font = new System.Drawing.Font("Meiryo", 9.75F);
			this.rbPNG.Location = new System.Drawing.Point(359, 283);
			this.rbPNG.Name = "rbPNG";
			this.rbPNG.Size = new System.Drawing.Size(54, 24);
			this.rbPNG.TabIndex = 6;
			this.rbPNG.TabStop = true;
			this.rbPNG.Text = "PNG";
			this.rbPNG.UseVisualStyleBackColor = true;
			// 
			// pbDraw
			// 
			this.pbDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
			this.pbDraw.Location = new System.Drawing.Point(26, 45);
			this.pbDraw.Name = "pbDraw";
			this.pbDraw.Size = new System.Drawing.Size(300, 300);
			this.pbDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbDraw.TabIndex = 8;
			this.pbDraw.TabStop = false;
			this.pbDraw.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbDraw_DragDrop);
			this.pbDraw.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbDraw_DragEnter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbSplitH);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.tbSplitW);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Font = new System.Drawing.Font("Meiryo", 10F);
			this.groupBox2.Location = new System.Drawing.Point(343, 140);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(218, 127);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "１枚の画像を複数に分割する";
			// 
			// tbSplitH
			// 
			this.tbSplitH.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbSplitH.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbSplitH.Location = new System.Drawing.Point(135, 75);
			this.tbSplitH.MaxLength = 2;
			this.tbSplitH.Name = "tbSplitH";
			this.tbSplitH.Size = new System.Drawing.Size(60, 27);
			this.tbSplitH.TabIndex = 5;
			this.tbSplitH.Text = "8";
			this.tbSplitH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbSplitH.Enter += new System.EventHandler(this.tbSplitH_Enter);
			this.tbSplitH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSplitH_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Meiryo", 10F);
			this.label5.Location = new System.Drawing.Point(20, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 21);
			this.label5.TabIndex = 0;
			this.label5.Text = "タテの分割数";
			// 
			// tbSplitW
			// 
			this.tbSplitW.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbSplitW.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbSplitW.Location = new System.Drawing.Point(135, 37);
			this.tbSplitW.MaxLength = 2;
			this.tbSplitW.Name = "tbSplitW";
			this.tbSplitW.Size = new System.Drawing.Size(60, 27);
			this.tbSplitW.TabIndex = 4;
			this.tbSplitW.Text = "8";
			this.tbSplitW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbSplitW.Enter += new System.EventHandler(this.tbSplitW_Enter);
			this.tbSplitW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSplitW_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Meiryo", 10F);
			this.label3.Location = new System.Drawing.Point(20, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "ヨコの分割数";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbLayoutW);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Meiryo", 10F);
			this.groupBox1.Location = new System.Drawing.Point(343, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(218, 86);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "複数の画像を１枚に結合する";
			// 
			// tbLayoutW
			// 
			this.tbLayoutW.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbLayoutW.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbLayoutW.Location = new System.Drawing.Point(135, 36);
			this.tbLayoutW.MaxLength = 2;
			this.tbLayoutW.Name = "tbLayoutW";
			this.tbLayoutW.Size = new System.Drawing.Size(60, 27);
			this.tbLayoutW.TabIndex = 2;
			this.tbLayoutW.Text = "8";
			this.tbLayoutW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbLayoutW.Enter += new System.EventHandler(this.tbLayoutW_Enter);
			this.tbLayoutW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLayoutW_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Meiryo", 10F);
			this.label2.Location = new System.Drawing.Point(20, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "ヨコに並べる数";
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 387);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Sprite Sheet Tool v.1.00";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pbDraw;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.TextBox tbSplitH;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox tbSplitW;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.TextBox tbLayoutW;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton rbBMP;
		private System.Windows.Forms.RadioButton rbTIFF;
		private System.Windows.Forms.RadioButton rbPNG;
		private System.Windows.Forms.Label lblPicSize;
		private System.Windows.Forms.Label lblPicNumber;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel pnlLeft;
	}
}

