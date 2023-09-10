namespace isrppsLab4
{
    partial class mainForm
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tsToolbox = new System.Windows.Forms.ToolStrip();
            this.cbFigType = new System.Windows.Forms.ToolStripComboBox();
            this.tbBuild = new System.Windows.Forms.ToolStripButton();
            this.tbClear = new System.Windows.Forms.ToolStripButton();
            this.add = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsToolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsToolbox
            // 
            this.tsToolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbFigType,
            this.tbBuild,
            this.tbClear,
            this.add,
            this.toolStripButton1});
            this.tsToolbox.Location = new System.Drawing.Point(0, 0);
            this.tsToolbox.Name = "tsToolbox";
            this.tsToolbox.Size = new System.Drawing.Size(470, 25);
            this.tsToolbox.TabIndex = 0;
            this.tsToolbox.Text = "toolStrip1";
            // 
            // cbFigType
            // 
            this.cbFigType.Items.AddRange(new object[] {
            "Red",
            "Green"});
            this.cbFigType.Name = "cbFigType";
            this.cbFigType.Size = new System.Drawing.Size(140, 25);
            // 
            // tbBuild
            // 
            this.tbBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBuild.Name = "tbBuild";
            this.tbBuild.Size = new System.Drawing.Size(38, 22);
            this.tbBuild.Text = "Build";
            this.tbBuild.Click += new System.EventHandler(this.tbBuild_Click);
            // 
            // tbClear
            // 
            this.tbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(38, 22);
            this.tbClear.Text = "Clear";
            this.tbClear.Click += new System.EventHandler(this.tbClear_Click);
            // 
            // add
            // 
            this.add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(89, 22);
            this.add.Text = "AddSingleForn";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(97, 22);
            this.toolStripButton1.Text = "AddSimpleForm";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 283);
            this.Controls.Add(this.tsToolbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mainForm";
            this.Text = "AbstarctFactoryExample";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tsToolbox.ResumeLayout(false);
            this.tsToolbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStrip tsToolbox;
        private System.Windows.Forms.ToolStripComboBox cbFigType;
        private System.Windows.Forms.ToolStripButton tbBuild;
        private System.Windows.Forms.ToolStripButton tbClear;
        private ToolStripButton add;
        private ToolStripButton toolStripButton1;
    }
}