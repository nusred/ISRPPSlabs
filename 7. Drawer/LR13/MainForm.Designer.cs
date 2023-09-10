namespace LR13
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WorkArea = new System.Windows.Forms.PictureBox();
            this.LineSet = new System.Windows.Forms.Button();
            this.ClearDrawer = new System.Windows.Forms.Button();
            this.clearArea = new System.Windows.Forms.Button();
            this.curveSet = new System.Windows.Forms.Button();
            this.bezieSet = new System.Windows.Forms.Button();
            this.Color1 = new System.Windows.Forms.Button();
            this.Color2 = new System.Windows.Forms.Button();
            this.Color3 = new System.Windows.Forms.Button();
            this.Color4 = new System.Windows.Forms.Button();
            this.Color5 = new System.Windows.Forms.Button();
            this.Color6 = new System.Windows.Forms.Button();
            this.Color7 = new System.Windows.Forms.Button();
            this.Color8 = new System.Windows.Forms.Button();
            this.Color9 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.WorkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkArea
            // 
            this.WorkArea.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WorkArea.Location = new System.Drawing.Point(140, 12);
            this.WorkArea.Name = "WorkArea";
            this.WorkArea.Size = new System.Drawing.Size(830, 530);
            this.WorkArea.TabIndex = 0;
            this.WorkArea.TabStop = false;
            // 
            // LineSet
            // 
            this.LineSet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LineSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LineSet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LineSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineSet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LineSet.Location = new System.Drawing.Point(12, 12);
            this.LineSet.Name = "LineSet";
            this.LineSet.Size = new System.Drawing.Size(110, 30);
            this.LineSet.TabIndex = 1;
            this.LineSet.Text = "Set line drawer";
            this.LineSet.UseVisualStyleBackColor = false;
            this.LineSet.Click += new System.EventHandler(this.LineSet_Click);
            // 
            // ClearDrawer
            // 
            this.ClearDrawer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClearDrawer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearDrawer.Enabled = false;
            this.ClearDrawer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClearDrawer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearDrawer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearDrawer.Location = new System.Drawing.Point(12, 128);
            this.ClearDrawer.Name = "ClearDrawer";
            this.ClearDrawer.Size = new System.Drawing.Size(110, 30);
            this.ClearDrawer.TabIndex = 2;
            this.ClearDrawer.Text = "Clear drawer";
            this.ClearDrawer.UseVisualStyleBackColor = false;
            this.ClearDrawer.Click += new System.EventHandler(this.ClearDrawer_Click);
            // 
            // clearArea
            // 
            this.clearArea.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.clearArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearArea.Enabled = false;
            this.clearArea.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearArea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearArea.Location = new System.Drawing.Point(12, 161);
            this.clearArea.Name = "clearArea";
            this.clearArea.Size = new System.Drawing.Size(110, 30);
            this.clearArea.TabIndex = 3;
            this.clearArea.Text = "Clear work area";
            this.clearArea.UseVisualStyleBackColor = false;
            this.clearArea.Click += new System.EventHandler(this.clearArea_Click);
            // 
            // curveSet
            // 
            this.curveSet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.curveSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curveSet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.curveSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curveSet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.curveSet.Location = new System.Drawing.Point(12, 45);
            this.curveSet.Name = "curveSet";
            this.curveSet.Size = new System.Drawing.Size(110, 30);
            this.curveSet.TabIndex = 4;
            this.curveSet.Text = "Set curve drawer";
            this.curveSet.UseVisualStyleBackColor = false;
            this.curveSet.Click += new System.EventHandler(this.curveSet_Click);
            // 
            // bezieSet
            // 
            this.bezieSet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bezieSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bezieSet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bezieSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bezieSet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bezieSet.Location = new System.Drawing.Point(12, 78);
            this.bezieSet.Name = "bezieSet";
            this.bezieSet.Size = new System.Drawing.Size(110, 30);
            this.bezieSet.TabIndex = 5;
            this.bezieSet.Text = "Set Bezie drawer";
            this.bezieSet.UseVisualStyleBackColor = false;
            this.bezieSet.Click += new System.EventHandler(this.bezieSet_Click);
            // 
            // Color1
            // 
            this.Color1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Color1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color1.Location = new System.Drawing.Point(12, 212);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(30, 30);
            this.Color1.TabIndex = 6;
            this.Color1.UseVisualStyleBackColor = false;
            this.Color1.Click += new System.EventHandler(this.Color1_Click);
            // 
            // Color2
            // 
            this.Color2.BackColor = System.Drawing.Color.Lime;
            this.Color2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color2.Location = new System.Drawing.Point(48, 212);
            this.Color2.Name = "Color2";
            this.Color2.Size = new System.Drawing.Size(30, 30);
            this.Color2.TabIndex = 7;
            this.Color2.UseVisualStyleBackColor = false;
            this.Color2.Click += new System.EventHandler(this.Color2_Click);
            // 
            // Color3
            // 
            this.Color3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Color3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Color3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color3.Location = new System.Drawing.Point(84, 212);
            this.Color3.Name = "Color3";
            this.Color3.Size = new System.Drawing.Size(30, 30);
            this.Color3.TabIndex = 8;
            this.Color3.UseVisualStyleBackColor = false;
            this.Color3.Click += new System.EventHandler(this.Color3_Click);
            // 
            // Color4
            // 
            this.Color4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Color4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Color4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color4.Location = new System.Drawing.Point(12, 248);
            this.Color4.Name = "Color4";
            this.Color4.Size = new System.Drawing.Size(30, 30);
            this.Color4.TabIndex = 9;
            this.Color4.UseVisualStyleBackColor = false;
            this.Color4.Click += new System.EventHandler(this.Color4_Click);
            // 
            // Color5
            // 
            this.Color5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Color5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Color5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color5.Location = new System.Drawing.Point(48, 248);
            this.Color5.Name = "Color5";
            this.Color5.Size = new System.Drawing.Size(30, 30);
            this.Color5.TabIndex = 10;
            this.Color5.UseVisualStyleBackColor = false;
            this.Color5.Click += new System.EventHandler(this.Color5_Click);
            // 
            // Color6
            // 
            this.Color6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Color6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Color6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color6.Location = new System.Drawing.Point(84, 248);
            this.Color6.Name = "Color6";
            this.Color6.Size = new System.Drawing.Size(30, 30);
            this.Color6.TabIndex = 11;
            this.Color6.UseVisualStyleBackColor = false;
            this.Color6.Click += new System.EventHandler(this.Color6_Click);
            // 
            // Color7
            // 
            this.Color7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Color7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Color7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color7.Location = new System.Drawing.Point(12, 284);
            this.Color7.Name = "Color7";
            this.Color7.Size = new System.Drawing.Size(30, 30);
            this.Color7.TabIndex = 12;
            this.Color7.UseVisualStyleBackColor = false;
            this.Color7.Click += new System.EventHandler(this.Color7_Click);
            // 
            // Color8
            // 
            this.Color8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Color8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Color8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color8.Location = new System.Drawing.Point(48, 284);
            this.Color8.Name = "Color8";
            this.Color8.Size = new System.Drawing.Size(30, 30);
            this.Color8.TabIndex = 13;
            this.Color8.UseVisualStyleBackColor = false;
            this.Color8.Click += new System.EventHandler(this.Color8_Click);
            // 
            // Color9
            // 
            this.Color9.BackColor = System.Drawing.Color.Black;
            this.Color9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Color9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color9.Location = new System.Drawing.Point(84, 284);
            this.Color9.Name = "Color9";
            this.Color9.Size = new System.Drawing.Size(30, 30);
            this.Color9.TabIndex = 14;
            this.Color9.UseVisualStyleBackColor = false;
            this.Color9.Click += new System.EventHandler(this.Color9_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(10, 320);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Color9);
            this.Controls.Add(this.Color8);
            this.Controls.Add(this.Color7);
            this.Controls.Add(this.Color6);
            this.Controls.Add(this.Color5);
            this.Controls.Add(this.Color4);
            this.Controls.Add(this.Color3);
            this.Controls.Add(this.Color2);
            this.Controls.Add(this.Color1);
            this.Controls.Add(this.bezieSet);
            this.Controls.Add(this.curveSet);
            this.Controls.Add(this.clearArea);
            this.Controls.Add(this.ClearDrawer);
            this.Controls.Add(this.LineSet);
            this.Controls.Add(this.WorkArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Drawer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox WorkArea;
        private Button LineSet;
        private Button ClearDrawer;
        private Button clearArea;
        private Button curveSet;
        private Button bezieSet;
        private Button Color1;
        private Button Color2;
        private Button Color3;
        private Button Color4;
        private Button Color5;
        private Button Color6;
        private Button Color7;
        private Button Color8;
        private Button Color9;
        private TrackBar trackBar1;
    }
}