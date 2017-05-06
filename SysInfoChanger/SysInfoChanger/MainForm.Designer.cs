namespace SysInfoChanger
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._FormDrag1 = new ns1.BunifuDragControl(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this._FormElipse = new ns1.BunifuElipse(this.components);
            this.plSide = new System.Windows.Forms.Panel();
            this.btVC = new ns1.BunifuImageButton();
            this.btRAM = new ns1.BunifuImageButton();
            this.btCP = new ns1.BunifuImageButton();
            this.plLogo = new System.Windows.Forms.Panel();
            this.plHeader = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.lbMinimize = new System.Windows.Forms.Label();
            this.ltExit = new System.Windows.Forms.Label();
            this.lbDeviceName = new System.Windows.Forms.Label();
            this._FormDrag2 = new ns1.BunifuDragControl(this.components);
            this.plFooter = new System.Windows.Forms.Panel();
            this.btSave = new ns1.BunifuImageButton();
            this.plProc = new SysInfoChanger.Processor();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.plSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btVC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCP)).BeginInit();
            this.plLogo.SuspendLayout();
            this.plHeader.SuspendLayout();
            this.plFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSave)).BeginInit();
            this.SuspendLayout();
            // 
            // _FormDrag1
            // 
            this._FormDrag1.Fixed = true;
            this._FormDrag1.Horizontal = true;
            this._FormDrag1.TargetControl = this.pbLogo;
            this._FormDrag1.Vertical = true;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(70, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // _FormElipse
            // 
            this._FormElipse.ElipseRadius = 10;
            this._FormElipse.TargetControl = this;
            // 
            // plSide
            // 
            this.plSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.plSide.Controls.Add(this.btVC);
            this.plSide.Controls.Add(this.btRAM);
            this.plSide.Controls.Add(this.btCP);
            this.plSide.Controls.Add(this.plLogo);
            this.plSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.plSide.Location = new System.Drawing.Point(0, 0);
            this.plSide.Name = "plSide";
            this.plSide.Size = new System.Drawing.Size(70, 256);
            this.plSide.TabIndex = 0;
            // 
            // btVC
            // 
            this.btVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btVC.Image = ((System.Drawing.Image)(resources.GetObject("btVC.Image")));
            this.btVC.ImageActive = null;
            this.btVC.Location = new System.Drawing.Point(10, 190);
            this.btVC.Name = "btVC";
            this.btVC.Size = new System.Drawing.Size(50, 50);
            this.btVC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btVC.TabIndex = 1;
            this.btVC.TabStop = false;
            this.btVC.Zoom = 10;
            // 
            // btRAM
            // 
            this.btRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btRAM.Image = ((System.Drawing.Image)(resources.GetObject("btRAM.Image")));
            this.btRAM.ImageActive = null;
            this.btRAM.Location = new System.Drawing.Point(10, 130);
            this.btRAM.Name = "btRAM";
            this.btRAM.Size = new System.Drawing.Size(50, 50);
            this.btRAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btRAM.TabIndex = 1;
            this.btRAM.TabStop = false;
            this.btRAM.Zoom = 10;
            // 
            // btCP
            // 
            this.btCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btCP.Image = ((System.Drawing.Image)(resources.GetObject("btCP.Image")));
            this.btCP.ImageActive = null;
            this.btCP.Location = new System.Drawing.Point(10, 70);
            this.btCP.Name = "btCP";
            this.btCP.Size = new System.Drawing.Size(50, 50);
            this.btCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btCP.TabIndex = 1;
            this.btCP.TabStop = false;
            this.btCP.Zoom = 10;
            this.btCP.Click += new System.EventHandler(this.btCP_Click);
            // 
            // plLogo
            // 
            this.plLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.plLogo.Controls.Add(this.pbLogo);
            this.plLogo.Location = new System.Drawing.Point(0, 0);
            this.plLogo.Name = "plLogo";
            this.plLogo.Size = new System.Drawing.Size(70, 50);
            this.plLogo.TabIndex = 0;
            // 
            // plHeader
            // 
            this.plHeader.BackColor = System.Drawing.Color.White;
            this.plHeader.Controls.Add(this.bunifuSeparator1);
            this.plHeader.Controls.Add(this.lbMinimize);
            this.plHeader.Controls.Add(this.ltExit);
            this.plHeader.Controls.Add(this.lbDeviceName);
            this.plHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.plHeader.Location = new System.Drawing.Point(70, 0);
            this.plHeader.Name = "plHeader";
            this.plHeader.Size = new System.Drawing.Size(442, 50);
            this.plHeader.TabIndex = 0;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 49);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(444, 1);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.TabStop = false;
            this.bunifuSeparator1.Transparency = 100;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lbMinimize
            // 
            this.lbMinimize.AutoSize = true;
            this.lbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMinimize.Location = new System.Drawing.Point(386, 15);
            this.lbMinimize.Name = "lbMinimize";
            this.lbMinimize.Size = new System.Drawing.Size(16, 22);
            this.lbMinimize.TabIndex = 0;
            this.lbMinimize.Text = "-";
            this.lbMinimize.Click += new System.EventHandler(this.lbMinimize_Click);
            // 
            // ltExit
            // 
            this.ltExit.AutoSize = true;
            this.ltExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltExit.Location = new System.Drawing.Point(408, 15);
            this.ltExit.Name = "ltExit";
            this.ltExit.Size = new System.Drawing.Size(22, 22);
            this.ltExit.TabIndex = 0;
            this.ltExit.Text = "X";
            this.ltExit.Click += new System.EventHandler(this.ltExit_Click);
            // 
            // lbDeviceName
            // 
            this.lbDeviceName.AutoSize = true;
            this.lbDeviceName.Location = new System.Drawing.Point(15, 15);
            this.lbDeviceName.Name = "lbDeviceName";
            this.lbDeviceName.Size = new System.Drawing.Size(76, 22);
            this.lbDeviceName.TabIndex = 0;
            this.lbDeviceName.Text = "Device";
            // 
            // _FormDrag2
            // 
            this._FormDrag2.Fixed = true;
            this._FormDrag2.Horizontal = true;
            this._FormDrag2.TargetControl = this.plHeader;
            this._FormDrag2.Vertical = true;
            // 
            // plFooter
            // 
            this.plFooter.BackColor = System.Drawing.Color.DarkGray;
            this.plFooter.Controls.Add(this.btSave);
            this.plFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plFooter.Location = new System.Drawing.Point(70, 206);
            this.plFooter.Name = "plFooter";
            this.plFooter.Size = new System.Drawing.Size(442, 50);
            this.plFooter.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.DarkGray;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageActive = null;
            this.btSave.Location = new System.Drawing.Point(390, 5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(40, 40);
            this.btSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSave.TabIndex = 1;
            this.btSave.TabStop = false;
            this.btSave.Visible = false;
            this.btSave.Zoom = 10;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // plProc
            // 
            this.plProc.BackColor = System.Drawing.Color.LightGray;
            this.plProc.Location = new System.Drawing.Point(70, 49);
            this.plProc.Name = "plProc";
            this.plProc.Size = new System.Drawing.Size(442, 156);
            this.plProc.TabIndex = 0;
            this.plProc.TabStop = false;
            this.plProc.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(512, 256);
            this.ControlBox = false;
            this.Controls.Add(this.plFooter);
            this.Controls.Add(this.plHeader);
            this.Controls.Add(this.plSide);
            this.Controls.Add(this.plProc);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "System Info Changer";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.plSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btVC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCP)).EndInit();
            this.plLogo.ResumeLayout(false);
            this.plHeader.ResumeLayout(false);
            this.plHeader.PerformLayout();
            this.plFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuDragControl _FormDrag1;
        private ns1.BunifuElipse _FormElipse;
        private System.Windows.Forms.Panel plHeader;
        private System.Windows.Forms.Label lbDeviceName;
        private System.Windows.Forms.Panel plSide;
        private System.Windows.Forms.Panel plLogo;
        private ns1.BunifuDragControl _FormDrag2;
        private System.Windows.Forms.Label ltExit;
        private System.Windows.Forms.Label lbMinimize;
        private System.Windows.Forms.PictureBox pbLogo;
        private ns1.BunifuImageButton btCP;
        private ns1.BunifuImageButton btRAM;
        private ns1.BunifuImageButton btVC;
        private System.Windows.Forms.Panel plFooter;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuImageButton btSave;
        private Processor plProc;
    }
}